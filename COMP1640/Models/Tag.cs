using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        public string tag_name { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
