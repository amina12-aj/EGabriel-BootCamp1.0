using CocktailApplication.Domain;
using Microsoft.EntityFrameworkCore;

namespace CocktailApplication.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Ingredient>? Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasKey(p => p.Id);
            modelBuilder.Entity<Ingredient>().Property(p => p.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}