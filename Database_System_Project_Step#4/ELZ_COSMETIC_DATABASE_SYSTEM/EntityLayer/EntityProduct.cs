using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityProduct
    {
        private int Productid;
        private string ProductName;
        private string ProductBrand;
        private string ProductType;
        private decimal ProductBoughtPrice;
        private decimal ProductSoldPrice;
        private int StorageCode;

        public int Productid1 { get => Productid; set => Productid = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public string ProductBrand1 { get => ProductBrand; set => ProductBrand = value; }
        public string ProductType1 { get => ProductType; set => ProductType = value; }
        public decimal ProductBoughtPrice1 { get => ProductBoughtPrice; set => ProductBoughtPrice = value; }
        public decimal ProductSoldPrice1 { get => ProductSoldPrice; set => ProductSoldPrice = value; }
        public int StorageCode1 { get => StorageCode; set => StorageCode = value; }
    }
}
