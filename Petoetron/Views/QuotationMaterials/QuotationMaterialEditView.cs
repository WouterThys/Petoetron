using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Petoetron.Views.Base;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM;
using DevExpress.Data;
using Petoetron.Classes;
using Petoetron.Models.Quotations.Helpers;
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

            gvMaterials.OptionsBehavior.Editable = false;
            gvMaterials.OptionsBehavior.AllowIncrementalSearch = true;
            gvMaterials.OptionsSelection.MultiSelect = true;
            gvMaterials.OptionsView.ShowDetailButtons = false;
            gvMaterials.OptionsBehavior.AutoExpandAllGroups = true;

            dragDropEvents.DragDrop += DragDropEvents_DragDrop;
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
                fluent.BindCommand(bbiGroup, m => m.Group());
                fluent.BindCommand(bbiUnGroup, m => m.UnGroup());
            }
        }

        

        #region Drag & Drop
        
        private void DragDropEvents_DragDrop(object sender, DragDropEventArgs e)
        {
            if (fluent != null  && e.Source is GridView source)
            {
                try
                {
                    IEnumerable<Material> materials = source.GetSelectedRows().Select(r => source.GetRow(r) as Material);
                    fluent.ViewModel.AddItems(materials);
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
