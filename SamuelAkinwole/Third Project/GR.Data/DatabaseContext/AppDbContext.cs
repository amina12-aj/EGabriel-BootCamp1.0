using GR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepoProductAPI.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
