using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Classes.Helpers;
using DevExpress.Utils.MVVM.Services;
using Petoetron.Services;
using DevExpress.Utils.MVVM;
using Petoetron.Models.Base;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils.Menu;

namespace Petoetron.Views.Base
{
    public partial class BaseListView : BaseRibbonControl
    {
        public BaseListView()
        {
            InitializeComponent();
        }
        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            InitializeGridView();
        }

        protected virtual void InitializeGridView()
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsBehavior.AllowIncrementalSearch = true;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsView.ShowDetailButtons = false;
            gridView.OptionsBehavior.AutoExpandAllGroups = true;
            gridView.RowCellStyle += GridView_RowCellStyle;
        }

        private void GridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            object obj = gridView.GetRow(e.RowHandle);
            if (obj is IBaseObject ibo)
            {
                SetRowAppearance(e, ibo);
            }
        }

        protected virtual void SetRowAppearance(RowCellStyleEventArgs args, IBaseObject ibo)
        {
            if (!ibo.Enabled)
            {
                args.Appearance.FontStyleDelta = FontStyle.Italic;
                args.Appearance.ForeColor = Color.Gray;
            }
            else
            {
                args.Appearance.FontStyleDelta = FontStyle.Regular;
                args.Appearance.ForeColor = Color.Black;
            }
        }

        protected override void InitializeServices()
        {
            base.InitializeServices();
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateXtraFormService(this));
            mvvmContext.RegisterService(MessageBoxService.Create(DefaultMessageBoxServiceType.XtraMessageBox));
            mvvmContext.RegisterService("DataExportService", new DataTransportService(gridControl));
        }
        
        protected virtual MVVMContextFluentAPI<TModel> InitializeBindings<T, TModel>()
            where TModel : BaseListViewModel<T>
            where T : class, IBaseObject, new()
        {
            var fluent = mvvmContext.OfType<TModel>();
            fluent.WithEvent<EventArgs>(this, "Load").EventToCommand(m => m.Load());

            // GridView
            fluent.SetBinding(gridView, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsEntities, m => m.Entities, m => m.UpdateCommands());

            // GridView - Selection changed
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged").SetBinding(
                m => m.Selected,
                args => args.Row as T,
                (gView, machine) => gView.FocusedRowHandle = gView.FindRow(machine));

            // GridView - Row double clicked
            fluent.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
                    m => m.Edit(null),
                    m => m.Selected,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

            // GridView - Multiple selected
            fluent.WithEvent<SelectionChangedEventArgs>(gridView, "SelectionChanged").SetBinding(
                m => m.Selection,
                e => new List<T>(gridView.GetSelectedRows().Select(r => gridView.GetRow(r) as T)));

            // GridView - Keys
            fluent.WithEvent<KeyEventArgs>(gridView, "KeyDown").EventToCommand(
                m => m.KeyPressed(null));

            // Ribbon
            fluent.BindCommand(bbiAdd, m => m.Add());
            fluent.BindCommand(bbiEdit, m => m.Edit(null), m => m.Selected);
            fluent.BindCommand(bbiDelete, m => m.Delete(null), m => m.Selection);

            fluent.BindCommand(bbiPrint, m => m.PrintList());
            fluent.BindCommand(bbiExport, m => m.ExportList());

            return fluent;
        }

        #region POPUP MENU
        protected virtual void CreateDefaultPopupMenu<T, TModel>(object sender, PopupMenuShowingEventArgs e) where TModel : BaseListViewModel<T> where T : AbstractBaseObject, new()
        {
            var fluent = mvvmContext.OfType<TModel>();
            GridView view = sender as GridView;
            int rowHandle = e.HitInfo.RowHandle;
            if (rowHandle >= 0 && e.Menu != null)
            {
                e.Menu.Items.Clear();

                //DXMenuItem addItem = CreateMenuItemAdd(view, rowHandle);
                DXMenuItem editItem = CreateMenuItemEdit(view, rowHandle);
                DXMenuItem deleteItem = CreateMenuItemDelete(view, rowHandle);

                //fluent.BindCommand(addItem, m => m.Add());
                fluent.BindCommand(editItem, m => m.Edit(null), m => m.Selected);
                fluent.BindCommand(deleteItem, m => m.Delete(null), m => m.Selection);

                //e.Menu.Items.Add(addItem);
                e.Menu.Items.Add(editItem);
                e.Menu.Items.Add(deleteItem);
            }
        }

        protected virtual DXMenuItem CreateMenuItemAdd(GridView view, int rowHandle)
        {
            DXMenuItem menuItemAdd = new DXMenuItem("&Add");
            menuItemAdd.ImageOptions.Image = images.Images16x16.Images[0];
            return menuItemAdd;
        }

        protected virtual DXMenuItem CreateMenuItemEdit(GridView view, int rowHandle)
        {
            DXMenuItem menuItemAdd = new DXMenuItem("&Edit");
            menuItemAdd.ImageOptions.Image = images.Images16x16.Images[1];
            return menuItemAdd;
        }

        protected virtual DXMenuItem CreateMenuItemDelete(GridView view, int rowHandle)
        {
            DXMenuItem menuItemAdd = new DXMenuItem("&Delete");
            menuItemAdd.ImageOptions.Image = images.Images16x16.Images[2];
            return menuItemAdd;
        }
        #endregion

        
    }
}