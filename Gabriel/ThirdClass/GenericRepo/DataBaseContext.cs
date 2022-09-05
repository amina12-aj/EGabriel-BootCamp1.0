using Microsoft.EntityFrameworkCore;

namespace GenericRepo
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }
        

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();
        public DbSet<Attendance> Attendance => Set<Attendance>();
    }
}