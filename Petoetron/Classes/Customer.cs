using System.Data.Common;
using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;

namespace Petoetron.Classes
{
    public class Customer : AbstractBaseObject
    {
        public override string TableName { get { return "customers"; } }

        private string contactName;
        private string street;
        private string city;
        private string state;
        private string zip;
        private string fixedPhone;
        private string mobilePhone;
        private double vat;

        public Customer() : this("") { }
        public Customer(string code) : base(code) { }

        #region Base overrides

        public override IObject CreateCopy()
        {
            Customer cpy = new Customer();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Customer c)
            {
                base.CopyFrom(toCopy);
                ContactName = c.ContactName;
                Street = c.Street;
                City = c.City;
                State = c.State;
                Zip = c.Zip;
                FixedPhone = c.FixedPhone;
                MobilePhone = c.MobilePhone;
                Vat = c.Vat;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is Customer c)
            {
                return base.PropertiesEqual(iObject) &&
                    ContactName == c.ContactName &&
                    Street == c.Street &&
                    City == c.City &&
                    State == c.State &&
                    Zip == c.Zip &&
                    FixedPhone == c.FixedPhone &&
                    MobilePhone == c.MobilePhone &&
                    Vat == c.Vat;
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "contactName", ContactName);
            DatabaseAccess.AddDbValue(command, "street", Street);
            DatabaseAccess.AddDbValue(command, "city", City);
            DatabaseAccess.AddDbValue(command, "state", State);
            DatabaseAccess.AddDbValue(command, "zip", Zip);
            DatabaseAccess.AddDbValue(command, "fixedPhone", FixedPhone);
            DatabaseAccess.AddDbValue(command, "mobilePhone", MobilePhone);
            DatabaseAccess.AddDbValue(command, "vat", Vat);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            ContactName = DatabaseAccess.RGetString(reader, "contactName");
            Street = DatabaseAccess.RGetString(reader, "street");
            City = DatabaseAccess.RGetString(reader, "city");
            State = DatabaseAccess.RGetString(reader, "state");
            Zip = DatabaseAccess.RGetString(reader, "zip");
            FixedPhone = DatabaseAccess.RGetString(reader, "fixedPhone");
            MobilePhone = DatabaseAccess.RGetString(reader, "mobilePhone");
            Vat = DatabaseAccess.RGetDouble(reader, "vat");
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

        public string ContactName
        {
            get => contactName ?? "";
            set { contactName = value; OnPropertyChanged("ContactName"); }
        }

        public string Street
        {
            get => street ?? "";
            set { street = value; OnPropertyChanged("Street"); }
        }

        public string City
        {
            get => city ?? "";
            set { city = value; OnPropertyChanged("City"); }
        }

        public string State
        {
            get => state ?? "";
            set { state = value; OnPropertyChanged("State"); }
        }

        public string Zip
        {
            get => zip ?? "";
            set { zip = value; OnPropertyChanged("Zip"); }
        }

        public string FixedPhone
        {
            get => fixedPhone ?? "";
            set { fixedPhone = value; OnPropertyChanged("FixedPhone"); }
        }

        public string MobilePhone
        {
            get => mobilePhone ?? "";
            set { mobilePhone = value; OnPropertyChanged("MobilePhone"); }
        }

        public double Vat
        {
            get => vat;
            set { vat = value; OnPropertyChanged("Vat"); }
        }
        #endregion
    }
}
