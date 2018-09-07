using ProductManagmentSystem.Models;
using Repository.DataModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductManagmentSystem
{
    public partial class _Default : Page
    {
        private ProductService _productService;
        public _Default()
        {
            //lazy init service
            if (_productService == null)
            {
                _productService = new ProductService();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            List<Product> productList = _productService.GetProductData();
            ItemsTable.DataSource = productList;
            ItemsTable.DataBind();
        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contact");
        }
    }

}