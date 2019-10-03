using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class QuotationPrice : AbstractQuoationItem
    {
        public override string TableName { get { return "quotationprices"; } }

        private long priceTypeId;
        private PriceType priceType;
        private decimal totalPrice;

        private QuotationPriceMaterialList materials;

        public QuotationPrice() : base() { }
        public QuotationPrice(string code) : base(code) { }
        public QuotationPrice(Quotation quotation) : base(quotation) { }

        public void SetPrice(PriceType t)
        {
            if (t != null)
            {
                PriceTypeId = t.Id;
                priceType = t;
            }
            else
            {
                PriceTypeId = 0;
            }
        }

        public void UpdatePrice()
        {
            if (PriceType != null)
            {
                if (PriceType.MaterialDependant)
                {
                    double weigth = 0.0;
                    foreach (QuotationMaterial qm in Quotation.MaterialList)
                    {
                        weigth += qm.TotalWeight;
                    }
                    TotalPrice = Amount * (decimal)weigth * 1;
                }
                else
                {
                    TotalPrice = Amount * (decimal)Value * PriceType.UnitPrice * (decimal)PriceType.Factor;
                }
            }
        }

        #region Base overrides

        public override IObject CreateCopy()
        {
            QuotationPrice cpy = new QuotationPrice();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is QuotationPrice qp)
            {
                base.CopyFrom(toCopy);
                PriceTypeId = qp.PriceTypeId;
                Materials = (QuotationPriceMaterialList)qp.Materials.CreateCopy();
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is QuotationPrice qp)
            {
                return
                     PriceTypeId == qp.PriceTypeId &&
                     base.PropertiesEqual(iObject) &&
                     Materials.Equals(qp.Materials);
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "priceTypeId", PriceTypeId);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitFromReader(reader);
            PriceTypeId = DatabaseAccess.RGetLong(reader, "priceTypeId");
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
        
        public long PriceTypeId
        {
            get
            {
                if (priceTypeId < UNKNOWN_ID)
                {
                    priceTypeId = UNKNOWN_ID;
                }
                return priceTypeId;
            }
            set
            {
                if (priceType != null && priceType.Id != value)
                {
                    priceType = null;
                }
                priceTypeId = value;
                OnPropertyChanged("PriceTypeId");
            }
        }
        
        public PriceType PriceType
        {
            get
            {
                if (priceType == null && PriceTypeId > UNKNOWN_ID)
                {
                    priceType = DataAccess.Dal.PriceTypes.ById(PriceTypeId);
                }
                return priceType;
            }
        }
        
        public decimal TotalPrice
        {
            get => totalPrice;
            set
            {
                totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }

        public QuotationPriceMaterialList Materials
        {
            get
            {
                if (materials == null)
                {
                    materials = new QuotationPriceMaterialList(Id);
                }
                return materials;
            }
            set
            {
                materials = value;
            }
        }

        #endregion
    }
}
