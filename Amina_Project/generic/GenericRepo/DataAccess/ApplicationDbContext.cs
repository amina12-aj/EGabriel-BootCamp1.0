using GenericRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        //entities
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Role> Roles { get; set; }
        

    }
}

