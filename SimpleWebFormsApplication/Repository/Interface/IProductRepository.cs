using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWebFormsApplication.Models;

namespace SimpleWebFormsApplication.Repository.Interface
{
    interface IProductRepository
    {
        IEnumerable<Product> SearchProduct(string search);
    }
}
