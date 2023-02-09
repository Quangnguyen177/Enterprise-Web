using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace COMP1640.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext Db;
        public StaffController(ApplicationDbContext context)
        {
            Db = context;
        }

        [HttpGet]
        public IActionResult AddIdea()
        {
            
            return View(Db.Tags.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddIdea(string title, string content, string tagName, string isAnonymous)
        {
            Tag tag = Db.Tags.FirstOrDefault(t => t.tag_name == tagName);
            Boolean anonynous = true;
            if (isAnonymous == null) anonynous=false;
            Idea newIdea = new Idea()
            {
                idea_title = title,
                idea_content = content,
                idea_anonymous = anonynous,
                StaffId = 1,
                TagId = tag.TagId,
                created_date = DateTime.Now,
            };
            Db.Add(newIdea);
            await Db.SaveChangesAsync();
            return View(Db.Tags.ToList());
        }
        
    }
}
