using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM;
using DevExpress.Data;
using Petoetron.Classes;
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Views.Quotations.Helpers
{
    public partial class QuotationPriceEditView : BaseUserControl
    {
        public bool Embedded { get; set; }
        public BindingSource PriceSource { get => bsPrices; }
        public BindingSource QPriceSource { get => bsQuotationPrices; }
        public BarButtonItem AddButton { get => bbiAddPrice; }
        public BarButtonItem RemoveButton { get => bbiDeletePrice; }

        public QuotationPriceEditView()
        {
            InitializeComponent();
            InitializeLayouts();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            barManager.Images = images.Images16x16;
            barManager.LargeImages = images.Images24x24;

            bbiAddPrice.ImageIndex = 0;
            bbiAddPrice.LargeImageIndex = 0;
            bbiDeletePrice.ImageIndex = 2;
            bbiDeletePrice.LargeImageIndex = 2;
            bbiZoom.ImageIndex = 34;
            bbiZoom.LargeImageIndex = 34;
            
            riSpinEditAmount.IsFloatValue = false;
            riSpinEditAmount.MinValue = 1;
            riSpinEditAmount.MaxValue = int.MaxValue;

            gvPrices.OptionsSelection.MultiSelect = true;
            gvPrices.OptionsBehavior.AutoExpandAllGroups = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && !Embedded)
            {
                InitializeModel(typeof(QuotationPriceEditViewModel));
                var fluent = mvvmContext.OfType<QuotationPriceEditViewModel>();
                InitBinding(fluent);
            }
        }

        public void InitializeBinding(QuotationPriceEditViewModel model)
        {
            InitializeModel(typeof(QuotationPriceEditViewModel), model);
            var fluent = mvvmContext.OfType<QuotationPriceEditViewModel>();
            InitBinding(fluent);
        }

        private void InitBinding(MVVMContextFluentAPI<QuotationPriceEditViewModel> fluent)
        {
            fluent.SetBinding(gvPrices, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsPrices, m => m.Data);
            fluent.BindCommand(bbiAddPrice, m => m.Add());
            fluent.BindCommand(bbiDeletePrice, m => m.Delete());
            fluent.BindCommand(bbiZoom, m => m.Zoom());

            // Materials
            fluent.SetBinding(gvPrices, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsQuotationPrices, m => m.QData, m => m.ValuesHaveChanged());
            // GridView - Multiple selected
            fluent.WithEvent<SelectionChangedEventArgs>(gvPrices, "SelectionChanged").SetBinding(
                m => m.Selection,
                g => new List<QuotationPrice>(gvPrices.GetSelectedRows().Select(r => gvPrices.GetRow(r) as QuotationPrice)));


            bbiZoom.Visibility = BarItemVisibility.Never; //Embedded ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
    }
}
