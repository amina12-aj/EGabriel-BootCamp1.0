using _DataAccess;
using Microsoft.EntityFrameworkCore;

namespace _Repository;
public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Product> Products {get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<Product>());
            new ProductDetailMap(modelBuilder.Entity<ProductDetails>());
        }


        
    }