using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using System.Collections.Generic;
using System.ComponentModel;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public class PriceLinksModel : IDataChanged<PriceType>
    {
        public static PriceLinksModel Create()
        {
            return ViewModelSource.Create(() => new PriceLinksModel());
        }

        private Quotation Quotation { get; set; }
        public virtual QuotationPrice Selected { get; set; }
        public virtual BindingList<QuotationPrice> QuotationPrices { get; set; }

        public PriceLinksModel()
        {
        }

        List<QuotationPrice> tmpList;
        public void Loading(Quotation quotation)
        {
            Quotation = quotation;
            tmpList = new List<QuotationPrice>(Quotation.Prices.Values);
        }

        public void Loaded()
        {
            QuotationPrices = new BindingList<QuotationPrice>(tmpList);
        }
        

        public void OnSelectedChanged()
        {

        }

        public void UpdateCommands()
        {
            this.RaiseCanExecuteChanged(x => x.Add());
            this.RaiseCanExecuteChanged(x => x.Edit());
            this.RaiseCanExecuteChanged(x => x.Delete());
        }



        public virtual bool CanAdd()
        {
            return Quotation != null;
        }
        public virtual void Add()
        {

        }

        public virtual bool CanEdit()
        {
            return Quotation != null && Selected != null;
        }
        public virtual void Edit()
        {

        }

        public virtual bool CanDelete()
        {
            return Quotation != null && Selected != null;
        }
        public virtual void Delete()
        {

        }



        #region IDataChanged Interface
        void IDataChanged<PriceType>.OnInserted(PriceType inserted)
        {

        }
        void IDataChanged<PriceType>.OnUpdated(PriceType updated)
        {

        }
        void IDataChanged<PriceType>.OnDeleted(PriceType deleted)
        {

        }
        #endregion
    }
}
