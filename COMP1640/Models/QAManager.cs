using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class QAManager
    {
        [Key]
        public int QamId { get; set; }
        public string qam_name { get; set; }
        public string qam_phone { get; set;}
        public string qam_email { get; set;}
        public string qam_gender { get; set;}

        //FK: Account ID
        public string Username { get; set; }
        public Account Account { get; set; }

    }
}
