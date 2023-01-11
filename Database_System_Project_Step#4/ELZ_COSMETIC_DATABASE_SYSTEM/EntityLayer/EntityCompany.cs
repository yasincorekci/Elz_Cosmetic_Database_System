using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer
{
    public class EntityCompany
    {
        private string TaxID;
        private string CompanyName;
        private string Country;
        private string City;
        private string PostalCode;
        private string IbanNumber;
        private string OrderID;
        private string ProductID;

        public string CompanyName1 { get => CompanyName; set => CompanyName = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string City1 { get => City; set => City = value; }
        public string PostalCode1 { get => PostalCode; set => PostalCode = value; }
        public string IbanNumber1 { get => IbanNumber; set => IbanNumber = value; }
        public string OrderID1 { get => OrderID; set => OrderID = value; }
        public string ProductID1 { get => ProductID; set => ProductID = value; }
        public string TaxID1 { get => TaxID; set => TaxID = value; }
    }
}