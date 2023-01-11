using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityStorage
    {
        private int StorageCode;
        private string Country;
        private int City;
        private int PostalCode;

        public int StorageCode1 { get => StorageCode; set => StorageCode = value; }
        public string Country1 { get => Country; set => Country = value; }
        public int City1 { get => City; set => City = value; }
        public int PostalCode1 { get => PostalCode; set => PostalCode = value; }
    }
}
