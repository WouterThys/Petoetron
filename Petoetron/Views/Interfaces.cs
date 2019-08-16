using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Views
{
    public interface IRibbonControl
    {
        RibbonControl Ribbon { get; }
    }

    public interface IMVVMControl
    {
        void InitializeModel(Type viewModelType);
        void InitializeModel(Type viewModelType, object viewModel);
    }
}
