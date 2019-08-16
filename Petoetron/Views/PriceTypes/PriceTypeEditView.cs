using System;
using Petoetron.Views.Base;
using Petoetron.Models.PriceTypes;
using Petoetron.Classes;

namespace Petoetron.Views.PriceTypes
{
    public partial class PriceTypeEditView : BaseEditView
    {
        public PriceTypeEditView()
        {
            InitializeModel(typeof(PriceTypeEditViewModel));
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
            ViewHelpers.SetTextAlignment(
                UnitPriceTextEdit,
                PriceTypeUnitImageComboBoxEdit);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<PriceType, PriceTypeEditViewModel>();

            }
        }
    }
}
