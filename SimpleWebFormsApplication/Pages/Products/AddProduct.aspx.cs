using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleWebFormsApplication.Models;
using SimpleWebFormsApplication.Repository;

namespace SimpleWebFormsApplication.Pages.Products
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected ProductRepository productRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            this.inflateCategoryDropDownList();
        }

        private void inflateCategoryDropDownList()
        {
            // populate the Category Dropdown List
            CategoryRepository categoryRepository = new CategoryRepository();
            ddlCategory.DataSource = categoryRepository.GetAll();
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "Id";
            ddlCategory.DataBind();
        }

        protected void SaveProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtProductName.Text;
            product.Description = txtProductDescription.Text;
            product.CategoryId = Int32.Parse(ddlCategory.SelectedValue);
            product.Image = txtImage.Text;
            // set the Timestamp of the Product
            product.CreatedAt = DateTime.Now;
            product.UpdatedAt = DateTime.Now;

            productRepository.Insert(product);

            Response.Redirect("/");
        }
    }
}