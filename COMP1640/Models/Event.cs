using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} cannot exceed {1} characters")]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public DateTime First_closure_date { get; set; }

        [DataType(DataType.Date)]
        public DateTime Last_closure_date { get; set; }

        [Required]
        public Boolean Status { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
