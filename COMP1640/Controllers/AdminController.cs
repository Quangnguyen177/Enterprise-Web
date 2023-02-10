using Microsoft.AspNetCore.Mvc;
using COMP1640.Models;

namespace COMP1640.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/Admin/")]
        public IActionResult Dashboard()
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
    }
}
