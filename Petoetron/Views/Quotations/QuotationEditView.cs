using System;
using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using Petoetron.Classes;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Petoetron.Views.Quotations
{
    public partial class QuotationEditView : BaseObjectEditView
    {
        public QuotationEditView()
        {
            InitializeModel(typeof(QuotationEditViewModel));
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

            InitializeLookUpEdit(CustomerIdLookUpEdit);

            ddbAddItem.ImageOptions.Image = images.Images16x16.Images[0];
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitObjectBindings<Quotation, QuotationEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);

                // Ribbon
                fluent.BindCommand(bbiAddCustomer, m => m.AddCustomer());
                fluent.BindCommand(bbiEditCustomer, m => m.EditCustomer());

                
            }
        }
    }
}