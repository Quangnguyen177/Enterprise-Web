using System.Collections.Generic;

namespace COMP1640.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        public string tag_name { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
