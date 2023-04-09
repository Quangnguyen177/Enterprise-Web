using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} cannot exceed {1} characters")]
        public string category_name { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
