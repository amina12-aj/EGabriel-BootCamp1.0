
using Blog.Models.AccountModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Blog.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Microsoft.AspNetCore.Identity.IdentityUser>
            _userManager;
        private readonly SignInManager<Microsoft.AspNetCore.Identity.IdentityUser>
            _signInManager;

        public AccountController(
            UserManager<Microsoft.AspNetCore.Identity.IdentityUser> userManager,

            SignInManager<Microsoft.AspNetCore.Identity.IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


            [HttpPost]
            public async Task<IActionResult> Register(RegisterModel model)
            {
                if (ModelState.IsValid)
                {
                    var user = new IdentityUser
                    {
                        Email = model.Email,
                       PasswordHash = model.Password,
                    };

                    var result = await _userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("index", "Home");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

                }
                return View(model);
            }

            [HttpPost]
            [AllowAnonymous]
            public async Task<IActionResult> Login(LoginModel user)
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

                }
                return View(user);
            }

            public async Task<IActionResult> Logout()
            {
                await _signInManager.SignOutAsync();

                return RedirectToAction("Login");
            }

        } 
    } 



   