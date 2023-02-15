using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
                ProfileId = 1,
                TagId = tag.TagId,
                created_date = DateTime.Now,
                Ipoint = 0
            };
            Db.Add(newIdea);
            await Db.SaveChangesAsync();
            return View(Db.Tags.ToList());
        }
        [HttpGet]
        public IActionResult EditIdea(int ideaId)
        {
            Idea currentIdea = Db.Ideas.Find(ideaId);
            //if (currentIdea.first_closure != null)
            //    if (!CheckFirtClosureDate(currentIdea)){
            //        ViewBag.Error = "You can not edit your idea when firt colosure date is due";
            //        return null;
            return View(currentIdea);
        }
        [HttpPut]
        public async Task<IActionResult> EditIdea(int ideaId, string title, string content, string tagName, string isAnonymous)
        {    
            bool anonynous = true;
            if (isAnonymous == null) anonynous = false;
            Tag tag = Db.Tags.FirstOrDefault(t => t.tag_name == tagName);
            Idea editedIdea = new Idea()
            {
                IdeaId = ideaId,
                idea_title = title,
                idea_content = content,
                idea_anonymous = anonynous,
                ProfileId = 1, //because session is not initialized, the defaut Staff is 1 
                created_date = DateTime.Now,
                TagId = tag.TagId, 
            };
            Db.Update(editedIdea);
            await Db.SaveChangesAsync();
            return RedirectToAction("EditIdea");
        }


        //comment
        public IActionResult Comment()
        {
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> Comment(string content, string isAnonymous, int ideaId)
        {
            bool anonynous = true;
            if (isAnonymous == null) anonynous = false;
            Comment newComment = new Comment()
            {
                com_content = content,
                ProfileId = 1,
                com_anonymous = anonynous,
                IdeaId = ideaId,
            };
            Db.Add(newComment);
            await Db.SaveChangesAsync();
            return View();
        }

        //check if current time is early than 1st closure date 
        public bool CheckFirtClosureDate(Idea idea)
        {
            DateTime firtClosureDate = DateTime.Parse(idea.first_closure.ToString()); //not accept nullable datetime type
            if (DateTime.Compare(DateTime.Now, firtClosureDate) < 0) return true;
            else return false;
        }

        //public bool CheckFinalClosureDate(int ideaId)
        //{
        //    Idea idea = Db.Ideas.Find(ideaId);
        //    DateTime finalClosureDate = DateTime.Parse(idea.first_closure.ToString()); //not accept nullable datetime type
        //    if (DateTime.Compare(DateTime.Now, finalClosureDate) < 0) return true;
        //    else return false;
        //}
    }
}
