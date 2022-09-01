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
        
    }
}