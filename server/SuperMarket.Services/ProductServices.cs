using System.Collections.Generic;
using System.Linq;
using SuperMarket.Core;
using SuperMarket.Core.Models;

namespace SuperMarket.Services
{
    public class ProductServices : IProductServices
    {
        private readonly DataContext _context;
        public ProductServices(DataContext context){
            _context = context;
        }
        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(x=>x.Id==productId);
            if(product == null){
                return;
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Product EditProduct(int ProductId, Product product)
        {
            var productEdit = _context.Products.FirstOrDefault(x=>x.Id==product.Id);
            if(product == null){
                return null;
            }
            productEdit.CategoryId = productEdit.CategoryId ;
            productEdit.Name = productEdit.Name;
            productEdit.Description = productEdit.Description;
            productEdit.ImageUrl = productEdit.ImageUrl;
            _context.SaveChanges();
            return productEdit;
        }

        public Product GetProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(x=>x.Id==productId);
            if(product == null){
                return null;
            }
            return product;
        }

        public List<Product> GetProducts()
        {
           return _context.Products.ToList();
        }
    }
}