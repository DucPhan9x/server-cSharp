using System.Collections.Generic;
using SuperMarket.Core;
using SuperMarket.Core.Models;
using System.Linq;
namespace SuperMarket.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly DataContext _context;
        public CategoryServices(DataContext context){
            _context=context;
        }
        public Category AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void DeleteCategory(int categoryID)
        {
            var category = _context.Categories.FirstOrDefault(x=>x.Id==categoryID);
            if(category ==null){
                return;
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category EditCategory(int categoryId, Category category)
        {
            var categoryEdit = _context.Categories.FirstOrDefault(x=>x.Id==categoryId);
            if(category == null){
                return null;
            }
            categoryEdit.Name = category.Name;
            _context.SaveChanges();
            return categoryEdit;
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return  _context.Categories.FirstOrDefault(x=>x.Id==categoryId);
        }
    }
}