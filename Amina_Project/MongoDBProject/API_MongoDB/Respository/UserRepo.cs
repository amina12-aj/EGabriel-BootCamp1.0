using MongoDB.Entities;
using API_MongoDB.Model;
namespace API_MongoDB.Respository
  
{
    public class UserRepo: IUserRepo
    {
        public async Task CreateUser(User user) 
        {
            await user.SaveAsync();

        }
    }
}
