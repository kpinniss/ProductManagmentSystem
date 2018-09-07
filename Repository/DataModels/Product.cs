using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataModels
{
    public class Product
    {
        public Product(int id, string sku, string ssku, string name, decimal price, int barcode, string updateTime)
        {
            ProductID = id;
            SKU = sku;
            SupplierSKU = ssku;
            ItemName = name;
            Price = price;
            Barcode = barcode;
            Updated = DateTime.Parse(updateTime);
        }
        public int ProductID { get; set; }
        public string SKU { get; set; }
        public string SupplierSKU { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Barcode { get; set; }
        public DateTime Updated { get; set; }
    }
}
