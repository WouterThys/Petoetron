using System;
using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using Petoetron.Classes;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Petoetron.Models.Quotations.Helpers;
using Petoetron.Views.Quotations.Helpers;
using DevExpress.XtraLayout;
using System.Collections.Generic;
using DevExpress.XtraLayout.Utils;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars;
using Petoetron.Dal;
using System.Linq;

namespace Petoetron.Views.Quotations
{
    public partial class QuotationEditView : BaseObjectEditView
    {
        private readonly Dictionary<string, LayoutControlGroup> layoutGroups = new Dictionary<string, LayoutControlGroup>();
        private MVVMContextFluentAPI<QuotationEditViewModel> fluent;

        public QuotationEditView()
        {
            InitializeModel(typeof(QuotationEditViewModel));
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeLayouts();
                InitializeServices();
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();

            InitializeLookUpEdit(CustomerIdLookUpEdit);

            ddbAddItem.ImageOptions.Image = images.Images16x16.Images[0];
            bsQuotationItems.ListChanged += BsQuotationItems_ListChanged;
            bsQuotationItems.DataMemberChanged += BsQuotationItems_DataMemberChanged;
        }

        private void BsQuotationItems_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void BsQuotationItems_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (fluent != null)
            {
                switch (e.ListChangedType)
                {
                    case System.ComponentModel.ListChangedType.Reset:
                        break;
                    case System.ComponentModel.ListChangedType.ItemAdded:
                        var itemToAdd = fluent.ViewModel.QuotationItems[e.NewIndex];
                        AddQuotationItem(itemToAdd);
                        break;

                    case System.ComponentModel.ListChangedType.ItemDeleted:
                        QuotationItemRemoved(fluent.ViewModel.QuotationItems);
                        break;

                    case System.ComponentModel.ListChangedType.ItemMoved:

                        break;
                    case System.ComponentModel.ListChangedType.ItemChanged:
                        break;
                    case System.ComponentModel.ListChangedType.PropertyDescriptorAdded:
                    case System.ComponentModel.ListChangedType.PropertyDescriptorDeleted:
                    case System.ComponentModel.ListChangedType.PropertyDescriptorChanged:
                        InitialiseQuotationItems(fluent.ViewModel.QuotationItems);
                        break;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                fluent = InitObjectBindings<Quotation, QuotationEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);
                fluent.SetObjectDataSourceBinding(bsQuotationItems, m => m.QuotationItems);

                // Ribbon
                fluent.BindCommand(bbiAddCustomer, m => m.AddCustomer());
                fluent.BindCommand(bbiEditCustomer, m => m.EditCustomer());

                // Dropdown button
                InitDropDownButton();
            }
        }

        #region Quotation items layout
        private void InitialiseQuotationItems(IEnumerable<AbstractQuotationViewModel> models)
        {
            dataLayoutControl.BeginUpdate();
            lcgQuotationItems.BeginUpdate();

            foreach (AbstractQuotationViewModel model in models)
            {
                if (model is PriceTypeItemViewModel ptiModel)
                {
                    AddPriceTypeQuotationItem(ptiModel);
                }
                // else if ..
            }
            //lcgQuotationItems.Add(new EmptySpaceItem());

            dataLayoutControl.EndUpdate();
            lcgQuotationItems.EndUpdate();
        }

        private void AddQuotationItem(AbstractQuotationViewModel model)
        {
            dataLayoutControl.BeginUpdate();
            lcgQuotationItems.BeginUpdate();

            if (model is PriceTypeItemViewModel ptiModel)
            {
                AddPriceTypeQuotationItem(ptiModel);
            }
            // else if ..

            dataLayoutControl.EndUpdate();
            lcgQuotationItems.EndUpdate();
        }

        private void QuotationItemRemoved(IEnumerable<AbstractQuotationViewModel> models)
        {
            dataLayoutControl.BeginUpdate();
            lcgQuotationItems.BeginUpdate();

            List<LayoutControlItem> allItems = new List<LayoutControlItem>(AllLayoutControlItems());
            foreach (LayoutControlItem lci in allItems)
            {
                var found = models.FirstOrDefault(model => model.Equals(lci.Tag));
                if (found == null)
                {
                    if (lci.Tag is PriceTypeItemViewModel ptModel)
                    {
                        RemovePriceTypeQuotationItem(ptModel, lci);
                    }
                }
            }

            dataLayoutControl.EndUpdate();
            lcgQuotationItems.EndUpdate();
        }


        private void AddPriceTypeQuotationItem(PriceTypeItemViewModel model)
        {
            QuotationItemView view = new QuotationItemView();
            view.InitializeBinding(model);

            LayoutControlGroup group = GetLayoutGroup(model.Title, lcgQuotationItems);

            group.BeginUpdate();
            LayoutControlItem item = group.AddItem();
            item.Control = view;
            item.TextVisible = false;
            item.Tag = model;
            group.EndUpdate();
        }

        private List<LayoutControlItem> AllLayoutControlItems()
        {
            List<LayoutControlItem> all = new List<LayoutControlItem>();
            foreach (LayoutControlGroup group in layoutGroups.Values)
            {
                foreach (var layoutItem in group.Items)
                {
                    if (layoutItem is LayoutControlItem lci)
                    {
                        all.Add(lci);
                    }
                }
            }
            return all;
        }

        private void RemovePriceTypeQuotationItem(PriceTypeItemViewModel model, LayoutControlItem lci)
        {
            LayoutControlGroup group = GetLayoutGroup(model.Title, lcgQuotationItems);
            group.BeginUpdate();
            lci.Control.Dispose();
            group.Remove(lci);
            group.EndUpdate();
            if (group.Items.Count == 0)
            {
                lcgQuotationItems.Remove(group);
                layoutGroups.Remove(model.Title);
            }
        }

        private LayoutControlGroup GetLayoutGroup(string code, LayoutGroup parent)
        {
            LayoutControlGroup group = null;
            if (layoutGroups.ContainsKey(code))
            {
                group = layoutGroups[code];
            }
            else
            {
                group = new LayoutControlGroup()
                {
                    Text = code,
                    ExpandButtonVisible = true,
                    GroupStyle = DevExpress.Utils.GroupStyle.Light
                };
                layoutGroups[code] = group;

                parent.AddGroup(group);
            }

            return group;
        }
        #endregion

        #region Popup Menu
        private void InitDropDownButton()
        {
            List<BarButtonItem> items = new List<BarButtonItem>();
            foreach (PriceType priceType in DataAccess.Dal.PriceTypes)
            {
                BarButtonItem item = CreateBarButtonItem(priceType.Code, priceType.Description, 0);
                item.Tag = priceType;
                fluent.WithEvent<ItemClickEventArgs>(item, "ItemClick").EventToCommand(m => m.AddPriceType(null), (arg) => arg.Item.Tag);
                items.Add(item);
            }

            //create and assign PopupMenu
            ddbAddItem.DropDownControl = CreatePopupMenu(items.ToArray(), "MyPopupMenu");
        }

        private static int PopupId;
        private BarButtonItem CreateBarButtonItem(string caption, string name, int imageIndex)
        {
            BarButtonItem item = new BarButtonItem();
            item.Caption = caption;
            item.Id = PopupId++;
            //item.ImageOptions.ImageIndex = imageIndex;
            item.Name = name;
            return item;
        }

        private PopupMenu CreatePopupMenu(BarItem[] items, string name)
        {
            AddQuotationItemPopupMenu.Name = name;
            AddQuotationItemPopupMenu.AddItems(items);
            return AddQuotationItemPopupMenu;
        }
        #endregion
    }
}