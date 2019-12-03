using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using CIS560_Project.Models;

namespace CIS560_Project.DataDelegates
{
    internal class CreateRaceParticipantDataDelegate : NonQueryDataDelegate<RaceParticipant>
    {
        public readonly int raceId;
        public readonly int runnerId;
        public readonly int time;
        public readonly double averageHR;

        public CreateRaceParticipantDataDelegate(int raceId, int runnerId, int time, double averageHR)
            : base("RaceParticipant.CreateRaceParticipant")
        {
            this.raceId = raceId;
            this.runnerId = runnerId;
            this.time = time;
            this.averageHR = averageHR;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceId", raceId);
            command.Parameters.AddWithValue("RunnerId", runnerId);
            command.Parameters.AddWithValue("Time", time);
            command.Parameters.AddWithValue("AverageHeartRate", averageHR);

            var t = command.Parameters.Add("RaceParticipantId", SqlDbType.Int);
            t.Direction = ParameterDirection.Output;
        }

        public override RaceParticipant Translate(SqlCommand command)
        {
            return new RaceParticipant((int)command.Parameters["RaceParticipantId"].Value, raceId, runnerId, time, averageHR);
        }
    }
}
