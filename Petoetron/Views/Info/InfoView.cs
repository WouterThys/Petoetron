using System;
using Petoetron.Views.Base;
using Petoetron.Models.Info;

namespace Petoetron.Views.Info
{
    public partial class InfoView : BaseUserControl
    {
        public InfoView()
        {
            InitializeModel(typeof(InfoViewModel));
            InitializeComponent();
            InitializeLayouts();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = mvvmContext.OfType<InfoViewModel>();
                fluent.SetObjectDataSourceBinding(bsInfo, m => m.Context.Info);
            }
        }
    }
}
