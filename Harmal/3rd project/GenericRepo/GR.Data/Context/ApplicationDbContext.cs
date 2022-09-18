    using GR.Data.Entities;
    using GR.Data.Mappers;
    using Microsoft.EntityFrameworkCore;

    namespace GR.Data.Context
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder) 
            {
                base.OnModelCreating(modelBuilder);
                new AuthorMap(modelBuilder.Entity<Author>());
                new BookMap(modelBuilder.Entity<Book>());
            }
        }
    }
