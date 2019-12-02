﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Runner : User
    {
        public int TeamId { get; }
        public int StartYear { get; }
        public int EndYear { get; set; }

        public Runner() { }

        public Runner(int teamId, int startYear, int endYear)
        {
            TeamId = teamId;
            StartYear = startYear;
            EndYear = endYear;
        }
    }
}
