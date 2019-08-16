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
    public class Quotation : AbstractBaseObject
    {
        public override string TableName { get { return "quotations"; } }

        private long customerId;
        private Customer customer;

        private DateTime deliveryDate;

        public Quotation() : this("") { }
        public Quotation(string code) : base(code) { }

        #region Base overrides

        public override IObject CreateCopy()
        {
            Quotation cpy = new Quotation();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy != null && toCopy is Quotation q)
            {
                base.CopyFrom(toCopy);
                CustomerId = q.CustomerId;
                DeliveryDate = q.DeliveryDate;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is Quotation q)
            {
                return base.PropertiesEqual(iObject) &&
                    CustomerId == q.CustomerId &&
                    DeliveryDate == q.DeliveryDate;
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "customerId", CustomerId);
            DatabaseAccess.AddDbValue(command, "deliveryDate", DeliveryDate);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            CustomerId = DatabaseAccess.RGetLong(reader, "customerId");
            DeliveryDate = DatabaseAccess.RGetDate(reader, "deliveryDate");
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

        public long CustomerId
        {
            get
            {
                if (customerId < UNKNOWN_ID)
                {
                    customerId = UNKNOWN_ID;
                }
                return customerId;
            }
            set
            {
                if (customer != null && customer.Id != value)
                {
                    customer = null;
                }
                customerId = value;
                OnPropertyChanged("CustomerId");
            }
        }

        public DateTime DeliveryDate
        {
            get => deliveryDate;
            set
            {
                deliveryDate = value;
                OnPropertyChanged("DeliveryDate");
            }
        }

        #endregion
    }
}
