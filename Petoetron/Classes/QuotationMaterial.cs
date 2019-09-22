using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class QuotationMaterial : AbstractQuoationItem
    {
        public override string TableName { get { return "quotationmaterials"; } }

        private long materialId;
        private Material material;

        public QuotationMaterial() : base() { }
        public QuotationMaterial(string code) : base(code) { }
        public QuotationMaterial(Quotation quotation) : base(quotation) { }
        
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
                MaterialId = qm.MaterialId;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is QuotationMaterial qm)
            {
                return
                     MaterialId == qm.MaterialId &&
                     base.PropertiesEqual(iObject);
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "materialId", MaterialId);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitFromReader(reader);
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
                if (string.IsNullOrEmpty(Code))
                {
                    Code = Material?.Code;
                }
                OnPropertyChanged("MaterialId");
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
