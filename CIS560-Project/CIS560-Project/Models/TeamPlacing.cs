using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class TeamPlacing
    {
        public string TeamName { get; }
        public int AvgTime { get; }

        public TeamPlacing() { }

        public TeamPlacing(string teamName, int avgTime)
        {
            TeamName = teamName;
            AvgTime = avgTime;
        }
    }
}
