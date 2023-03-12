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

        public Boolean idea_anonymous { get; set; }

        public int idea_view { get; set; }

        // FK1: Staff id
        public string ProfileId { get; set; }
        public Profile Profile { get; set; }

        // FK2: Category id
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // FK3: React Point id
        public int ReactPointId { get; set; }
        public ReactPoint Reacpoint { get; set; }

        // FK4: Event id
        public int? EventId { get; set; }
        public Event Event { get; set; }

        //---------------
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<React> React { get; set; }

    }
}
