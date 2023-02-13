using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace COMP1640.Models
{
    public class Account
    {

        [Key]
        [Required(ErrorMessage = "Username is missing")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is missing")]
        [StringLength(30)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please choose an account role")]
        public string Role { get; set; }

        //------------------------
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Admin> Admins { get; set; }
        public ICollection<QAManager> QAManagers { get; set; }
        public ICollection<QACoordinator> QACoordinators { get; set; }
    }
}
