using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using COMP1640.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace COMP1640.Areas.Identity.Pages.Account.Manage
{
    [Authorize]
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Models.Profile> _userManager;
        private readonly SignInManager<Models.Profile> _signInManager;
        private readonly ApplicationDbContext Db;

        public IndexModel(
            UserManager<Models.Profile> userManager,
            SignInManager<Models.Profile> signInManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            Db = context;
        }

        //Custom
        [Required]
        public string Fullname { get; set; }
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(Models.Profile user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Email = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber
            };

            var theUser = await _userManager.GetUserAsync(User);
            Fullname = theUser.Name;
            DoB = theUser.DoB;
            Gender = theUser.Gender;
            Address = theUser.Address;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            await LoadAsync(user);

            ViewData["User"] = user;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile uploadedAva, string Email, string Fullname, DateTime DoB, string Gender, string Address)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }
            //Upload Avatar
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Avatars");

            //create folder if not exist
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (uploadedAva != null)
            {
                string fileNameWithPath = Path.Combine(path, uploadedAva.FileName);
                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    uploadedAva.CopyTo(stream); //đoạn này add vô root 
                }

                user.Avatar = uploadedAva.FileName;
            }
            else
            {
                user.Avatar = user.Avatar;
            }   

            //Update the rest
            if (ModelState.IsValid)
            {
                user.Email = Email;
                user.UserName = Email;
                user.NormalizedUserName = Email;
                user.Name = Fullname;
                user.DoB = DoB;
                user.Gender = Gender;
                user.Address = Address;
                Db.Profile.Update(user);
                await Db.SaveChangesAsync();
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
