using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class RaceParticipant
    {
        public int RaceParticipantId { get; }
        public int RaceId { get; }
        public int RunnerId { get; }
        public string Time { get; }
        public int AverageHeartRate { get; set; }

        public RaceParticipant() { }

        public RaceParticipant(int raceParticipantId, int raceId, int runnerId, int time=0, int averageHeartRate=0)
        {
            RaceParticipantId = raceParticipantId;
            RaceId = raceId;
            RunnerId = runnerId;
            Time = Program.GetTimeString(time);
            AverageHeartRate = averageHeartRate;
        }
    }
}
