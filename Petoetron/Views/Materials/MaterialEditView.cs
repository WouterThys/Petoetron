using System;
using Petoetron.Views.Base;
using Petoetron.Models.Materials;
using Petoetron.Classes;

namespace Petoetron.Views.Materials
{
    public partial class MaterialEditView : BaseObjectEditView
    {
        public MaterialEditView()
        {
            InitializeModel(typeof(MaterialEditViewModel));
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
                TypeIdSearchLookUpEdit,
                UnitPriceTextEdit,
                WeightTextEdit);

            InitializeLookUpEdit(TypeIdSearchLookUpEdit);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitObjectBindings<Material, MaterialEditViewModel>();
                fluent.SetObjectDataSourceBinding(bsType, m => m.TypeEntities);
            }
        }
    }
}

