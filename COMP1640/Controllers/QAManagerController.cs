using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace COMP1640.Controllers
{
    [Authorize(Roles = "Quality Assurance Manager")]
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
                return RedirectToAction(nameof(CategoryManager));
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
        public IActionResult DownloadFile()
        {
            List<Document> listFiles = new List<Document>();

            //Path For download From Network Path.
            string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

            DirectoryInfo dirInfo = new DirectoryInfo(fileSavePath);

            int i = 0;

            foreach (var item in dirInfo.GetFiles())
            {
                listFiles.Add(new Document()
                {

                    DocId = i + 1,

                    doc_name = item.Name,

                    doc_path = dirInfo.FullName + @"\" + item.Name

                });

                i = i + 1;
            }
            var fileColumns = listFiles.ToList();
            using (var memoryStream = new MemoryStream())
            {
                using (var ziparchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    for (int j = 0; j < fileColumns.Count; j++)
                    {
                        ziparchive.CreateEntryFromFile(fileColumns[j].doc_path, fileColumns[j].doc_name);

                    }
                }

                return File(memoryStream.ToArray(), "application/zip", "Documents.zip");
            }
        }
    }
}
