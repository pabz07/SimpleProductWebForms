using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleWebFormsApplication.Models;
using SimpleWebFormsApplication.Repository;

namespace SimpleWebFormsApplication.Pages.Categories
{
    public partial class AllCategories : System.Web.UI.Page
    {
        CategoryRepository categoryRepository;
        protected IEnumerable<Category> categories;
        protected int idToDelete;

        protected void Page_Load(object sender, EventArgs e)
        {
            categoryRepository = new CategoryRepository();
            this.categories = categoryRepository.GetAll();
            rptCategories.DataSource = this.categories;
            rptCategories.DataBind();
        }

        protected void SetIdToDelete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            idToDelete = Int32.Parse(btn.CommandArgument);
            categoryRepository.Delete(idToDelete);

            // reload the page to reflect the changes
            Response.Redirect("~/Pages/Categories/AllCategories");
        }
    }
}