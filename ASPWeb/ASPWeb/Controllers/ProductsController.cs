using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWeb.Models;
using ASPWeb.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPWeb.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {

        private JsonFileProductService ProductService { get; }

        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}
