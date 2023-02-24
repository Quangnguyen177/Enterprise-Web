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
        public IActionResult ViewPage(int pageNum)
        {
            int skipPage = 5 * (pageNum - 1);
            var page = Db.Ideas.Skip(skipPage).Take(5).ToList();
            ViewBag.Page = pageNum;
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
            return View(Db.Tags.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddIdea(List<IFormFile> uploadedFiles,string title, string content, string tagName, string isAnonymous)
        {
            Tag tag = Db.Tags.FirstOrDefault(t => t.tag_name == tagName);
            Boolean anonynous = true;
            if (isAnonymous == null) anonynous = false;
            Idea newIdea = new Idea()
            {
                idea_title = title,
                idea_content = content,
                idea_anonymous = anonynous,
                ProfileId = "1",
                TagId = tag.TagId,
                created_date = DateTime.Now,
                Ipoint = 0
            };
            Db.Add(newIdea);
            await Db.SaveChangesAsync();
            if (uploadedFiles.Count > 0)
            {
                AddFile(uploadedFiles, Db.Ideas.OrderBy(i=>i.IdeaId).Last().IdeaId); //add file
            }
            return View(Db.Tags.ToList());
        }
        public void AddFile(List<IFormFile> uploadedFiles, int idIdea)
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
                Db.Add(doc);
                Db.SaveChanges();
            }
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
                ProfileId = "1", //because session is not initialized, the defaut Staff is 1 
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

        //[HttpPost]
        //public async Task<HttpResponseMessage> Like(int id)
        //{
        //    var idea = Db.Ideas.FirstOrDefault(i => i.IdeaId == id);
        //    idea.Ipoint++;
        //    Db.Update(idea);
        //    await Db.SaveChangesAsync();
        //    return new HttpResponseMessage(HttpStatusCode.Accepted);
        //}

        [HttpPost]
        public IActionResult Like(Idea idea)
        {
            //{
            //    var updatedLike = Db.Ideas.FirstOrDefault(i => i.IdeaId == idea.IdeaId);

            //    if (updatedLike != null)
            //    {
            //        //updatedLike.Ipoint = idea.Ipoint + 1;
            //        updatedLike.Ipoint++;
            //        Db.Update(updatedLike);
            //        Db.SaveChanges();
            //        return Json(true);
            //    }
            //}

            //return Json(false);

            if (ModelState.IsValid)
            {
                Db.Update(idea);
                Db.SaveChanges();
                return Ok("Done");
            }
            else return Ok("not good");
           
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

        public IActionResult DetailIdea(int id)
        {

            var user_of_idea = Db.Ideas.Include(u => u.Profile).FirstOrDefault(u => u.IdeaId == id);
            var name_of_user = user_of_idea.Profile.Name;
            ViewBag.Name = name_of_user;

            var comments = Db.Comments.Include(p => p.Idea).FirstOrDefault(p => p.IdeaId == id);
            ViewBag.Comments = Db.Comments.Where(comments => comments.IdeaId == id).ToList();

            var documents = Db.Documents.Include(d=>d.Idea).FirstOrDefault(d=>d.IdeaId == id);
            ViewBag.Documents = Db.Documents.Where(documents => documents.IdeaId == id).ToList();

            var idea = Db.Ideas.Include(c => c.Tag).FirstOrDefault(c => c.IdeaId == id);
            return View(idea);
        }

        public FileResult DownloadFile(int id)
        {
            var file = Db.Documents.Find(id);
            var filename = file.doc_content;
            return File(@"F:\\F2G - UOG\\COMP1640 - Enterprise Web Software Development", filename, System.Net.Mime.MediaTypeNames.Application.Octet);
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
