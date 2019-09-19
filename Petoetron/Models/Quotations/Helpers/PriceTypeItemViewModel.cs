using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Models.QuotationPrices;
using System;
using System.Threading.Tasks;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public class PriceTypeItemViewModel : AbstractQuotationViewModel
    {
        public static PriceTypeItemViewModel Create(QuotationPrice priceType, Action _onDelete)
        {
            return ViewModelSource.Create(() => new PriceTypeItemViewModel(priceType, _onDelete));
        }
        
        public override string Title { get { return ((QuotationPrice)Data).PriceType.Code; } }
        public override long Id { get { return ((QuotationPrice)Data).Id; } }
        
        protected PriceTypeItemViewModel(QuotationPrice priceType, Action _onDelete) : base(priceType, _onDelete)
        {
            Data = priceType;
        }

        public virtual QuotationPrice Price
        {
            get { return Data as QuotationPrice; }
            set { Data = value as QuotationPrice; }
        }
        

        public override Task Load()
        {
            return null;
        }

        public override void EditItem()
        {
            QuotationPrice copy = (QuotationPrice)Price.CreateCopy();

            QuotationPriceEditViewModel model = QuotationPriceEditViewModel.Create(copy);
            var res = DialogService.ShowDialog(MessageButton.OKCancel, copy.PriceType.Code, model);
            if (res == MessageResult.OK)
            {
                Price.CopyFrom(copy);
            }
        }
    }
}
