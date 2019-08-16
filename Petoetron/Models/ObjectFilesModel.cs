using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Models
{
    [POCOViewModel]
    public class ObjectFilesModel : BaseDocumentViewModel, IDataChanged<ObjectDocument>
    {

        public static ObjectFilesModel Create(IModuleType module, Action<IEnumerable<ObjectDocument>> reloadAction)
        {
            return ViewModelSource.Create(() => new ObjectFilesModel(module, reloadAction));
        }


        private readonly Action<IEnumerable<ObjectDocument>> reloadAction;
        public virtual IBaseObject FileEntity { get; set; }


        // Icons
        private Image iconToSave = null;
        public virtual Image ObjectIcon { get; set; }

        // Documents
        public virtual ObjectDocument SelectedDocument { get; set; }
        public virtual BindingList<ObjectDocument> ObjectDocuments { get; set; }

        public ObjectFilesModel(IModuleType module, Action<IEnumerable<ObjectDocument>> reloadAction) : base(module)
        {
            this.reloadAction = reloadAction;
        }

        #region MODEL

        public override Task Load()
        {
            IsLoading = true;

            return Task.Factory.StartNew((state) =>
            {

                // Icon
                Image im = iconToSave;
                if (im == null)
                {
                    string fileName = FileEntity.IconPath;
                    if (string.IsNullOrEmpty(fileName))
                    {
                        im = null;
                    }
                    else
                    {
                        try
                        {
                            im = Image.FromFile(fileName);
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
                iconToSave = null;

                // Documents
                List<ObjectDocument> docs = new List<ObjectDocument>();
                if (FileEntity.ObjectDocuments != null)
                {
                    docs.AddRange(FileEntity.ObjectDocuments);
                }

                // Dispatch
                ((IDispatcherService)state).BeginInvoke(() =>
                {
                    // Icon
                    ObjectIcon = im;

                    // Documents
                    ObjectDocuments = new BindingList<ObjectDocument>(docs);

                    DataChangedService.AddListener(this);
                    OnLoaded();
                });
            }, DispatcherService);
        }


        private Task ReLoadDocuments()
        {
            IsLoading = true;
            return Task.Factory.StartNew((state) =>
            {
                // Documents
                List<ObjectDocument> docs = new List<ObjectDocument>();
                FileEntity.ObjectDocuments = null;
                if (FileEntity.ObjectDocuments != null)
                {
                    docs.AddRange(FileEntity.ObjectDocuments);
                }
                reloadAction?.Invoke(docs);

                // Dispatch
                ((IDispatcherService)state).BeginInvoke(() =>
                {
                    // Documents
                    ObjectDocuments = new BindingList<ObjectDocument>(docs);

                    DataChangedService.AddListener(this);
                    OnLoaded();
                });
            }, DispatcherService);
        }

        public override void OnLoading()
        {

        }

        public override void OnLoaded()
        {
            IsLoading = false;
        }

        public void UpdateCommands()
        {
            this.RaiseCanExecuteChanged(x => x.AddDocument());
            this.RaiseCanExecuteChanged(x => x.EditDocument(SelectedDocument));
            this.RaiseCanExecuteChanged(x => x.DeleteDocument(SelectedDocument));
        }

        public override void OnClose(CancelEventArgs e)
        {
            base.OnClose(e);
            DataChangedService.RemoveListener(this);
        }

        #endregion

        #region OBJECT ICON

        private int iconChangeCnt = 0;
        private readonly char[] iconChanger = new char[] { 'b', 'a', 'n', 'a', 'n', 'a' };

        public void OnObjectIconChanged()
        {
            if (IsLoading) return;
            iconToSave = ObjectIcon;
            if (FileEntity != null)
            {
                if (iconToSave != null)
                {
                    // Just change icon path to trigger property changed
                    FileEntity.IconPath += iconChanger[iconChangeCnt];
                    iconChangeCnt++;
                    if (iconChangeCnt >= iconChanger.Length)
                    {
                        iconChangeCnt = 0;
                    }
                }
                else
                {
                    FileEntity.IconPath = "";
                }
            }
        }

        public virtual void SaveImage()
        {
            if (iconToSave != null)
            {
                string dir = Path.Combine(FileEntity.TableName, "Icons");
                string name = Guid.NewGuid().ToString() + ".jpg";
                FileEntity.IconPath = Path.Combine(dir, name);

                Tuple<Image, string> saveData = new Tuple<Image, string>(iconToSave, FileEntity.IconPath);

                Task.Factory.StartNew((d) =>
                {
                    Tuple<Image, string> data = (Tuple<Image, string>)d;
                    Image image = data.Item1;
                    string path = data.Item2;
                    try
                    {
                        using (MemoryStream resized = Toolbox.ResizeImage(image, 256))
                        {
                            using (MemoryStream compressed = Toolbox.CompressImage(Image.FromStream(resized), ImageFormat.Jpeg))
                            {
                                using (var fileStream = File.Create(path))
                                {
                                    compressed.CopyTo(fileStream);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("SaveImage failed: " + e);
                    }

                }, saveData);
            }
            else
            {
                if (string.IsNullOrEmpty(FileEntity.IconPath))
                {

                }
            }
        }

        #endregion

        #region OBJECT DOCUMENTS

        public virtual void OnSelectedDocumentChanged()
        {
            UpdateCommands();
        }

        public virtual bool CanEditDocument(ObjectDocument document)
        {
            return (FileEntity != null) && (FileEntity.IsValid()) && (document != null);
        }

        public virtual void EditDocument(ObjectDocument document)
        {
            ShowDocument(ObjectDocumentEditViewModel.Create(document, FileEntity));
        }


        public virtual bool CanAddDocument()
        {
            return (FileEntity != null) && (FileEntity.IsValid());
        }

        public virtual void AddDocument()
        {
            ObjectDocument document = new ObjectDocument
            {
                ObjectId = FileEntity.Id,
                Code = Guid.NewGuid().ToString(),
                ObjectName = FileEntity.TableName
            };
            ShowDocument(ObjectDocumentEditViewModel.Create(document, FileEntity));
        }


        public virtual bool CanDeleteDocument(ObjectDocument document)
        {
            return (FileEntity != null) && (FileEntity.IsValid()) && (document != null);
        }

        public virtual void DeleteDocument(ObjectDocument document)
        {
            if (MessageBoxService.ShowMessage("Are you sure you want to delete " + document.Description + "?",
                "Delete",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                document.Delete();
            }
        }

        #endregion

        #region DATA CHANGED
        public void OnInserted(ObjectDocument inserted)
        {
            if (inserted != null && inserted.ObjectId == FileEntity.Id && inserted.ObjectName == FileEntity.TableName)
            {
                ReLoadDocuments();
            }
        }

        public void OnUpdated(ObjectDocument updated)
        {
            if (updated != null && updated.ObjectId == FileEntity.Id && updated.ObjectName == FileEntity.TableName)
            {
                ReLoadDocuments();
            }
        }

        public void OnDeleted(ObjectDocument deleted)
        {
            if (deleted != null && deleted.ObjectId == FileEntity.Id && deleted.ObjectName == FileEntity.TableName)
            {
                ReLoadDocuments();
            }
        }
        #endregion
    }
}
