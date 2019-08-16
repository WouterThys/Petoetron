using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Petoetron.Classes.Helpers;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.MVVM;
using Petoetron.Models.Base;
using Petoetron.Resources;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq.Expressions;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Petoetron.Views.Base
{
    public partial class BaseEditView : BaseRibbonControl
    {
        public BaseEditView()
        {
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            dataLayoutControl.Images = images.Images16x16;

            flyoutPanel.Options.AnchorType = PopupToolWindowAnchor.Bottom;
            flyoutPanel.Options.AnimationType = PopupToolWindowAnimation.Slide;

            peObjectIcon.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            peObjectIcon.PopupMenuShowing += ObjectImageEdit_PopupMenuShowing;

            lcgLogs.CaptionImageOptions.ImageIndex = ModuleTypes.ObjectLogModule.ImageId;
            lcgDocuments.CaptionImageOptions.ImageIndex = ModuleTypes.ObjectDocumentEditModule.ImageId;

            InitializeCodeEdit(CodeTextEdit);
            InitializeDescEdit(DescriptionTextEdit);
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
        protected virtual MVVMContextFluentAPI<TModel> InitBindings<T, TModel>()
            where TModel : BaseEditViewModel<T>
            where T : class, IBaseObject, new()
        {
            var fluent = mvvmContext.OfType<TModel>();
            fluent.SetObjectDataSourceBinding(bsObject, m => m.Editable, m => m.UpdateCommands());
            fluent.SetTrigger(m => m.IsSaving, (saving) =>
            {
                if (saving)
                {
                    flyoutPanel.ShowPopup(true);
                }
                else
                {
                    flyoutPanel.HidePopup(false);
                }
            });
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

            // Good old bindings
            fluent.BindCommand(bbiSave, m => m.Save());
            fluent.BindCommand(bbiSaveAndDone, m => m.SaveAndDone());
            fluent.BindCommand(bbiReset, m => m.Reset());
            fluent.BindCommand(bbiDelete, m => m.Delete());
            fluent.BindCommand(bbiCopy, m => m.Copy());

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

        #region VIEW HELPERS
        protected void InitializeLinkTable<E, L, TModel>(
            MVVMContextFluentAPI<TModel> fluent,
            GridView gvLinks, BindingSource bsLinks,
            Expression<Func<TModel, BindingList<L>>> entitySelector,
            Expression<Func<TModel, L>> selectorExpression)
            where TModel : BaseEditViewModel<E>
            where E : class, IBaseObject, new()
            where L : class, IBaseObject, new()
        {
            fluent.SetBinding(gvLinks, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsLinks, entitySelector, null);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gvLinks, "FocusedRowObjectChanged").SetBinding(
                selectorExpression,
                args => args.Row as L,
                (gView, operation) => gView.FocusedRowHandle = gView.FindRow(operation));
        }

        protected void InitializeLinkLookup<E, L, TModel>(
            MVVMContextFluentAPI<TModel> fluent,
            SearchLookUpEdit beiLookUp,
            SimpleButton sbEdit,
            SimpleButton sbDelete,
            BindingSource bsLinks,
            Expression<Func<TModel, BindingList<L>>> entitySelector,
            Expression<Func<TModel, L>> selectorExpression,
            Expression<Action<TModel>> commandDeleteSelector,
            Expression<Action<TModel>> commandEditSelector)
            where TModel : BaseEditViewModel<E>
            where E : class, IBaseObject, new()
            where L : class, IBaseObject, new()
        {
            fluent.BindCommand(sbDelete, commandDeleteSelector);
            fluent.BindCommand(sbEdit, commandEditSelector);
            fluent.SetObjectDataSourceBinding(bsLinks, entitySelector);
            fluent.WithEvent(beiLookUp, "EditValueChanged").SetBinding(
                selectorExpression,
                (args) => beiLookUp.EditValue as L);
        }


        protected void InitializeLookUpGridView(GridView gridView)
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsBehavior.AllowIncrementalSearch = true;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsView.ShowDetailButtons = false;
        }

        protected void InitializeLinkButtons(LabelControl lblAdd, SimpleButton sbEdit, SimpleButton sbDelete)
        {
            lblAdd.ImageOptions.Image = images.Images16x16.Images[0];
            sbEdit.ImageOptions.Image = images.Images16x16.Images[1];
            sbDelete.ImageOptions.Image = images.Images16x16.Images[2];
        }

        public class CodeLengthValidationRule : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                string code = (string)value;
                return (!string.IsNullOrEmpty(code)) && (code.Length >= ClientContext.MIN_OBJECT_CODE_LENGTH);
            }
        }

        protected virtual void InitializeLookUpEdit(LookUpEdit typeLookUp)
        {
            typeLookUp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            typeLookUp.Properties.Columns.AddRange(new LookUpColumnInfo[] {
            new LookUpColumnInfo("Code", "Code"),
            new LookUpColumnInfo("Description", "Description")});
            typeLookUp.Properties.ValueMember = "Id";
            typeLookUp.Properties.DisplayMember = "Code";
            typeLookUp.Properties.NullText = "";
        }

        protected virtual void InitializeCodeEdit(TextEdit codeEdit)
        {
            codeEdit.Properties.CharacterCasing = CharacterCasing.Upper;
            codeEdit.Properties.MaxLength = ClientContext.MAX_OBJECT_CODE_LENGTH;

            CodeLengthValidationRule codeValidationRule = new CodeLengthValidationRule
            {
                CaseSensitive = true,
                ErrorText = "Code should be at least " + ClientContext.MIN_OBJECT_CODE_LENGTH + " characters."
            };
            validationProvider.SetValidationRule(codeEdit, codeValidationRule);
        }

        protected virtual void InitializeDescEdit(TextEdit descEdit)
        {
            descEdit.Properties.MaxLength = ClientContext.MAX_OBJECT_DESC_LENGTH;
        }

        protected virtual void InitializeInfoEdit(TextEdit infoEdit)
        {
            infoEdit.Properties.MaxLength = ClientContext.MAX_OBJECT_INFO_LENGTH;
        }

        #endregion
    }
}
