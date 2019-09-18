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

            ViewHelpers.InitializeGridView(gvMaterials);
            ViewHelpers.InitializeGridView(gvPrices);
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

                // Materials
                fluent.SetObjectDataSourceBinding(bsMaterials, m => m.MaterialLinksModel.QuotationMaterials);
                fluent.BindCommand(bbiAddMaterial, m => m.MaterialLinksModel.Add());
                fluent.BindCommand(bbiEditMaterial, m => m.MaterialLinksModel.Edit());
                fluent.BindCommand(bbiDeleteMaterial, m => m.MaterialLinksModel.Delete());
                fluent.SetBinding(gvMaterials, gv => gv.LoadingPanelVisible, m => m.IsLoading);
                fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gvMaterials, "FocusedRowObjectChanged").SetBinding(
                    m => m.MaterialLinksModel.Selected,
                    args => args.Row as QuotationMaterial,
                    (gView, machine) => gView.FocusedRowHandle = gView.FindRow(machine));
                fluent.WithEvent<RowClickEventArgs>(gvMaterials, "RowClick").EventToCommand(
                        m => m.MaterialLinksModel.Edit(),
                        args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));


                // Prices
                fluent.SetObjectDataSourceBinding(bsPrices, m => m.PriceLinksModel.QuotationPrices);
                fluent.BindCommand(bbiAddPrice, m => m.PriceLinksModel.Add());
                fluent.BindCommand(bbiEditPrice, m => m.PriceLinksModel.Edit());
                fluent.BindCommand(bbiDeletePrice, m => m.PriceLinksModel.Delete());
            }
        }
    }
}