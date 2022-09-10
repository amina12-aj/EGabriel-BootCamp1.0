using BookManagement.Domain;

namespace BookManagement.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T?> Get(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
