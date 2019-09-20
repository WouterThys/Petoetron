using Petoetron.Views.Base;
using Petoetron.Models.Pauses;
using Petoetron.Classes;

namespace Petoetron.Views.Pauses
{
    public partial class PauseListView : BaseListView
    {
        public PauseListView()
        {
            InitializeModel(typeof(PauseListViewModel));
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
            CreateDefaultPopupMenu<Pause, PauseListViewModel>(sender, e);
        }

        private void InitBindings()
        {
            var fluent = base.InitializeBindings<Pause, PauseListViewModel>();
        }
    }
}
