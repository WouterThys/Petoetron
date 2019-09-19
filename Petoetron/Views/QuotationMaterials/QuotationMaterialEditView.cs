using System;
using Petoetron.Views.Base;
using Petoetron.Models.QuotationMaterials;

namespace Petoetron.Views.QuotationMaterials
{
    public partial class QuotationMaterialEditView : BaseUserControl
    {
        public QuotationMaterialEditView()
        {
            InitializeModel(typeof(QuotationMaterialEditViewModel));
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeLayouts();
                InitializeServices();
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            ItemForMaterialUnit.Enabled = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = mvvmContext.OfType<QuotationMaterialEditViewModel>();
                fluent.SetObjectDataSourceBinding(bsQuotationMaterial, m => m.QuotationMaterial);
                fluent.SetObjectDataSourceBinding(bsMaterials, m => m.Materials);
            }
        }
    }
}
