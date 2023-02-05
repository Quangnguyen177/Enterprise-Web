using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string staff_name { get; set; }

        public int staff_phone { get; set; }

        public string staff_email { get; set; }

        [DataType(DataType.Date)]
        public DateTime staff_DoB { get; set; }

        public string staff_gender { get; set; }

        public string staff_address { get; set; }

        public string staff_avatar { get; set; }


        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
