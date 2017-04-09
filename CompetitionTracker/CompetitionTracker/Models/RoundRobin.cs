using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionTracker.Models
{
    public class RoundRobin
    {
        public List<Competitor> compList;
        public RoundRobin(List<Competitor> cList) {
            compList = cList;
        }


    }
}
