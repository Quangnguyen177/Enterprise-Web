using COMP1640.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.IO;
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

        [Route("/QACoordinator")]
        [Route("/QACoordinator/ListIdea")]
        public IActionResult ListIdea(int pageNum = 1, string viewType = "latest")
        {
            var documents = context.Documents.Include(d => d.Idea);
            ViewBag.Documents = context.Documents.ToList();
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.Include(d=>d.Department).FirstOrDefault(p => p.Id.Equals(currentUserId));
            if (pageNum == 1) ViewBag.PageNum = 1;
            else ViewBag.PageNum = pageNum;
            int skipPage = 25 * (pageNum - 1);
            List<Idea> list = null;
            if (viewType.Equals("mostview"))
            {
                list = context.Ideas.OrderByDescending(i => i.idea_view).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Include(r => r.Reacpoint).Skip(skipPage).Take(25).ToList();
                ViewBag.ViewType = "mostview";
            }
            else if (viewType.Equals("latest"))
            {
                list = context.Ideas.OrderByDescending(i => i.created_date).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Include(r => r.Reacpoint).Skip(skipPage).Take(25).ToList();
                ViewBag.ViewType = "latest";
            }
            else if (viewType.Equals("popular"))
            {
                list = context.Ideas.Include(i => i.Reacpoint).OrderByDescending(i => i.Reacpoint.ThumbUp + i.Reacpoint.ThumbDown).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Skip(skipPage).Take(25).ToList();
                ViewBag.ViewType = "popular";
            }
            ViewBag.Total = context.Ideas.Count();
            /*var ideas = context.Ideas.Include(e=>e.Event).Include(p=>p.Profile).Include(c=>c.Category).Include(r=>r.Reacpoint).ToList();*/
            return View(list);
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
            ViewBag.Comments = context.Comments.OrderByDescending(d=>d.created_date).Include(i=>i.Idea).Include(p=>p.Profile).ToList();
            return View();
        }
        public IActionResult DownloadEachFile(int id)
        {
            var file = context.Documents.Where(d => d.IdeaId == id).ToList();
            /*            var filename = file.doc_name;*/
            List<Document> listFiles = new List<Document>();

            //Path For download From Network Path.
            string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files"); ;

            DirectoryInfo dirInfo = new DirectoryInfo(fileSavePath);

            int i = 0;
            foreach (var f in file)
            {
                foreach (var item in dirInfo.GetFiles())
                {
                    if (item.Name == f.doc_name)
                    {
                        listFiles.Add(new Document()
                        {

                            DocId = i + 1,

                            doc_name = item.Name,

                            doc_path = dirInfo.FullName + @"\" + item.Name

                        });
                    }


                    i = i + 1;
                }
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
