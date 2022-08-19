using Microsoft.AspNetCore.Mvc;
using API_MongoDB.Respository;
using API_MongoDB.Model;

namespace API_MongoDB.Controllers
{
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
       private readonly IUserRepo _UserRepo;

        public UserController(IUserRepo userRepo)
        { _UserRepo = userRepo; }
        
        [HttpPost]
        public async Task <IActionResult>Create(User user)
        { 
          if (user == null) return BadRequest("User cannot be null");
            await _UserRepo.CreateUser(user);
                return Ok();
        }
    }
}
