using Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer : AbstractBaseObject
    {
        public override string TableName { get { return "Customers"; } }

        private string contactName;
        private string street;
        private string city;
        private string state;
        private string zip;
        private string fixedPhone;
        private string mobilePhone;
        private string vat;

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
            if (toCopy != null && toCopy is Customer c)
            {
                base.CopyFrom(toCopy);
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
            if (iObject != null && iObject is Customer c)
            {
                return base.PropertiesEqual(iObject) &&
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
        #endregion

        #region Properties

        public string ContactName
        {
            get => contactName;
            set { contactName = value; OnPropertyChanged("ContactName"); }
        }

        public string Street
        {
            get => street;
            set { street = value; OnPropertyChanged("Street"); }
        }

        public string City
        {
            get => city;
            set { city = value; OnPropertyChanged("City"); }
        }

        public string State
        {
            get => state;
            set { state = value; OnPropertyChanged("State"); }
        }

        public string Zip
        {
            get => zip;
            set { zip = value; OnPropertyChanged("Zip"); }
        }

        public string FixedPhone
        {
            get => fixedPhone;
            set { fixedPhone = value; OnPropertyChanged("FixedPhone"); }
        }

        public string MobilePhone
        {
            get => mobilePhone;
            set { mobilePhone = value; OnPropertyChanged("MobilePhone"); }
        }

        public string Vat
        {
            get => vat;
            set { vat = value; OnPropertyChanged("Vat"); }
        }
        #endregion
    }
}
