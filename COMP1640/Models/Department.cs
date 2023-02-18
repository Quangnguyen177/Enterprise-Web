using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Department
    {
        [Key]
        public string DepId { get; set; }
        public string dep_name { get; set; }

        public ICollection<Profile> Profiles { get; set; }
    }
}
