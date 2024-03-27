using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TransactionRecordApp.Models;

namespace TransactionRecordApp.Controllers
{
    public class AccountController : Controller
    {
        //private variables for signing manager and user manager
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        //constructor to set up the private sign in and user managers
        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
