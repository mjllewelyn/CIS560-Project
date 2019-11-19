using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Runner : User
    {
        public int TeamId { get; }
        public DateTime StartYear { get; }
        public DateTime EndYear { get; set; }

        public Runner() { }

        public Runner(int teamId, DateTime startYear)
        {
            TeamId = teamId;
            StartYear = startYear;
        }
    }
}
