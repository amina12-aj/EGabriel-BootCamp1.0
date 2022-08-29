using BookManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;

        private readonly DbSet<T> entities;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task<bool> Delete(T entity)
        {
            if(entity is null) throw new ArgumentNullException(nameof(entity));
            entities.Remove(entity);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<T?> Get(int id)
        {
            return await entities.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task Insert(T entity)
        {
            if(entity is null) throw new ArgumentNullException(nameof(entity));
            await entities.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if(entity is null) throw new ArgumentNullException(nameof(entity));
            await context.SaveChangesAsync();
        }
    }
}