namespace GenericRepo.Repository
{
    using GenericRepo.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq.Expressions;

    namespace BlogProject.Repository
    {
        public interface IRepo<T> where T : BaseEntity
        {
            Task<IEnumerable<T>> GetAllAsync();
            Task<IEnumerable<T>> GetAllAsync(int Id);
            Task<T> GetByIdAsync(int id);
            void Add(T entity);
            void Delete(T entity);
            Task<bool> SaveChangesAsync();
            Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate);

        }
    }

}
