using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Petoetron.Views.Base
{
    public partial class BaseUserControl : XtraUserControl, IMVVMControl
    {
        public BaseUserControl()
        {
            InitializeComponent();
        }

        public virtual void InitializeLayouts()
        {
        }

        protected virtual void InitializeServices()
        {

        }

        public virtual void InitializeModel(Type viewModelType)
        {
            mvvmContext.ViewModelType = viewModelType;
            BindingContext = new BindingContext();
        }

        public virtual void InitializeModel(Type viewModelType, object viewModel)
        {
            mvvmContext.SetViewModel(viewModel.GetType(), viewModel);
            BindingContext = new BindingContext();
        }
    }
}
