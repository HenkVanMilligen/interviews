using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realmdigital_Interview.ApiClients
{
    public partial class ApiClient
    {
        //get all products
        public async Task<List<Product>> GetProducts()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                ""));
            return await GetAsync<List<Product>>(requestUrl);
        }

        //get specific product
        public async Task<Product> GetProductById(string id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"id/{id}"));
            return await GetAsync<Product>(requestUrl);
        }

        //search for products
        public async Task<List<Product>> GetProductsByName(string name)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"names/{name}"));
            return await GetAsync<List<Product>>(requestUrl);
        }

        //public async Task<ApiMessage<Product>> SaveProduct(Product model)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "User/SaveUser"));
        //    return await PostAsync<Product>(requestUrl, model);
        //}
    }
}
