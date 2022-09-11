using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class RoleController : Controller

    {
        RoleManager<IdentityRole> _roleManager;
            public RoleController (RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var role = _roleManager.Roles.Tolist();
            return View(role);
        }
    }
}
