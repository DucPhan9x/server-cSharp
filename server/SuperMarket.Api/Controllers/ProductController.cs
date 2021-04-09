using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.Models;
using SuperMarket.Services;

namespace SuperMarket.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly IProductServices _productServies;
        [HttpGet]
        public List<Product> Get(){
            return _productServies.GetProducts();
        }
        [HttpGet("{productId}")]
        public Product Get(int productId){
            return _productServies.GetProduct(productId);
        }
        [HttpPut("{productId}")]
        public Product Put(int productId,Product product){
            return _productServies.EditProduct(productId,product);
        }
        [HttpPost]
        public Product Post(Product product){
            return _productServies.AddProduct(product);
        }
        [HttpDelete("{productId}")]
        public void Delete(int productId){
            _productServies.DeleteProduct(productId);
        }
    }
}