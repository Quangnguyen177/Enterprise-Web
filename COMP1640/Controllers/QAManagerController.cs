using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace COMP1640.Controllers
{
    public class QAManagerController : Controller
    {
        private readonly ApplicationDbContext context;
        public QAManagerController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Categories.ToList());
        }

        [HttpGet]
        public IActionResult AddCate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCate(Category cate)
        {
            context.Categories.Add(cate);
            context.SaveChanges();
            return RedirectToAction(nameof(CategoryManager));
        }

        public IActionResult DeleteTag(int? id)
        {
            var ideas = context.Ideas.Include(i => i.Category).FirstOrDefault(i => i.CategoryId == id);
            var ideas_tag = context.Ideas.Where(ideas => ideas.CategoryId == id).ToList();
            if (ideas_tag.Count == 0)
            {
                var tag = context.Categories.Find(id);
                context.Categories.Remove(tag);
                context.SaveChanges();
                return RedirectToAction("CategoryManager");
            }
            return RedirectToAction("CategoryManager");

        }

        [HttpGet]
        public IActionResult EditTag(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(context.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult EditTag(Category cate)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Update(cate);
                context.SaveChanges();
                TempData["Message"] = "Edit student successfully !";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cate);
            }
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Idea()
        {
            return View();
        }
        public IActionResult CommentIdea()
        {
            return View();
        }
        public IActionResult CategoryManager()
        {
            return View(context.Categories.ToList());
        }
    }
}
