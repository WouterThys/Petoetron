using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Petoetron.Classes
{
    public class Quotation : AbstractBaseObject
    {
        public override string TableName { get { return "quotations"; } }

        private long customerId;
        private Customer customer;

        private DateTime deliveryDate;
        private DateTime dueDate;
        private DateTime paidDate;
        private bool paid;
        
        private QuotationMaterialList quotationMaterials;
        private QuotationPriceList quotationPrices;

        public Quotation() : this("") { }
        public Quotation(string code) : base(code)
        {
            deliveryDate = DateTime.Now;
            dueDate = DateTime.Now;
        }

        public IEnumerable<QuotationMaterial> MaterialList
        {
            get { return Materials?.Values; }
        }

        public IEnumerable<QuotationPrice> PriceList
        {
            get { return Prices?.Values; }
        }

        public IEnumerable<string> MaterialGroupCodes
        {
            get
            {
                List<string> codes = new List<string>();
                if (Materials != null)
                {
                    foreach (QuotationMaterial qm in Materials.Values)
                    {
                        string code = qm.GroupCode;
                        if (!string.IsNullOrEmpty(code) && !codes.Contains(code))
                        {
                            codes.Add(code);
                        }
                    }
                }
                return codes;
            }
        }

        public void UpdatePrices()
        {
            if (Prices != null)
            {
                foreach (QuotationPrice qp in Prices.Values)
                {
                    qp.UpdatePrice()
                }
            }
        }

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
                DueDate = q.DueDate;
                PaidDate = q.PaidDate;
                Paid = q.Paid;
                Materials = (QuotationMaterialList)q.Materials.CreateCopy();
                Prices = (QuotationPriceList)q.Prices.CreateCopy();
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is Quotation q)
            {
                return base.PropertiesEqual(iObject) &&
                    CustomerId == q.CustomerId &&
                    DeliveryDate == q.DeliveryDate &&
                    DueDate == q.DueDate &&
                    PaidDate == q.PaidDate &&
                    Paid == q.Paid &&
                    Materials.Equals(q.Materials) &&
                    Prices.Equals(q.Prices);
            }
            return false;
        }

        public override void DoInsert() { }
        public override void DoUpdate() { }
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override bool Save()
        {
            if (Id < UNKNOWN_ID)
            {
                DataAccess.Dal.Db.InsertTask(this).Wait();
                UpdateMaterials(null);
                UpdatePrices(null);
                DataAccess.Dal.OnInserted(this);
            }
            else
            {
                DataAccess.Dal.Db.UpdateTask(this).Wait();
                UpdateMaterials(DataAccess.Dal.Quotations.ById(Id));
                UpdatePrices(DataAccess.Dal.Quotations.ById(Id));
                DataAccess.Dal.OnUpdated(this);
            }

            return true;
        }

        protected static void CalculateLinks<L>(HashSet<L> newLinks, HashSet<L> oldLinks, out HashSet<L> toAdd, out HashSet<L> toDelete)
        {
            toDelete = new HashSet<L>(oldLinks);
            toDelete.ExceptWith(newLinks);

            toAdd = new HashSet<L>(newLinks);
            toAdd.ExceptWith(oldLinks);
        }

        private void UpdateMaterials(Quotation oldQuotation)
        {
            List<Task> tasks = new List<Task>();
            if (oldQuotation == null) // New one
            {
                if (Materials != null && Materials.Count > 0)
                {
                    foreach (QuotationMaterial qm in Materials.Values)
                    {
                        qm.QuotationId = Id;
                        tasks.Add(DataAccess.Dal.Db.InsertTask(qm));
                    }
                }
            }
            else
            {
                HashSet<QuotationMaterial> newIds = Materials != null ?
                                    new HashSet<QuotationMaterial>(Materials.Values) :
                                    new HashSet<QuotationMaterial>();
                HashSet<QuotationMaterial> oldIds = oldQuotation.Materials != null ?
                                    new HashSet<QuotationMaterial>(oldQuotation.Materials.Values) :
                                    new HashSet<QuotationMaterial>();

                CalculateLinks(newIds, oldIds, out HashSet<QuotationMaterial> toAdd, out HashSet<QuotationMaterial> toDelete);
                HashSet<QuotationMaterial> toUpdate = new HashSet<QuotationMaterial>(Materials.Values);
                toUpdate.ExceptWith(toAdd);
                toUpdate.ExceptWith(toDelete);

                foreach (QuotationMaterial qm in toAdd)
                {
                    tasks.Add(DataAccess.Dal.Db.InsertTask(qm));
                }
                foreach (QuotationMaterial qm in toDelete)
                {
                    tasks.Add(DataAccess.Dal.Db.DeleteTask(qm));
                }
                foreach (QuotationMaterial qm in toUpdate)
                {
                    tasks.Add(DataAccess.Dal.Db.UpdateTask(qm));
                }
            }
            Task.WaitAll(tasks.ToArray());
            if (oldQuotation != null)
            {
                oldQuotation.Materials.Ids = null;
            }
            Materials.ObjectId = Id;
            Materials.Ids = null;
        }

        private void UpdatePrices(Quotation oldQuotation)
        {
            List<Task> tasks = new List<Task>();
            if (oldQuotation == null) // New one
            {
                if (Materials != null && Materials.Count > 0)
                {
                    foreach (QuotationPrice qp in Prices.Values)
                    {
                        qp.QuotationId = Id;
                        tasks.Add(DataAccess.Dal.Db.InsertTask(qp));
                    }
                }
            }
            else
            {
                HashSet<QuotationPrice> newIds = Materials != null ?
                                    new HashSet<QuotationPrice>(Prices.Values) :
                                    new HashSet<QuotationPrice>();
                HashSet<QuotationPrice> oldIds = oldQuotation.Materials != null ?
                                    new HashSet<QuotationPrice>(oldQuotation.Prices.Values) :
                                    new HashSet<QuotationPrice>();

                CalculateLinks(newIds, oldIds, out HashSet<QuotationPrice> toAdd, out HashSet<QuotationPrice> toDelete);
                HashSet<QuotationPrice> toUpdate = new HashSet<QuotationPrice>(Prices.Values);
                toUpdate.ExceptWith(toAdd);
                toUpdate.ExceptWith(toDelete);

                foreach (QuotationPrice qp in toAdd)
                {
                    tasks.Add(DataAccess.Dal.Db.InsertTask(qp));
                }
                foreach (QuotationPrice qp in toDelete)
                {
                    tasks.Add(DataAccess.Dal.Db.DeleteTask(qp));
                }
                foreach (QuotationPrice qp in toUpdate)
                {
                    tasks.Add(DataAccess.Dal.Db.UpdateTask(qp));
                }
            }
            Task.WaitAll(tasks.ToArray());
            if (oldQuotation != null)
            {
                oldQuotation.Prices.Ids = null;
            }
            Prices.ObjectId = Id;
            Prices.Ids = null;
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "customerId", CustomerId);
            DatabaseAccess.AddDbValue(command, "deliveryDate", DeliveryDate);
            DatabaseAccess.AddDbValue(command, "dueDate", DueDate);
            DatabaseAccess.AddDbValue(command, "paidDate", PaidDate);
            DatabaseAccess.AddDbValue(command, "paid", Paid);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            CustomerId = DatabaseAccess.RGetLong(reader, "customerId");
            DeliveryDate = DatabaseAccess.RGetDate(reader, "deliveryDate");
            DueDate = DatabaseAccess.RGetDate(reader, "dueDate");
            PaidDate = DatabaseAccess.RGetDate(reader, "paidDate");
            Paid = DatabaseAccess.RGetBool(reader, "paid");
        }

        public override void OnChanged(ActionType queryType)
        {
            base.OnChanged(queryType);
            switch (queryType)
            {
                case ActionType.Delete:
                    DataAccess.Dal.OnDeleted(this);
                    break;
            }
        }

        #endregion

        #region Properties

        // Helper for report
        public Info MyInfo
        {
            get { return ClientContext.Context.Info; }
        }

       
        public override string Code
        {
            get
            {
                if (Id > UNKNOWN_ID && (string.IsNullOrEmpty(code) || code.Contains("xxx")))
                {
                    int year = DateTime.Now.Year;
                    code = year.ToString() + "-" + Id.ToString("D6");
                }
                else if (Id < UNKNOWN_ID)
                {
                    code = DateTime.Now.Year + "-xxxxxx";
                }
                return code;
            }
            set
            {
                base.Code = value;
            }
        }

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
            get => deliveryDate.Date;
            set
            {
                deliveryDate = value;
                OnPropertyChanged("DeliveryDate");
            }
        }

        public DateTime DueDate
        {
            get => dueDate.Date;
            set
            {
                dueDate = value;
                OnPropertyChanged("DueDate");
            }
        }

        public DateTime PaidDate
        {
            get
            {
                if (Paid)
                {
                    return paidDate.Date;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                paidDate = value;
                OnPropertyChanged("PaidDate");
            }
        }

        public bool Paid
        {
            get => paid;
            set
            {
                if (value && (PaidDate == null || PaidDate.Equals(DateTime.MinValue)))
                {
                    PaidDate = DateTime.Now;
                }
                paid = value;
                OnPropertyChanged("Paid");
            }
        }

        public QuotationMaterialList Materials
        {
            get
            {
                if (quotationMaterials == null)
                {
                    quotationMaterials = new QuotationMaterialList(Id);
                }
                return quotationMaterials;
            }
            set
            {
                quotationMaterials = value;
            }
        }

        public QuotationPriceList Prices
        {
            get
            {
                if (quotationPrices == null)
                {
                    quotationPrices = new QuotationPriceList(Id);
                }
                return quotationPrices;
            }
            set
            {
                quotationPrices = value;
            }
        }


        public Customer Customer
        {
            get
            {
                if (customer == null && CustomerId > UNKNOWN_ID)
                {
                    customer = DataAccess.Dal.Customers.ById(CustomerId);
                }
                return customer;
            }
        }

        #endregion
    }
}
