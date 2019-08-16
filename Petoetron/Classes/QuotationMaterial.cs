using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class QuotationMaterial : AbstractObject
    {
        public override string TableName { get { return "quotationmaterials"; } }

        private double amount;

        private long quotationId;
        private Quotation quotation;

        private long materialId;
        private Material material;

        public QuotationMaterial() : this("") { }
        public QuotationMaterial(string code) : base(code) { }

        #region Base overrides

        public override IObject CreateCopy()
        {
            QuotationMaterial cpy = new QuotationMaterial();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is QuotationMaterial qm)
            {
                base.CopyFrom(toCopy);
                Amount = qm.Amount;
                QuotationId = qm.QuotationId;
                MaterialId = qm.MaterialId;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is QuotationMaterial qm)
            {
                return base.PropertiesEqual(iObject) &&
                    Amount == qm.Amount &&
                    QuotationId == qm.QuotationId &&
                    MaterialId == qm.MaterialId;
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "amount", Amount);
            DatabaseAccess.AddDbValue(command, "quotationId", QuotationId);
            DatabaseAccess.AddDbValue(command, "materialId", MaterialId);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            Amount = DatabaseAccess.RGetDouble(reader, "amount");
            QuotationId = DatabaseAccess.RGetLong(reader, "quotationId");
            MaterialId = DatabaseAccess.RGetLong(reader, "materialId");
        }

        public override void OnChanged(ActionType queryType)
        {
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

        public double Amount
        {
            get => amount;
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public long QuotationId
        {
            get
            {
                if (quotationId < UNKNOWN_ID)
                {
                    quotationId = UNKNOWN_ID;
                }
                return quotationId;
            }
            set
            {
                if (quotation != null && quotation.Id != value)
                {
                    quotation = null;
                }
                quotationId = value;
                OnPropertyChanged("QuotationId");
            }
        }

        public long MaterialId
        {
            get
            {
                if (materialId < UNKNOWN_ID)
                {
                    materialId = UNKNOWN_ID;
                }
                return materialId;
            }
            set
            {
                if (material != null && material.Id != value)
                {
                    material = null;
                }
                materialId = value;
                OnPropertyChanged("MaterialId");
            }
        }

        public Quotation Quotation
        {
            get
            {
                if (quotation == null && QuotationId > UNKNOWN_ID)
                {
                    quotation = DataAccess.Dal.Quotations.ById(QuotationId);
                }
                return quotation;
            }
        }

        public Material Material
        {
            get
            {
                if (material == null && MaterialId > UNKNOWN_ID)
                {
                    material = DataAccess.Dal.Materials.ById(MaterialId);
                }
                return material;
            }
        }

        #endregion
    }
}
