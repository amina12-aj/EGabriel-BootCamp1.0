using _DataAccess;

namespace _Repository
{
    public interface IRepository<T> where T : BaseEntity
    {

        T Get(int id);
        IEnumerable<T> GetAll();
    }
}