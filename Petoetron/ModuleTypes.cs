using Petoetron.Models;
using System;

namespace Petoetron
{
    public class ModuleTypes
    {
        public readonly static SimpleModuleType MainViewModule = new SimpleModuleType(-10, -1, "MainView", "Petoetron");
        public readonly static SimpleModuleType QuotationItemModule = new SimpleModuleType(-11, -1, "", "");
        public readonly static SimpleModuleType InfoModule = new SimpleModuleType(-12, -1, "InfoView", "Info");

        public readonly static DataListModuleType QuotationListModule = new DataListModuleType(-100, 21, "Quotation");
        public readonly static AddEditDataModule QuotationEditModule = new AddEditDataModule(-101, 21, "Quotation");
        public readonly static AddEditDataModule QuotationPriceEditModule = new AddEditDataModule(-110, 21, "QuotationPrice");
        public readonly static AddEditDataModule QuotationMaterialEditModule = new AddEditDataModule(-111, 21, "QuotationMaterial");
        

        public readonly static DataListModuleType CustomerListModule = new DataListModuleType(-200, 18, "Customer");
        public readonly static AddEditDataModule CustomerEditModule = new AddEditDataModule(-201, 18, "Customer");

        public readonly static DataListModuleType MaterialTypeListModule = new DataListModuleType(-300, 19, "MaterialType");
        public readonly static AddEditDataModule MaterialTypeEditModule = new AddEditDataModule(-301, 19, "MaterialType");

        public readonly static DataListModuleType MaterialListModule = new DataListModuleType(-400, 17, "Material");
        public readonly static AddEditDataModule MaterialEditModule = new AddEditDataModule(-401, 17, "Material");

        public readonly static DataListModuleType PriceTypeListModule = new DataListModuleType(-500, 20, "PriceType");
        public readonly static AddEditDataModule PriceTypeEditModule = new AddEditDataModule(-501, 20, "PriceType");

        

        public readonly static AddEditDataModule ObjectDocumentEditModule = new AddEditDataModule(-1000, -1, "ObjectDocument");
        public readonly static SimpleModuleType ObjectLogModule = new SimpleModuleType(-1100, -1, "ObjectLog", "Wu us duur gebuurd?");
    }


    public abstract class BaseModuleType : IModuleType
    {
        public long Id { get; }
        public int ImageId { get; }
        public string ViewName { get; }
        public string ViewTitle { get; }

        protected BaseModuleType(int id, int imageId, string viewName, string titleCode)
        {
            Id = id;
            ImageId = imageId;
            ViewName = viewName;
            ViewTitle = titleCode;
        }

        public abstract Guid GetGuid(long id);

        public override bool Equals(object obj)
        {
            return obj is BaseModuleType type && Id == type.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }

    public class EmptyGuidModuleType : BaseModuleType
    {
        public EmptyGuidModuleType(int id, int imageId, string name) : base(id, imageId, name, "") { }

        public override Guid GetGuid(long id)
        {
            return Guid.Empty;
        }
    }

    public class SimpleModuleType : BaseModuleType
    {
        private Guid guid;
        public SimpleModuleType(int id, int imageId, string name, string titleCode) : base(id, imageId, name, titleCode)
        {
            guid = Guid.NewGuid();
        }

        public override Guid GetGuid(long id)
        {
            return guid;
        }
    }

    public class DataListModuleType : BaseModuleType
    {
        private Guid guid;
        public DataListModuleType(int id, int imageId, string objectName) : base(id, imageId, objectName + "ListView", objectName + "s")
        {
            guid = Guid.NewGuid();
        }

        public override Guid GetGuid(long id)
        {
            return guid;
        }
    }

    public class AddEditDataModule : BaseModuleType
    {
        public AddEditDataModule(int id, int imageId, string objectName) : base(id, imageId, objectName + "EditView", objectName + "s")
        {

        }
        
        public override Guid GetGuid(long id)
        {
            if (id > 0)
            {
                short s = (short)Id;
                return new Guid((int)id, s, 0, new byte[8]);
            }
            else
            {
                return Guid.NewGuid();
            }
        }
    }
}
