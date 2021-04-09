using Microsoft.EntityFrameworkCore;
using SuperMarket.Core.Models;
using System.Threading.Tasks;
namespace SuperMarket.Core.Helpers
{
    public class SeedHelper
    {
        public static async Task SeedCategories(DataContext context)
        {
            if (await context.Categories.AnyAsync())
            {
                // if it have already exist, it'll not be added.
                return;
            }
            await context.Categories.AddAsync(new Category { Name = "Phone" });
            await context.Categories.AddAsync(new Category { Name = "Tivi" });
            await context.SaveChangesAsync();
        }

        public static  async Task SeedProducts(DataContext context){
            if(await context.Products.AnyAsync()){
                return;
            }
            await context.Products.AddAsync(new Product{
                Name = "IPhone 12",
                CategoryId = 1,
                Description = "This is IPhone 12",
                Price = 1500,
                ImageUrl = "this is url image"
            });
            await context.Products.AddAsync(new Product{
                Name = "IPhone 13",
                CategoryId = 2,
                Description = "This is IPhone 13",
                Price = 2000,
                ImageUrl = "this is url image"
            });
            await context.SaveChangesAsync();
        }

    }
}