using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using Petoetron.Classes;

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

        private void GridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<Quotation, QuotationListViewModel>(sender, e);
        }

        private void InitBindings()
        {
            var fluent = base.InitializeBindings<Quotation, QuotationListViewModel>();
        }
    }
}
