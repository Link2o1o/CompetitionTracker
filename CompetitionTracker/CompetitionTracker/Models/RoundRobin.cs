using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionTracker.Models
{
    public class RoundRobin
    {
        public List<Competitor> CompClockList { get; set; }
        public int RoundSize { get; set; }
        public Competitor Center { get; set; }

        public RoundRobin(List<Competitor> cList) {
            if (cList.Count > 1)
            {
                CompClockList = cList;
                RoundSize = cList.Count - 1;
                Center = cList[0];
                CompClockList.Remove(cList[0]);
            }
        }
    }
}
