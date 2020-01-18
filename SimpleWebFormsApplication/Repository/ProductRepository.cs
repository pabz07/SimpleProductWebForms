using SimpleWebFormsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleWebFormsApplication.Repository.Interface;

namespace SimpleWebFormsApplication.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        // search for Product
        public IEnumerable<Product> SearchProduct(string search)
        {
            return _dbContext.Products.Where(prod => prod.Name.Contains(search)).ToList();
        }
    }
}