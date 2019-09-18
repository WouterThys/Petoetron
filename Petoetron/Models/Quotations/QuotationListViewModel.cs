using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;

namespace Petoetron.Models.Quotations
{
    [POCOViewModel]
    public class QuotationListViewModel : BaseListViewModel<Quotation>
    {
        public static QuotationListViewModel Create()
        {
            return ViewModelSource.Create(() => new QuotationListViewModel());
        }

        public QuotationListViewModel() : base(ModuleTypes.QuotationListModule, ModuleTypes.QuotationEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Quotation baseObject)
        {
            return QuotationEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Quotation> DataSource()
        {
            return DataAccess.Dal.Quotations;
        }
    }
}
