using Microsoft.EntityFrameworkCore;
using SuperMarket.Core.Models;
using System.Threading.Tasks;
namespace SuperMarket.Core.Helpers
{
    public class SeedHelper
    {
        public static async Task SeedCategories(DataContext context)
        {
            if (await context.Category.AnyAsync())
            {
                // if it have already exist, it'll not be added.
                return;
            }
            await context.Category.AddAsync(new Category { Name = "Phone" });
            await context.Category.AddAsync(new Category { Name = "Tivi" });
            await context.SaveChangesAsync();
        }

    }
}