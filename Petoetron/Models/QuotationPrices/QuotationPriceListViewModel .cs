using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Models.QuotationPrices
{
    [POCOViewModel]
    public class QuotationPriceListViewModel : BaseQuoationListEditViewModel<PriceType, QuotationPrice>
    {
        public static QuotationPriceListViewModel Create()
        {
            return ViewModelSource.Create(() => new QuotationPriceListViewModel());
        }
        
        protected QuotationPriceListViewModel() : base (
            ModuleTypes.QuotationPriceListModule,
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

        private bool zoomed = false;
        private bool change = false;
        public override void Zoom()
        {
            var model = QuotationPriceEditViewModel.Create(Quotation);
            DialogService.ShowDialog(MessageButton.OK, "Pruzen", model);
            model.SaveSelection();
            zoomed = true;
            change = ValuesChanged;
            Load();
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            if (zoomed)
            {
                zoomed = false;
                ValuesChanged = change;
                UpdateCommands();
                DataChanged?.Invoke();
                change = false;
            }
        }

    }
}
