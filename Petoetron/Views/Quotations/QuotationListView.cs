using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using Petoetron.Classes;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Classes.Helpers;
using System;
using System.Drawing;

namespace Petoetron.Views.Quotations
{
    public partial class QuotationListView : BaseListView
    {
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

        private void InitBindings()
        {
            var fluent = base.InitializeBindings<Quotation, QuotationListViewModel>();
        }
    }
}
