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
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Views.Quotations.Helpers
{
    public partial class QuotationItemView : BaseUserControl
    {
        public QuotationItemView()
        {
            InitializeComponent();
            InitializeLayouts();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            ItemForPriceTypePriceTypeUnit.Enabled = false;

            sbDelete.Text = "";
            sbDelete.ImageOptions.Image = images.Images16x16.Images[31];

            sbEdit.Text = "";
            sbEdit.ImageOptions.Image = images.Images16x16.Images[1];
        }

        public void InitializeBinding(PriceTypeItemViewModel model)
        {
            InitializeModel(typeof(PriceTypeItemViewModel), model);
            var fluent = mvvmContext.OfType<PriceTypeItemViewModel>();
            
            fluent.SetBinding(AmountSpinEdit, se => se.EditValue, m => m.Price.Amount);
            fluent.SetBinding(ItemForAmount, itm => itm.Text, m => m.Price.Code);
            fluent.SetBinding(PriceTypePriceTypeUnitImageComboBoxEdit, cbe => cbe.EditValue, m => m.Price.PriceType);
            fluent.BindCommand(sbDelete, m => m.DeleteItem());
            fluent.BindCommand(sbEdit, m => m.EditItem());
        }
    }
}
