using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Security.Claims;

namespace COMP1640.Controllers
{
    [Authorize(Roles = "Quality Assurance Coordinator")]
    public class QACoordinatorController : Controller
    {
        private readonly ApplicationDbContext context;
        public QACoordinatorController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult ListIdea()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            var ideas = context.Ideas.Include(e=>e.Event).Include(p=>p.Profile).Include(c=>c.Category).Include(r=>r.Reacpoint).ToList();
            return View(ideas);
        }
        public IActionResult LatestComment()
        {
            return View();
        }
    }
}
