using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using Petoetron.Models.Customers;
using Petoetron.Models.QuotationMaterials;
using Petoetron.Models.QuotationPrices;
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

        public virtual QuotationMaterialListViewModel QMaterialModel { get; protected set; }
        public virtual QuotationPriceListViewModel QPriceModel { get; protected set; }

        protected QuotationEditViewModel(Quotation original) : base(ModuleTypes.QuotationEditModule, original)
        {
            QMaterialModel = QuotationMaterialListViewModel.Create();
            QMaterialModel.DataChanged = () => UpdateCommands();
            QMaterialModel.SetParentViewModel(this);
            QPriceModel = QuotationPriceListViewModel.Create();
            QPriceModel.DataChanged = () => UpdateCommands();
            QPriceModel.SetParentViewModel(this);
            Load();

            DataChangedService.AddListener((IDataChanged<Customer>)this);
        }

        private List<Customer> tmpCustomers;
        public override void OnLoading()
        {
            base.OnLoading();

            tmpCustomers = new List<Customer>(DataAccess.Dal.Customers);

            QMaterialModel.Quotation = Editable;
            QMaterialModel.Loading();

            QPriceModel.Quotation = Editable;
            QPriceModel.Loading();
        }

        public override void OnLoaded()
        {
            Customers = new BindingList<Customer>(tmpCustomers);
            QMaterialModel.Loaded();
            QPriceModel.Loaded();

            base.OnLoaded();
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
            QMaterialModel.UpdateCommands();
            QPriceModel.UpdateCommands();

            this.RaiseCanExecuteChanged(x => x.AddCustomer());
            this.RaiseCanExecuteChanged(x => x.EditCustomer());
        }

        protected override bool ArePropertiesEqual()
        {
            return !QMaterialModel.ValuesChanged && !QPriceModel.ValuesChanged && base.ArePropertiesEqual();
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
            Quotation toSave = (Quotation)entity.CreateCopy();
            toSave.Materials = entity.Materials;
            toSave.Prices = entity.Prices;
            toSave.Save();
        }

        #region Customer

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

        #endregion
        
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
