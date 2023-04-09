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
        [StringLength(70, ErrorMessage = "The {0} cannot exceed {1} characters")]
        public string doc_path { get; set; }

        [Required]
        [StringLength(70, ErrorMessage = "The {0} cannot exceed {1} characters")]
        public string doc_name { get; set;}

        // FK1: Idea Id
        public int IdeaId { get; set; }
        public Idea Idea { get; set; }
    }
}
