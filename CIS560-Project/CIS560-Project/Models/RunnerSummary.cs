using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class RunnerSummary
    {
        public int averageDistance { get; }
        public int averageTime { get; }
        public int averagePace { get; }
    
        public RunnerSummary(int averageDistance, int averageTime)
        {
            this.averageDistance = averageDistance;
            this.averageTime = averageTime;
            averagePace = averageTime / averageDistance;
        }
    }
}
