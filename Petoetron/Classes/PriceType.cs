using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class PriceType : AbstractBaseObject
    {
        public override string TableName { get { return "pricetypes"; } }

        private decimal unitPrice;
        private PriceTypeUnit priceTypeUnit;

        public PriceType() : this("") { }
        public PriceType(string code) : base(code) { }
        

        #region Base overrides
        public override IObject CreateCopy()
        {
            PriceType cpy = new PriceType();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is PriceType p)
            {
                base.CopyFrom(toCopy);
                PriceTypeUnit = p.PriceTypeUnit;
                UnitPrice = p.UnitPrice;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is PriceType p)
            {
                return base.PropertiesEqual(p) &&
                PriceTypeUnit == p.PriceTypeUnit &&
                UnitPrice == p.UnitPrice;
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "priceTypeUnit", PriceTypeUnitInt);
            DatabaseAccess.AddDbValue(command, "unitPrice", UnitPrice);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            PriceTypeUnitInt = DatabaseAccess.RGetInt(reader, "priceTypeUnit");
            UnitPrice = DatabaseAccess.RGetDecimal(reader, "unitPrice");
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
        public PriceTypeUnit PriceTypeUnit
        {
            get => priceTypeUnit;
            set
            {
                priceTypeUnit = value;
                OnPropertyChanged("PriceTypeUnit");
            }
        }

        public int PriceTypeUnitInt
        {
            get => (int)PriceTypeUnit;
            set
            {
                PriceTypeUnit = (PriceTypeUnit)value;
                OnPropertyChanged("PriceTypeUnitInt");
            }
        }

        public decimal UnitPrice
        {
            get => unitPrice;
            set
            {
                unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }

        #endregion
    }
}
