using GR.Data.Entities;
using GR.Data.Maps;
using Microsoft.EntityFrameworkCore;

namespace GR.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions <ApplicationContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new AuthorMap (modelBuilder.Entity <Author> ());
            new BookMap (modelBuilder.Entity <Book> ());
        }

    }
}