using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes
{
    public class QuotationPrice : AbstractObject
    {
        public override string TableName { get { return "quotationprices"; } }

        private double amount;

        private long quotationId;
        private Quotation quotation;

        private long priceTypeId;
        private PriceType priceType;

        public QuotationPrice() : this("") { }
        public QuotationPrice(string code) : base(code) { }

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
                Amount = qp.Amount;
                QuotationId = qp.QuotationId;
                PriceTypeId = qp.PriceTypeId;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is QuotationPrice qp)
            {
                return base.PropertiesEqual(iObject) &&
                    Amount == qp.Amount &&
                    QuotationId == qp.QuotationId &&
                    PriceTypeId == qp.PriceTypeId;
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
            DatabaseAccess.AddDbValue(command, "priceTypeId", PriceTypeId);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            Amount = DatabaseAccess.RGetDouble(reader, "amount");
            QuotationId = DatabaseAccess.RGetLong(reader, "quotationId");
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
