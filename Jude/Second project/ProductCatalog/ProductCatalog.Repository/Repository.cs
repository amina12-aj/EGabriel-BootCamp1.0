using Microsoft.EntityFrameworkCore;
using ProductCatalog.Dormain;

namespace ProductCatalog.Repository
{
    public class Repository<T>:IRepository<T> where T : BaseEntity  
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> entities;
        public Repository(ApplicationContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T Get(int id)
        {
            return entities.SingleOrDefault(p => p.ProductId == id)!;
        }
    }
}