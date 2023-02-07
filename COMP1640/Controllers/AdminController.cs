using Microsoft.AspNetCore.Mvc;

namespace COMP1640.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult dashboard()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
