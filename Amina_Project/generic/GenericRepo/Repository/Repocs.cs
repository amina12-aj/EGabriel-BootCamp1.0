using GenericRepo.DataAccess;
using GenericRepo.Models;
using GenericRepo.Repository.BlogProject.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GenericRepo.Repository
{
    public class Repocs
    {
        public class Repo<T> : IRepo<T> where T : BaseEntity
        {
            private readonly ApplicationDbContext _context;
            private readonly DbSet<T> _entities;

            public Repo(ApplicationDbContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
                _entities = context.Set<T>();
            }

            public async Task<IEnumerable<T>> GetAllAsync()
            {
                return await _entities.ToListAsync();
            }

            public async Task<T> GetByIdAsync(int id)
            {
                return await _entities.SingleOrDefaultAsync(s => s.Id == id);
            }

            public void Add(T entity)
            {
                _entities.Add(entity);
            }

            public async Task<bool> SaveChangesAsync()
            {
                return await _context.SaveChangesAsync().ConfigureAwait(false) > 0;
            }

            public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate)
            {
                return await _context.Set<T>().FirstOrDefaultAsync(predicate);
            }



            public async Task<IEnumerable<T>> GetAllAsync(int Id)
            {
                var get = await _context.Blogs.Where(n => n.Id == Id).OrderBy(
                  n => n.CreatedDate).ToListAsync();
                return ((IEnumerable<T>)get);
            }

           
        }
    }
}
