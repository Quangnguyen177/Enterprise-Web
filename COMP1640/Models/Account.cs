using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace COMP1640.Models
{
    public class Account
    {

        [Key]
        public string Email { get; set; }
        //[Required]
        [StringLength(100)]
        public string Password { get; set; }
        //[Required]
        [StringLength(50)]
        public string Role { get; set; }

        //------------------------
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Admin> Admins { get; set; }
        public ICollection<QAManager> QAManagers { get; set; }
    }
}
