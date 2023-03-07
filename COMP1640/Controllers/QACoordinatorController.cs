using Microsoft.AspNetCore.Mvc;

namespace COMP1640.Controllers
{
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
