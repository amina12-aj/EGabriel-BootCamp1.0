using CrudAPI.MongoDB.Models;

namespace CrudAPI.MongoDB.Repo
{
    public interface MyUserRepo
    {
        Task CreateUser (User user);
        Task<List<User>> GetAll();
        Task<User> GetAll(string Id);
        Task<User> update (string Id, User user);
    }
}