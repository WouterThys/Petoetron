using System;
using Petoetron.Views.Base;
using Petoetron.Models.QuotationPrices;
using Petoetron.Classes;

namespace Petoetron.Views.QuotationPrices
{
    public partial class QuotationPriceEditView : BaseUserControl
    {
        public QuotationPriceEditView()
        {
            InitializeModel(typeof(QuotationPriceEditViewModel));
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
            ItemForPriceTypePriceTypeUnit.Enabled = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = mvvmContext.OfType<QuotationPriceEditViewModel>();
                fluent.SetObjectDataSourceBinding(bsQuotationPrice, m => m.QuotationPrice);
            }
        }
    }
}
