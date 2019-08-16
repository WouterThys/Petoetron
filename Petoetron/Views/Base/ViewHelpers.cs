using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Petoetron.Views.Base
{
    public static class ViewHelpers
    {
        public static void InitializeGridView(GridView gridView)
        {
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsBehavior.AllowIncrementalSearch = true;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsView.ShowDetailButtons = false;
            gridView.OptionsBehavior.AutoExpandAllGroups = true;
        }

        public static void SetTextAlignment(params BaseEdit[] values)
        {
            if (values != null)
            {
                foreach (BaseEdit edit in values)
                {
                    edit.Properties.Appearance.TextOptions.HAlignment
                        = HorzAlignment.Near;
                }
            }
        }
    }
}
