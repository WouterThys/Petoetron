﻿using System;
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
    public partial class QuotationMaterialEditView : BaseUserControl
    {
        public bool Embedded { get; set; }
        public BindingSource MaterialSource { get => bsMaterials; }
        public BindingSource QMaterialSource { get => bsQuotationMaterials; }
        public BarButtonItem AddButton { get => bbiAddMaterial; }
        public BarButtonItem RemoveButton { get => bbiDeleteMaterial; }

        public QuotationMaterialEditView()
        {
            InitializeComponent();
            InitializeLayouts();
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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && !Embedded)
            {
                InitializeModel(typeof(QuotationMaterialEditViewModel));
                var fluent = mvvmContext.OfType<QuotationMaterialEditViewModel>();
                InitBinding(fluent);
            }
        }

        public void InitializeBinding(QuotationMaterialEditViewModel model)
        {
            InitializeModel(typeof(QuotationMaterialEditViewModel), model);
            var fluent = mvvmContext.OfType<QuotationMaterialEditViewModel>();
            InitBinding(fluent);
        }

        private void InitBinding(MVVMContextFluentAPI<QuotationMaterialEditViewModel> fluent)
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


            bbiZoom.Visibility = BarItemVisibility.Never; //Embedded ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
    }
}