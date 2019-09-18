using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using System;
using System.Threading.Tasks;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public class QuotationMaterialQuotationItem : AbstractQuotationViewModel<QuotationMaterialList>
    {
        public static QuotationMaterialQuotationItem Create(QuotationMaterialList materialList)
        {
            return ViewModelSource.Create(() => new QuotationMaterialQuotationItem(materialList));
        }

        public override string Title { get { return "Muturiulen"; } }

        protected QuotationMaterialQuotationItem(QuotationMaterialList materialList) : base(materialList)
        {

        }

        public override Task Load()
        {
            throw new NotImplementedException();
        }


    }
}
