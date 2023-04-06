using COMP1640.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace COMP1640.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly UserManager<Profile> _userManager;
        public HomeController(ApplicationDbContext context,
                              UserManager<Profile> userManager)
        {
            Db = context;
            _userManager = userManager;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = Db.Profile.FirstOrDefault(a => a.Id == userId);
            var userRole = await _userManager.GetRolesAsync(user);
            var ur = userRole.Last();
            if (user.Name == null)
            {
                return Redirect("Identity/Account/Manage/Index");
            }
            else if (ur == "Staff")
            {
                return RedirectToAction("ViewPage", "Staff");
            }
            else if (ur == "Quality Assurance Manager")
            {
                return RedirectToAction("Dashboard", "QAManager");
            }
            else if (ur == "Quality Assurance Coordinator")
            {
                return RedirectToAction("ListIdea", "QACoordinator");
            }
            else if (ur == "Administrator")
            {
                return RedirectToAction("Home", "Admin");
            }
            else 
            {
                return View();    
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
