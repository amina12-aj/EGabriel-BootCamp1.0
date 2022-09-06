using GenericRepo.Models;
using GenericRepo.Repository.BlogProject.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace GenericRepo.Controllers
{
    public class RoleController1 : Controller
    {
        private readonly IRepo<Role> _roleRepository;
        public RoleController1(IRepo<Role> roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            var role = await _roleRepository.GetAllAsync();
            return (IEnumerable<Role>)View(role);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var getRole = await _roleRepository.GetByIdAsync(id);
            return View(getRole);
        }

        public async Task<IActionResult> AddRole([FromBody] Role role)
        {
            _roleRepository.Add(role);
            var Saved = await _roleRepository.SaveChangesAsync();
            return View(Saved);
        }



        public async Task<bool> SaveChanges(int id)
        {
            return await _roleRepository.SaveChangesAsync();
        }


    }
}

