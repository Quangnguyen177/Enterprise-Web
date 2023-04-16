using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Document
    {
        [Key]
        public int DocId { get; set; }

        [Required]
        public string doc_path { get; set; }

        [Required]
        public string doc_name { get; set;}

        // FK1: Idea Id
        public int IdeaId { get; set; }
        public Idea Idea { get; set; }
    }
}
