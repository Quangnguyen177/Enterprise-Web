using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string category_name { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
