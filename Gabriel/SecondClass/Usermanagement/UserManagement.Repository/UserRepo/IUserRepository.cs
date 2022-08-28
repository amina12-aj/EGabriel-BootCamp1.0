using UserManagement.Domain.Entities;

namespace UserManagement.Repository.UserRepo
{
    public interface IUserRepository
    {
        Task<User> Createuser(User user);
        Task<IEnumerable<User>> Get();
    }
}