using OA_DataAccess;

namespace OA_Repository
{
    public interface IRepository<T> where T : BaseEntity
    {

        T Get(int id);
        IEnumerable<T> GetAll();
    }
    
    
}