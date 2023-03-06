using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace COMP1640.Models
{
    public class Comment
    {
        [Key]
        public int ComId { get; set; }
        public string com_content { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> created_date { get; set; }

        public Boolean com_anonymous { get; set; }

        // FK1: Staff id
        public string ProfileId { get; set; }
        public Profile Profile { get; set; }

        // FK2: Idea Id
        public int IdeaId { get; set; }
        public Idea Idea { get; set; }

        //------------------------
        //public ICollection<Staff> Staffs { get; set; }
        //public ICollection<Idea> Ideas { get; set; }
    }
}
