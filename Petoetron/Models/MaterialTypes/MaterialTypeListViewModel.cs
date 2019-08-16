using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;

namespace Petoetron.Models.MaterialTypes
{
    [POCOViewModel]
    public class MaterialTypeListViewModel : BaseListViewModel<MaterialType>
    {
        public static MaterialTypeListViewModel Create()
        {
            return ViewModelSource.Create(() => new MaterialTypeListViewModel());
        }

        public MaterialTypeListViewModel() : base(ModuleTypes.MaterialTypeListModule, ModuleTypes.MaterialTypeEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(MaterialType baseObject)
        {
            return MaterialTypeEditViewModel.Create(baseObject);
        }

        public override IEnumerable<MaterialType> DataSource()
        {
            return DataAccess.Dal.MaterialTypes;
        }
    }
}
