using System.Collections.Generic;
using SuperMarket.Core.Models;

namespace SuperMarket.Services
{
    public interface IProductServices
    {
        public List<Product> GetProducts();
        public Product GetProduct (int productId);
        public Product AddProduct (Product product);
        public Product EditProduct (int productId,Product product);
        public void DeleteProduct(int productId);
    }
}