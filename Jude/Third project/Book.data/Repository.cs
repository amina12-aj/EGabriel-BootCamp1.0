

using Microsoft.EntityFrameworkCore;

namespace Book.data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(AppDbContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }
        public void Create(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(long id)
        {
            ArgumentNullException.ThrowIfNull(id);
            return entities.SingleOrDefault(e => e.Id == id)!;
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable<T>();
        }

        public void Update(T entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            entities.Update(entity);
            _context.SaveChanges();
        }
    }
}