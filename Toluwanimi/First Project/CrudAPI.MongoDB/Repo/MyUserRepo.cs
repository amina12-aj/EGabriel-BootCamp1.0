using CrudAPI.MongoDB.Models;

namespace CrudAPI.MongoDB.Repo
{
    public interface MyUserRepo
    {
        Task CreateUser (User user);
         
    }
}