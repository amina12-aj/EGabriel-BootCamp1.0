using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using GR.Data.Models;

namespace GR.Data.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new AuthorMap(modelBuilder.Entity<Author>());
            new BookMap(modelBuilder.Entity<Book>());
        }
    }
}
