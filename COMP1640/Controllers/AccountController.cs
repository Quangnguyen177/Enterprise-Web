using Microsoft.AspNetCore.Mvc;
using COMP1640.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;


namespace COMP1640.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext context;

        public AccountController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[Route("/Login")]
        //[HttpGet]
        //public IActionResult Login()
        //{
   
        //   return View();
        //}

        //[HttpPost]
        //public IActionResult Login(string username, string password)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //tim trong database thong tin tai khoan tuong ung voi username,password nguoi dung nhap
        //        var account = context.Accounts.Where(s => s.Username.Equals(username) && s.Password.Equals(password)).ToList();
        //        //neu accout.count>0 tuc la thong tin nguoi dung nhap dung 
        //        if (account.Count() > 0)
        //        {
        //            //lay role tu tai khoan va gan session
        //            var accountRole = account.FirstOrDefault().Role;
        //            HttpContext.Session.SetString("ROLE", accountRole);
        //            switch (accountRole) //kiem tra role de redirect den trang tuong ung voi role
        //            {
        //                case "ADMIN":
        //                    //gan session "id" = id cua admin
        //                    HttpContext.Session.SetInt32("ID", context.Admins.FirstOrDefault(a => a.Username.Equals(username)).AdId);                          
        //                    return RedirectToAction("Dashboard", "Admin");

        //                case "QAC":
        //                    //gan session "id" = id cua QAC
        //                    HttpContext.Session.SetInt32("ID", context.QACoordinators.FirstOrDefault(qac => qac.Username.Equals(username)).QacId);
        //                    return RedirectToAction("Index", "QACoordinator");                          
        //                case "QAM":
        //                    HttpContext.Session.SetInt32("ID", context.QAManagers.FirstOrDefault(qam => qam.Username.Equals(username)).QamId);
        //                    return RedirectToAction("Index", "QaManager");
                            
        //                case "STAFF":
        //                    HttpContext.Session.SetInt32("ID", context.Staffs.FirstOrDefault(s => s.Username.Equals(username)).StaffId);                          
        //                    return RedirectToAction("Index", "Staff");
                          
        //            }

        //        }
        //        else
        //        {
        //            ViewBag.error = "Login failed!";
        //            return RedirectToAction("Login");
                    
        //        }
        //    }
        //    return View();
            
        //}

        //public ActionResult Logout()
        //{
        //    HttpContext.Session.Clear();
        //    return RedirectToAction("Login");
        //}
    }
}
