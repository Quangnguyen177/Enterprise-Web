using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Document
    {
        [Key]
        public int DocId { get; set; }
        public string doc_type { get; set; }
        public string doc_content { get; set;}

        // FK1: Idea Id
        public int IdeaId { get; set; }
        public Idea Idea { get; set; }
    }
}
