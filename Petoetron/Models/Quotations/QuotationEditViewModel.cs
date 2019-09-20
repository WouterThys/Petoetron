using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using Petoetron.Models.Base;
using Petoetron.Models.Customers;
using System;
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
        public virtual BindingList<Material> Materials { get; protected set; }
        public virtual BindingList<PriceType> PriceTypes { get; protected set; }

        private bool materialValuesChanged = false;
        public virtual BindingList<QuotationMaterial> QuotationMaterials { get; set; }
        public virtual List<QuotationMaterial> MaterialSelection { get; set; }

        private bool priceValuesChanged = false;
        public virtual BindingList<QuotationPrice> QuotationPrices { get; set; }
        public virtual List<QuotationPrice> PriceSelection { get; set; }

        protected QuotationEditViewModel(Quotation original) : base(ModuleTypes.QuotationEditModule, original)
        {

            Load();

            DataChangedService.AddListener((IDataChanged<Customer>)this);
        }

        private List<Customer> tmpCustomers;
        private List<Material> tmpMaterials;
        private List<PriceType> tmpPriceTypes;
        private List<QuotationMaterial> tmpQMaterials;
        private List<QuotationPrice> tmpQPrices;
        public override void OnLoading()
        {
            base.OnLoading();
            materialValuesChanged = false;
            priceValuesChanged = false;
            tmpCustomers = new List<Customer>(DataAccess.Dal.Customers);
            tmpMaterials = new List<Material>(DataAccess.Dal.Materials);
            tmpPriceTypes = new List<PriceType>(DataAccess.Dal.PriceTypes);

            tmpQMaterials = new List<QuotationMaterial>(Editable.Materials.Values);
            tmpQPrices = new List<QuotationPrice>(Editable.Prices.Values);
        }

        public override void OnLoaded()
        {
            Customers = new BindingList<Customer>(tmpCustomers);
            Materials = new BindingList<Material>(tmpMaterials);
            PriceTypes = new BindingList<PriceType>(tmpPriceTypes);

            QuotationMaterials = new BindingList<QuotationMaterial>(tmpQMaterials);
            QuotationPrices = new BindingList<QuotationPrice>(tmpQPrices);

            base.OnLoaded();
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();

            this.RaiseCanExecuteChanged(x => x.AddCustomer());
            this.RaiseCanExecuteChanged(x => x.EditCustomer());

            this.RaiseCanExecuteChanged(x => x.AddMaterial());
            this.RaiseCanExecuteChanged(x => x.DeleteMaterials());

            this.RaiseCanExecuteChanged(x => x.AddPrice());
            this.RaiseCanExecuteChanged(x => x.DeletePrices());
        }

        protected override bool ArePropertiesEqual()
        {
            return !materialValuesChanged && !priceValuesChanged && base.ArePropertiesEqual();
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

        #region Materials

        public void MaterialValuesChanged()
        {
            materialValuesChanged = true;
            UpdateCommands();
        }

        public void OnMaterialSelectionChanged()
        {
            this.RaiseCanExecuteChanged(x => x.DeleteMaterials());
        }

        public virtual bool CanAddMaterial()
        {
            return !IsLoading && Editable != null;
        }
        public virtual void AddMaterial()
        {
            var qm = new QuotationMaterial(Editable);

            Editable.Materials.Add(qm);
            QuotationMaterials.Add(qm);
            UpdateCommands();
        }

        public virtual bool CanDeleteMaterials()
        {
            return !IsLoading && Editable != null && MaterialSelection != null && MaterialSelection.Count > 0;
        }
        public virtual void DeleteMaterials()
        {
            foreach (QuotationMaterial qm in MaterialSelection)
            {
                Editable.Materials.Remove(qm);
                QuotationMaterials.Remove(qm);
                UpdateCommands();
            }
        }

        #endregion

        #region Prices

        public void PriceValuesChanged()
        {
            priceValuesChanged = true;
            UpdateCommands();
        }

        public void OnPriceSelectionChanged()
        {
            this.RaiseCanExecuteChanged(x => x.DeletePrices());
        }

        public virtual bool CanAddPrice()
        {
            return !IsLoading && Editable != null;
        }
        public virtual void AddPrice()
        {
            var qp = new QuotationPrice(Editable);

            Editable.Prices.Add(qp);
            QuotationPrices.Add(qp);
            UpdateCommands();
        }

        public virtual bool CanDeletePrices()
        {
            return !IsLoading && Editable != null && PriceSelection != null && PriceSelection.Count > 0;
        }
        public virtual void DeletePrices()
        {
            foreach (QuotationPrice qm in PriceSelection)
            {
                Editable.Prices.Remove(qm);
                QuotationPrices.Remove(qm);
                UpdateCommands();
            }
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
