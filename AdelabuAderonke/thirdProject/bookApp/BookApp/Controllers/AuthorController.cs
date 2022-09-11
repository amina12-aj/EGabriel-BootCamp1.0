using Book.Data;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IRepository<Author> _repoAuthor;
        private readonly IRepository<book> _repoBook;

        public AuthorController(IRepository<Author> repoAuthor, IRepository<book> repoBook)
        {
           _repoAuthor = repoAuthor;
            _repoBook = repoBook;
        }

        public IActionResult Index()
        {
            List<AuthorListingViewModel> model = new List<AuthorListingViewModel>();
            _repoAuthor.GetAll().ToList().ForEach(a =>
            {
                AuthorListingViewModel author = new AuthorListingViewModel
                {
                    Id = a.Id,
                    Name = $"{a.FirstName}{a.LastName}",
                    Email = a.Email,

                };
                author.TotalBooks = _repoBook.GetAll().Count(x => x.AuthorId == a.Id);
                model.Add(author);
            });
            return View("Index",model);
        }


        public PartialViewResult AddAuthor()
        {
            AuthorViewModel model = new AuthorViewModel();
            return PartialView("AddAuthor", model);
        }
        [HttpPost]
        public ActionResult AddAuthor(AuthorViewModel model)
        {
            Author author = new Author
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                AddedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                ModifiedDate = DateTime.UtcNow,
                Books = new List<book> {
                new book {
                    Name = model.BookName,
                        ISBN = model.ISBN,
                        Publisher = model.Publisher,
                        IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                        AddedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow
                }
            }
            };
            _repoAuthor.Insert(author);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAuthor(long id)
        {
            AuthorViewModel model = new AuthorViewModel();
            Author author = _repoAuthor.Get(id);
            if (author != null)
            {
                model.FirstName = author.FirstName;
                model.LastName = author.LastName;
                model.Email = author.Email;
            }
            return PartialView("EditAuthor", model);
        }
        [HttpPost]
        public IActionResult EditAuthor(long id, AuthorViewModel model)
        {
            Author author = _repoAuthor.Get(id);
            if (author != null)
            {
                author.FirstName = model.FirstName;
                author.LastName = model.LastName;
                author.Email = model.Email;
                author.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                author.ModifiedDate = DateTime.UtcNow;
                _repoAuthor.Update(author);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public PartialViewResult AddBook(long id)
        {
            BookViewModel model = new BookViewModel();
            return PartialView("AddBook", model);
        }
        [HttpPost]
        public IActionResult AddBook(long id, BookViewModel model)
        {
            book book = new book
            {
                AuthorId = id,
                Name = model.BookName,
                ISBN = model.ISBN,
                Publisher = model.Publisher,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                AddedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };
            _repoBook.Insert(book);
            return RedirectToAction("Index");
        }
    }
}
