using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using COMP1640.ChartModels;
using Newtonsoft.Json;
using System;
using COMP1640.ViewModels;
using System.Security.Claims;

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
        [HttpGet]
        public IActionResult AddCate()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
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
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
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
            List<TopContributor> list = new List<TopContributor>();
            var ideas = context.Ideas.Where(i=>i.created_date.Value.Month == GetCurrentVnTime().Month).Include(i => i.Profile.Department).ToList();
            var groupById = ideas.GroupBy(i => i.Profile);
            foreach (var group in groupById)
            {
                list.Add(new TopContributor(group.Key, group.Count()));
            }
            list = list.OrderByDescending(i => i.PostedIdea).Take(5).ToList();
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            var totalIdea = context.Ideas.Where(i => i.created_date.Value.Month == GetCurrentVnTime().Month).Count();
            var totalComment = context.Comments.Where(i => i.created_date.Value.Month == GetCurrentVnTime().Month).Count();
            var totalContributor = context.Ideas.Where(i => i.created_date.Value.Month == GetCurrentVnTime().Month).GroupBy(i => i.ProfileId).Count();
            var totalView = context.Ideas.Where(i => i.created_date.Value.Month == GetCurrentVnTime().Month).Sum(i => i.idea_view);
            ViewBag.Statistic = new Statistic(totalIdea, totalContributor, totalView, totalComment);
            
            return View(list);
        }
        public IActionResult Idea(int pageNum, string viewType)
        {
            if (pageNum == 1) ViewBag.PageNum = 1;
            else ViewBag.PageNum = pageNum;
            int skipPage = 5* (pageNum - 1);
            List<Idea> list = null;
            if (viewType.Equals("mostview"))
            {
                list = context.Ideas.OrderByDescending(i=>i.idea_view).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Include(r => r.Reacpoint).Skip(skipPage).Take(5).ToList();
                ViewBag.ViewType = "mostview";
            }else if (viewType.Equals("lastest"))
            {
                list = context.Ideas.OrderByDescending(i=>i.created_date).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Include(r => r.Reacpoint).Skip(skipPage).Take(5).ToList();
                ViewBag.ViewType = "lastest";
            }else if (viewType.Equals("popular"))
            {
                list = context.Ideas.Include(i=>i.Reacpoint).OrderByDescending(i=>i.Reacpoint.ThumbUp + i.Reacpoint.ThumbDown).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Skip(skipPage).Take(5).ToList();
                ViewBag.ViewType = "popular";
            }
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            ViewBag.Total = context.Ideas.Count();
            return View(list);
        }
        public IActionResult CommentIdea()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            return View();
        }
        public IActionResult CategoryManager()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = context.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
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
            var data = context.Ideas.Include(i => i.Profile).Include(i=>i.Category).Include(i => i.Reacpoint).Include(i => i.Event).ToList();
            var csv = new StringBuilder();
            string heading = "IdeaId,Title,Content,Created Date,Anonymous,Total View,Owner Name,Category,Point,Event";
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
                                row.idea_anonymous ? "Anonymous" : row.Profile.Name,
                                row.Category.category_name,
                                row.Reacpoint.ThumbUp- row.Reacpoint.ThumbDown,
                                row.Event.EventName
                              );
                csv.AppendLine(newRow);
            }
            byte[] bytes = Encoding.ASCII.GetBytes(csv.ToString());
            return File(bytes, "text/csv", "Ideas.csv");
        }

        public JsonResult GetPieChartData()
        {
            var pieChartData = new List<PieChart>();
            var departmentNames = context.Departments.Select(d => d.Dep_name).ToList();
            var total = context.Profile.Count();
            foreach (var name in departmentNames)
            {

                //i.created_date.Value.Month == DateTime.UtcNow.Month &&
                var ideas = context.Ideas.Include(i => i.Profile.Department).Where(i => i.Profile.Department.Dep_name.Equals(name)).ToList();
                int contributors = ideas.GroupBy(i => i.Profile.Id).Count();
                double percent = (double)contributors * 100 / total;
                pieChartData.Add(new PieChart(name, Math.Round(percent, 2)));

            }
            var result = JsonConvert.SerializeObject(pieChartData);
            return Json(result);
        }

        public JsonResult GetLineChartData()
        {
            List<LineChart> res = new List<LineChart>();
            var ideas = context.Ideas.Include(i => i.Profile.Department).ToList();
            var departments = context.Departments.Select(d => d.Dep_name).ToList();
            int[] totalIdeas = new int[12];
            foreach (var department in departments)
            {
                for (int i = 0; i < 12; i++)
                {
                    totalIdeas[i] = ideas.Where(idea => idea.Profile.Department.Dep_name.Equals(department) && idea.created_date.Value.Month == i + 1).Count();
                }
                LineChart data = new LineChart()
                {
                    Department = department,
                    Total = totalIdeas.ToList(),
                };
                res.Add(data);
            }
            var result = JsonConvert.SerializeObject(res);
            return Json(result);
        }

        public JsonResult GetBarChartData()
        {
            var data = new List<BarChart>();
            var categories = context.Categories.ToList();
            foreach (var cate in categories)
            {
                var total = context.Ideas.Where(i => i.CategoryId == cate.CategoryId).Count();
                data.Add(new BarChart(cate.category_name, total));
            }
            data = data.OrderByDescending(d => d.NumOfUses).Take(5).ToList();
            var result = JsonConvert.SerializeObject(data);
            return Json(result);
        }

        public JsonResult GetMixedChartData()
        {
            List<MixedChart> data = new List<MixedChart>();
            //lay du lieu nhung idea trong vong 7 ngay ke tu idea gan nhat.
            var lastestDate = context.Ideas.OrderByDescending(i => i.created_date).First().created_date;
            var bound = lastestDate.Value.Date.AddDays(-6);
            var ideas = context.Ideas.Include(i => i.Reacpoint).OrderByDescending(i => i.created_date).Where(i => i.created_date >= bound).ToList();
            while (bound <= lastestDate)
            {
                var selectedIdeas = ideas.Where(i => i.created_date.Value.Day == bound.Day).ToList();
                var view = selectedIdeas.Sum(i => i.idea_view);
                var point = selectedIdeas.Sum(i => i.Reacpoint.ThumbUp + i.Reacpoint.ThumbDown);
                data.Add(new MixedChart(point, view, bound.ToString("MM/dd")));
                bound = bound.AddDays(1);
            }
            var result = JsonConvert.SerializeObject(data);
            return Json(result);
        }

        public DateTime GetCurrentVnTime()
        {
            return DateTime.UtcNow.AddHours(7);
        }
    }
}
