using System;
using Petoetron.Views.Base;
using Petoetron.Models.Other;
using Petoetron.Classes;

namespace Petoetron.Views.Other
{
    public partial class SimpleInputView : BaseUserControl
    {
        public SimpleInputView()
        {
            InitializeModel(typeof(InputDialogViewModel));
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
                var fluent = mvvmContext.OfType<InputDialogViewModel>();

                fluent.SetBinding(ItemForInput, lci => lci.Text, m => m.Name);
                fluent.SetBinding(InputTextEdit, te => te.Text, m => m.Value);

                InputTextEdit.Focus();

            }
        }
    }
}
