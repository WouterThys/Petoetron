using DevExpress.Mvvm.DataAnnotations;
using Petoetron.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Models.Quotations.Helpers
{
    public interface IQuotationItem<T> // where T : INotifyDataChanged?
    {
        long Id { get; }
        string Title { get; }
        T Data { get; }

        bool CanDeleteItem();
        void DeleteItem();
    }

    [POCOViewModel]
    public abstract class AbstractQuotationViewModel<T> : BaseViewModel, IQuotationItem<T>
    {
        private static long id;
        private T data;

        protected AbstractQuotationViewModel(T data) : base(ModuleTypes.QuotationItemModule)
        {
            id++;
            this.data = data;
        }

        public virtual long Id { get { return id; } }
        public virtual T Data { get { return data; } protected set { data = value; } }// where T : INotifyDataChanged? in setter? -> OnDataChanged -> properties changed stuff
        public abstract string Title { get; }

        public void UpdateCommands()
        {

        }

        public virtual bool CanDeleteItem()
        {
            return !IsLoading;
        }

        public virtual void DeleteItem()
        {

        }
    }
}
