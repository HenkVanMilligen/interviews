using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Realmdigital_Interview.Factory;
using Realmdigital_Interview.Models;
using Realmdigital_Interview.Utility;

namespace Realmdigital_Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IOptions<ApiSettings> appSettings;
        public ProductsController(IOptions<ApiSettings> app)
        {
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
        }
       
        // GET api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            return await ApiFactory.Instance.GetProducts();
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(string id)
        {
            return await ApiFactory.Instance.GetProductById(id);
        }

        // GET api/products/"productExample"
        [HttpGet("{productName}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetByName(string productName)
        {
            return await ApiFactory.Instance.GetProductsByName(productName);
        }

    }
}

