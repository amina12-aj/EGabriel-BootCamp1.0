using _DataAccess;
using Microsoft.EntityFrameworkCore;

namespace _Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(p => p.ProductId == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
    }

}
