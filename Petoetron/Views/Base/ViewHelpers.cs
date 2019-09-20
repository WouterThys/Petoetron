using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Classes;
using Petoetron.Dal;
using System;
using System.Collections.Generic;

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



        #region Popup Menu
        public static PopupMenu InitPauseDropDownButton(PopupMenu menu, Action<BarButtonItem> addClick)
        {
            List<BarButtonItem> items = new List<BarButtonItem>();

            // Price types
            foreach (Pause pause in DataAccess.Dal.Pauses)
            {
                if (pause.IsUnknown()) continue;

                BarButtonItem item = CreateBarButtonItem(pause.Code, pause.Description, 0);
                item.Tag = pause;
                addClick(item);
                //fluent.WithEvent<ItemClickEventArgs>(item, "ItemClick").EventToCommand(m => m.AddPriceType(null), (arg) => arg.Item.Tag);
                items.Add(item);
            }

            //create and assign PopupMenu
            return CreatePopupMenu(menu, items.ToArray(), "MyPopupMenu");
        }

        private static int PopupId;
        private static BarButtonItem CreateBarButtonItem(string caption, string name, int imageIndex)
        {
            BarButtonItem item = new BarButtonItem
            {
                Caption = caption,
                Id = PopupId++,
                Name = name
            };
            return item;
        }

        private static PopupMenu CreatePopupMenu(PopupMenu menu, BarItem[] items, string name)
        {
            menu.Name = name;
            menu.AddItems(items);
            return menu;
        }
        #endregion
    }
}
