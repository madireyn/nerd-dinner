using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.Models
{
    // used to handle the retrieval of Dinner and RSVP instances from a database
    public class NerdDinners : DbContext
    {
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<Dinner.RSVP> RSVPs { get; set; }
    }
}