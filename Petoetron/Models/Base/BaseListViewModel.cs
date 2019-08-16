using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using Petoetron.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petoetron.Models.Base
{
    [POCOViewModel]
    public abstract class BaseListViewModel<TEntity> : BaseDocumentViewModel, IBaseListViewModel<TEntity>, IDataChanged<TEntity> where TEntity : IBaseObject, new()
    {
        // Variables for entity
        public virtual IModuleType EditModule { get; }
        public virtual BindingList<TEntity> Entities { get; set; }
        public virtual TEntity Selected { get; set; }
        public virtual List<TEntity> Selection { get; set; }

        // Services
        [ServiceProperty(Key = "DataExportService")]
        public virtual IDataTransportService DataTransportService { get { throw new NotImplementedException(); } }

        protected BaseListViewModel(IModuleType module, IModuleType editModule) : base(module)
        {
            EditModule = editModule;
        }

        public abstract IBaseViewModel GetEditViewModel(TEntity baseObject);
        public abstract IEnumerable<TEntity> DataSource();

        #region LIST MODEL
        public override Task Load()
        {
            IsLoading = true;
            return Task.Factory.StartNew((dispatcher) =>
            {
                List<TEntity> results = null;
                try
                {
                    results = new List<TEntity>(DataSource());
                    OnLoading();
                }
                catch (Exception e)
                {
                    MessageBoxService.ShowMessage("Tgu nu: " + e, "Uieuieuie", MessageButton.OK, MessageIcon.Error);
                    results = null;
                    IsLoading = false;
                }

                if (results != null)
                {
                    results.RemoveAll(e => !e.IsValid());
                    // Update on UI thread
                    ((IDispatcherService)dispatcher).BeginInvoke(() =>
                    {
                        DataChangedService.AddListener(this);
                        Entities = new BindingList<TEntity>(results);
                        OnLoaded();
                    });
                }

            }, DispatcherService);
        }

        public override void OnLoading()
        {

        }

        public override void OnLoaded()
        {
            IsLoading = false;
            UpdateCommands();
        }

        public virtual void OnSelectionChanged()
        {
            UpdateCommands();
        }

        public virtual void UpdateCommands()
        {
            this.RaiseCanExecuteChanged(x => x.Add());
            this.RaiseCanExecuteChanged(x => x.Edit(Selected));
            this.RaiseCanExecuteChanged(x => x.Delete(Selection));
            this.RaiseCanExecuteChanged(x => x.Copy(Selected));

            this.RaiseCanExecuteChanged(x => x.PrintList());
            this.RaiseCanExecuteChanged(x => x.ImportList());
            this.RaiseCanExecuteChanged(x => x.ExportList());
        }

        #endregion

        protected virtual TEntity CreateNewObject()
        {
            TEntity t = new TEntity(); // Default

            return t;
        }

        

        #region COMMANDS
        public virtual bool CanAdd()
        {
            return !IsLoading;
        }

        public virtual void Add()
        {
            IBaseViewModel model = GetEditViewModel(CreateNewObject());
            model.SetParentViewModel(this);
            ShowDocument(model);
        }

        public virtual bool CanEdit(TEntity entity)
        {
            return !IsLoading && entity != null && entity.IsValid();// && (Features == null || Features.CanEdit);
        }

        public virtual void Edit(TEntity entity)
        {
            IBaseViewModel model = GetEditViewModel(entity);
            model.SetParentViewModel(this);
            ShowDocument(model);
        }

        public virtual bool CanCopy(TEntity entity)
        {
            return !IsLoading && entity != null && entity.IsValid();
        }

        public virtual void Copy(TEntity obj)
        {
            TEntity newObj = (TEntity)obj.CreateCopy();
            newObj.Code = "";
            newObj.Id = -1;
            Edit(newObj);
        }


        public virtual bool CanDelete(IList<TEntity> objs)
        {
            if (!IsLoading && objs != null && objs.Count > 0)
            {
                    if (objs.Count == 1)
                    {
                        return objs[0].Id > AbstractObject.UNKNOWN_ID;
                    }
                    return true;
            }
            return false;
        }

        public virtual void Delete(IList<TEntity> objs)
        {
            if (objs != null)
            {
                if (objs.Count == 1)
                {
                    DoDelete(objs.OfType<TEntity>().FirstOrDefault());
                }
                else
                {
                    DoDelete(objs);
                }
            }
        }

        protected virtual void DoDelete(TEntity obj)
        {
            if (MessageBoxService.ShowMessage("Mut " + obj + " ucht wug?",
                "Wug",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                if (obj.Id > AbstractObject.UNKNOWN_ID)
                {
                    obj.Delete();
                }
            }
        }

        protected virtual void DoDelete(ICollection<TEntity> objs)
        {
            if (MessageBoxService.ShowMessage("Mutte duu " + objs.Count + " ullemuul wug?",
                "Wug",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                foreach (TEntity obj in objs)
                {
                    if (obj.Id > AbstractObject.UNKNOWN_ID)
                    {
                        obj.Delete();
                    }
                }
            }
        }


        public virtual bool CanPrintList()
        {
            return !IsLoading && Entities != null && Entities.Count > 0;
        }

        public virtual void PrintList()
        {
            DataTransportService.ShowPrint();
        }

        public virtual bool CanImportList()
        {
            return !IsLoading;
        }

        public virtual void ImportList()
        {
            MessageBoxService.ShowMessage("Not yet implemented, coming soon..", "Coming soon", MessageButton.OK);
        }

        public virtual bool CanExportList()
        {
            return !IsLoading && Entities != null && Entities.Count > 0;
        }

        public virtual void ExportList()
        {
            DataTransportService.ShowPreview();
        }


        public virtual void KeyPressed(KeyEventArgs keyEvent)
        {
            if (keyEvent == null) return;

            // Delete
            if (keyEvent.KeyCode == Keys.Delete)
            {
                Delete(Selection);
                keyEvent.Handled = true;
                return;
            }

            // Copy
            if (keyEvent.Control && keyEvent.KeyCode == Keys.C)
            {
                Copy(Selected);
                keyEvent.Handled = true;
                return;
            }
        }

        #endregion

        #region DOCUMENT
        public override void OnClose(CancelEventArgs e)
        {
            if (!e.Cancel && DocumentOwner != null)
            {
                DataChangedService.RemoveListener(this);
                DocumentOwner.Close(this, true);
            }
        }
        #endregion

        #region DATA CHANGED
        protected virtual void Inserted(TEntity inserted)
        {
            Entities.Add(inserted);
            Selected = inserted;
        }

        protected virtual void Updated(TEntity updated)
        {
            int ndx = Entities.IndexOf(updated);
            if (ndx >= 0)
            {
                Entities[ndx].CopyFrom(updated);
                Selected = Entities[ndx];
            }
        }

        protected virtual void Deleted(TEntity deleted)
        {
            Entities.Remove(deleted);
            Selected = default(TEntity);
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
