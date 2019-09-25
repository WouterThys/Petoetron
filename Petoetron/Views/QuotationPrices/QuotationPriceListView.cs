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
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Models.QuotationPrices;

namespace Petoetron.Views.QuotationPrices
{
    public partial class QuotationPriceListView : BaseUserControl
    {
        private MVVMContextFluentAPI<QuotationPriceListViewModel> fluent;

        public bool Embedded { get; set; }
        public BindingSource PriceSource { get => bsPrices; }
        public BindingSource QPriceSource { get => bsQuotationPrices; }
        public BarButtonItem AddButton { get => bbiAddPrice; }
        public BarButtonItem RemoveButton { get => bbiDeletePrice; }

        public QuotationPriceListView()
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

            dragDropEvents.DragDrop += DragDropEvents_DragDrop;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && !Embedded)
            {
                InitializeModel(typeof(QuotationPriceListViewModel));
                fluent = mvvmContext.OfType<QuotationPriceListViewModel>();
                InitBinding(fluent);
            }
        }

        public void InitializeBinding(QuotationPriceListViewModel model)
        {
            InitializeModel(typeof(QuotationPriceListViewModel), model);
            fluent = mvvmContext.OfType<QuotationPriceListViewModel>();
            InitBinding(fluent);
        }

        private void InitBinding(MVVMContextFluentAPI<QuotationPriceListViewModel> fluent)
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

        #region Drag & Drop

        private void DragDropEvents_DragDrop(object sender, DragDropEventArgs e)
        {
            if (fluent != null && e.Source is GridView source)
            {
                try
                {
                    IEnumerable<PriceType> prices = source.GetSelectedRows().Select(r => source.GetRow(r) as PriceType);
                    fluent.ViewModel.AddItems(prices);
                    e.Handled = true;
                }
                catch
                {

                }
            }
        }

        #endregion
    }
}
