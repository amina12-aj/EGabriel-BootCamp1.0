using GenericRepo.Models;
using GenericRepo.Repository.BlogProject.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace GenericRepo.Controllers
{
    public class BlogController1 : Controller
    {
        [Authorize]
        public class BlogsController : Controller
        {
            private IRepo<Blog> _blogRepository;

            public BlogsController(IRepo<Blog> blogRepository)
            {
                _blogRepository = blogRepository;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Blog>>> GetbyDate(int Id)
            {
                var sorted = await _blogRepository.GetAllAsync(Id);
                return View(sorted);
            }



        }
    }
}
