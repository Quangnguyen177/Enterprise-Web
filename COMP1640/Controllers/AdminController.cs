using Microsoft.AspNetCore.Mvc;
using COMP1640.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Dynamic;

namespace COMP1640.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            _roleManager = roleManager;
        }

        public IActionResult Dashboard()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult InformationStaff()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(Account acc)
        {
            if (ModelState.IsValid)
            {
                context.Accounts.Add(acc);
                context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                //ViewBag.<Somethings> = context.<Somethings>.ToList();
                return View(acc);
            }
        }

        public IActionResult SetClosureDate()
        {
            return View();
        }

        public IActionResult EditClosureDate()
        {
            return View();
        }


    }
}
