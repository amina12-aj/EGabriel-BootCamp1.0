using GR.Data.Entities;
using GR.Data.Repository;
using GR.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GR.Web.Controllers
{
    public class AuthorController : Controller
    {
        private IRepository <Author> repoAuthor;
        private IRepository <Book> repoBook;
        public AuthorController(IRepository <Author> repoAuthor, IRepository <Book> repoBook )
        {
            this.repoAuthor = repoAuthor;
            this.repoBook = repoBook;
        }
        
        //Index Action Method
        [HttpGet]
        public IActionResult Index()
        {
            List<AuthorListingModel> model = new List<AuthorListingModel>();
            repoAuthor.GetAll().ToList().ForEach(a =>
            {
                AuthorListingModel author = new AuthorListingModel
                {
                    Id = a.Id,
                    Name = $"{a.FirstName} {a.LastName}",
                    Email = a.Email
                };
                author.Cart = repoBook.GetAll().Count(b => b.AuthorId == a.Id);
                model.Add(author);
            });
            return View("Index", model);
        }

        //Add Author 
        [HttpGet]
        public PartialViewResult AddAuthor()
        {
            AddAuthorModel model = new AddAuthorModel();
            return PartialView("_AddAuthor", model);
        }
        
        [HttpPost]
        public ActionResult AddAuthor (AddAuthorModel model)
        {
            Author author = new Author
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                DateAdded = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                ModifiedDate = DateTime.UtcNow,
                Books = new List <Book>
                {
                    new Book
                    {
                        Name = model.BookName,
                        Category = model.Category,
                        ISBN = model.ISBN,
                        Publisher = model.Publisher,
                        IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                        DateAdded = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow
                    }
                }
            };
            repoAuthor.Insert(author);
            return RedirectToAction("Index");
        }

        //Edit Author 
        [HttpGet]
        public IActionResult EditAuthor(long id)
        {
            EditAuthorModel model = new EditAuthorModel();
            Author author = repoAuthor.Get(id);
            if (author != null)
            {
                model.FirstName = author.FirstName;
                model.LastName = author.LastName;
                model.Email = author.Email;
            }
            return PartialView("_EditAuthor", model);
        }

        [HttpPost]
        public IActionResult EditAuthor(long id, EditAuthorModel model)
        {
            Author author = repoAuthor.Get(id);
            if (author != null)
            {
                author.FirstName = model.FirstName;
                author.LastName = model.LastName;
                author.Email = model.Email;
                author.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                author.ModifiedDate = DateTime.UtcNow;
                repoAuthor.Update(author);
            }
            return RedirectToAction("Index");
        }

        //AddBook
        [HttpGet]
        public PartialViewResult AddBook(long id)
        {
            AddBookModel model = new AddBookModel();
            return PartialView("_AddBook", model);
        }
        [HttpPost]
        public IActionResult AddBook(long id, AddBookModel model)
        {
            Book book = new Book
            {
                AuthorId = id,
                Name = model.BookName,
                ISBN = model.Publisher,
                Publisher = model.Publisher,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                DateAdded = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };
            repoBook.Insert(book);
            return RedirectToAction("Index");
        }

    }
}