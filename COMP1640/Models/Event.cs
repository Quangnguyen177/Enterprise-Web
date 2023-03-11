using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COMP1640.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> First_closure_date { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> Last_closure_date { get; set; }

        //-------------------------
        public ICollection<Idea> Ideas { get; set; }
    }
}
