using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Admin
    {
        [Key]
        public int AdId { get; set; }
        public string ad_name { get; set; }
        public string ad_phone { get; set; }
        public string ad_email { get; set;}
        public virtual Account account { get; set; }
    }
}
