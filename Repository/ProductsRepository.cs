using Repository.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductsRepository
    {
        private string GetAllProductsQuery()
        {
            string sql = @"";
            return sql;
        }
        public List<Product> GetAllProductData()
        {
            List<Product> productList = new List<Product>()
            {
                new Product(1001,"K00123","P1-9001", "Pencil", .50m, 1111111001, "01/01/2018"),
                new Product(1001,"K00333","P1-9015", "Pen", .60m, 111092911, "01/01/2018"),
                new Product(1001,"K00563","P1-9002", "Paper Ream", 8.50m, 1121102011, "01/01/2018"),
                new Product(1001,"K10990","P1-9002", "Paper Case", 35.50m, 1111222021, "01/01/2018")
            };

            return productList;
        }
    }
}
