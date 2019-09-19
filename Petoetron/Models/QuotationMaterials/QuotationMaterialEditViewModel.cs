using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using DevExpress.Mvvm;

namespace Petoetron.Models.QuotationMaterials
{
    [POCOViewModel]
    public class QuotationMaterialEditViewModel : BaseViewModel
    {
        public static QuotationMaterialEditViewModel Create(QuotationMaterial original)
        {
            return ViewModelSource.Create(() => new QuotationMaterialEditViewModel(original));
        }

        public virtual QuotationMaterial QuotationMaterial { get; protected set; }
        public virtual BindingList<Material> Materials { get; protected set; }

        protected QuotationMaterialEditViewModel(QuotationMaterial original) : base(ModuleTypes.QuotationMaterialEditModule)
        {
            QuotationMaterial = original;
            Load();
        }

        public override Task Load()
        {
            return Task.Factory.StartNew((dispatcher) => 
            {
                List<Material> materials = new List<Material>(DataAccess.Dal.Materials);
                materials.RemoveAll(m => !m.IsValid());

                ((IDispatcherService)dispatcher).BeginInvoke(() => 
                {
                    Materials = new BindingList<Material>(materials);
                });

            }, DispatcherService);
        }
    }
}
