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
using Petoetron.Views.Base;
using DevExpress.Utils.MVVM;
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Views.Quotations.Helpers
{
    public partial class BaseQuotationItemView : BaseUserControl
    {
        public BaseQuotationItemView()
        {
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();

            barManager.Images = images.Images16x16;
            bbiDeleteItem.ImageIndex = 31;
        }

        public virtual MVVMContextFluentAPI<TModel> InitializeBinding<TModel, T>()
            where TModel : AbstractQuotationViewModel<T>
        {
            var fluent = mvvmContext.OfType<TModel>();

            fluent.SetObjectDataSourceBinding(bsData, m => m.Data, m => m.UpdateCommands());
            fluent.BindCommand(bbiDeleteItem, m => m.DeleteItem());

            return fluent;
        }
    }
}
