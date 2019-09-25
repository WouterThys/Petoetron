using Database;
using Petoetron.Dal;
using System;
using System.Data.Common;

namespace Petoetron.Classes.Helpers
{
    public abstract class AbstractQuoationItem : AbstractObject 
    {
        protected static long insertId = -10000;
        public static long NextId { get { return insertId--; } }

        protected int amount;
        protected double value;
        protected DateTime date;
        protected string info;

        protected long quotationId;
        protected Quotation quotation;

        public AbstractQuoationItem() : this("") { }
        public AbstractQuoationItem(string code) : base(code)
        {
            Id = NextId;
        }
        public AbstractQuoationItem(Quotation quotation) : this("")
        {
            this.quotation = quotation;
            quotationId = quotation != null ? quotation.Id : 0;

            date = DateTime.Now;
            amount = 1;
            value = 1;
        }

        #region Base overrides

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is AbstractQuoationItem qm)
            {
                base.CopyFrom(toCopy);
                Amount = qm.Amount;
                Value = qm.Value;
                Date = qm.Date;
                Info = qm.Info;
                QuotationId = qm.QuotationId;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is AbstractQuoationItem qm)
            {
                return base.PropertiesEqual(iObject) &&
                    Amount == qm.Amount &&
                    Value == qm.Value &&
                    Date == qm.Date &&
                    Info == qm.Info &&
                    QuotationId == qm.QuotationId;
            }
            return false;
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "amount", Amount);
            DatabaseAccess.AddDbValue(command, "value", Value);
            DatabaseAccess.AddDbValue(command, "date", Date);
            DatabaseAccess.AddDbValue(command, "info", Info);
            DatabaseAccess.AddDbValue(command, "quotationId", QuotationId);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            Amount = DatabaseAccess.RGetInt(reader, "amount");
            Value = DatabaseAccess.RGetDouble(reader, "value");
            Date = DatabaseAccess.RGetDateTime(reader, "date");
            Info = DatabaseAccess.RGetString(reader, "info");
            QuotationId = DatabaseAccess.RGetLong(reader, "quotationId");
        }

        #endregion

        #region Properties

        public int Amount
        {
            get => amount;
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public double Value
        {
            get => value;
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public string Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged("Info");
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
                //OnPropertyChanged("QuotationId");
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
            set { quotation = value; }
        }

        #endregion
    }
}
