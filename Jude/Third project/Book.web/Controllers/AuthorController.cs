
using Book.data;
using Book.web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Book.web.Controllers
{
    [Route("[controller]")]
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IRepository<Author> _authRepo;
        private readonly IRepository<data.Book> _bookRepo;

        public AuthorController(ILogger<AuthorController> logger, IRepository<Author> authRepo, IRepository<Book.data.Book> bookRepo)
        {
            _logger = logger;
            _authRepo = authRepo;
            _bookRepo = bookRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = new List<AuthorListingViewModel>();
            _authRepo.GetAll().ToList().ForEach( item => {
                var author = new AuthorListingViewModel
                {
                    Id = item.Id,
                    Email = item.Email,
                    Name = $"{item.FirstName} {item.LastName}"
                };
                author.TotalBooks = _bookRepo.GetAll().Count(b => b.AuthorId == item.Id);
                model.Add(author);
            }    
            );
            return View("Index", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}