using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using System;
using System.Threading.Tasks;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public class PriceTypeQuotationItem : AbstractQuotationViewModel<QuotationPrice>
    {
        public static PriceTypeQuotationItem Create(QuotationPrice priceType)
        {
            return ViewModelSource.Create(() => new PriceTypeQuotationItem(priceType));
        }

        public override string Title { get { return Data.Code; } }

        protected PriceTypeQuotationItem(QuotationPrice priceType) : base(priceType)
        {

        }

        public override Task Load()
        {
            throw new NotImplementedException();
        }

        
    }
}
