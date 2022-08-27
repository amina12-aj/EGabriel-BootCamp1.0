using Microsoft.EntityFrameworkCore;
using Onion_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Onion_Repository
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
            return entities.SingleOrDefault(p => p.ProductId == id);
        }
    }
}
