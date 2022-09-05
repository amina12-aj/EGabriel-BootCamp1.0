using Microsoft.EntityFrameworkCore;
using UserManagement.Data.DatabaseContext;
using UserManagement.Domain.Entities;

namespace UserManagement.Repository.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> Createuser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<User>> Get()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}