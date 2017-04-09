using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionTracker.Models
{
    public class Competitor
    {
        public int CompetitorId { get; set; }
        public string Alias { get; set; }
        public int Score { get; set; }

        public int PersonId { get; set; }
        public virtual List<Person> Persons { get; set; }
    }
}