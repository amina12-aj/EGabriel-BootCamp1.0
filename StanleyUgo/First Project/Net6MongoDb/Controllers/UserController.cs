using Microsoft.AspNetCore.Mvc;
using Net6MongoDb.Models;
using Net6MongoDb.Repository;

namespace Net6MongoDb.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;
        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (user == null)
               return BadRequest("User must not be null");

            await _userRepo.CreateUser(user);

            return Ok(user);
        }
    }
}