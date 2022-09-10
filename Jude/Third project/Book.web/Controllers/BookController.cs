
using Book.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Book.web.Controllers
{
    [Route("[controller]")]
    public class BookController : Controller
    {
    private readonly ILogger<BookController> _logger;
        private readonly IRepository<data.Book> _bookRepo;

        public BookController(ILogger<BookController> logger, IRepository<Book.data.Book> bookRepo)
        {
            _bookRepo = bookRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
          
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}