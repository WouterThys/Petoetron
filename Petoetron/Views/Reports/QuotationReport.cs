using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Petoetron.Classes;

namespace Petoetron.Views.Reports
{
    public partial class QuotationReport : DevExpress.XtraReports.UI.XtraReport
    {
        public QuotationReport()
        {
            InitializeComponent();
        }

        public void SetDataSource(Quotation quotation)
        {
            objectDataSource1.DataSource = quotation;
        }
    }
}
