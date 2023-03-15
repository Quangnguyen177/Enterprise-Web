using COMP1640.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using System.Security.Claims;

namespace COMP1640.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext Db;
        public HomeController(ApplicationDbContext context)
        {
            Db = context;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = Db.Profile.FirstOrDefault(a => a.Id == userId);
            if (user.Name == null)
            {
                return Redirect("Identity/Account/Manage/Index");
            }
            else
            {
                return RedirectToAction("ViewPage", "Staff", new { pageNum = 1, viewType = "lastest" });
            }
        }

        //[HttpGet]
        //public JsonResult LastestComment(int pageNum)
        //{
        //    int skipPage = 5 * (pageNum - 1);
        //    var ideasList = Db.Comments.OrderByDescending(c => c.created_date);
        //    var page = Db.Ideas.Skip(skipPage).Take(5).ToList();
        //    ViewBag.Page = pageNum;
        //    return Json();
        //}







        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PostIdea()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Comment()
        {
            return View();
        }
        public IActionResult EditIdea()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult DeleteIdea()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
