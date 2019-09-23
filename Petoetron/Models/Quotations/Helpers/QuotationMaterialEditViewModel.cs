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
    public class QuotationMaterialEditViewModel : BaseQuoationListEditViewModel<Material, QuotationMaterial>
    {
        public static QuotationMaterialEditViewModel Create()
        {
            return ViewModelSource.Create(() => new QuotationMaterialEditViewModel());
        }
        
        protected QuotationMaterialEditViewModel() : base (
            ModuleTypes.QuotationMaterialEditModule,
            ( ) => DataAccess.Dal.Materials,
            (q) => q.Materials)
        {
            
        }

        protected override QuotationMaterial CreateQuotationItem(Material t)
        {
            QuotationMaterial qm = base.CreateQuotationItem(t);
            if (t != null)
            {
                qm.SetMaterial(t);
            }
            return qm;
        }

        public override void Zoom()
        {
            DialogService.ShowDialog(MessageButton.OK, "Muturiuul", this);
        }
        
    }
}
