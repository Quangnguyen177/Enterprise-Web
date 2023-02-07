using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace COMP1640.Models
{
    public class Account
    {

        [Key]
        public string Username { get; set; }
        //[Required]
        [StringLength(100)]
        public string password { get; set; }
        //[Required]
        [StringLength(50)]
        public string role { get; set; }

        //------------------------
        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Admin> Admins { get; set; }
        public ICollection<QAManager> QAManagers { get; set; }
        public ICollection<QACoordinator> QACoordinators { get; set; }
    }
}
