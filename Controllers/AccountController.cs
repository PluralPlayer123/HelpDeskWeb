using HelpDeskWeb.Controllers;
using HelpDeskWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace HelpDeskWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

    }
 }
