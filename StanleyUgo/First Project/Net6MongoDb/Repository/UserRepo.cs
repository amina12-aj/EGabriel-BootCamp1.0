using MongoDB.Entities;
using Net6MongoDb.Models;

namespace Net6MongoDb.Repository
{
    public class UserRepo : IUserRepo
    {
        public async Task CreateUser(User user)
        {
            await user.SaveAsync();
        }
    }
}