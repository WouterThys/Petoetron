using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Petoetron.Services;
using System;
using System.Threading.Tasks;

namespace Petoetron.Models.Base
{
    [POCOViewModel]
    public abstract class BaseViewModel : IBaseViewModel//, ISupportParentViewModel
    {
        public IModuleType Module { get; }
        public virtual bool IsLoading { get; set; }
        public object ParentViewModel { get { return ((ISupportParentViewModel)this).ParentViewModel; } }

        protected BaseViewModel(IModuleType module)
        {
            Module = module;
        }

        public abstract Task Load();
        public abstract void OnLoading();
        public abstract void OnLoaded();

        public ClientContext Context { get { return ClientContext.Context; } }

        public virtual Guid Guid
        {
            get { return Module.GetGuid(-1); }
        }

        public virtual string ViewTitle
        {
            get { return ""; }
        }

        public virtual IMessageBoxService MessageBoxService { get { throw new NotImplementedException(); } }
        public virtual IDialogService DialogService { get { throw new NotImplementedException(); } }
        public virtual IDispatcherService DispatcherService { get { throw new NotImplementedException(); } }

        //[ServiceProperty(Key = "ErrorManagerService")]
        //public virtual IErrorManagerService ErrorManagerService { get { throw new NotImplementedException(); } }

        [ServiceProperty(Key = "DataChangedService")]
        public virtual IDataChangedService DataChangedService { get { throw new NotImplementedException(); } }
    }
}
