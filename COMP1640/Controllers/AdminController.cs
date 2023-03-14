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

namespace COMP1640.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            Db = context;
            _roleManager = roleManager;
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

        //[HttpGet]
        //public IActionResult CreateAccount()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult CreateAccount(Account acc)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Db.Accounts.Add(acc);
        //        Db.SaveChanges();
        //        return RedirectToAction("Dashboard");
        //    }
        //    else
        //    {
        //        //ViewBag.<Somethings> = context.<Somethings>.ToList();
        //        return View(acc);
        //    }
        //}

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
        public IActionResult ManageInformation(string? id)
        {
            if (id == "")
            {
                return NotFound();
            }
            var acc = Db.Profile.FirstOrDefault(x => x.Id == id);
            return View(acc);
        }

        [HttpPost]
        public async Task<IActionResult> ManageInformation(string id, string Name, string Email, string PhoneNumber, DateTime DoB, string Gender, string Address)
        {
            //var userrole = Input.Role;

            //var result = await _userManager.CreateAsync(user, Input.Password);

            //await _userManager.AddToRoleAsync(user, userrole);
            var user = Db.Profile.FirstOrDefault(u => u.Id == id);
            user.Name = Name;
            user.Email = Email;
            user.PhoneNumber = PhoneNumber;
            user.DoB = DoB;
            user.Gender = Gender;
            user.Address = Address;
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
