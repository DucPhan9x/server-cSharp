using Microsoft.EntityFrameworkCore;
using MovieTheater.Core.Models;

namespace MovieTheater.Core
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Film> Films { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}