using Microsoft.AspNetCore.Mvc;
using UserLoginProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using UserLoginProject.Models;

namespace UserLoginProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginDbContext _dbcontext;

        public LoginController(LoginDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                var user = _dbcontext.Users.SingleOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);
                if (user != null)
                {
                    return RedirectToAction("Dashboard");
            
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                }
            }
            return View(model);
        }

        public IActionResult Dashboard()
        {
            return View();  
        }
    }
}
