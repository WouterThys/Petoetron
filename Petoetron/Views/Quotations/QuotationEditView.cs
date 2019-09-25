using System;
using Petoetron.Views.Base;
using Petoetron.Models.Quotations;
using Petoetron.Classes;
using DevExpress.XtraLayout;
using System.Collections.Generic;
using DevExpress.Utils.MVVM;
using DevExpress.Data;
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

            lcgQMaterials.ExpandButtonVisible = true;
            lcgQPrices.ExpandButtonVisible = true;
            
            ItemForCode.Enabled = false;
        }

       

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                fluent = InitObjectBindings<Quotation, QuotationEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);
                
                // Ribbon
                fluent.BindCommand(bbiAddCustomer, m => m.AddCustomer());
                fluent.BindCommand(bbiEditCustomer, m => m.EditCustomer());

                // 
                QMaterialsListView.InitializeBinding(fluent.ViewModel.QMaterialModel);
                QPriceListView.InitializeBinding(fluent.ViewModel.QPriceModel);

                // Data
                fluent.SetBinding(ItemForPaidDate, itm => itm.Enabled, m => m.Editable.Paid);
            }
        }

    }
}