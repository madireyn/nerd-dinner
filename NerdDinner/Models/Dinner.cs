﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public class Dinner
    {
        public int DinnerID { get; set; }
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public string Address { get; set; }
        public string HostedBy { get; set; }
        public string Country { get; set; }

        public virtual ICollection<RSVP> RSVPs { get; set; }

        public class RSVP
        {
            public int RsvpID { get; set; }
            public int DinnerID { get; set; }
            public string AttendeeEmail { get; set; }

            public virtual Dinner Dinner { get; set; }
        }
    }
}