using Petoetron.Views.Base;
using Petoetron.Models.PriceTypes;
using Petoetron.Classes;

namespace Petoetron.Views.PriceTypes
{
    public partial class PriceTypeListView : BaseListView
    {
        public PriceTypeListView()
        {
            InitializeModel(typeof(PriceTypeListViewModel));
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
            CreateDefaultPopupMenu<PriceType, PriceTypeListViewModel>(sender, e);
        }

        private void InitBindings()
        {
            var fluent = base.InitializeBindings<PriceType, PriceTypeListViewModel>();
        }
    }
}
