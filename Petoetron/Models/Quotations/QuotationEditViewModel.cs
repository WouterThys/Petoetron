using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using Petoetron.Models.Base;
using Petoetron.Models.Customers;
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
        public override void OnLoading()
        {
            base.OnLoading();

            tmpCustomers = new List<Customer>(DataAccess.Dal.Customers);
        }

        public override void OnLoaded()
        {
            Customers = new BindingList<Customer>(tmpCustomers);
            QuotationItems = new BindingList<AbstractQuotationViewModel>();
            // TODO: load all price types and stuff to create quotation view items

            //TEST
            //List<AbstractQuotationViewModel> models = new List<AbstractQuotationViewModel>();

            //var p1 = new PriceType()
            //{
            //    Id = 1,
            //    Code = "Price type 1",
            //    Description = "This is a test price type",
            //    UnitPrice = 1.23M,
            //    PriceTypeUnit = PriceTypeUnit.PerKg
            //};
            //var p2 = new PriceType()
            //{
            //    Id = 2,
            //    Code = "Price type 2",
            //    Description = "This is another test price type",
            //    UnitPrice = 0.36M,
            //    PriceTypeUnit = PriceTypeUnit.PerKg
            //};
            //var qp1 = new QuotationPrice(Editable, p1);
            //var qp2 = new QuotationPrice(Editable, p2);
            //var qpvm1 = PriceTypeItemViewModel.Create(qp1);
            //var qpvm2 = PriceTypeItemViewModel.Create(qp2);
            //var qpvm3 = PriceTypeItemViewModel.Create(qp2);

            //models.Add(qpvm1);
            //models.Add(qpvm2);
            //models.Add(qpvm3);
            //QuotationItems = new BindingList<AbstractQuotationViewModel>(models);
            ////TEST

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



        public virtual void AddPriceType(PriceType priceType)
        {
            // TODO: add to editable
            var qp = new QuotationPrice(Editable, priceType);

            QuotationPriceEditViewModel model = QuotationPriceEditViewModel.Create(qp);
            var res = DialogService.ShowDialog(MessageButton.OKCancel, priceType.Code, model);
            if (res == MessageResult.OK)
            {
                var qpModel = PriceTypeItemViewModel.Create(qp, () => RemoveQuotationPrice(qp));
                QuotationItems.Add(qpModel);
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
