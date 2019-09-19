using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Models.QuotationMaterials;
using Petoetron.Models.QuotationPrices;
using System;
using System.Threading.Tasks;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public class MaterialItemViewModel : AbstractQuotationViewModel
    {
        public static MaterialItemViewModel Create(QuotationMaterial material, Action _onDelete)
        {
            return ViewModelSource.Create(() => new MaterialItemViewModel(material, _onDelete));
        }
        
        public override string Title { get { return ((QuotationMaterial)Data).Material.Type?.Code; } }
        public override long Id { get { return ((QuotationMaterial)Data).Id; } }
        
        protected MaterialItemViewModel(QuotationMaterial material, Action _onDelete) : base(material, _onDelete)
        {
            Data = material;
        }

        public virtual QuotationMaterial Material
        {
            get { return Data as QuotationMaterial; }
            set { Data = value as QuotationMaterial; }
        }
        

        public override Task Load()
        {
            return null;
        }

        public override void EditItem()
        {
            QuotationMaterial copy = (QuotationMaterial)Material.CreateCopy();

            QuotationMaterialEditViewModel model = QuotationMaterialEditViewModel.Create(copy);
            var res = DialogService.ShowDialog(MessageButton.OKCancel, copy.Material.Code, model);
            if (res == MessageResult.OK)
            {
                Material.CopyFrom(copy);
            }
        }
    }
}
