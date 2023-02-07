using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        public string staff_name { get; set; }

        public string staff_phone { get; set; }

        public string staff_email { get; set; }

        [DataType(DataType.Date)]
        public DateTime staff_DoB { get; set; }

        public string staff_gender { get; set; }

        public string staff_address { get; set; }

        public string staff_avatar { get; set; }

        //FK1: Department ID
        public int DepId { get; set; }
        public Department Department { get; set; }

        //FK2: Account ID
        public string Username { get; set; }
        public Account Account { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
