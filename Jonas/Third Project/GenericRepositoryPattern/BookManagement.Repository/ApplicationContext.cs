using BookManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = new AuthorMap(modelBuilder.Entity<Author>());
            _ = new BookMap(modelBuilder.Entity<Book>());
        }
    }
}
