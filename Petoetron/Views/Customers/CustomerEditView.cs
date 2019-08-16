using System;
using Petoetron.Views.Base;
using Petoetron.Models.Customers;
using Petoetron.Classes;

namespace Petoetron.Views.Customers
{
    public partial class CustomerEditView : BaseEditView
    {
        public CustomerEditView()
        {
            InitializeModel(typeof(CustomerEditViewModel));
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
                var fluent = InitBindings<Customer, CustomerEditViewModel>();

            }
        }
    }
}
