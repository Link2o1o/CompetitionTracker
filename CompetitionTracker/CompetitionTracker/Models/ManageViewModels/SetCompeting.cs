﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionTracker.Models.ManageViewModels
{
    public class SetCompeting
    {
        [Required]
        public bool IsCompeting;
    }
}
