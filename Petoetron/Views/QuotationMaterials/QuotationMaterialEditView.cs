using System;
using Petoetron.Views.Base;
using Petoetron.Models.QuotationMaterials;
using Petoetron.Classes;

namespace Petoetron.Views.QuotationMaterials
{
    public partial class QuotationMaterialEditView : BaseEditView
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
            lcgMaterial.Enabled = false;

            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<QuotationMaterial, QuotationMaterialEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsMaterials, m => m.Materials);
            }
        }
    }
}
