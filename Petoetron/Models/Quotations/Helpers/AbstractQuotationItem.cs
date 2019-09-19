using DevExpress.Mvvm.DataAnnotations;
using Petoetron.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Models.Quotations.Helpers
{
    public interface IQuotationItem // where T : INotifyDataChanged?
    {
        long Id { get; }
        string Title { get; }
        object Data { get; }

        bool CanDeleteItem();
        void DeleteItem();

        bool CanEditItem();
        void EditItem();
    }

    [POCOViewModel]
    public abstract class AbstractQuotationViewModel : BaseViewModel, IQuotationItem, IEquatable<AbstractQuotationViewModel>
    {
        private object data;

        protected readonly Action _onDelete;

        protected AbstractQuotationViewModel(object data, Action _onDelete) : base(ModuleTypes.QuotationItemModule)
        {
            this.data = data;
            this._onDelete = _onDelete;
        }
        
        public virtual object Data { get { return data; } protected set { data = value; } }// where T : INotifyDataChanged? in setter? -> OnDataChanged -> properties changed stuff

        public abstract long Id { get; }
        public abstract string Title { get; }
        public abstract void EditItem();

        public void UpdateCommands()
        {

        }

        public virtual bool CanDeleteItem()
        {
            return !IsLoading && _onDelete != null;
        }

        public virtual void DeleteItem()
        {
            _onDelete();
        }

        public virtual bool CanEditItem()
        {
            return !IsLoading && _onDelete != null;
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as AbstractQuotationViewModel);
        }

        public bool Equals(AbstractQuotationViewModel other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(AbstractQuotationViewModel model1, AbstractQuotationViewModel model2)
        {
            return EqualityComparer<AbstractQuotationViewModel>.Default.Equals(model1, model2);
        }

        public static bool operator !=(AbstractQuotationViewModel model1, AbstractQuotationViewModel model2)
        {
            return !(model1 == model2);
        }
    }
}
