using System;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Comment
    {
        [Key]
        public int ComId { get; set; }
        public string com_content { get; set; }
        [DataType(DataType.Date)]
        public Nullable<DateTime> created_date { get;}

        // FK1: Staff id
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        // FK1: Idea Id
        public int IdeaId { get; set; }
        public Idea Idea { get; set; }

    }
}
