using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles= "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
