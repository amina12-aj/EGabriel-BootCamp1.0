using GenericRepoProductAPI.DatabaseContext;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GR.Repository.GenericRepository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class, new()
    {
        private readonly AppDbContext _db;
        private readonly ILogger _logger;

        public GenericRepo(AppDbContext db, ILogger<GenericRepo<T>> logger)
        {
            _db = db;
            _logger = logger;
        }
        public async Task<int> CreateAsync(T entity, bool isSave = true)
        {
            if (entity == null)
            {
                _logger.LogError("Entity cannot be null");
                return 3;
            }

            _db.Set<T>().Add(entity);

            if (isSave)
            {
                return await SaveChangesToDbAsync();
            }

            return 1;
        }

        public async Task<int> DeleteAsync(int id, bool isSave = true)
        {
            T entity = await GetByIdAsync(id);
            if(entity == null)
            {
                _logger.LogError("Entity cannot be null");
            }

            _db.Set<T>().Remove(entity);

            if (isSave)
            {
                return await SaveChangesToDbAsync();
            }

            return 1;
        }

        public async Task<bool> EntityExistsAsync(int id)
        {
            T entityFound = await _db.Set<T>().FindAsync(id);

            if(entityFound == null)
            {
                return false;
            }

            return true;
        }

        public IQueryable<T> GetAll()
        {
            return _db.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _db.Set<T>().FindAsync(id);

            if (entity == null)
            {
                return null;
            }
            else
            {
                return entity;
            }
        }

        public async Task<int> SaveChangesToDbAsync()
        {
            _logger.LogInformation("Save process started");
            int saveResult;

            try
            {
                int tempResult = await _db.SaveChangesAsync();
                saveResult = 1;
            }
            catch (Exception ex)
            {
                _logger.LogError("Cannot save");
                saveResult = -1;
                throw;
            }
            return saveResult;
        }

        public async Task<int> UpdateAsync(T entity, bool isSave = true)
        {
            _db.Set<T>().Update(entity);

            if (isSave)
            {
                return await SaveChangesToDbAsync();
            }

            return 1;
        }

        //public void Add(T entity)
        //{
        //    _db.Set<T>().Add(entity);
        //}
        //public void AddRange(IEnumerable<T> entities)
        //{
        //    _db.Set<T>().AddRange(entities);
        //}
        //public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        //{
        //    return _db.Set<T>().Where(expression);
        //}
        //public IEnumerable<T> GetAll()
        //{
        //    return _db.Set<T>().ToList();
        //}
        //public T GetById(int id)
        //{
        //    return _db.Set<T>().Find(id);
        //}
        //public void Remove(T entity)
        //{
        //    _db.Set<T>().Remove(entity);
        //}
        //public void RemoveRange(IEnumerable<T> entities)
        //{
        //    _db.Set<T>().RemoveRange(entities);
        //}
    }
}
