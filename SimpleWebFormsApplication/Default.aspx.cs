using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleWebFormsApplication.Repository;
using SimpleWebFormsApplication.Models;

namespace SimpleWebFormsApplication
{
    public partial class _Default : Page
    {
        ProductRepository productRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();

            // load all the Products
            if (!IsPostBack)
            {
                rptProducts.DataSource = productRepository.GetAll();
                rptProducts.DataBind();
            }
        }

        protected void SearchProduct_Click(object sender, EventArgs e)
        {
            string search = txtProductSearch.Text;
            rptProducts.DataSource = productRepository.SearchProduct(search);
            rptProducts.DataBind();
        }

        protected void EditProduct_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string productId = btn.CommandArgument;

            Response.Redirect("~/Pages/Products/EditProduct?productId=" + productId);
        }

        protected void DeleteProduct_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int productId = Int32.Parse(btn.CommandArgument);

            productRepository.Delete(productId);

            Response.Redirect("/");
        }
    }
}