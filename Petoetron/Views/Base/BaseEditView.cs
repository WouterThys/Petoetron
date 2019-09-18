using DevExpress.Utils.Win;
using Petoetron.Models.Base;
using Petoetron.Classes.Helpers;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
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
        }
        
        #region BINDINGS
        protected virtual MVVMContextFluentAPI<TModel> InitBindings<T, TModel>()
            where TModel : BaseEditViewModel<T>
            where T : class, IObject, new()
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
            
            // Good old bindings
            fluent.BindCommand(bbiSave, m => m.Save());
            fluent.BindCommand(bbiSaveAndDone, m => m.SaveAndDone());
            fluent.BindCommand(bbiReset, m => m.Reset());
            fluent.BindCommand(bbiDelete, m => m.Delete());
            fluent.BindCommand(bbiCopy, m => m.Copy());

            return fluent;
        }

        #endregion

        #region VIEW HELPERS
        //protected void InitializeLinkTable<E, L, TModel>(
        //    MVVMContextFluentAPI<TModel> fluent,
        //    GridView gvLinks, BindingSource bsLinks,
        //    Expression<Func<TModel, BindingList<L>>> entitySelector,
        //    Expression<Func<TModel, L>> selectorExpression)
        //    where TModel : BaseObjectEditViewModel<E>
        //    where E : class, IBaseObject, new()
        //    where L : class, IBaseObject, new()
        //{
        //    fluent.SetBinding(gvLinks, gv => gv.LoadingPanelVisible, m => m.IsLoading);
        //    fluent.SetObjectDataSourceBinding(bsLinks, entitySelector, null);
        //    fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gvLinks, "FocusedRowObjectChanged").SetBinding(
        //        selectorExpression,
        //        args => args.Row as L,
        //        (gView, operation) => gView.FocusedRowHandle = gView.FindRow(operation));
        //}

        //protected void InitializeLinkLookup<E, L, TModel>(
        //    MVVMContextFluentAPI<TModel> fluent,
        //    SearchLookUpEdit beiLookUp,
        //    SimpleButton sbEdit,
        //    SimpleButton sbDelete,
        //    BindingSource bsLinks,
        //    Expression<Func<TModel, BindingList<L>>> entitySelector,
        //    Expression<Func<TModel, L>> selectorExpression,
        //    Expression<Action<TModel>> commandDeleteSelector,
        //    Expression<Action<TModel>> commandEditSelector)
        //    where TModel : BaseObjectEditViewModel<E>
        //    where E : class, IBaseObject, new()
        //    where L : class, IBaseObject, new()
        //{
        //    fluent.BindCommand(sbDelete, commandDeleteSelector);
        //    fluent.BindCommand(sbEdit, commandEditSelector);
        //    fluent.SetObjectDataSourceBinding(bsLinks, entitySelector);
        //    fluent.WithEvent(beiLookUp, "EditValueChanged").SetBinding(
        //        selectorExpression,
        //        (args) => beiLookUp.EditValue as L);
        //}


        //protected void InitializeLookUpGridView(GridView gridView)
        //{
        //    gridView.OptionsBehavior.Editable = false;
        //    gridView.OptionsBehavior.AllowIncrementalSearch = true;
        //    gridView.OptionsSelection.MultiSelect = true;
        //    gridView.OptionsView.ShowDetailButtons = false;
        //}

        //protected void InitializeLinkButtons(LabelControl lblAdd, SimpleButton sbEdit, SimpleButton sbDelete)
        //{
        //    lblAdd.ImageOptions.Image = images.Images16x16.Images[0];
        //    sbEdit.ImageOptions.Image = images.Images16x16.Images[1];
        //    sbDelete.ImageOptions.Image = images.Images16x16.Images[2];
        //}

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

        protected virtual void InitializeCodeEdit(TextEdit codeEdit, DXValidationProvider validationProvider)
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
