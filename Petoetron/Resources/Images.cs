using DevExpress.Utils;
using Petoetron.Models;
using System.ComponentModel;
using System.Drawing;

namespace Petoetron.Resources
{
    public enum ImageSize
    {
        i16x16,
        i24x24,
        i32x32,
        i48x48
    }

    public partial class Images : Component
    {
        private ImageSize defaultSize = ImageSize.i16x16;

        public Images()
        {
            InitializeComponent();
        }

        public Images(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public ImageSize DefaultSize
        {
            get { return defaultSize; }
            set { defaultSize = value; }
        }

        public Image GetIcon(IModuleType moduleType)
        {
            return GetIcon(moduleType, DefaultSize);
        }

        public Image GetIcon(IModuleType moduleType, ImageSize size)
        {
            if (moduleType == null || moduleType.ImageId < 0) return null;
            switch (size)
            {
                default:
                case ImageSize.i16x16: return Images16x16.Images[moduleType.ImageId];
                case ImageSize.i24x24: return Images24x24.Images[moduleType.ImageId];
                //case ImageSize.i32x32: return Images32x32.Images[moduleType.ImageId];
                case ImageSize.i48x48: return Images48x48.Images[moduleType.ImageId];
            }
        }

        public Image GetIcon(int index)
        {
            return GetIcon(index, DefaultSize);
        }

        public Image GetIcon(int index, ImageSize size)
        {
            if (index < 0) return null;
            switch (size)
            {
                default:
                case ImageSize.i16x16: return Images16x16.Images[index];
                case ImageSize.i24x24: return Images24x24.Images[index];
                //case ImageSize.i32x32: return Images32x32.Images[index];
                case ImageSize.i48x48: return Images48x48.Images[index];
            }
        }

        public ImageCollection Images16x16
        {
            get { return imageCollection16x16; }
        }
        public ImageCollection Images24x24
        {
            get { return imageCollection24x24; }
        }

        public ImageCollection Images48x48
        {
            get { return imageCollection48x48; }
        }
    }
}
