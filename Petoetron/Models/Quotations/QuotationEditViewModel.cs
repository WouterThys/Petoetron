using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using Petoetron.Models.Base;
using Petoetron.Models.Customers;
using Petoetron.Models.QuotationMaterials;
using Petoetron.Models.QuotationPrices;
using Petoetron.Models.Quotations.Helpers;
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

        public virtual BindingList<AbstractQuotationViewModel> QuotationItems { get; set; }

        protected QuotationEditViewModel(Quotation original) : base(ModuleTypes.QuotationEditModule, original)
        {

            Load();

            DataChangedService.AddListener((IDataChanged<Customer>)this);
        }

        private List<Customer> tmpCustomers;
        private List<AbstractQuotationViewModel> tmpItemViewModels;
        public override void OnLoading()
        {
            base.OnLoading();

            tmpCustomers = new List<Customer>(DataAccess.Dal.Customers);

            tmpItemViewModels = new List<AbstractQuotationViewModel>();
            foreach (QuotationMaterial qm in Editable.Materials.Values)
            {
                var mModel = MaterialItemViewModel.Create(qm, () => RemoveQuotationMaterial(qm));
                tmpItemViewModels.Add(mModel);
            }
            foreach (QuotationPrice qp in Editable.Prices.Values)
            {
                var qpModel = PriceTypeItemViewModel.Create(qp, () => RemoveQuotationPrice(qp));
                tmpItemViewModels.Add(qpModel);
            }
        }

        public override void OnLoaded()
        {
            Customers = new BindingList<Customer>(tmpCustomers);
            QuotationItems = new BindingList<AbstractQuotationViewModel>(tmpItemViewModels);
            
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

        public virtual void AddMaterial()
        {
            var qm = new QuotationMaterial(Editable);

            QuotationMaterialEditViewModel model = QuotationMaterialEditViewModel.Create(qm);
            var res = DialogService.ShowDialog(MessageButton.OKCancel, "Muturiuul", model);
            if (res == MessageResult.OK && qm.MaterialId > AbstractObject.UNKNOWN_ID)
            {
                var mModel = MaterialItemViewModel.Create(qm, () => RemoveQuotationMaterial(qm));
                Editable.Materials.Add(qm);
                QuotationItems.Add(mModel);
                UpdateCommands();
            }
        }

        public virtual void RemoveQuotationMaterial(QuotationMaterial material)
        {
            // TODO: remove from editable
            foreach (AbstractQuotationViewModel model in QuotationItems)
            {
                if (model is MaterialItemViewModel qmModel)
                {
                    if (qmModel.Material.Equals(material))
                    {
                        QuotationItems.Remove(model);
                        Editable.Materials.Remove(material);
                        UpdateCommands();
                        break;
                    }
                }
            }
        }

        public virtual void AddPriceType(PriceType priceType)
        {
            var qp = new QuotationPrice(Editable, priceType);

            QuotationPriceEditViewModel model = QuotationPriceEditViewModel.Create(qp);
            var res = DialogService.ShowDialog(MessageButton.OKCancel, priceType.Code, model);
            if (res == MessageResult.OK)
            {
                var qpModel = PriceTypeItemViewModel.Create(qp, () => RemoveQuotationPrice(qp));
                Editable.Prices.Add(qp);
                QuotationItems.Add(qpModel);
                UpdateCommands();
            }
        }

        public virtual void RemoveQuotationPrice(QuotationPrice price)
        {
            // TODO: remove from editable
            foreach (AbstractQuotationViewModel model in QuotationItems)
            {
                if (model is PriceTypeItemViewModel qpModel)
                {
                    if (qpModel.Price.Equals(price))
                    {
                        QuotationItems.Remove(model);
                        Editable.Prices.Remove(price);
                        UpdateCommands();
                        break;
                    }
                }
            }
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
