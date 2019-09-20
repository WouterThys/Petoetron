using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Petoetron.Views.Reports
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
            vendorLogo.ImageUrl = ClientContext.Context.Info.Logo;
        }

    }
}
