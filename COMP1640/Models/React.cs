using System;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class React
    {
        [Key]
        public int ReactId { get; set; }
        public Boolean Reacted { get; set; }

        //FK1: Idea ID
        public int IdeaId { get; set; }
        public Idea Idea { get; set; }

        // FK2: Profile Id
        public string ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
