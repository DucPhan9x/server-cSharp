using System.Collections.Generic;
using SuperMarket.Core.Models;

namespace SuperMarket.Services
{
    public interface ICategoryServices
    {
        public List<Category> GetCategories();
        public Category GetCategory(int categoryId);
        public Category AddCategory(Category category);
        public Category EditCategory(int categoryId,Category category);
        public void DeleteCategory(int categoryID);
    }
}