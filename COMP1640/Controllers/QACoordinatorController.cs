using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
            return View();
        }
        public IActionResult LatestComment()
        {
            return View();
        }
    }
}
