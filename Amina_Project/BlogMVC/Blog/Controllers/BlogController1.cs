using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Authorize]
    public class BlogController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
