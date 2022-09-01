using BookManagement.Domain;
using BookManagement.Repository;
using BookManagement.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.UI.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IRepository<Author> authorRepository;
        private readonly IRepository<Book> bookRepository;

        public AuthorController(IRepository<Author> authorRepository, IRepository<Book> bookRepository)
        {
            this.authorRepository = authorRepository;
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<AuthorListingViewModel> model = new();
            authorRepository.GetAll().ToList().ForEach(a =>
            {
                AuthorListingViewModel author = new()
                {
                    Id = a.Id,
                    Name = $"{a.FirstName} {a.LastName}",
                    Email = a.Email,
                    TotalBooks = bookRepository.GetAll().Count(b => b.AuthorId == a.Id)
                };

                model.Add(author);
            });
            return View("Index", model);
        }

        [HttpGet]
        public PartialViewResult AddAuthor()
        {
            AuthorBookViewModel model = new();
            return PartialView("_AddAuthor", model);
        }

        [HttpPost]
        public IActionResult AddAuthor(AuthorBookViewModel model)
        {
            Author author = new() 
            {  
                FirstName = model.FirstName,  
                LastName = model.LastName,  
                Email = model.Email,  
                DateAdded = DateTime.UtcNow,  
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),  
                DateModified = DateTime.UtcNow,  
                
                Books = new List < Book > 
                {  
                    new Book 
                    {  
                        Name = model.BookName,  
                        ISBN = model.ISBN,  
                        Publisher = model.Publisher,  
                        IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),  
                        DateAdded = DateTime.UtcNow,  
                        DateModified = DateTime.UtcNow  
                    }  
                }  
            };  
            authorRepository.Insert(author);  
            return RedirectToAction("Index"); 
        }
    }
}