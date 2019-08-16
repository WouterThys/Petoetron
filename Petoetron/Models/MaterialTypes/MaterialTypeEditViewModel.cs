using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Models.Base;

namespace Petoetron.Models.MaterialTypes
{
    [POCOViewModel]
    public class MaterialTypeEditViewModel : BaseEditViewModel<MaterialType>
    {
        public static MaterialTypeEditViewModel Create(MaterialType original)
        {
            return ViewModelSource.Create(() => new MaterialTypeEditViewModel(original));
        }

        protected MaterialTypeEditViewModel(MaterialType original) : base(ModuleTypes.MaterialTypeEditModule, original)
        {
            Load();
        }
    }
}
