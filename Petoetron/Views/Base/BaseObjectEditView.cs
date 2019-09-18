using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.MVVM;
using DevExpress.XtraLayout.Utils;
using Petoetron.Models.Base;
using Petoetron.Classes.Helpers;
using Petoetron.Resources;

namespace Petoetron.Views.Base
{
    public partial class BaseObjectEditView : BaseEditView
    {
        public BaseObjectEditView()
        {
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();

            peObjectIcon.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            peObjectIcon.PopupMenuShowing += ObjectImageEdit_PopupMenuShowing;

            lcgLogs.CaptionImageOptions.ImageIndex = ModuleTypes.ObjectLogModule.ImageId;
            lcgDocuments.CaptionImageOptions.ImageIndex = ModuleTypes.ObjectDocumentEditModule.ImageId;

            InitializeCodeEdit(CodeTextEdit, validationProvider);
            InitializeDescEdit(DescriptionMemoEdit);
            InitializeInfoEdit(InfoMemoEdit);
        }

        private void ObjectImageEdit_PopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e)
        {
            if (e.PopupMenu == null) return;
            for (int i = 0; i < e.PopupMenu.Items.Count; i++)
            {
                DXMenuItem menuItem = e.PopupMenu.Items[i];
                menuItem.ImageOptions.SvgImage = null;
                switch ((StringId)menuItem.Tag)
                {
                    case StringId.PictureEditMenuCut:
                        menuItem.ImageOptions.Image = images.Images16x16.Images[43];
                        break;
                    case StringId.PictureEditMenuCopy:
                        menuItem.ImageOptions.Image = images.Images16x16.Images[44];
                        break;
                    case StringId.PictureEditMenuPaste:
                        menuItem.ImageOptions.Image = images.Images16x16.Images[45];
                        break;
                    case StringId.PictureEditMenuDelete:
                        menuItem.ImageOptions.Image = images.Images16x16.Images[2];
                        break;
                    case StringId.PictureEditMenuLoad:
                        menuItem.ImageOptions.Image = images.Images16x16.Images[46];
                        break;
                    case StringId.TakePictureMenuItem:
                        menuItem.ImageOptions.Image = images.Images16x16.Images[47];
                        break;
                    case StringId.PictureEditMenuSave:
                        menuItem.Visible = false;
                        break;
                    case StringId.PictureEditMenuZoom:
                        menuItem.Visible = false;
                        break;
                }
            }
        }

        #region BINDINGS
        protected virtual MVVMContextFluentAPI<TModel> InitObjectBindings<T, TModel>()
            where TModel : BaseObjectEditViewModel<T>
            where T : class, IBaseObject, new()
        {
            var fluent = InitBindings<T, TModel>();

            fluent.SetBinding(peObjectIcon, pe => pe.EditValue, m => m.ObjectFilesModel.ObjectIcon, (args) =>
            {
                if (args == null)
                {
                    return images.GetIcon(fluent.ViewModel.Module, ImageSize.i48x48);
                }
                else
                {
                    return args;
                }
            });

            //// Object documents
            //DocumentsView.InitializeBindings<T, TModel>(fluent);

            //// Logs
            //var objectLogModel = fluent.ViewModel.ObjectLogModel;
            //if (objectLogModel != null)
            //{
            //    LogsView.InitializeModel(fluent.ViewModel.ObjectLogModel);
            //}
            

            // Move tabs
            int numPages = tabbedControlGroup.TabPages.Count;
            lcgLogs.Move(tabbedControlGroup.TabPages[numPages - 1], InsertType.Right);
            lcgDocuments.Move(tabbedControlGroup.TabPages[numPages - 2], InsertType.Right);

            // Select tab
            tabbedControlGroup.SelectedTabPage = lcgData;
            lcgData.CaptionImageOptions.ImageIndex = fluent.ViewModel.Module.ImageId;

            return fluent;
        }

        #endregion

        
    }
}
