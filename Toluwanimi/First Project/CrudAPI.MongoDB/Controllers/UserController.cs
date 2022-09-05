using CrudAPI.MongoDB.Models;
using CrudAPI.MongoDB.Repo;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.MongoDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class UserController : ControllerBase 
    {
        private readonly MyUserRepo _userRepo;
        public UserController(MyUserRepo userRepo)
        {
            _userRepo = userRepo;

        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (user == null) return BadRequest("User must not be null");
            await _userRepo.CreateUser (user);
            return Ok(user);
        }
        [HttpGet("/get-all")]
        public async Task<IActionResult> Get()
        {
            var allUsers = await _userRepo.GetAll();
            return Ok(allUsers);
        }
        [HttpGet("/get")]
        public async Task<IActionResult> GetOne (string Id)
        {
            var user = await _userRepo.GetAll();
            return Ok(user);
        }
         [HttpPut]
        public async Task<IActionResult> Update(string Id, User user)
        {
            var updatedUser = await _userRepo.update(Id, user);
            return Ok(user);
        }
    
    }
}

    
