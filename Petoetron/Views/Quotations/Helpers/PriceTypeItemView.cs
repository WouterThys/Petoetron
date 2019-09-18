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
using Petoetron.Classes;
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Views.Quotations.Helpers
{
    public partial class PriceTypeItemView : BaseQuotationItemView
    {
        public PriceTypeItemView()
        {
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            PriceTypeDescriptionTextEdit.Enabled = false;
            PriceTypePriceTypeUnitImageComboBoxEdit.Enabled = false;
        }

        public void InitBindings()
        {
            var fluent = base.InitializeBinding<PriceTypeQuotationItem, QuotationPrice>();
        }
    }
}
