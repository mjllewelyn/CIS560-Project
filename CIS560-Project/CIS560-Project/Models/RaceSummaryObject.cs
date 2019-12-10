using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class RaceSummaryObject
    {
        public int NumberOfRacers { get; }
        public string AveragePace { get; }
        public string WinningTime { get; }

        public RaceSummaryObject(int racers, int avgPace, int winningTime)
        {
            NumberOfRacers = racers;
            AveragePace = Program.GetTimeString(avgPace);
            WinningTime = Program.GetTimeString(winningTime);
        }
    }
}
