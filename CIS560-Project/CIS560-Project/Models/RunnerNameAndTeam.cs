using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class RunnerNameAndTeam
    {
        public string RunnerName { get; }
        public string TeamName { get; }
        public int StartYear { get; }
        public int EndYear { get; set; }

        public RunnerNameAndTeam() { }

        public RunnerNameAndTeam(string runnerName, string teamName, int startYear, int endYear)
        {
            RunnerName = runnerName;
            TeamName = teamName;
            StartYear = startYear;
            EndYear = endYear;
        }
    }
}
