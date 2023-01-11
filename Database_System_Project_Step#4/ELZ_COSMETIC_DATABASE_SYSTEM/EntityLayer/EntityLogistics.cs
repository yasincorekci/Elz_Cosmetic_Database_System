using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityLogistics
    {
        private int Logisticid;
        private string LogisticCompanyName;
       
        private string Country;
        private string City;
        private int PostalCode;
        private int OrderCount;

        public int Logisticid1 { get => Logisticid; set => Logisticid = value; }
        public string LogisticCompanyName1 { get => LogisticCompanyName; set => LogisticCompanyName = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string City1 { get => City; set => City = value; }
        public int PostalCode1 { get => PostalCode; set => PostalCode = value; }
        public int OrderCount1 { get => OrderCount; set => OrderCount = value; }
    }
}
