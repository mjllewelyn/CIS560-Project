using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using DataAccess;
using System.Data.SqlClient;

namespace CIS560_Project.DataDelegates
{
    class GetTeamRecordsDataDelegate : DataReaderDelegate<IReadOnlyList<RaceParticipant>>
    {
        private readonly int teamId;

        public GetTeamRecordsDataDelegate(int teamId)
            : base("CrossCountry.GetTeamRecords")
        {
            this.teamId = teamId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", teamId);
        }

        public override IReadOnlyList<RaceParticipant> Translate(SqlCommand command, IDataRowReader reader)
        {
            var raceParticipants = new List<RaceParticipant>();

            while (reader.Read())
            {
                raceParticipants.Add(new RaceParticipant(
                    reader.GetInt32("RaceParticipantId"),
                    reader.GetInt32("RaceId"),
                    reader.GetInt32("RunnerId"),
                    reader.GetInt32("Time"),
                    reader.GetValue<double>("AverageHeartRate")));
            }

            return raceParticipants;
        }
    }
}
