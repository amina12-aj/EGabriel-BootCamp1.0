using CrudAPI.MongoDB.Models;
using MongoDB.Entities;

namespace CrudAPI.MongoDB.Repo
{
    public class UserRepo : MyUserRepo
    {
        public async Task CreateUser(User user)
        {
            await user.SaveAsync();
        }
        public async Task<List<User>> GetAll()
        {
            var users = await DB.Find<User>()
                                 .Match(_ => true)
                                 .ExecuteAsync();
            return users;
        }
         public async Task<User> Get(string Id)
        {
            var user = await DB.Find<User>()
                                 .Match(x => x.ID == Id)
                                 .ExecuteFirstAsync();
            return user;
        }
         public async Task<User> update (string Id, User user)
        {
            var updatedUser = await DB.UpdateAndGet<User>()
                                 .Modify(Id)
                                 .ExecuteAsync();
            return updatedUser;
        }

        public Task<User> GetAll(string Id)
        {
            throw new NotImplementedException();
        }
    }
}