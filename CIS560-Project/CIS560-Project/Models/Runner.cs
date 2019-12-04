using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class Runner : User
    {
        public int RunnerId { get; }
        public int TeamId { get; }
        public int StartYear { get; }
        public int EndYear { get; set; }

        public Runner() { }

        public Runner(int runnerId, int teamId, int startYear, int endYear)
        {
            RunnerId = runnerId;
            TeamId = teamId;
            StartYear = startYear;
            EndYear = endYear;
        }
    }
}
