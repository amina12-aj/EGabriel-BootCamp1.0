using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GRP.Data
{
    public class Repository<T>: IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            _context = context;
            entities = context.Set<T>();    
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            SaveChanges();
        }

        public IQueryable<T> GetQueryable(long id)
        {
            return entities.Where(x => x.Id == id).AsQueryable();
        }
       
        public T Get(long id)
        {
            return entities.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public void Insert(T entity)
        {
            if (entity == null) { throw new ArgumentNullException("entity"); }
            entities.Add(entity);
            SaveChanges ();
        }

        public void Update(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            SaveChanges();  
        }

        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
