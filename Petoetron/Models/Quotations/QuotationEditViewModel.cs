using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using Petoetron.Models.Base;
using Petoetron.Models.Customers;
using Petoetron.Models.Materials;
using Petoetron.Models.PriceTypes;
using Petoetron.Models.Quotations.Helpers;
using System.Collections.Generic;
using System.ComponentModel;

namespace Petoetron.Models.Quotations
{
    [POCOViewModel]
    public class QuotationEditViewModel : BaseObjectEditViewModel<Quotation>,
        IDataChanged<Customer>
    {
        public static QuotationEditViewModel Create(Quotation original)
        {
            return ViewModelSource.Create(() => new QuotationEditViewModel(original));
        }


        public virtual BindingList<Customer> Customers { get; protected set; }
        public virtual MaterialLinksModel MaterialLinksModel { get; protected set; }
        public virtual PriceLinksModel PriceLinksModel { get; protected set; }

        protected QuotationEditViewModel(Quotation original) : base(ModuleTypes.QuotationEditModule, original)
        {
            MaterialLinksModel = MaterialLinksModel.Create(() => UpdateCommands());
            PriceLinksModel = PriceLinksModel.Create();

            Load();

            DataChangedService.AddListener((IDataChanged<Customer>)this);
        }

        private List<Customer> tmpCustomers;
        public override void OnLoading()
        {
            base.OnLoading();

            tmpCustomers = new List<Customer>(DataAccess.Dal.Customers);
            MaterialLinksModel.Loading(Editable);
            PriceLinksModel.Loading(Editable);
        }

        public override void OnLoaded()
        {
            Customers = new BindingList<Customer>(tmpCustomers);
            MaterialLinksModel.Loaded();
            PriceLinksModel.Loaded();

            base.OnLoaded();
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();

            this.RaiseCanExecuteChanged(x => x.AddCustomer());
            this.RaiseCanExecuteChanged(x => x.EditCustomer());
        }

        public override void OnClose(CancelEventArgs e)
        {
            base.OnClose(e);
            if (!e.Cancel)
            {
                DataChangedService.RemoveListener((IDataChanged<Customer>)this);
            }
        }

        protected override void DoSave(Quotation entity)
        {
            entity.Save();
        }


        public virtual bool CanAddCustomer()
        {
            return !IsLoading && Editable != null;
        }
        public virtual void AddCustomer()
        {
            CustomerEditViewModel model = CustomerEditViewModel.Create(new Customer());
            ShowDocument(model);
        }
        public virtual bool CanEditCustomer()
        {
            return !IsLoading && Editable != null && Editable.Customer != null;
        }
        public virtual void EditCustomer()
        {
            CustomerEditViewModel model = CustomerEditViewModel.Create(Editable.Customer);
            ShowDocument(model);
        }


        
        #region IDataChanged listeners
        void IDataChanged<Customer>.OnInserted(Customer inserted)
        {
            Customers.Add(inserted);
        }
        void IDataChanged<Customer>.OnUpdated(Customer updated)
        {
            int ndx = Customers.IndexOf(updated);
            if (ndx >= 0)
            {
                Customers[ndx].CopyFrom(updated);
            }
        }
        void IDataChanged<Customer>.OnDeleted(Customer deleted)
        {
            int ndx = Customers.IndexOf(deleted);
            if (ndx >= 0)
            {
                Customers.RemoveAt(ndx);
            }
        }

       
        #endregion
    }
}
