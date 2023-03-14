using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Text;

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
            var file = context.Documents.ToList();
            List<Document> listFiles = new List<Document>();

            //Path For download From Network Path.
            string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

            DirectoryInfo dirInfo = new DirectoryInfo(fileSavePath);

            int i = 0;

            foreach (var item in dirInfo.GetFiles())
            {
                foreach (var f in file)
                {
                    if (f.doc_name == item.Name)
                    {
                        listFiles.Add(new Document()
                        {

                            DocId = i + 1,

                            doc_name = item.Name,

                            doc_path = dirInfo.FullName + @"\" + item.Name

                        });
                        break;
                    }
                }
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
        public IActionResult DownloadCSV()
        {
            var data = context.Ideas.ToList();
            var csv = new StringBuilder();
            string heading = "IdeaId,idea_title,idea_content,created_date,idea_anonymous,idea_view,ProfileId,CategoryId,ReactPointId,EventId";
            csv.AppendLine(heading);
            foreach (var row in data)
            {
                var newRow = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                                row.IdeaId,
                                row.idea_title,
                                row.idea_content,
                                row.created_date,
                                row.idea_anonymous,
                                row.idea_view,
                                row.ProfileId,
                                row.CategoryId,
                                row.ReactPointId,
                                row.EventId
                              );
                csv.AppendLine(newRow);
            }
            byte[] bytes = Encoding.ASCII.GetBytes(csv.ToString());
            return File(bytes, "text/csv", "Ideas.csv");
        }
    }
}
