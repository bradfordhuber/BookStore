using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mission_7.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_7.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> SignInManager;

        public AccountController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            userManager = um;
            SignInManager = sim;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginmodel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginmodel.Username);

                if (user != null)
                {
                    await SignInManager.SignOutAsync();

                    if ((await SignInManager.PasswordSignInAsync(user, loginmodel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginmodel?.ReturnUrl ?? "/admin");
                    }
                }
            }
           
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginmodel);

        }

        public async Task<RedirectResult> Logout (string returnUrl = "/")
        {
            await SignInManager.SignOutAsync();

            return Redirect(returnUrl);
        }
    }
}
