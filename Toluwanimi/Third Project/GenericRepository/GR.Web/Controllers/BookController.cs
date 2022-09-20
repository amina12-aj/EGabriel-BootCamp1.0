using GR.Data.Entities;
using GR.Data.Repository;
using GR.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GR.Web.Controllers
{
    public class BookController : Controller
    {
        private IRepository <Author> repoAuthor;
        private IRepository <Book> repoBook;
        public BookController(IRepository <Author> repoAuthor, IRepository <Book> repoBook )
        {
            this.repoAuthor = repoAuthor;
            this.repoBook = repoBook;
        }

        //Index 
        public IActionResult Index()
        {
            List<BookListingModel> model = new List<BookListingModel>();
            repoBook.GetAll().ToList().ForEach(b =>
            {
                BookListingModel book = new BookListingModel
                {
                    Id = b.Id,
                    BookName = b.Name,
                    Category = b.Category,
                    Publisher = b.Publisher,
                    ISBN = b.ISBN
                };
                Author author = repoAuthor.Get(b.AuthorId);
                book.AuthorName = $" {author.FirstName} {author.LastName}";
                model.Add(book);
            });
            return View("Index", model);  
        }

        //EditBook Action
        [HttpGet]
        public PartialViewResult EditBook (long id)
        {
            EditBookModel model = new EditBookModel();
            model.Authors = repoAuthor.GetAll().Select(a => new SelectListItem
            {
                Text = $"{a.FirstName}{a.LastName}",
                Value = a.Id.ToString()
            }).ToList();
            Book book = repoBook.Get(id);
            if (book != null)
            {
                model.BookName = book.Name;
                model.Category = book.Category;
                model.ISBN = book.ISBN;
                model.Publisher = book.Publisher;
                model.AuthorId = book.AuthorId;
            }
            return PartialView("_EditBook", model);
        }
        [HttpPost]
        public ActionResult EditBook(long id , EditBookModel model)
        {
            Book book = repoBook.Get(id);
            if (book != null)
            {
                book.Name = model.BookName;
                book.Category = model.Category;
                book.ISBN = model.ISBN;
                book.Publisher = model.Publisher;
                book.AuthorId = model.AuthorId;
                book.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                book.ModifiedDate = DateTime.UtcNow;
                repoBook.Update(book);
            }
            return RedirectToAction("Index");
        }
        
        //Delete Book
        [HttpGet]
        public PartialViewResult DeleteBook (long id)
        {
            Book book = repoBook.Get(id);
            return PartialView ("_DeleteBook", book? .Name);
        }
        [HttpPost]
        public ActionResult DeleteBook(long id , IFormCollection form)
        {
            Book book = repoBook.Get(id);
            if (book != null)
            {
                repoBook.Delete(book);
            }
            return RedirectToAction("Index");
        }   
    }
}