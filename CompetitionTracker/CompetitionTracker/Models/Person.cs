using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionTracker.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string HSName { get; set; }
        public string NextCollege { get; set; }
        public string Awards { get; set; }
        public string Experience { get; set; }
        public bool IsCompeting { get; set; }

        public string UserForeignKey { get; set; }
        public ApplicationUser User { get; set; }
        public int? CompetitorId { get; set; }
        public Competitor Competitor { get; set; }
    }
}
