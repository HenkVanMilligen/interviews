using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realmdigital_Interview.Contracts
{
    public interface IProductsService
    {

        List<Product> GetProducts();
        Product GetProductById(string id);
        List<Product> GetProductsByName(string name);

    }
}
