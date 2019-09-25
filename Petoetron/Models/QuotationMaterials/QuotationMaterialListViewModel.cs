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
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Models.QuotationMaterials
{
    [POCOViewModel]
    public class QuotationMaterialListViewModel : BaseQuoationListEditViewModel<Material, QuotationMaterial>
    {
        public static QuotationMaterialListViewModel Create()
        {
            return ViewModelSource.Create(() => new QuotationMaterialListViewModel());
        }
        
        protected QuotationMaterialListViewModel() : base (
            ModuleTypes.QuotationMaterialListModule,
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

        private bool zoomed = false;
        private bool change = false;
        public override void Zoom()
        {
            var model = QuotationMaterialEditViewModel.Create(Quotation);
            DialogService.ShowDialog(MessageButton.OK, "Muturiuul", model);
            zoomed = true;
            change = ValuesChanged;
            Load();
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            if (zoomed)
            {
                zoomed = false;
                ValuesChanged = change;
                UpdateCommands();
                DataChanged?.Invoke();
                change = false;
            }
        }

    }
}
