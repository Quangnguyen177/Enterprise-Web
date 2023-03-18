using COMP1640.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.Internal.AsyncLock;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using System.IO.Compression;
using Microsoft.AspNetCore.Authorization;

namespace COMP1640.Controllers
{
    [Authorize]
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext Db;
        public StaffController(ApplicationDbContext context)
        {
            Db = context;
        }

        [HttpGet]
        public IActionResult ViewPage(int pageNum, string viewType)
        {
            if (pageNum == 1) ViewBag.PageNum = 1;
            else ViewBag.PageNum = pageNum;
            int skipPage = 5 * (pageNum - 1);
            List<Idea> page = null;
            if (viewType.Equals("mostview"))
            {
                page = Db.Ideas.Include(i => i.Comments).OrderByDescending(i => i.idea_view).Skip(skipPage).Take(5).Include(i => i.Profile).ToList();
                ViewBag.ViewType = "mostview";
            }
            else if (viewType.Equals("lastest"))
            {
                page = Db.Ideas.Include(i => i.Comments).OrderByDescending(i => i.created_date).Skip(skipPage).Take(5).Include(i => i.Profile).ToList();
                ViewBag.ViewType = "lastest";
            }
            else if (viewType.Equals("popular"))
            {
                page = Db.Ideas.Include(i => i.Reacpoint).OrderByDescending(i => i.Reacpoint.ThumbDown + i.Reacpoint.ThumbUp).Include(i => i.Comments).Skip(skipPage).Take(5).Include(i => i.Profile).ToList();
                ViewBag.ViewType = "lastest";
            }
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));   
            ViewBag.Category = Db.Categories.ToList();
            ViewBag.Total = Db.Ideas.Count();
            return View(page);
        }
        
        [HttpGet]
        public IActionResult AddIdea()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            return View(Db.Categories.ToList());
        }

        [HttpPost]
        public IActionResult AddIdea(List<IFormFile> uploadedFiles,string title, string content, string categoryName, string isAnonymous, string profileId)
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
            Category category = Db.Categories.FirstOrDefault(t => t.category_name.Equals(categoryName));
            Boolean anonynous = true;
            if (isAnonymous == null) anonynous = false;
            Idea newIdea = new Idea()
            {
                idea_title = title,
                idea_content = content,
                idea_anonymous = anonynous,
                created_date = DateTime.Now,
                idea_view = 0,
                ProfileId = profileId,
                Profile = Db.Profile.FirstOrDefault(p => p.Id == profileId),
                CategoryId = category.CategoryId,
                Category = category,
                ReactPointId = reactPoint.ReactPointId,
                Reacpoint = reactPoint,

            };
            Db.Add(newIdea);
            Db.SaveChanges();
            if (uploadedFiles.Count > 0)
            {
                HandleFile(uploadedFiles, Db.Ideas.OrderBy(i => i.IdeaId).Last().IdeaId,"ADD"); //add file
            }
            return RedirectToAction("ViewPage", "Staff", new { pageNum = 1, viewType = "lastest" });

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
                } else if (type.Equals("UPDATE"))
                {
                    Db.Update(doc);
                }              
                Db.SaveChanges();
            }
        }

        [HttpGet]
        public IActionResult EditIdea(int id)
        {
            var a = id;
            Idea currentIdea = Db.Ideas.FirstOrDefault(i => i.IdeaId == id);
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.LogginedUser = Db.Profile.FirstOrDefault(p => p.Id.Equals(currentUserId));
            ViewBag.Category = Db.Categories.ToList();
            //if (currentIdea.first_closure != null)
            //    if (!CheckFirtClosureDate(currentIdea)){
            //        ViewBag.Error = "You can not edit your idea when firt colosure date is due";
            //        return null;
            return View(currentIdea);
        }
        
       [HttpPost]
        public IActionResult EditIdea(int ideaId, List<IFormFile> uploadedFiles, string title, string content, string categoryName, string isAnonymous)
        {
            bool anonynous = true;
            if (isAnonymous == null) anonynous = false;
            Category category = Db.Categories.FirstOrDefault(t => t.category_name.Equals(categoryName));
            var idea = Db.Ideas.FirstOrDefault(i => i.IdeaId == ideaId);
            idea.idea_title = title;
            idea.idea_content = content;
            idea.idea_anonymous = anonynous;
            idea.created_date = DateTime.Now;
            idea.CategoryId = category.CategoryId;
            idea.Category = category;
            if (uploadedFiles.Count > 0)
            {
                HandleFile(uploadedFiles, ideaId, "UPDATE"); //edit file
            }
            Db.Update(idea);
            Db.SaveChanges();
            return RedirectToAction("EditIdea", new {id=ideaId});
        }


        //comment
        [HttpPost]
        public JsonResult Comment(Comment com)
        {
            //get user to use name and toEmail
            var profile = Db.Profile.FirstOrDefault(u =>  u.Id == com.ProfileId);
            var idea = Db.Ideas.Include(i => i.Profile).FirstOrDefault(i => i.IdeaId == com.IdeaId);
            //default sender is system, so from email is not needed.
            //var sendMail = SendEmail("dantruong2002tq@gmail.com", "Dan Truong", com.com_content);
            //var sendMail = SendEmail(idea.Profile.Email, idea.Profile.Name, com.com_content);
            if (true) // check if sending mail is successfull!
            {
                //add comment 
                Comment newComment = new Comment()
                {
                    com_content = com.com_content,
                    ProfileId = com.ProfileId,
                    Profile = profile,
                    created_date = DateTime.Now,
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
            else
            {
                return Json(null);
            }

        }

        public bool SendEmail(string toEmail, string name, string content)
        {
            try
            {
                // Create a new MailMessage object
                MailMessage message = new MailMessage();

                // Set the sender's email address
                message.From = new MailAddress("truongtd2002tq@gmail.com");

                // Add a recipient email address
                message.To.Add("dantruong2002tq@gmail.com");

                // Set the subject and body of the email
                message.Subject = name + " comments your idea";
                message.Body = content;

                // Create a new SmtpClient object
                SmtpClient client = new SmtpClient();

                // Set the SMTP server and port number
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                // Set the credentials used to authenticate with the SMTP server (if required)
                client.Credentials = new System.Net.NetworkCredential("truongtd2002tq@gmail.com", "uqjavdcqqzxrsjmo");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                // Enable SSL if required
                client.EnableSsl = true;
                client.Timeout = 200000;
                // Send the email
                client.Send(message);
                return true;
            }
            catch
            {
                return false;
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
            var check = Db.React.FirstOrDefault(r => r.ProfileId == save.ProfileId);

            if ( check != null )
            {                
                check.Reacted = save.Reacted;
                Db.React.Update(check);
                await Db.SaveChangesAsync();
            }
            else if ( check == null)
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

        //check if current time is earlier than 1st closure date 
        //public bool CheckFirtClosureDate(Idea idea)
        //    {
        //        DateTime firtClosureDate = DateTime.Parse(idea.first_closure.ToString()); //not accept nullable datetime type
        //        if (DateTime.Compare(DateTime.Now, firtClosureDate) < 0) return true;
        //        else return false;
        //    }

        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> DetailIdea(int id)
        {

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
            catch (Exception ex)
            {
                ViewBag.UserReact = null;
            }

            return View(idea);
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




        // What the actual k? why login here?
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        //public bool CheckFinalClosureDate(int ideaId)
        //{
        //    Idea idea = Db.Ideas.Find(ideaId);
        //    DateTime finalClosureDate = DateTime.Parse(idea.first_closure.ToString()); //not accept nullable datetime type
        //    if (DateTime.Compare(DateTime.Now, finalClosureDate) < 0) return true;
        //    else return false;
        //}
         public IActionResult TermsConditions()
        {
            return View();
        }
    }
}
