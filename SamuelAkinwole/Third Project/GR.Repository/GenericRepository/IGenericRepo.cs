using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GR.Repository.GenericRepository
{
    public interface IGenericRepo<T>
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<int> CreateAsync(T entity, bool isSave = true);
        Task<int> UpdateAsync(T entity, bool isSave = true);
        Task<int> DeleteAsync(int id, bool isSave = true);
        Task<int> SaveChangesToDbAsync();
        Task<bool> EntityExistsAsync(int id);


        //T GetById(int id);
        //IEnumerable<T> GetAll();
        //IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        //void Add(T entity);
        //void AddRange(IEnumerable<T> entities);
        //void Remove(T entity);
        //void RemoveRange(IEnumerable<T> entities);

    }
}
