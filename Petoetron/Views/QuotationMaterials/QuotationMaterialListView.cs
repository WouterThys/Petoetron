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
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Models.QuotationMaterials;
using DevExpress.Utils.MVVM.Services;

namespace Petoetron.Views.QuotationMaterials
{
    public partial class QuotationMaterialListView : BaseUserControl
    {
        private MVVMContextFluentAPI<QuotationMaterialListViewModel> fluent;

        public bool Embedded { get; set; }
        public BindingSource MaterialSource { get => bsMaterials; }
        public BindingSource QMaterialSource { get => bsQuotationMaterials; }
        public BarButtonItem AddButton { get => bbiAddMaterial; }
        public BarButtonItem RemoveButton { get => bbiDeleteMaterial; }

        public QuotationMaterialListView()
        {
            InitializeComponent();
            InitializeLayouts();
            InitializeServices();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            barManager.Images = images.Images16x16;
            barManager.LargeImages = images.Images24x24;

            bbiAddMaterial.ImageIndex = 0;
            bbiAddMaterial.LargeImageIndex = 0;
            bbiDeleteMaterial.ImageIndex = 2;
            bbiDeleteMaterial.LargeImageIndex = 2;
            bbiZoom.ImageIndex = 34;
            bbiZoom.LargeImageIndex = 34;
            
            riSpinEditAmount.IsFloatValue = false;
            riSpinEditAmount.MinValue = 1;
            riSpinEditAmount.MaxValue = int.MaxValue;

            gvMaterials.OptionsSelection.MultiSelect = true;
            gvMaterials.OptionsBehavior.AutoExpandAllGroups = true;
            
            dragDropEvents.DragDrop += DragDropEvents_DragDrop;
        }

        protected override void InitializeServices()
        {
            base.InitializeServices();
            //var service = DialogService.CreateXtraDialogService(this);
            //service.DialogFormStyle = f =>
            //{
            //    Form form = f as Form;
            //    form.FormBorderStyle = FormBorderStyle.Sizable;
            //};
            //mvvmContext.RegisterDefaultService(service);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && !Embedded)
            {
                InitializeModel(typeof(QuotationMaterialListViewModel));
                fluent = mvvmContext.OfType<QuotationMaterialListViewModel>();
                InitBinding(fluent);
            }
        }

        public void InitializeBinding(QuotationMaterialListViewModel model)
        {
            InitializeModel(typeof(QuotationMaterialListViewModel), model);
            fluent = mvvmContext.OfType<QuotationMaterialListViewModel>();
            InitBinding(fluent);
        }

        private void InitBinding(MVVMContextFluentAPI<QuotationMaterialListViewModel> fluent)
        {
            fluent.SetBinding(gvMaterials, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsMaterials, m => m.Data);
            fluent.BindCommand(bbiAddMaterial, m => m.Add());
            fluent.BindCommand(bbiDeleteMaterial, m => m.Delete());
            fluent.BindCommand(bbiZoom, m => m.Zoom());

            // Materials
            fluent.SetBinding(gvMaterials, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsQuotationMaterials, m => m.QData, m => m.ValuesHaveChanged());
            // GridView - Multiple selected
            fluent.WithEvent<SelectionChangedEventArgs>(gvMaterials, "SelectionChanged").SetBinding(
                m => m.Selection,
                g => new List<QuotationMaterial>(gvMaterials.GetSelectedRows().Select(r => gvMaterials.GetRow(r) as QuotationMaterial)));
            
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
