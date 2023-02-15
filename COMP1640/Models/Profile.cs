using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace COMP1640.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Avatar { get; set; }

        //FK1: Account ID
        public string UserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        //FK2: Department ID
        public int DepId { get; set; }
        public Department Department { get; set; }

        //------------------------
        public ICollection<Comment> Comments { get; set; }
    }
}
