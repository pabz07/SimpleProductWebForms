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
    public partial class EditProduct : System.Web.UI.Page
    {
        protected ProductRepository productRepository;
        int productId;

        protected void Page_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            try
            {
                productId = Int32.Parse(Request.QueryString["productId"]);
            } catch(Exception exception)
            {
                Response.Redirect("/");
            }

            if (!IsPostBack)
            {
                this.inflateCategoryDropDownList();
                Product product = productRepository.GetById(productId);
                txtProductName.Text = product.Name;
                txtProductDescription.Text = product.Description;
                txtImage.Text = product.Image;
                ddlCategory.SelectedValue = product.CategoryId.ToString();
            }
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
            Product product = productRepository.GetById(productId);
            product.Name = txtProductName.Text;
            product.Description = txtProductDescription.Text;
            product.CategoryId = Int32.Parse(ddlCategory.SelectedValue);
            product.Image = txtImage.Text;
            // set the Timestamp of the Product
            product.UpdatedAt = DateTime.Now;

            productRepository.Update(product);

            Response.Redirect("/");
        }
    }
}