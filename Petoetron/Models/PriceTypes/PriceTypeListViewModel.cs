using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;

namespace Petoetron.Models.PriceTypes
{
    [POCOViewModel]
    public class PriceTypeListViewModel : BaseListViewModel<PriceType>
    {
        public static PriceTypeListViewModel Create()
        {
            return ViewModelSource.Create(() => new PriceTypeListViewModel());
        }

        public PriceTypeListViewModel() : base(ModuleTypes.PriceTypeListModule, ModuleTypes.PriceTypeEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(PriceType baseObject)
        {
            return PriceTypeEditViewModel.Create(baseObject);
        }

        public override IEnumerable<PriceType> DataSource()
        {
            return DataAccess.Dal.PriceTypes;
        }
    }
}
