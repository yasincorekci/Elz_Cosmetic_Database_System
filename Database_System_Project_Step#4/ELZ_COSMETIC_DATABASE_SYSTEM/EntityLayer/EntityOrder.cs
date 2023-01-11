using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOrder
    {
        private int Orderid;
        private string OrderDate;
        private int TotalPrice;
        private int Logisticid;
        private int StorageCode;
        private int taxid;

        public int Orderid1 { get => Orderid; set => Orderid = value; }
        public string OrderDate1 { get => OrderDate; set => OrderDate = value; }
        public int TotalPrice1 { get => TotalPrice; set => TotalPrice = value; }
        public int Logisticid1 { get => Logisticid; set => Logisticid = value; }
        public int StorageCode1 { get => StorageCode; set => StorageCode = value; }
        public int Taxid { get => taxid; set => taxid = value; }
    }
}
