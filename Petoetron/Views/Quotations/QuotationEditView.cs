using System;
using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using Petoetron.Classes;
using DevExpress.XtraLayout;
using System.Collections.Generic;
using DevExpress.Utils.MVVM;
using DevExpress.Data;
using System.Linq;

namespace Petoetron.Views.Quotations
{
    public partial class QuotationEditView : BaseObjectEditView
    {
        private readonly Dictionary<string, LayoutControlGroup> layoutGroups = new Dictionary<string, LayoutControlGroup>();
        private MVVMContextFluentAPI<QuotationEditViewModel> fluent;

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

            lcgQMaterials.ExpandButtonVisible = true;
            lcgQPrices.ExpandButtonVisible = true;

            sbAddMaterial.ImageOptions.Image = images.Images24x24.Images[0];
            sbDeleteMaterial.ImageOptions.Image = images.Images24x24.Images[2];
            sbAddPrice.ImageOptions.Image = images.Images24x24.Images[0];
            sbDeletePrice.ImageOptions.Image = images.Images24x24.Images[2];

            gvMaterials.OptionsSelection.MultiSelect = true;
            gvMaterials.OptionsBehavior.AutoExpandAllGroups = true;
            gvPrices.OptionsSelection.MultiSelect = true;
            gvPrices.OptionsBehavior.AutoExpandAllGroups = true;

            ItemForCode.Enabled = false;
        }

       

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                fluent = InitObjectBindings<Quotation, QuotationEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);
                fluent.SetObjectDataSourceBinding(bsMaterials, m => m.Materials);
                fluent.SetObjectDataSourceBinding(bsPriceTypes, m => m.PriceTypes);
                
                // Ribbon
                fluent.BindCommand(bbiAddCustomer, m => m.AddCustomer());
                fluent.BindCommand(bbiEditCustomer, m => m.EditCustomer());

                // Materials
                fluent.SetBinding(gvMaterials, gv => gv.LoadingPanelVisible, m => m.IsLoading);
                fluent.SetObjectDataSourceBinding(bsQuotationMaterials, m => m.QuotationMaterials, m => m.MaterialValuesChanged());                
                // GridView - Multiple selected
                fluent.WithEvent<SelectionChangedEventArgs>(gvMaterials, "SelectionChanged").SetBinding(
                    m => m.MaterialSelection,
                    g => new List<QuotationMaterial>(gvMaterials.GetSelectedRows().Select(r => gvMaterials.GetRow(r) as QuotationMaterial)));

                // Prices
                fluent.SetBinding(gvPrices, gv => gv.LoadingPanelVisible, m => m.IsLoading);
                fluent.SetObjectDataSourceBinding(bsQuotationPrices, m => m.QuotationPrices, m => m.PriceValuesChanged());
                // GridView - Multiple selected
                fluent.WithEvent<SelectionChangedEventArgs>(gvPrices, "SelectionChanged").SetBinding(
                    m => m.PriceSelection,
                    g => new List<QuotationPrice>(gvPrices.GetSelectedRows().Select(r => gvPrices.GetRow(r) as QuotationPrice)));


                // Commands
                fluent.BindCommand(sbAddMaterial, m => m.AddMaterial());
                fluent.BindCommand(sbDeleteMaterial, m => m.DeleteMaterials());
                fluent.BindCommand(sbAddPrice, m => m.AddPrice());
                fluent.BindCommand(sbDeletePrice, m => m.DeletePrices());

                // Data
                fluent.SetBinding(ItemForPaidDate, itm => itm.Enabled, m => m.Editable.Paid);
            }
        }

    }
}