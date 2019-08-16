using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class Material : AbstractBaseObject
    {
        public override string TableName { get { return "materials"; } }

        private decimal unitPrice;
        private MaterialUnit unit;
        private double weight; // Per meter

        private long typeId;
        private MaterialType type;

        public Material() : this("") { }
        public Material(string code) : base(code) { }

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
                UnitPrice = m.UnitPrice;
                Unit = m.Unit;
                Weight = m.Weight;
                TypeId = m.TypeId;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is Material m)
            {
                return base.PropertiesEqual(iObject) &&
                    UnitPrice == m.UnitPrice &&
                    Unit == m.Unit &&
                    Weight == m.Weight &&
                    TypeId == m.TypeId;
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "unitPrice", UnitPrice);
            DatabaseAccess.AddDbValue(command, "unit", Unit);
            DatabaseAccess.AddDbValue(command, "weight", Weight);
            DatabaseAccess.AddDbValue(command, "typeId", TypeId);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            UnitPrice = DatabaseAccess.RGetDecimal(reader, "unitPrice");
            UnitInt = DatabaseAccess.RGetInt(reader, "unit");
            Weight = DatabaseAccess.RGetDouble(reader, "weight");
            TypeId = DatabaseAccess.RGetLong(reader, "typeId");
        }

        public override void OnChanged(ActionType queryType)
        {
            base.OnChanged(queryType);
            switch (queryType)
            {
                case ActionType.Insert:
                    DataAccess.Dal.OnInserted(this);
                    break;
                case ActionType.Update:
                    DataAccess.Dal.OnUpdated(this);
                    break;
                case ActionType.Delete:
                    DataAccess.Dal.OnDeleted(this);
                    break;
            }
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

        public int UnitInt
        {
            get => (int)Unit;
            set
            {
                Unit = (MaterialUnit)value;
                OnPropertyChanged("UnitInt");
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
                if (type != null && type.Id != value)
                {
                    type = null;
                }
                typeId = value;
                OnPropertyChanged("TypeId");
            }
        }

        public MaterialType Type
        {
            get
            {
                if (type == null && TypeId > UNKNOWN_ID)
                {
                    type = DataAccess.Dal.MaterialTypes.ById(TypeId);
                }
                return type;
            }
        }
        

        #endregion
    }
}
