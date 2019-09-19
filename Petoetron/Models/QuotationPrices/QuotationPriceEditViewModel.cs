using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Models.Base;

namespace Petoetron.Models.QuotationPrices
{
    [POCOViewModel]
    public class QuotationPriceEditViewModel : BaseViewModel
    {
        public static QuotationPriceEditViewModel Create(QuotationPrice original)
        {
            return ViewModelSource.Create(() => new QuotationPriceEditViewModel(original));
        }

        public virtual QuotationPrice QuotationPrice { get; protected set; }

        protected QuotationPriceEditViewModel(QuotationPrice original) : base(ModuleTypes.QuotationPriceEditModule)
        {
            QuotationPrice = original;
            Load();
        }

        public override Task Load()
        {
            return null;
        }
    }
}
