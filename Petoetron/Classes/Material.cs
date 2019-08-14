using Petoetron.Classes.Helpers;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class Material : AbstractBaseObject
    {
        public override string TableName { get { return "Material"; } }

        private decimal unitPrice;
        private MaterialUnit unit;
        private double weight; // Per meter

        private long typeId;

        public Material() : this("") {}
        public Material(string code) : base (code) { }

        #region Base Overrides

        public override IObject CreateCopy()
        {
            Material cpy = new Material();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Material m)
            {
                base.CopyFrom(m);

            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            return base.PropertiesEqual(iObject);
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
        }

        #endregion

        #region Properties

        public decimal UnitPrice
        {
            get => unitPrice;
            set
            {
                unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }

        public MaterialUnit Unit
        {
            get => unit;
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                weight = value;
                OnPropertyChanged("Weight");
            }
        }

        public long TypeId
        {
            get => typeId;
            set
            {
                typeId = value;
                OnPropertyChanged("TypeId");
            }
        }

        public virtual MaterialType Type { get; set; }

        #endregion
    }
}
