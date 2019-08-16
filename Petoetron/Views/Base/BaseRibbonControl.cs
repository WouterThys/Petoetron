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
using DevExpress.XtraBars.Ribbon;

namespace Petoetron.Views.Base
{
    public partial class BaseRibbonControl : BaseUserControl, IRibbonControl
    {
        public BaseRibbonControl()
        {
            InitializeComponent();
        }

        public RibbonControl Ribbon { get { return ribbonControl; } }
    }
}
