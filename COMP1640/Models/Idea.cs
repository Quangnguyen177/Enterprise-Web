using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace COMP1640.Models
{
    public class Idea
    {
        public int IdeaId { get; set; }

        public string idea_title { get; set; }

        public string idea_content { get; set; }

        public string idea_document { get; set; }

        public string idea_image { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> first_closure { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> last_closure { get; set; }

        // FK1: Staff id
        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        // FK2: Tag id
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        // FK2: Comment id ???
        //public int cmt_id { get; set; }
        //public Comment Comments { get; set; }

    }
}
