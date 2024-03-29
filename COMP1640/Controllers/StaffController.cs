﻿using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json;
using System.Security.Claims;
using System.IO.Compression;
using Microsoft.AspNetCore.Authorization;
using COMP1640.ViewModels;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Hosting;
using static COMP1640.Controllers.StaffController;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace COMP1640.Controllers
{
    [Authorize(Roles = "Staff")]
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly IConfiguration _configuration;
        private readonly UserManager<Profile> _userManager;
        public StaffController(ApplicationDbContext context, IConfiguration configuration, UserManager<Profile> userManager)
        {
            Db = context;
            _configuration = configuration;
            _userManager = userManager;
        }

        public class PostViewModel
        {
            //public Idea Post { get; set; }
            public int IdeaId { get; set; }
            public string idea_title { get; set; }
            public string idea_content { get; set; }
            [DataType(DataType.Date)]
            public DateTime created_date { get; set; }
            public Boolean idea_anonymous { get; set; }
            public int idea_view { get; set; }
            public string ProfileId { get; set; }
            public Profile Profile { get; set; }
            public int CategoryId { get; set; }
            public Category Category { get; set; }
            public int ReactPointId { get; set; }
            public ReactPoint Reacpoint { get; set; }
            public int EventId { get; set; }
            public Event Event { get; set; }
            public ICollection<Comment> Comments { get; set; }
            public ICollection<Document> Documents { get; set; }
            public bool? IsLikedByCurrentUser { get; set; }
        }

        [Route("/Staff")]
        [Route("/Staff/ViewPage")]
        [HttpGet]
        public IActionResult ViewPage(int pageNum = 1, string orderBy = "latest", string viewType = "idea", int id = 1)
        {
            int skipPage = 5 * (pageNum - 1);
            var temp = new List<Models.Idea>();
            List<Models.Idea> page = GetIdeaByType(viewType, id);
            ViewBag.Total = page.Count();

            if (orderBy.Equals("mostview"))
            {
                temp = page.OrderByDescending(i => i.idea_view).ToList();
            }
            else if (orderBy.Equals("latest"))
            {
                temp = page.OrderByDescending(i => i.created_date).ToList();
            }
            else if (orderBy.Equals("popular"))
            {
                temp = page.OrderByDescending(i => i.Reacpoint.ThumbUp - i.Reacpoint.ThumbDown).ToList();
            }
            //page = temp.Skip(skipPage).Take(5).ToList();
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            ViewBag.Category = Db.Categories.ToList();
            ViewBag.Department = Db.Departments.ToList();
            var Evt = Db.Events.Where(e => e.Status == false).ToList();
            if (Evt != null)
            {
                ViewBag.Event = Evt;
            }
            else { ViewBag.Event = null; }

            ViewBag.Page = new ViewPage(pageNum, orderBy, viewType, id); 
            
            var documents = Db.Documents.Include(d => d.Idea);
            ViewBag.Documents = Db.Documents.ToList();

            var postViewModels = new List<PostViewModel>();

            foreach (var post in temp)
            {
                var r = Db.React.Where(x => x.ProfileId == currentUserId && x.IdeaId == post.IdeaId).SingleOrDefault();
                if (r != null)
                {
                    var postViewModel = new PostViewModel
                    {
                        IdeaId = post.IdeaId,
                        idea_title = post.idea_title,
                        idea_content = post.idea_content,
                        created_date = post.created_date,
                        idea_anonymous = post.idea_anonymous,
                        idea_view = post.idea_view,
                        ProfileId = post.ProfileId,
                        Profile = post.Profile,
                        CategoryId = post.CategoryId,
                        Category = post.Category,
                        ReactPointId = post.ReactPointId,
                        Reacpoint = post.Reacpoint,
                        EventId = post.EventId,
                        //Event = post.Event,
                        Comments = post.Comments,
                        Documents = post.Documents,
                        IsLikedByCurrentUser = r.Reacted
                    };
                    postViewModels.Add(postViewModel);
                }    
                else
                {
                    var postViewModel = new PostViewModel
                    {
                        IdeaId = post.IdeaId,
                        idea_title = post.idea_title,
                        idea_content = post.idea_content,
                        created_date = post.created_date,
                        idea_anonymous = post.idea_anonymous,
                        idea_view = post.idea_view,
                        ProfileId = post.ProfileId,
                        Profile = post.Profile,
                        CategoryId = post.CategoryId,
                        Category = post.Category,
                        ReactPointId = post.ReactPointId,
                        Reacpoint = post.Reacpoint,
                        EventId = post.EventId,
                        //Event = post.Event,
                        Comments = post.Comments,
                        Documents = post.Documents,
                        IsLikedByCurrentUser = null
                    };
                    postViewModels.Add(postViewModel);
                }         
            }

            return View(postViewModels.Skip(skipPage).Take(5).ToList());
        }

        [HttpGet]
        public IActionResult AddIdea()
        {
            var EvtL = Db.Events.ToList().Where(e => e.Status == false).Where(e => e.First_closure_date > DateTime.UtcNow.AddHours(7));
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            ViewBag.Event = EvtL;
            ViewBag.Category = Db.Categories.ToList();
            ViewBag.Department = Db.Departments.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult AddIdea(List<IFormFile> uploadedFiles, string title, string content, int eventId, string categoryName, string isAnonymous, string profileId)
        {
            var evt = Db.Events.FirstOrDefault(e => e.EventId == eventId);

            if (evt.First_closure_date > DateTime.UtcNow.AddHours(7))
            {
                ////Create reactpoint entity to relate to Idea entity
                ReactPoint newReactPoint = new ReactPoint
                {
                    ThumbDown = 0,
                    ThumbUp = 0,
                };
                Db.Add(newReactPoint);
                Db.SaveChanges();
                var reactPoint = Db.ReactPoints.OrderBy(r => r.ReactPointId).Last();
                var profile = Db.Profile.FirstOrDefault(p => p.Id == profileId);
                Category category = Db.Categories.FirstOrDefault(t => t.category_name.Equals(categoryName));
                var subject = profile.Name + " has posted a new idea with title \"" + title + "\"";
                var qacList = _userManager.GetUsersInRoleAsync("Quality Assurance Coordinator").Result;
                foreach(var qac in qacList)
                {
                    SendEmail(qac.Email, subject, content);
                }
                Boolean anonynous = isAnonymous == null ? false : true;
                Idea newIdea = new Idea()
                {
                    idea_title = title,
                    idea_content = content,
                    idea_anonymous = anonynous,
                    created_date = DateTime.UtcNow.AddHours(7),
                    idea_view = 0,
                    ProfileId = profileId,
                    Profile = profile,
                    CategoryId = category.CategoryId,
                    Category = category,
                    ReactPointId = reactPoint.ReactPointId,
                    Reacpoint = reactPoint,
                    EventId = evt.EventId,
                    Event = evt
                };
                Db.Add(newIdea);
                Db.SaveChanges();
                if (uploadedFiles.Count > 0)
                {
                    HandleFile(uploadedFiles, Db.Ideas.OrderBy(i => i.IdeaId).Last().IdeaId, "ADD"); //add file
                }
            }
            return RedirectToAction("ViewPage", "Staff");
        }

        public void HandleFile(List<IFormFile> uploadedFiles, int idIdea, string type)
        {

            foreach (var file in uploadedFiles)
            {

                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

                //create folder if not exist
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);


                string fileNameWithPath = Path.Combine(path, file.FileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    file.CopyTo(stream); //đoạn này add vô root 

                }
                Models.Document doc = new Models.Document() //đoạn này đang addd  dữ liệu vô database goodddd :)))
                {

                    doc_name = file.FileName,
                    doc_path = path,
                    IdeaId = idIdea
                };
                if (type.Equals("ADD"))
                {
                    Db.Add(doc);
                }
                else if (type.Equals("UPDATE"))
                {
                    Db.Update(doc);
                }
                Db.SaveChanges();
            }
        }

        [HttpGet]
        public IActionResult EditIdea(int id)
        {
            Idea currentIdea = Db.Ideas.Include(i => i.Event).FirstOrDefault(i => i.IdeaId == id);
            if (currentIdea.Event.First_closure_date > DateTime.UtcNow.AddHours(7))
            {
                string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
                ViewBag.Department = Db.Departments.ToList();
                ViewBag.Category = Db.Categories.ToList();
                ViewBag.Event = Db.Events.Where(e => e.Status == false).ToList();
                return View(currentIdea);
            }
            else
            {
                return RedirectToAction("DetailIdea", "Staff", new { id });
            }
        }

        [HttpPost]
        public IActionResult EditIdea(int ideaId, List<IFormFile> uploadedFiles, string title, string content, string categoryName, int eventId, string isAnonymous)
        {
            var evt = Db.Events.FirstOrDefault(i => i.EventId == eventId);
            if (evt.First_closure_date > DateTime.UtcNow.AddHours(7))
            {
                bool anonynous = true;
                if (isAnonymous == null) anonynous = false;
                Category category = Db.Categories.FirstOrDefault(t => t.category_name.Equals(categoryName));
                var idea = Db.Ideas.FirstOrDefault(i => i.IdeaId == ideaId);
                idea.idea_title = title;
                idea.idea_content = content;
                idea.idea_anonymous = anonynous;
                idea.created_date = DateTime.UtcNow.AddHours(7);
                idea.CategoryId = category.CategoryId;
                idea.Category = category;
                idea.EventId = evt.EventId;
                idea.Event = evt;
                if (uploadedFiles.Count > 0)
                {
                    HandleFile(uploadedFiles, ideaId, "UPDATE"); //edit file
                }
                Db.Update(idea);
                Db.SaveChanges();
            }
            return RedirectToAction("DetailIdea", "Staff", new { id=ideaId });

        }


        [HttpPost]
        public JsonResult Comment(Comment com)
        {
            //get user to use name and toEmail
            var idea = Db.Ideas.Include(i => i.Profile).FirstOrDefault(i => i.IdeaId == com.IdeaId);
            var evt = Db.Events.FirstOrDefault(e => e.EventId == idea.EventId);
            if (evt.Last_closure_date > DateTime.UtcNow.AddHours(7))
            {
                //default sender is system, so from email is not needed.
                var profile = Db.Profile.FirstOrDefault(u => u.Id == com.ProfileId);
                var name = (com.com_anonymous) ? "An anonymous user" : profile.Name;
                var subject = name + " has commented your \"" + idea.idea_title + "\" idea";
                SendEmail(idea.Profile.Email, subject, com.com_content);
                Comment newComment = new Comment()
                {
                    com_content = com.com_content,
                    ProfileId = com.ProfileId,
                    Profile = profile,
                    created_date = DateTime.UtcNow.AddHours(7),
                    com_anonymous = com.com_anonymous,
                    IdeaId = com.IdeaId,
                    Idea = idea
                };
                Db.Add(newComment);
                Db.SaveChanges();
                var result = new
                {
                    Name = profile.Name,
                    Avatar = profile.Avatar,
                    Anonymous = com.com_anonymous,
                    Content = com.com_content,
                    Time = String.Format("{0:g}", newComment.created_date),
                    ComNumber = Db.Comments.Where(c => c.IdeaId == com.IdeaId).Count()
                };
                var response = JsonConvert.SerializeObject(result);
                return Json(response);
            }
            return Json(null);
        }

        public async Task<IActionResult> DetailIdea(int id)
        {
            ViewBag.Category = Db.Categories.ToList();
            ViewBag.Department = Db.Departments.ToList();
            var user_of_idea = Db.Ideas.Include(u => u.Profile).FirstOrDefault(u => u.IdeaId == id);
            var name_of_user = user_of_idea.Profile.Name;
            ViewBag.Name = name_of_user;

            var comments = Db.Comments.Include(c => c.Idea);
            ViewBag.Comments = Db.Comments.Where(comments => comments.IdeaId == id).Include(c => c.Profile).ToList();

            var documents = Db.Documents.Include(d => d.Idea).FirstOrDefault(d => d.IdeaId == id);
            ViewBag.Documents = Db.Documents.Where(documents => documents.IdeaId == id).ToList();

            var idea = Db.Ideas.Include(c => c.Category).FirstOrDefault(c => c.IdeaId == id);
            idea.idea_view++;
            Db.Ideas.Update(idea);
            Db.SaveChanges();

            //ducmt1
            var reactpoint_of_idea = Db.Ideas.Include(r => r.Reacpoint).FirstOrDefault(u => u.IdeaId == id);
            var number_of_upvote = reactpoint_of_idea.Reacpoint.ThumbUp;
            ViewBag.ThumbUp = number_of_upvote;
            var number_of_downvote = reactpoint_of_idea.Reacpoint.ThumbDown;
            ViewBag.ThumbDown = number_of_downvote;
            ViewBag.Event = Db.Events.Where(e => e.Status == false).ToList();

            //ducmt2
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(userId));
            var user_react = Db.React.Include(p => p.Profile).FirstOrDefault(p => p.ProfileId == userId);
            var idea_react = Db.React.Include(i => i.Idea).FirstOrDefault(i => i.IdeaId == id);
            try
            {
                var the_react = Db.React.Where(a => a.IdeaId == idea_react.IdeaId).Where(b => b.ProfileId == user_react.ProfileId).Single();
                ViewBag.UserReact = the_react.Reacted;
            }
            catch (Exception)
            {
                ViewBag.UserReact = null;
            }

            //ducmt3
            var UE = Db.Ideas.FirstOrDefault(i => i.IdeaId == id);
            var Evt = Db.Events.FirstOrDefault(i => i.EventId == UE.EventId);
            ViewBag.FDate = Evt.First_closure_date;
            ViewBag.LDate = Evt.Last_closure_date;

            return View(idea);
        }

        public IActionResult DeleteIdea(int id)
        {
            Models.Idea idea = Db.Ideas.FirstOrDefault(i => i.IdeaId == id);
            var docs = Db.Documents.Where(i => i.IdeaId == id).ToList();
            var reacts = Db.React.Where(i => i.IdeaId == id).ToList();
            var reactpoint = Db.ReactPoints.FirstOrDefault(i => i.ReactPointId == idea.ReactPointId);
            var coms = Db.Comments.Where(i => i.IdeaId == id).ToList();
            if (docs.Count() > 0)
            {
                Db.RemoveRange(docs);
            }
            if (reacts.Count() > 0)
            {
                Db.RemoveRange(reacts);
            }
            if (coms.Count() > 0)
            {
                Db.RemoveRange(coms);
            }
            Db.Remove(reactpoint);
            Db.Remove(idea);
            Db.SaveChanges();
            return RedirectToAction("ViewPage", "Staff");
        }

        public IActionResult DownloadFile(int id)
        {
            var file = Db.Documents.Find(id);
            var filename = file.doc_name;
            List<Document> listFiles = new List<Document>();

            //Path For download From Network Path.
            string fileSavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files"); ;

            DirectoryInfo dirInfo = new DirectoryInfo(fileSavePath);

            int i = 0;

            foreach (var item in dirInfo.GetFiles())
            {
                if (item.Name == filename)
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

        [HttpPost]
        public JsonResult FilterComment(int id, int order)
        {
            string result = "";
            if (order == 0)
            {
                var data = Db.Comments.Include(c => c.Profile).Where(c => c.IdeaId == id).OrderBy(c => c.created_date).Select(c => new
                {
                    avatar = c.Profile.Avatar,
                    anonymous = c.com_anonymous,
                    content = c.com_content,
                    name = c.Profile.Name,
                    time = String.Format("{0:g}", c.created_date)
                });
                result = JsonConvert.SerializeObject(data);
            }
            else
            {
                var data = Db.Comments.Include(c => c.Profile).Where(c => c.IdeaId == id).OrderByDescending(c => c.created_date).Select(c => new
                {
                    avatar = c.Profile.Avatar,
                    anonymous = c.com_anonymous,
                    content = c.com_content,
                    name = c.Profile.Name,
                    time = String.Format("{0:g}", c.created_date)
                });
                result = JsonConvert.SerializeObject(data);
            }
            return Json(result);
        }

        public IActionResult Profile(string? id, int pageNum = 1, string viewType = "latest")
        {
            ViewBag.Category = Db.Categories.ToList();
            ViewBag.Department = Db.Departments.ToList();
            var Evt = Db.Events.Where(e => e.Status == false).ToList();
            if (Evt != null)
            {
                ViewBag.Event = Evt;
            }
            else { ViewBag.Event = null; }
            if (id == null)
            {
                return NotFound();
            }
            if (pageNum == 1) ViewBag.PageNum = 1;
            else ViewBag.PageNum = pageNum;
            int skipPage = 5 * (pageNum - 1);
            List<Models.Idea> list = null;
            if (viewType.Equals("mostview"))
            {
                list = Db.Ideas.OrderByDescending(i => i.idea_view)
                        .Include(p => p.Profile).Include(c => c.Category)
                        .Include(r => r.Reacpoint)
                        .Include(c => c.Comments).Where(i => i.ProfileId.Equals(id)).ToList();
                ViewBag.ViewType = "mostview";
            }
            else if (viewType.Equals("latest"))
            {
                list = Db.Ideas.OrderByDescending(i => i.created_date)
                        .Include(p => p.Profile).Include(c => c.Category)
                        .Include(r => r.Reacpoint)
                        .Include(c => c.Comments).Where(i => i.ProfileId.Equals(id)).ToList();
                ViewBag.ViewType = "latest";
            }
            else if (viewType.Equals("popular"))
            {
                list = Db.Ideas.Include(i => i.Reacpoint).OrderByDescending(i => i.Reacpoint.ThumbUp + i.Reacpoint.ThumbDown).Include(e => e.Event).Include(p => p.Profile).Include(c => c.Category).Include(c => c.Comments).Where(i => i.ProfileId.Equals(id)).ToList();
                ViewBag.ViewType = "popular";
            }
            ViewBag.Numberofidea = Db.Ideas.Include(c => c.Comments).Include(p => p.Profile).Include(i => i.Category).Where(ideas => ideas.ProfileId.Equals(id)).ToList();
            ViewBag.Ideas = list;

            ViewBag.Total = ViewBag.Numberofidea.Count;

            var documents = Db.Documents.Include(d => d.Idea);
            ViewBag.Documents = Db.Documents.ToList();

            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));

            ViewBag.Pro = Db.Profile.Include(d => d.Department).FirstOrDefault(p => p.Id.Equals(id));

            var postViewModels = new List<PostViewModel>();
            foreach (var post in list)
            {
                var r = Db.React.Where(x => x.ProfileId == currentUserId && x.IdeaId == post.IdeaId).SingleOrDefault();
                if (r != null)
                {
                    var postViewModel = new PostViewModel
                    {
                        IdeaId = post.IdeaId,
                        idea_title = post.idea_title,
                        idea_content = post.idea_content,
                        created_date = post.created_date,
                        idea_anonymous = post.idea_anonymous,
                        idea_view = post.idea_view,
                        ProfileId = post.ProfileId,
                        Profile = post.Profile,
                        CategoryId = post.CategoryId,
                        Category = post.Category,
                        ReactPointId = post.ReactPointId,
                        Reacpoint = post.Reacpoint,
                        EventId = post.EventId,
                        //Event = post.Event,
                        Comments = post.Comments,
                        Documents = post.Documents,
                        IsLikedByCurrentUser = r.Reacted
                    };
                    postViewModels.Add(postViewModel);
                }
                else
                {
                    var postViewModel = new PostViewModel
                    {
                        IdeaId = post.IdeaId,
                        idea_title = post.idea_title,
                        idea_content = post.idea_content,
                        created_date = post.created_date,
                        idea_anonymous = post.idea_anonymous,
                        idea_view = post.idea_view,
                        ProfileId = post.ProfileId,
                        Profile = post.Profile,
                        CategoryId = post.CategoryId,
                        Category = post.Category,
                        ReactPointId = post.ReactPointId,
                        Reacpoint = post.Reacpoint,
                        EventId = post.EventId,
                        //Event = post.Event,
                        Comments = post.Comments,
                        Documents = post.Documents,
                        IsLikedByCurrentUser = null
                    };
                    postViewModels.Add(postViewModel);
                }
            }
            return View(postViewModels.Skip(skipPage).Take(5).ToList());
        }

        public IActionResult TermsConditions()
        {

            return View();
        }

        public JsonResult SearchIdea(string searchString)
        {
            var results = Db.Ideas.Where(i => i.idea_title.Contains(searchString)).OrderBy(i => i.created_date).Include(i => i.Event).Include(i => i.Reacpoint).Include(i => i.Category).Include(i => i.Profile).Include(i => i.Comments).ToList();
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var uAvatar = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId)).Avatar;
            var data = new List<SearchResult>();
            foreach (var result in results)
            {
                data.Add(new SearchResult
                {
                    IdeaId = result.IdeaId,
                    IdeaTile = result.idea_title,
                    IdeaContent = result.idea_content,
                    View = result.idea_view,
                    Point = result.Reacpoint.ThumbUp - result.Reacpoint.ThumbUp,
                    CreatedDate = String.Format("{0:g}", result.created_date),
                    OwnerName = result.Profile.Name,
                    OwnerId = result.Profile.Id,
                    Category = result.Category.category_name,
                    Anonymous = result.idea_anonymous,
                    Avatar = result.Profile.Avatar,
                    CommentCount = result.Comments.Count(),
                    UAvatar = uAvatar,
                    CateId = result.CategoryId
                });
            }
            var res = JsonConvert.SerializeObject(data);
            return Json(res);
        }

        public List<Models.Idea> GetIdeaByType(string type, int id)
        {
            List<Models.Idea> output = new List<Models.Idea>();
            switch (type)
            {
                case "idea":
                    output = Db.Ideas.Include(i => i.Comments).Include(i => i.Reacpoint)
                                        .Include(i => i.Category).Include(i => i.Profile).ToList();
                    break;
                case "dep":
                    output = Db.Ideas.Include(i => i.Comments).Include(i => i.Reacpoint)
                                        .Include(i => i.Category).Include(i => i.Profile).ThenInclude(d => d.Department).Where(i => i.Profile.Department.DepId == id).ToList();
                    break;
                case "cat":
                    output = Db.Ideas.Include(i => i.Comments).Include(i => i.Reacpoint)
                                        .Include(i => i.Category).Include(i => i.Profile).Where(i => i.Category.CategoryId == id).ToList();
                    break;
                case "evt":
                    output = Db.Ideas.Where(i => i.EventId == id).Include(i => i.Comments)
                                        .Include(i => i.Reacpoint).Include(i => i.Category).Include(i => i.Profile).ToList();
                    break;
            }
            return output;
        }

        public void SendEmail(string toEmail, string subject, string content)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Notification System", "truongtd2002tq@gmail.com"));
                message.To.Add(MailboxAddress.Parse(toEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain")
                {
                    Text = "content: " + content,
                };
                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(_configuration["Email:Username"], _configuration["Email:Password"]);
                client.Send(message);
                client.Disconnect(true);
                client.Dispose();
            }
            catch (Exception ex)
            {

            }
        }

        [HttpPost]
        public async Task<JsonResult> ReactPoint([FromBody] ReactPoint obj)
        {
            Db.ReactPoints.Update(obj);
            await Db.SaveChangesAsync();
            ReactPoint data = Db.ReactPoints.FirstOrDefault(o => o.ReactPointId == obj.ReactPointId);
            string result = JsonConvert.SerializeObject(data);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> React([FromBody] React save)
        {
            var check = Db.React.Where(r => r.ProfileId == save.ProfileId && r.IdeaId == save.IdeaId).SingleOrDefault();

            if (check != null)
            {
                check.Reacted = save.Reacted;
                Db.React.Update(check);
                await Db.SaveChangesAsync();
            }
            else if (check == null)
            {
                Db.React.Add(save);
                await Db.SaveChangesAsync();
            }
            string result = JsonConvert.SerializeObject(save);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> DeleteReact([FromBody] React save)
        {
            var the_idea = Db.React.Include(i => i.Idea).FirstOrDefault(i => i.IdeaId == save.IdeaId);
            var the_profile = Db.React.Include(p => p.Profile).FirstOrDefault(p => p.ProfileId == save.ProfileId);
            var the_result = Db.React.Where(a => a.IdeaId == the_idea.IdeaId).Where(b => b.ProfileId == the_profile.ProfileId).Single();

            if (the_result != null)
            {
                Db.React.Remove(the_result);
                await Db.SaveChangesAsync();
            }
            string result = JsonConvert.SerializeObject(save);
            return Json(result);
        }
    }
}