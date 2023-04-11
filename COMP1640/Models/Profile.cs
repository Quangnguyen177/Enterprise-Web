using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace COMP1640.Models
{
    public class Profile : IdentityUser
    {
        [StringLength(70, ErrorMessage = "The {0} cannot exceed {1} characters")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public string Gender { get; set; }

        [StringLength(100, ErrorMessage = "The {0} cannot exceed {1} characters")]
        public string Address { get; set; }

        public string Avatar { get; set; }

        //FK1: Department ID
        public int? DepId { get; set; }
        public Department Department { get; set; }

        //------------------------
        public ICollection<Comment> Comments { get; set; }
    }
}
