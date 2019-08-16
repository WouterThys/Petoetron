using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;

namespace Petoetron.Models.Materials
{
    [POCOViewModel]
    public class MaterialListViewModel : BaseListViewModel<Material>
    {
        public static MaterialListViewModel Create()
        {
            return ViewModelSource.Create(() => new MaterialListViewModel());
        }

        public MaterialListViewModel() : base(ModuleTypes.MaterialListModule, ModuleTypes.MaterialEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Material baseObject)
        {
            return MaterialEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Material> DataSource()
        {
            return DataAccess.Dal.Materials;
        }
    }
}
