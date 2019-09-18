using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Petoetron.Models.Base
{
    [POCOViewModel]
    public abstract class BaseObjectEditViewModel<TEntity> : BaseEditViewModel<TEntity> where TEntity : class, IBaseObject, new()
    {
        // Helper models
        public virtual ObjectLogModel ObjectLogModel { get; protected set; }
        public virtual ObjectFilesModel ObjectFilesModel { get; protected set; }
        
        protected BaseObjectEditViewModel(IModuleType moduleType, TEntity original) : base(moduleType, original)
        {
            ObjectLogModel = ObjectLogModel.Create(moduleType, (f) => DataAccess.Dal.GetObjectLogs<TEntity>(f), original != null ? original.Id : 0);
            ObjectLogModel.SetParentViewModel(this);

            ObjectFilesModel = ObjectFilesModel.Create(moduleType, (newDocs) => Original.CopyDocuments(newDocs));
            ObjectFilesModel.SetParentViewModel(this);
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
                ObjectFilesModel.FileEntity = Editable;
                ObjectFilesModel.Load();
                OnLoaded();
                return null;
            }
        }

        public virtual string Description
        {
            get { return Editable?.Description; }
            set { Editable.Description = value; }
        }
        
        protected override void BeforeSave(TEntity editable)
        {
            ObjectFilesModel.SaveImage();
        }
    }
}
