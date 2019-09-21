using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using DevExpress.XtraBars;

namespace Petoetron.Views.Quotations.Helpers
{
    public partial class QuotationMaterialsEditView : BaseUserControl
    {
        public bool Embedded { get; set; }
        public BindingSource MaterialSource { get => bsMaterials; }
        public BindingSource QMaterialSource { get => bsQuoationMaterials; }
        public BarButtonItem AddButton { get => bbiAddMaterial; }
        public BarButtonItem RemoveButton { get => bbiDeleteMaterial; }

        public QuotationMaterialsEditView()
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

            riSpinEditAmount.IsFloatValue = false;
            riSpinEditAmount.MinValue = 1;
            riSpinEditAmount.MaxValue = int.MaxValue;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode && !Embedded)
            {
                var fluent = mvvmContext.OfType<QuotationEditViewModel>();

                fluent.BindCommand(bbiAddMaterial, m => m.AddMaterial());
                fluent.BindCommand(bbiDeleteMaterial, m => m.DeleteMaterials());
            }
        }
    }
}
