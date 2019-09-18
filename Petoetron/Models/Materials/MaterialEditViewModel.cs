using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace Petoetron.Models.Materials
{
    [POCOViewModel]
    public class MaterialEditViewModel : BaseObjectEditViewModel<Material>
    {
        public static MaterialEditViewModel Create(Material original)
        {
            return ViewModelSource.Create(() => new MaterialEditViewModel(original));
        }

        public virtual BindingList<MaterialType> TypeEntities { get; set; }

        protected MaterialEditViewModel(Material original) : base(ModuleTypes.MaterialEditModule, original)
        {
            Load();
        }

        private List<MaterialType> tmpTypes;
        public override void OnLoading()
        {
            base.OnLoading();
            tmpTypes = new List<MaterialType>(DataAccess.Dal.MaterialTypes);
        }

        public override void OnLoaded()
        {
            TypeEntities = new BindingList<MaterialType>(tmpTypes);
            base.OnLoaded();
        }
    }
}
