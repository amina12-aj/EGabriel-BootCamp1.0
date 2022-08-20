using Net6MongoDb.Models;

namespace Net6MongoDb.Repository
{
    public interface IUserRepo
    {
        Task CreateUser(User user);
    }
}