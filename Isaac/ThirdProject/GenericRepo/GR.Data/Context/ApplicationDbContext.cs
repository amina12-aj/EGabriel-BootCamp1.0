using GR.Data.Entities;
using GR.Data.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        }
     
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Address { get; set; }
    }
}
