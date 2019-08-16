using DevExpress.XtraBars.Ribbon;

namespace Petoetron.Views.Base
{
    public partial class BaseRibbonControl : BaseUserControl, IRibbonControl
    {
        public BaseRibbonControl()
        {
            InitializeComponent();

            Ribbon.Images = images.Images24x24;
            Ribbon.LargeImages = images.Images48x48;
        }

        public RibbonControl Ribbon { get { return ribbonControl; } }
    }
}
