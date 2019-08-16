using Petoetron.Views.Base;
using Petoetron.Models.MaterialTypes;
using Petoetron.Classes;

namespace Petoetron.Views.MaterialTypes
{
    public partial class MaterialTypeListView : BaseListView
    {
        public MaterialTypeListView()
        {
            InitializeModel(typeof(MaterialTypeListViewModel));
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
            CreateDefaultPopupMenu<MaterialType, MaterialTypeListViewModel>(sender, e);
        }

        private void InitBindings()
        {
            var fluent = base.InitializeBindings<MaterialType, MaterialTypeListViewModel>();
        }
    }
}
