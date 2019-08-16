using Petoetron.Views.Base;
using Petoetron.Models.Customers;
using Petoetron.Classes;

namespace Petoetron.Views.Customers
{
    public partial class CustomerListView : BaseListView
    {
        public CustomerListView()
        {
            InitializeModel(typeof(CustomerListViewModel));
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
            CreateDefaultPopupMenu<Customer, CustomerListViewModel>(sender, e);
        }

        private void InitBindings()
        {
            var fluent = base.InitializeBindings<Customer, CustomerListViewModel>();
        }
    }
}
