using System;
using Petoetron.Views.Base;
using Petoetron.Models.MaterialTypes;
using Petoetron.Classes;

namespace Petoetron.Views.MaterialTypes
{
    public partial class MaterialTypeEditView : BaseEditView
    {
        public MaterialTypeEditView()
        {
            InitializeModel(typeof(MaterialTypeEditViewModel));
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeLayouts();
                InitializeServices();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<MaterialType, MaterialTypeEditViewModel>();

            }
        }
    }
}
