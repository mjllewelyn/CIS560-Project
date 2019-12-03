using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    internal class GetRaceParticipantDataDelegate : DataReaderDelegate<RaceParticipant>
    {
        private readonly int raceParticipantId;

        public GetRaceParticipantDataDelegate(int raceParticipantId)
            : base("RaceParticipant.GetRaceParticipant")
        {
            this.raceParticipantId = raceParticipantId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceParticipantId", raceParticipantId);
        }
        public override RaceParticipant Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new RaceParticipant(
                raceParticipantId,
                reader.GetInt32("RaceId"),
                reader.GetInt32("RunnerId"),
                reader.GetInt32("Time"),
                reader.GetValue<double>("AverageHeartRate")
                );
        }
    }
}
