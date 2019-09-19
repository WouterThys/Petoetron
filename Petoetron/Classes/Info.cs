using Petoetron.Classes.Helpers;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes
{
    public class Info
    {
        private readonly IniFile iniFile;

        private string companyName;
        private string email;
        private string phone;
        private double vat;
        private string vatNumber;
        private string logo;
        private string addressStreet;
        private string addressPlace;
        private string addressCity;
        private string addressCountry;

        public Info(IniFile iniFile)
        {
            this.iniFile = iniFile;
        }

        public void Read()
        {
            companyName = iniFile.ReadString("Info", "CompanyName");
            email = iniFile.ReadString("Info", "Email");
            phone = iniFile.ReadString("Info", "Phone");
            vat = iniFile.ReadDouble("Info", "VAT");
            vatNumber = iniFile.ReadString("Info", "VATNumber");
            logo = iniFile.ReadString("Info", "Logo");
            addressStreet = iniFile.ReadString("Info", "AddressStreet");
            addressPlace = iniFile.ReadString("Info", "AddressPlace");
            addressCity = iniFile.ReadString("Info", "AddressCity");
            addressCountry = iniFile.ReadString("Info", "AddressCountry");
        }

        public string Address
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (AddressStreet != null) sb.Append(AddressStreet).Append(Environment.NewLine);
                if (AddressPlace != null) sb.Append(AddressPlace).Append(Environment.NewLine);
                if (AddressCity != null) sb.Append(AddressCity).Append(Environment.NewLine);
                if (AddressCountry != null) sb.Append(AddressCountry).Append(Environment.NewLine);
                return sb.ToString();
            }
        }

        private void Write(string name, object value)
        {
            Task.Factory.StartNew(() => 
            {
                iniFile.WriteValue("Info", name, value.ToString());
            });
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; Write("CompanyName", value); }
        }

        public string Email
        {
            get { return email; }
            set { email = value; Write("Email", value); }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; Write("Phone", value); }
        }

        public double VAT
        {
            get { return vat; }
            set { vat = value; Write("VAT", value); }
        }

        public string VATNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; Write("VATNumber", value); }
        }

        public string Logo
        {
            get { return logo; }
            set { logo = value; Write("Logo", value); }
        }

        public string AddressStreet
        {
            get { return addressStreet; }
            set { addressStreet = value; Write("AddressStreet", value); }
        }

        public string AddressPlace
        {
            get { return addressPlace; }
            set { addressPlace = value; Write("AddressPlace", value); }
        }

        public string AddressCity
        {
            get { return addressCity; }
            set { addressCity = value; Write("AddressCity", value); }
        }

        public string AddressCountry
        {
            get { return addressCountry; }
            set { addressCountry = value; Write("AddressCountry", value); }
        }
    }
}
