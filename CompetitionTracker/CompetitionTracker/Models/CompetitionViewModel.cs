using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CompetitionTracker.Models
{
    public class CompetitionViewModel
    {
        [Display(Name = "Check if you're competing in this tournament")]
        public bool IsCompeting { get; set; }
    }
}
