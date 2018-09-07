using Repository;
using Repository.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Services
{
    public class ProductService
    {
        ProductsRepository _productRepo = new ProductsRepository();
        public ProductService()
        {
            //lazy init repo
            if(_productRepo == null)
            {
                _productRepo = new ProductsRepository();
            }
        }

        public List<Product> GetProductData()
        {
            return _productRepo.GetAllProductData();
        }
    }
}
