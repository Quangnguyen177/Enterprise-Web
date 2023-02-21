﻿using COMP1640.Models;
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
            return View(context.Tags.ToList());
        }

        [HttpGet]
        public IActionResult AddTag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTag(Tag tag)
        {
            context.Tags.Add(tag);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteTag(int? id)
        {
            var ideas = context.Ideas.Include(i => i.Tag).FirstOrDefault(i => i.TagId == id);
            var ideas_tag = context.Ideas.Where(ideas => ideas.TagId == id).ToList();
            if (ideas_tag.Count == 0)
            {
                var tag = context.Tags.Find(id);
                context.Tags.Remove(tag);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult EditTag(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(context.Tags.Find(id));
        }

        [HttpPost]
        public IActionResult EditTag(Tag tag)
        {
            if (ModelState.IsValid)
            {
                context.Tags.Update(tag);
                context.SaveChanges();
                TempData["Message"] = "Edit student successfully !";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(tag);
            }
        }
    }
}
