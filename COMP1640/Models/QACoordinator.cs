using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class QACoordinator
    {
        [Key]
        public int QacId { get; set; }
        public string qac_name { get; set;}
        public string qac_phone { get;set;}
        public string qac_gender { get;set;}
        public string qac_email { get;set;}
    }
}
