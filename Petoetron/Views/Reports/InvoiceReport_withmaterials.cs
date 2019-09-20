using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Petoetron.Views.Reports
{
    public partial class InvoiceReport_withmaterials : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport_withmaterials()
        {
            InitializeComponent();
            vendorLogo.ImageUrl = ClientContext.Context.Info.Logo;
        }

    }
}
