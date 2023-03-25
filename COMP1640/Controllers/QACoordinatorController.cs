using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
            ViewBag.LogginedUser = context.Profile.Include(d=>d.Department).FirstOrDefault(p => p.Id.Equals(currentUserId));
            var ideas = context.Ideas.Include(e=>e.Event).Include(p=>p.Profile).Include(c=>c.Category).Include(r=>r.Reacpoint).ToList();
            return View(ideas);
        }
        public IActionResult MostViewedIdea()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.Include(d => d.Department).FirstOrDefault(p => p.Id.Equals(currentUserId));
            var ideas = context.Ideas.OrderByDescending(i => i.idea_view).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Include(r => r.Reacpoint).ToList();
            return View("ListIdea", ideas);
        }
        public IActionResult LatestIdea()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.Include(d => d.Department).FirstOrDefault(p => p.Id.Equals(currentUserId));
            var ideas = context.Ideas.OrderByDescending(i => i.created_date).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Include(r => r.Reacpoint).ToList();
            return View("ListIdea", ideas);
        }
        public IActionResult LatestComment()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.Include(d => d.Department).FirstOrDefault(p => p.Id.Equals(currentUserId));
            return View();
        }
    }
}
