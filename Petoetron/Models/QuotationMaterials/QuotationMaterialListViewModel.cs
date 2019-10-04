using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Quotations;
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

        public override void Zoom()
        {
            var model = QuotationMaterialEditViewModel.Create(Quotation);
            var document = ShowFloatingDocument(model);
            model.OnDone = (q, args) =>
            {
                document.Close(true);
                DataChanged?.Invoke();
                Load();
            };
            model.OnOpenPrices = () =>
            {
                ((QuotationEditViewModel)ParentViewModel).QPriceModel.Zoom();
            };
        }

    }
}
