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

namespace COMP1640.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly UserManager<Profile> _userManager;
        public StaffController(ApplicationDbContext context, UserManager<Profile> userManager)
        {
            Db = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult ViewPage(int pageNum = 1)
        {
            int skipPage = 5 * (pageNum - 1);
            var ideasList = Db.Comments.OrderByDescending(c => c.created_date);
            var page = Db.Ideas.Skip(skipPage).Take(5).ToList();
            ViewBag.Page = pageNum;
            ViewBag.Category = Db.Categories.ToList();
            /*List<Document> Documentss = new List<Document>();
            foreach(var idea in page)
            {
var documents = Db.Documents.Include(d => d.Idea).FirstOrDefault(d => d.IdeaId == idea.IdeaId);
            var result = Db.Documents.Where(documents => documents.IdeaId == idea.IdeaId).ToList();
                Documentss.Add(result);


            }*/
            

            return View(page);
        }

        //chua co truong view trong idea nen comment
        /*[HttpGet]
        public IActionResult MostView(int pageNum)
        {
            int skipPage = 5 * (pageNum - 1);
            var ideasList = Db.Ideas.OrderByDescending(i => i.View);
            var page = ideasList.Skip(skipPage).Take(5).ToList();
            ViewBag.Page = pageNum;
            return View(page);
        }*/

        [HttpGet]
        public IActionResult LastComment(int pageNum)
        {
            int skipPage = 5 * (pageNum - 1);
            var ideasList = Db.Comments.OrderByDescending(c => c.created_date);
            var page = Db.Ideas.Skip(skipPage).Take(5).ToList();
            ViewBag.Page = pageNum;
            return View(page);
        }
        
        [HttpGet]
        public IActionResult AddIdea()
        {
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
            return View(Db.Categories.ToList());

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

                    doc_content = file.FileName,
                    doc_type = "Still dont know",
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
                HandleFile(uploadedFiles, ideaId, "UPDATE"); //add file
            }
            Db.Update(idea);
            Db.SaveChanges();
            return RedirectToAction("AddIdea");
        }


        //comment
        public IActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Comment(string content, string isAnonymous, int ideaId, string toEmail, string name)
        {
            // send a notification mail to idea owner
            var sendMail = SendNotificationEmail(name, toEmail, content);
            if (sendMail) // check if sending mail is successfull!
            {
                //add comment 
                bool anonynous = true;
                if (isAnonymous == null) anonynous = false;
                Comment newComment = new Comment()
                {
                    com_content = content,
                    ProfileId = "1",
                    com_anonymous = anonynous,
                    IdeaId = ideaId,
                };
                Db.Add(newComment);
                await Db.SaveChangesAsync();
            }
            else
            {
                ViewBag.Error = "Comment failed!";
            }
            return View();
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
    public bool CheckFirtClosureDate(Idea idea)
        {
            DateTime firtClosureDate = DateTime.Parse(idea.first_closure.ToString()); //not accept nullable datetime type
            if (DateTime.Compare(DateTime.Now, firtClosureDate) < 0) return true;
            else return false;
        }
        [HttpPost]
        public bool SendNotificationEmail(string name, string toEmail, string content)
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
                client.Credentials = new System.Net.NetworkCredential("truongtd2002tq@gmail.com", "dyxjomsrvccdgfys");
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

        public async Task<IActionResult> DetailIdea(int id)
        {

            var user_of_idea = Db.Ideas.Include(u => u.Profile).FirstOrDefault(u => u.IdeaId == id);
            var name_of_user = user_of_idea.Profile.Name;
            ViewBag.Name = name_of_user;

            var comments = Db.Comments.Include(p => p.Idea).FirstOrDefault(p => p.IdeaId == id);
            ViewBag.Comments = Db.Comments.Where(comments => comments.IdeaId == id).ToList();

            var documents = Db.Documents.Include(d => d.Idea).FirstOrDefault(d => d.IdeaId == id);
            ViewBag.Documents = Db.Documents.Where(documents => documents.IdeaId == id).ToList();

            var idea = Db.Ideas.Include(c => c.Category).FirstOrDefault(c => c.IdeaId == id);

            //ducmt1
            var reactpoint_of_idea = Db.Ideas.Include(r => r.Reacpoint).FirstOrDefault(u => u.IdeaId == id);
            var number_of_upvote = reactpoint_of_idea.Reacpoint.ThumbUp;
            ViewBag.ThumbUp = number_of_upvote;
            var number_of_downvote = reactpoint_of_idea.Reacpoint.ThumbDown;
            ViewBag.ThumbDown = number_of_downvote;


            //ducmt2
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
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

        public FileResult DownloadFile(int id)
        {
            var file = Db.Documents.Find(id);
            var filename = file.doc_content;
            return File(@"F:\\F2G - UOG\\COMP1640 - Enterprise Web Software Development", filename, System.Net.Mime.MediaTypeNames.Application.Octet);
        }

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
    }
}
