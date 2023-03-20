using Microsoft.AspNetCore.Mvc;
using COMP1640.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

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

        public IActionResult Dashboard()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult InformationStaff()
        {
            return View();
        }

        public IActionResult SetClosureDate()
        {
            return View();
        }

        public IActionResult EditClosureDate()
        {
            return View();
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
            user.Avatar = uploadedAva.FileName;
            user.Name = Input.Name;
            user.Email = Input.Email;
            user.PhoneNumber = Input.PhoneNumber;
            user.DoB = Input.DoB;
            user.Gender = Input.Gender;
            user.Address = Input.Address;
            user.DepId = Input.DepartmentId;

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

        public IActionResult ManageClosureDate()
        {
            return View();
        }
    }
}
