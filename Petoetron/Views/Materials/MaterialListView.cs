using Petoetron.Views.Base;
using Petoetron.Models.Materials;
using Petoetron.Classes;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.DragDrop;

namespace Petoetron.Views.Materials
{
    public partial class MaterialListView : BaseListView
    {
        public MaterialListView()
        {
            InitializeModel(typeof(MaterialListViewModel));
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
            CreateDefaultPopupMenu<Material, MaterialListViewModel>(sender, e);
        }

        private void InitBindings()
        {
            var fluent = base.InitializeBindings<Material, MaterialListViewModel>();
        }
    }
}
