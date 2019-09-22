using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;

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
        
        public override void Zoom()
        {
            DialogService.ShowDialog(MessageButton.OK, "Pruzen", this);
        }
        
    }
}
