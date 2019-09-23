using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public class QuotationPriceEditViewModel : BaseQuoationListEditViewModel<PriceType, QuotationPrice>
    {
        public static QuotationPriceEditViewModel Create()
        {
            return ViewModelSource.Create(() => new QuotationPriceEditViewModel());
        }
        
        protected QuotationPriceEditViewModel() : base (
            ModuleTypes.QuotationPriceEditModule,
            ( ) => DataAccess.Dal.PriceTypes,
            (q) => q.Prices)
        {
            
        }

        protected override QuotationPrice CreateQuotationItem(PriceType t)
        {
            QuotationPrice qm = base.CreateQuotationItem(t);
            if (t != null)
            {
                qm.SetPrice(t);
            }
            return qm;
        }

        public override void Zoom()
        {
            DialogService.ShowDialog(MessageButton.OK, "Pruzen", this);
        }
        
    }
}
