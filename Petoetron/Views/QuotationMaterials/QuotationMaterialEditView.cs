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
using Petoetron.Models.QuotationMaterials;

namespace Petoetron.Views.QuotationMaterials
{
    public partial class QuotationMaterialEditView : BaseRibbonControl
    {
        private MVVMContextFluentAPI<QuotationMaterialEditViewModel> fluent;

        public QuotationMaterialEditView()
        {
            InitializeModel(typeof(QuotationMaterialEditViewModel));
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

            riSpinEditAmount.IsFloatValue = false;
            riSpinEditAmount.MinValue = 1;
            riSpinEditAmount.MaxValue = int.MaxValue;

            gvQMaterials.OptionsSelection.MultiSelect = true;
            gvQMaterials.OptionsBehavior.AutoExpandAllGroups = true;
            gvQMaterials.ShownEditor += QMaterials_ShownEditor;

            gvMaterials.OptionsBehavior.Editable = false;
            gvMaterials.OptionsBehavior.AllowIncrementalSearch = true;
            gvMaterials.OptionsSelection.MultiSelect = true;
            gvMaterials.OptionsView.ShowDetailButtons = false;
            gvMaterials.OptionsBehavior.AutoExpandAllGroups = true;

            gvQMaterials.SelectionChanged += GvQMaterials_SelectionChanged;

            dragDropEvents.DragDrop += DragDropEvents_DragDrop;
        }

        private void GvQMaterials_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridView grid = sender as GridView;
            int[] handles = grid.GetSelectedRows();
            foreach (int handle in handles)
            {
                if (grid.IsGroupRow(handle))
                {
                    SelectChild(grid, handle);
                }
            }
        }

        private void SelectChild(GridView grid, int handle)
        {
            int childRowCount = grid.GetChildRowCount(handle);
            grid.BeginSelection();
            for (int i = 0; i < childRowCount; i++)
            {
                int childRowHandle = grid.GetChildRowHandle(handle, i);
                grid.SelectRow(childRowHandle);
            }
            grid.EndSelection();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                fluent = mvvmContext.OfType<QuotationMaterialEditViewModel>();

                fluent.SetBinding(gvQMaterials, gv => gv.LoadingPanelVisible, m => m.IsLoading);
                fluent.SetObjectDataSourceBinding(bsMaterials, m => m.Data);

                // Materials
                fluent.SetBinding(gvQMaterials, gv => gv.LoadingPanelVisible, m => m.IsLoading);
                fluent.SetObjectDataSourceBinding(bsQuotationMaterials, m => m.QData, m => m.ValuesHaveChanged());
                // GridView - Multiple selected
                fluent.WithEvent<SelectionChangedEventArgs>(gvQMaterials, "SelectionChanged").SetBinding(
                    m => m.Selection,
                    g => new List<QuotationMaterial>(gvQMaterials.GetSelectedRows().Select(r => gvQMaterials.GetRow(r) as QuotationMaterial)));

                // Commands
                fluent.BindCommand(bbiAdd, m => m.Add());
                fluent.BindCommand(bbiDelete, m => m.Delete());
                fluent.BindCommand(bbiCopy, m => m.CopyGroup());
                fluent.BindCommand(bbiGroup, m => m.Group());
                fluent.BindCommand(bbiUnGroup, m => m.UnGroup());
            }
        }

        #region Cell Appearance

        private void QMaterials_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "Value")
            {
                var qm = view.GetRow(view.FocusedRowHandle) as QuotationMaterial;
                if (qm == null || qm.Material == null) return;

                DevExpress.XtraEditors.SpinEdit edit = view.ActiveEditor as DevExpress.XtraEditors.SpinEdit;
                edit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;

                string mask = "";
                switch (qm.Material.Unit)
                {
                    case Classes.Helpers.MaterialUnit.lm:
                        mask = ",#######0.00 m";
                        break;
                    case Classes.Helpers.MaterialUnit.kg:
                        mask = ",#######0.00 kg";
                        break;
                    case Classes.Helpers.MaterialUnit.st:
                        mask = ",#######0 st";
                        break;
                }
                edit.Properties.Mask.EditMask = mask;
            }
        }
        #endregion

        #region Drag & Drop

        private void DragDropEvents_DragDrop(object sender, DragDropEventArgs e)
        {
            if (fluent != null && e.Source is GridView source)
            {
                try
                {
                    if (source.Equals(gvMaterials))
                    {
                        IEnumerable<Material> materials = source.GetSelectedRows().Select(r => source.GetRow(r) as Material);
                        fluent.ViewModel.AddItems(materials);
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
