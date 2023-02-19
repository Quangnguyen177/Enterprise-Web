using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace COMP1640.Models
{
    public class Idea
    {
        [Key]
        public int IdeaId { get; set; }

        public string idea_title { get; set; }

        public string idea_content { get; set; }

        [DataType(DataType.Date)] 
        public Nullable<DateTime> created_date { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> first_closure { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> last_closure { get; set; }

        public Boolean idea_anonymous { get; set; }

        public int Ipoint { get; set; }

        // FK1: Staff id
        public string ProfileId { get; set; }
        public Profile Profile { get; set; }

        // FK2: Tag id
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        //---------------
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Document> Documents { get; set; }

    }
}
