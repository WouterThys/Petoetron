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

            lcgPriceItems.ExpandButtonVisible = true;
            lcgMaterialItems.ExpandButtonVisible = true;

            ItemForCode.Enabled = false;

            ddbAddItem.ImageOptions.Image = images.Images16x16.Images[0];
            bsQuotationItems.ListChanged += BsQuotationItems_ListChanged;
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

                // Data
                fluent.SetBinding(ItemForPaidDate, itm => itm.Enabled, m => m.Editable.Paid);

                // Dropdown button
                InitDropDownButton();
            }
        }

        #region Quotation items layout
        private void InitialiseQuotationItems(IEnumerable<AbstractQuotationViewModel> models)
        {
            dataLayoutControl.BeginUpdate();
            lcgQuotationItems.BeginUpdate();
            lcgPriceItems.BeginUpdate();
            lcgMaterialItems.BeginUpdate();

            List<LayoutControlItem> allItems = new List<LayoutControlItem>(AllLayoutControlItems());
            foreach (LayoutControlItem lci in allItems)
            {
                if (lci.Tag is PriceTypeItemViewModel ptModel)
                {
                    RemovePriceTypeQuotationItem(ptModel, lci);
                }
                else if (lci.Tag is MaterialItemViewModel miModel)
                {
                    RemoveMaterialQuotationItem(miModel, lci);
                }
            }

            foreach (AbstractQuotationViewModel model in models)
            {
                if (model is PriceTypeItemViewModel ptiModel)
                {
                    AddPriceTypeQuotationItem(ptiModel);
                }
                else if (model is MaterialItemViewModel miModel)
                {
                    AddMaterialQuotationItem(miModel);
                }
            }

            lcgMaterialItems.EndUpdate();
            lcgPriceItems.EndUpdate();
            lcgQuotationItems.EndUpdate();
            dataLayoutControl.EndUpdate();
        }

        private void AddQuotationItem(AbstractQuotationViewModel model)
        {
            dataLayoutControl.BeginUpdate();
            lcgQuotationItems.BeginUpdate();
            lcgPriceItems.BeginUpdate();
            lcgMaterialItems.BeginUpdate();

            if (model is PriceTypeItemViewModel ptiModel)
            {
                AddPriceTypeQuotationItem(ptiModel);
            }
            else if (model is MaterialItemViewModel miModel)
            {
                AddMaterialQuotationItem(miModel);
            }

            lcgMaterialItems.EndUpdate();
            lcgPriceItems.EndUpdate();
            lcgQuotationItems.EndUpdate();
            dataLayoutControl.EndUpdate();
        }

        private void QuotationItemRemoved(IEnumerable<AbstractQuotationViewModel> models)
        {
            dataLayoutControl.BeginUpdate();
            lcgQuotationItems.BeginUpdate();
            lcgPriceItems.BeginUpdate();
            lcgMaterialItems.BeginUpdate();

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
                    else if (lci.Tag is MaterialItemViewModel miModel)
                    {
                        RemoveMaterialQuotationItem(miModel, lci);
                    }
                }
            }

            lcgMaterialItems.EndUpdate();
            lcgPriceItems.EndUpdate();
            lcgQuotationItems.EndUpdate();
            dataLayoutControl.EndUpdate();
        }

        private void AddMaterialQuotationItem(MaterialItemViewModel model)
        {
            QuotationItemView view = new QuotationItemView();
            view.InitializeBinding(model);

            LayoutControlGroup group = GetLayoutGroup(model.Title, lcgMaterialItems);

            group.BeginUpdate();
            LayoutControlItem item = group.AddItem();
            item.Control = view;
            item.TextVisible = false;
            item.Tag = model;
            group.EndUpdate();
        }

        private void AddPriceTypeQuotationItem(PriceTypeItemViewModel model)
        {
            QuotationItemView view = new QuotationItemView();
            view.InitializeBinding(model);

            LayoutControlGroup group = GetLayoutGroup(model.Title, lcgPriceItems);

            group.BeginUpdate();
            LayoutControlItem item = group.AddItem();
            item.Control = view;
            item.TextVisible = false;
            item.Tag = model;
            group.EndUpdate();
        }

        private void RemoveMaterialQuotationItem(MaterialItemViewModel model, LayoutControlItem lci)
        {
            LayoutControlGroup group = GetLayoutGroup(model.Title, lcgMaterialItems);
            group.BeginUpdate();
            lci.Control.Dispose();
            group.Remove(lci);
            group.EndUpdate();
            if (group.Items.Count == 0)
            {
                lcgMaterialItems.Remove(group);
                layoutGroups.Remove(model.Title);
            }
        }

        private void RemovePriceTypeQuotationItem(PriceTypeItemViewModel model, LayoutControlItem lci)
        {
            LayoutControlGroup group = GetLayoutGroup(model.Title, lcgPriceItems);
            group.BeginUpdate();
            lci.Control.Dispose();
            group.Remove(lci);
            group.EndUpdate();
            if (group.Items.Count == 0)
            {
                lcgPriceItems.Remove(group);
                layoutGroups.Remove(model.Title);
            }
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

            // Materials
            BarButtonItem material = CreateBarButtonItem("MUTURIUUL", "Muturiulen", 0);
            material.Tag = null;
            fluent.WithEvent<ItemClickEventArgs>(material, "ItemClick").EventToCommand(m => m.AddMaterial());
            items.Add(material);

            // Price types
            foreach (PriceType priceType in DataAccess.Dal.PriceTypes)
            {
                if (priceType.IsUnknown()) continue;

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
            BarButtonItem item = new BarButtonItem
            {
                Caption = caption,
                Id = PopupId++,
                Name = name
            };
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