using ProductCatalog.Dormain;

namespace ProductCatalog.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}