using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityCustomer
    {
        private int Customerid;
        private string FirsName;
        private string LastName;
        private string Gender;
        private string Country;
        private string City;
        private int PostalCode;
        private string IbanNumber;
        private int Logisticid;

        public int Customerid1 { get => Customerid; set => Customerid = value; }
        public string FirsName1 { get => FirsName; set => FirsName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string City1 { get => City; set => City = value; }
        public int PostalCode1 { get => PostalCode; set => PostalCode = value; }
        public string IbanNumber1 { get => IbanNumber; set => IbanNumber = value; }
        public int Logisticid1 { get => Logisticid; set => Logisticid = value; }
    }
}
