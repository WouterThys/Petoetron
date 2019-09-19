using Petoetron.Views.Base;
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Views.Quotations.Helpers
{
    public partial class QuotationItemView : BaseUserControl
    {
        public QuotationItemView()
        {
            InitializeComponent();
            InitializeLayouts();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            ItemForUnitEditText.Enabled = false;
            
            sbDelete.Text = "";
            sbDelete.ImageOptions.Image = images.Images16x16.Images[31];

            sbEdit.Text = "";
            sbEdit.ImageOptions.Image = images.Images16x16.Images[1];
        }

        public void InitializeBinding(PriceTypeItemViewModel model)
        {
            InitializeModel(typeof(PriceTypeItemViewModel), model);
            var fluent = mvvmContext.OfType<PriceTypeItemViewModel>();
            
            fluent.SetBinding(AmountSpinEdit, se => se.EditValue, m => m.Price.Amount);
            fluent.SetBinding(ItemForAmount, itm => itm.Text, m => m.Price.Code);
            fluent.SetBinding(UnitEditText, cbe => cbe.Text, m => m.Price.PriceType.PriceTypeUnit);
            fluent.BindCommand(sbDelete, m => m.DeleteItem());
            fluent.BindCommand(sbEdit, m => m.EditItem());
        }

        public void InitializeBinding(MaterialItemViewModel model)
        {
            InitializeModel(typeof(MaterialItemViewModel), model);
            var fluent = mvvmContext.OfType<MaterialItemViewModel>();

            fluent.SetBinding(AmountSpinEdit, se => se.EditValue, m => m.Material.Amount);
            fluent.SetBinding(ItemForAmount, itm => itm.Text, m => m.Material.Code);
            fluent.SetBinding(UnitEditText, cbe => cbe.Text, m => m.Material.Material.Unit);
            fluent.BindCommand(sbDelete, m => m.DeleteItem());
            fluent.BindCommand(sbEdit, m => m.EditItem());
        }
    }
}
