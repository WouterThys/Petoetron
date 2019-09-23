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

        public QuotationPrice() : base() { }
        public QuotationPrice(string code) : base(code) { }
        public QuotationPrice(Quotation quotation) : base(quotation) { }

        public void SetPrice(PriceType t)
        {
            if (t != null)
            {
                PriceTypeId = t.Id;
                priceType = priceType;
            }
            else
            {
                PriceTypeId = 0;
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
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is QuotationPrice qp)
            {
                return
                     PriceTypeId == qp.PriceTypeId &&
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

        #endregion
    }
}
