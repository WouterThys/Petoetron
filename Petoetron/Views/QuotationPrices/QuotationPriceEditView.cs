using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Petoetron.Views.Base;
using DevExpress.Utils.MVVM;
using DevExpress.Data;
using Petoetron.Classes;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Models.QuotationPrices;

namespace Petoetron.Views.QuotationPrices
{
    public partial class QuotationPriceEditView : BaseRibbonControl
    {
        private MVVMContextFluentAPI<QuotationPriceEditViewModel> fluent;

        public QuotationPriceEditView()
        {
            InitializeModel(typeof(QuotationPriceEditViewModel));
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

            //riSpinEditAmount.IsFloatValue = false;
            //riSpinEditAmount.MinValue = 1;
            //riSpinEditAmount.MaxValue = int.MaxValue;

            gvQPrices.OptionsBehavior.Editable = false;
            gvQPrices.OptionsSelection.MultiSelect = false;
            gvQPrices.OptionsView.ShowDetailButtons = false;
            gvQPrices.OptionsBehavior.AutoExpandAllGroups = true;
            gvQPrices.ShownEditor += QPrices_ShownEditor;

            gvPrices.OptionsBehavior.Editable = false;
            gvPrices.OptionsBehavior.AllowIncrementalSearch = true;
            gvPrices.OptionsSelection.MultiSelect = true;
            gvPrices.OptionsView.ShowDetailButtons = false;
            gvPrices.OptionsBehavior.AutoExpandAllGroups = true;

            gvPriceMaterials.OptionsSelection.MultiSelect = true;
            gvPriceMaterials.OptionsView.ShowDetailButtons = false;
            gvPriceMaterials.OptionsBehavior.AutoExpandAllGroups = true;


            dragDropEvents.DragDrop += DragDropEvents_DragDrop;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                fluent = mvvmContext.OfType<QuotationPriceEditViewModel>();

                fluent.SetBinding(gvQPrices, gv => gv.LoadingPanelVisible, m => m.IsLoading);
                fluent.SetObjectDataSourceBinding(bsPrices, m => m.Data);

                // Prices
                fluent.SetBinding(gvQPrices, gv => gv.LoadingPanelVisible, m => m.IsLoading);
                fluent.SetObjectDataSourceBinding(bsQuotationPrices, m => m.QData, m => m.ValuesHaveChanged());
                // GridView - Multiple selected
                fluent.WithEvent<SelectionChangedEventArgs>(gvQPrices, "SelectionChanged").SetBinding(
                    m => m.Selection,
                    g => new List<QuotationPrice>(gvQPrices.GetSelectedRows().Select(r => gvQPrices.GetRow(r) as QuotationPrice)));

                // Commands
                fluent.BindCommand(bbiAdd, m => m.Add());
                fluent.BindCommand(bbiDelete, m => m.Delete());

            }
        }

        #region Cell Appearance

        private void QPrices_ShownEditor(object sender, EventArgs e)
        {
            //GridView view = sender as GridView;
            //if (view.FocusedColumn.FieldName == "Value")
            //{
            //    var qm = view.GetRow(view.FocusedRowHandle) as QuotationMaterial;
            //    if (qm == null || qm.Material == null) return;

            //    DevExpress.XtraEditors.SpinEdit edit = view.ActiveEditor as DevExpress.XtraEditors.SpinEdit;
            //    edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

            //    string mask = "";
            //    switch (qm.Material.Unit)
            //    {
            //        case Classes.Helpers.MaterialUnit.lm:
            //            mask = ",#######0.00 m";
            //            break;
            //        case Classes.Helpers.MaterialUnit.kg:
            //            mask = ",#######0.00 kg";
            //            break;
            //        case Classes.Helpers.MaterialUnit.st:
            //            mask = ",#######0 st";
            //            break;
            //    }
            //    edit.Properties.Mask.EditMask = mask;
            //}
        }
        #endregion

        #region Drag & Drop

        private void DragDropEvents_DragDrop(object sender, DragDropEventArgs e)
        {
            if (fluent != null && e.Source is GridView source)
            {
                try
                {
                    if (source.Equals(gvPrices))
                    {
                        IEnumerable<PriceType> prices = source.GetSelectedRows().Select(r => source.GetRow(r) as PriceType);
                        fluent.ViewModel.AddItems(prices);
                        e.Handled = true;
                    }
                }
                catch
                {

                }
            }
        }

        #endregion
    }
}
