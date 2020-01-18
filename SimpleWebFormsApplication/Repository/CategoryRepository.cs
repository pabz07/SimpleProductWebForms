using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleWebFormsApplication.Models;
using SimpleWebFormsApplication.Repository.Interface;

namespace SimpleWebFormsApplication.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        
    }
}