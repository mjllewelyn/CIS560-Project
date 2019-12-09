using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Racer
    {
        public int RaceParticipantId { get; }
        public string RunnerName { get; }
        public string Time { get; }
        public int AverageHeartRate { get; set; }

        public Racer(int raceParticipantId, string runnerName, int runnerId, int time = 0, int averageHeartRate = 0)
        {
            RaceParticipantId = raceParticipantId;
            RunnerName = runnerName;
            Time = Program.GetTimeString(time);
            AverageHeartRate = averageHeartRate;
        }
    }
}
