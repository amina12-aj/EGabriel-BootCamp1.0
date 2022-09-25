using CocktailApplication.Domain;

namespace CocktailApplication.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task Create(T entity);
    }
}