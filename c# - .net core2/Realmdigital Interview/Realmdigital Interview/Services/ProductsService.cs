using Models;
using Realmdigital_Interview.Contracts;
using Realmdigital_Interview.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realmdigital_Interview.Services
{
    public class ProductsService : IProductsService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>();
        }
        public Product GetProductById(string id)
        {
            return new Product();
        }
        public List<Product> GetProductsByName(string name)
        {
            return new List<Product>();
        }
    }
}
