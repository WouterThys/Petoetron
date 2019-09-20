using System;
using Petoetron.Views.Base;
using Petoetron.Models.Pauses;
using Petoetron.Classes;

namespace Petoetron.Views.Pauses
{
    public partial class PauseEditView : BaseObjectEditView
    {
        public PauseEditView()
        {
            InitializeModel(typeof(PauseEditViewModel));
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
                var fluent = InitObjectBindings<Pause, PauseEditViewModel>();

            }
        }
    }
}
