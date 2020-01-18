using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleWebFormsApplication.Repository;
using SimpleWebFormsApplication.Models;

namespace SimpleWebFormsApplication.Pages.Categories
{
    public partial class AddCategory : System.Web.UI.Page
    {
        CategoryRepository categoryRepository;

        protected void Page_Load(object sender, EventArgs e)
        {
            categoryRepository = new CategoryRepository();
        }

        protected void SaveCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            categoryRepository.Insert(category);

            Response.Redirect("~/Pages/Categories/AllCategories");
        }
    }
}