using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace Petoetron.Models.QuotationPrices
{
    [POCOViewModel]
    public class QuotationPriceEditViewModel : BaseEditViewModel<QuotationPrice>
    {
        public static QuotationPriceEditViewModel Create(QuotationPrice original)
        {
            return ViewModelSource.Create(() => new QuotationPriceEditViewModel(original));
        }

        public virtual BindingList<PriceType> PriceTypes { get; set; }
        //public virtual Material Selected { get; set; }

        protected QuotationPriceEditViewModel(QuotationPrice original) : base(ModuleTypes.QuotationPriceEditModule, original)
        {
            Load();
        }

        private List<PriceType> tmpList;
        public override void OnLoading()
        {
            base.OnLoading();

            tmpList = new List<PriceType>(DataAccess.Dal.PriceTypes);
            foreach (QuotationPrice qp in Editable.Quotation.Prices.Values)
            {
                tmpList.Remove(qp.PriceType);
            }
        }

        public override void OnLoaded()
        {
            PriceTypes = new BindingList<PriceType>(tmpList);

            base.OnLoaded();

        }
    }
}
