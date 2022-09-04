using BookManagement.Domain;
using BookManagement.Repository;
using BookManagement.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookManagement.UI.Controllers
{
    public class BookController : Controller
    {
        private readonly IRepository<Author> authorRepository;
        private readonly IRepository<Book> bookRepository;

        public BookController(IRepository<Author> authorRepository, IRepository<Book> bookRepository)
        {
            this.authorRepository = authorRepository;
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<BookListingViewModel> model = new();
            bookRepository.GetAll().ToList().ForEach(b =>
            {
                BookListingViewModel book = new()
                {
                    Id = b.Id,
                    BookName = b.Name,
                    Publisher = b.Publisher,
                    ISBN = b.ISBN
                };
                var author = authorRepository.Get(b.AuthorId).Result;
                book.AuthorName = $"{author.FirstName} {author.LastName}";
                model.Add(book);
            });
            return View("Index", model);
        }

        [HttpGet]
        public async Task<IActionResult> EditBook(int id)
        {
            EditBookViewModel model = new()
            {
                Authors = authorRepository.GetAll().Select(a => new SelectListItem
                {
                    Text = $"{a.FirstName} {a.LastName}",
                    Value = a.Id.ToString()
                }).ToList()
            };
            
            var book = await bookRepository.Get(id);

            if (book is not null)
            {
                model.BookName = book.Name;
                model.ISBN = book.ISBN;
                model.Publisher = book.Publisher;
                model.AuthorId = book.AuthorId;
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditBook(int id, EditBookViewModel model)
        {
            var book = bookRepository.Get(id).Result;

            if (book is not null)
            {
                book.Name = model.BookName;
                book.ISBN = model.ISBN;
                book.Publisher = model.Publisher;
                book.AuthorId = model.AuthorId;
                book.DateModified = DateTime.UtcNow;
                book.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();

                await bookRepository.Update(book);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await bookRepository.Get(id);
            return View("RemoveBook", book ? .Name);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBookAsync(int id, IFormCollection form)
        {
            var book = await bookRepository.Get(id);
            if (book is not null) 
                await bookRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}