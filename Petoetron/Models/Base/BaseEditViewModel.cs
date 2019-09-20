using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petoetron.Models.Base
{
    [POCOViewModel]
    public abstract class BaseEditViewModel<TEntity> : BaseDocumentViewModel, IBaseEditViewModel<TEntity>, IDataChanged<TEntity> where TEntity : class, IObject, new()
    {
        protected bool closeOnSave = false;
        public virtual bool IsSaving { get; protected set; }

        public Task LoadingTask { get; protected set; }
        public virtual TEntity Original { get; protected set; }
        public virtual TEntity Editable { get; protected set; }

        // Helper variables
        protected bool propertiesEqual;
        protected bool checkCode = true;


        protected BaseEditViewModel(IModuleType moduleType, TEntity original) : base(moduleType)
        {
            Original = original;
        }

        public override Task Load()
        {
            IsLoading = true;
            if (closeOnSave)
            {
                closeOnSave = false;
                Editable = (TEntity)Original.CreateCopy();
                OnClose(new CancelEventArgs());
                IsLoading = false;
                return null;
            }
            else
            {
                OnLoading();
                OnLoaded();
                return null;
            }
        }

        public virtual void OnLoading()
        {
            if (Editable == null)
            {
                // Create new
                try
                {
                    Editable = (TEntity)Original.CreateCopy();
                }
                catch (Exception e)
                {
                    Debug.WriteLine("BaseEditViewModel - OnLoading(): " + e);
                }
            }
            else
            {
                // Keep object reference
                Editable.CopyFrom(Original);
            }
            DataChangedService.AddListener(this);
        }

        public virtual void OnLoaded()
        {
            IsLoading = false;
            UpdateCommands();
        }

        public override Guid Guid
        {
            get
            {
                return Module.GetGuid(Original.Id);
            }
        }

        public override string ViewTitle
        {
            //get { return Original.Code; }
            get { return Original.TableName; }
        }

        public virtual void UpdateCommands()
        {
            propertiesEqual = ArePropertiesEqual();

            this.RaiseCanExecuteChanged(x => x.Save());
            this.RaiseCanExecuteChanged(x => x.SaveAndDone());
            this.RaiseCanExecuteChanged(x => x.Reset());
            this.RaiseCanExecuteChanged(x => x.Delete());
            this.RaiseCanExecuteChanged(x => x.Copy());
        }

        protected virtual bool ArePropertiesEqual()
        {
            return Editable != null && Original.PropertiesEqual(Editable);
        }

        public virtual string Code
        {
            get { return Editable?.Code; }
            set { Editable.Code = value; }
        }

        public bool CanPause(Pause pause)
        {
            return !IsLoading;
        }

        public void Pause(Pause pause)
        {
            if (pause != null)
            {
                Toolbox.OpenBrowser(pause.Url);
            }
        }

        public bool CanEditCode()
        {
            return Editable != null && Editable.Id > AbstractObject.UNKNOWN_ID;
        }

        public virtual bool CanClose()
        {
            return Original.PropertiesEqual(Editable) || Editable.Code.Length < ClientContext.MIN_OBJECT_CODE_LENGTH;
        }


        #region DOCUMENT

        public override void OnClose(CancelEventArgs e)
        {
            if (!CanClose())
            {
                MessageResult result = MessageBoxService.ShowMessage(
                    "Sug " + Editable + " us nug ni upgesluge, mutek du nu uurst duun?",
                    "Slute",
                    MessageButton.YesNoCancel,
                    MessageIcon.Warning);

                if (result == MessageResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == MessageResult.Yes)
                {
                    e.Cancel = true;
                    closeOnSave = true;
                    Save();
                }
            }
            if ((Editable == null) || (Editable.Id < 0) || (!e.Cancel && DocumentOwner != null))
            {
                RemoveDataChangedListeners();
                DocumentOwner.Close(this);
            }
        }

        protected virtual void RemoveDataChangedListeners()
        {
            DataChangedService.RemoveListener(this);
        }

        #endregion

        #region COMMANDS
        public virtual bool CanSave()
        {
            if (IsSaving || IsLoading) return false;
            
            return !propertiesEqual && Editable != null && Editable.Code.Length >= ClientContext.MIN_OBJECT_CODE_LENGTH;
        }

        public virtual void Save()
        {
            if (checkCode && Editable.Id < AbstractObject.UNKNOWN_ID && DataAccess.Dal.CodeExists<TEntity>(Editable.Code))
            {
                MessageBoxService.ShowMessage("" + Editable.Code + " bestuut ul he puljuske", "Bestuut ul", MessageButton.OK);
            }
            else
            {
                IsSaving = true;
                Task.Factory.StartNew((dispatcher) =>
                {
                    try
                    {
                        BeforeSave(Editable);
                        DoSave(Editable);
                    }
                    catch (Exception e)
                    {
                        ((IDispatcherService)dispatcher).BeginInvoke(() =>
                        {
                            MessageBoxService.ShowMessage(e.Message, "Gudverdikke", MessageButton.OK, MessageIcon.Error);
                            IsSaving = false;
                        });
                    }
                }, DispatcherService);

            }
        }

        protected virtual void DoSave(TEntity entity)
        {
            TEntity toSave = (TEntity)entity.CreateCopy();
            toSave.Save();
        }

        public virtual bool CanSaveAndDone()
        {
            return CanSave();
        }

        public virtual void SaveAndDone()
        {
            closeOnSave = true;
            Save();
        }

        protected virtual void BeforeSave(TEntity editable)
        {
           
        }

        public virtual bool CanReset()
        {
            if (IsSaving || IsLoading) return false;
            return !propertiesEqual;
        }

        public virtual void Reset()
        {
            if (MessageBoxService.ShowMessage("Zudde gu zuker du guu " + Editable + " wult rusutte?",
                "Trug",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                Editable.CopyFrom(Original);
                OnReset();
            }
        }

        public virtual void OnReset()
        {
            Load();
        }


        public virtual bool CanDelete()
        {
            if (IsSaving || IsLoading) return false;
            return Editable != null && Editable.Id > AbstractObject.UNKNOWN_ID;
        }

        public void Delete()
        {
            if (MessageBoxService.ShowMessage("Zudde gu zuker du " + Editable + "wug mut?",
                "Wug",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                IsLoading = true;
                try
                {
                    DoDelete(Editable);
                }
                catch (Exception e)
                {
                    MessageBoxService.ShowMessage(e.Message, "Kunker", MessageButton.OK, MessageIcon.Error);
                }
                finally
                {
                    IsLoading = false;
                }
            }
        }

        protected virtual void DoDelete(TEntity toDelete)
        {
            toDelete.Delete();
        }


        public virtual bool CanCopy()
        {
            if (IsSaving || IsLoading) return false;
            return (Editable != null) && Editable.Id > AbstractObject.UNKNOWN_ID;
        }

        public virtual void Copy()
        {
            try
            {
                ((IBaseListViewModel<TEntity>)ParentViewModel).Copy(Editable);
            }
            catch (Exception e)
            {
                MessageBoxService.ShowMessage("Du kupieke pukke lukt mu muur ni" + e, "Gudverdumme", MessageButton.OK, MessageIcon.Error);
            }
        }

        public virtual void KeyPressed(KeyEventArgs keyEvent)
        {
            if (keyEvent == null) return;

            // Close
            if (keyEvent.KeyCode == Keys.Escape)
            {
                OnClose(new CancelEventArgs());
                keyEvent.Handled = true;
                return;
            }

            // Save
            if (keyEvent.Control && keyEvent.KeyCode == Keys.S)
            {
                Save();
                keyEvent.Handled = true;
                return;
            }

            // Save
            if (keyEvent.KeyCode == Keys.Delete)
            {
                Delete();
                keyEvent.Handled = true;
                return;
            }
        }

        #endregion

        #region DATA CHANGED

        protected virtual bool Inserted(TEntity inserted)
        {
            if (Editable.Code == inserted.Code)
            {
                Original = inserted;
                IsSaving = false;
                Load();
            }
            return true;
        }

        protected virtual bool Updated(TEntity updated)
        {
            if (Editable.Id == updated.Id)
            {
                Original = updated;
                IsSaving = false;
                Load();
            }
            return true;
        }

        protected virtual bool Deleted(TEntity deleted)
        {
            if (Editable.Id == deleted.Id)
            {
                OnClose(new CancelEventArgs());
            }
            return true;
        }

        void IDataChanged<TEntity>.OnInserted(TEntity inserted)
        {
            DispatcherService.BeginInvoke(() => Inserted(inserted));
        }

        void IDataChanged<TEntity>.OnUpdated(TEntity updated)
        {
            DispatcherService.BeginInvoke(() => Updated(updated));
        }

        void IDataChanged<TEntity>.OnDeleted(TEntity deleted)
        {
            DispatcherService.BeginInvoke(() => Deleted(deleted));
        }

        #endregion


    }
}
