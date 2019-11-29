﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class RaceParticipant
    {
        public int RaceParticipantId { get; }
        public int RaceId { get; }
        public int RunnerId { get; }
        public double Time { get; }
        public double AverageHeartRate { get; set; }

        public RaceParticipant() { }

        public RaceParticipant(int raceParticipantId, int raceId, int runnerId, double time=0.0, double averageHeartRate=0.0)
        {
            RaceParticipantId = raceParticipantId;
            RaceId = raceId;
            RunnerId = runnerId;
            Time = time;
            AverageHeartRate = averageHeartRate;
        }
    }
}