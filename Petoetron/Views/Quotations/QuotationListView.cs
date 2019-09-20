using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using Petoetron.Classes;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Classes.Helpers;
using System;
using System.Drawing;
using DevExpress.XtraReports.UI;
using Petoetron.Views.Reports;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using System.Collections.Generic;

namespace Petoetron.Views.Quotations
{
    public partial class QuotationListView : BaseListView
    {
        private MVVMContextFluentAPI<QuotationListViewModel> fluent;

        public QuotationListView()
        {
            InitializeModel(typeof(QuotationListViewModel));
            InitializeComponent();
            InitializeLayouts();
            if (!DesignMode)
            {
                InitializeServices();
                InitBindings();

                gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            }
        }

        protected override void SetRowAppearance(RowCellStyleEventArgs args, IBaseObject ibo)
        {
            base.SetRowAppearance(args, ibo);
            if (args.Column.FieldName == "Code" && ibo is Quotation q)
            {
                if (q.Paid)
                {
                    if (q.DueDate < q.PaidDate)
                    {
                        args.Appearance.BackColor = Color.Orange;
                    }
                }
                else
                {
                    if (q.DueDate < DateTime.Now)
                    {
                        args.Appearance.BackColor = Color.Red;
                    }
                }
            }
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<Quotation, QuotationListViewModel>(sender, e);
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();

            bbiInvoice.ItemClick += BbiInvoice_ItemClick;
        }

        private void BbiInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fluent == null) return;
            if (fluent.ViewModel.Selected == null) return;

            InvoiceReport report = new InvoiceReport();
            report.DataSource = new List<Quotation>() { fluent.ViewModel.Selected };

            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void InitBindings()
        {
            fluent = base.InitializeBindings<Quotation, QuotationListViewModel>();

            fluent.BindCommand(bbiInvoice, m => m.PrintInvoice());
        }
    }
}
