using Microsoft.AspNetCore.Mvc;
using COMP1640.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Profile> _userManager;

        public AdminController(ApplicationDbContext context,
                               RoleManager<IdentityRole> roleManager,
                               UserManager<Profile> userManager)
        {
            Db = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public string Id { get; set; }

            public string Name { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            public string PhoneNumber { get; set; }

            [DataType(DataType.Date)]
            public DateTime DoB { get; set; }

            public string Gender { get; set; }

            public string Address { get; set; }

            public string Role { get; set; }

            public int DepartmentId { get; set; }

            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }
        }

        public IActionResult Home()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult InformationStaff()
        {
            return View();
        }

        public IActionResult ManageClosureDate()
        {
            return View(Db.Events.OrderByDescending(e => e.EventId).ToList());
        }

        [HttpGet]
        public IActionResult SetClosureDate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SetClosureDate(Event eve)
        {
            if (eve.First_closure_date <= DateTime.UtcNow | eve.Last_closure_date <= DateTime.UtcNow)
            {
                ViewBag.Message = "The first closure date or last closure date must be later than today";
                return View(eve);
            }
            if (eve.First_closure_date >= eve.Last_closure_date)
            {
                ViewBag.Message = "The first closure date can not be later than the last closure date";
                return View(eve);
            }
            else
            {
                Db.Events.Add(eve);
                Db.SaveChanges();
                return RedirectToAction(nameof(ManageClosureDate));
            }

        }

        //[HttpGet]
        //public IActionResult SetStatus(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(Db.Events.Find(id));
        //}
        [HttpPost]
        public IActionResult SetStatus(int id)
        {
            var eve = Db.Events.FirstOrDefault(i => i.EventId == id);
            if (eve.Status == true) { eve.Status = false; }
            else if (eve.Status == false) { eve.Status = true; }
            if (ModelState.IsValid)
            {
                Db.Events.Update(eve);
                Db.SaveChanges();
                return RedirectToAction(nameof(ManageClosureDate));
            }
            else
            {
                return View(eve);
            }
        }

        [HttpGet]
        public IActionResult EditClosureDate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(Db.Events.Find(id));
        }

        [HttpPost]
        public IActionResult EditClosureDate(Event eve)
        {
            if (eve.First_closure_date >= eve.Last_closure_date)
            {
                ViewBag.Message = "The first closure date can not be later than the last closure date";
                return View(eve);
            }
            else
            {
                Db.Events.Update(eve);
                Db.SaveChanges();
                return RedirectToAction(nameof(ManageClosureDate));
            }
        }

        public IActionResult DeleteClosureDate(int? id)
        {
            var ideas_event = Db.Ideas.Where(ideas => ideas.EventId == id).ToList();
            if (ideas_event.Count == 0)
            {
                var eve = Db.Events.Find(id);
                Db.Events.Remove(eve);
                Db.SaveChanges();
                return RedirectToAction(nameof(ManageClosureDate));
            }
            return RedirectToAction(nameof(ManageClosureDate));
        }
        [HttpPost]
        public IActionResult SearchEvent(string keyword)
        {
            var events = Db.Events.Where(p => p.EventName.Contains(keyword)).OrderByDescending(e => e.EventId).ToList();
            if (events.Count == 0)
            {
                TempData["Message"] = "No event found !";
            }
            return View("ManageClosureDate", events);
        }

        public IActionResult ManageAccount()
        {
            var accs = Db.Profile.AsNoTracking().ToList();
            return View(accs);
        }

        [HttpGet]
        public async Task<IActionResult> EditAccount(string? id)
        {
            if (id == "")
            {
                return NotFound();
            }
            var acc = Db.Profile.FirstOrDefault(x => x.Id == id);
            ViewData["Roles"] = new List<IdentityRole>(await _roleManager.Roles.ToListAsync());
            ViewData["Departments"] = new List<Department>(Db.Departments.ToList());
            ViewBag.User = acc;
            ViewBag.UserDoB = acc.DoB.Date.ToString("yyyy-MM-dd");
            var role = await _userManager.GetRolesAsync(acc);
            ViewBag.UserRole = role.Last();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditAccount(IFormFile uploadedAva)
        {
            var user = Db.Profile.FirstOrDefault(u => u.Id == Input.Id);
            var currentRoles = await _userManager.GetRolesAsync(user);

            user.Id = Input.Id;
            user.Name = Input.Name;
            user.Email = Input.Email;
            user.PhoneNumber = Input.PhoneNumber;
            user.DoB = Input.DoB;
            user.Gender = Input.Gender;
            user.Address = Input.Address;
            user.DepId = Input.DepartmentId;
            if (uploadedAva != null)
            {
                user.Avatar = uploadedAva.FileName;
                //Upload Avatar
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatars");

                //create folder if not exist
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                string fileNameWithPath = Path.Combine(path, uploadedAva.FileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    uploadedAva.CopyTo(stream); //đoạn này add vô root 

                }
            }
            else
            {
                user.Avatar = null;
            }

            if (currentRoles.Last() != Input.Role)
            {
                await _userManager.RemoveFromRoleAsync(user, currentRoles.Last());
                await _userManager.AddToRoleAsync(user, Input.Role);
            }

            if (ModelState.IsValid)
            {
                Db.Profile.Update(user);
                await Db.SaveChangesAsync();
                return RedirectToAction("ManageAccount");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword()
        {
            var user = Db.Profile.FirstOrDefault(u => u.Id == Input.Id);
            var hashed = new PasswordHasher<Profile>();
            user.PasswordHash = hashed.HashPassword(user, Input.Password);

            if (ModelState.IsValid)
            {
                Db.Profile.Update(user);
                await Db.SaveChangesAsync();
                return RedirectToAction("ManageAccount");
            }
            else
            {
                return View(user);
            }
        }


    }
}
