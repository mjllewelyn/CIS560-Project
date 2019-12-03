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
    internal class FetchRunnersForRaceDataDelegate : DataReaderDelegate<IReadOnlyList<RaceParticipant>>
    {
        private readonly int raceId;

        public FetchRunnersForRaceDataDelegate(int raceId)
            : base("Race.FetchRunnersForRace")
        {
            this.raceId = raceId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceId", raceId);
        }

        public override IReadOnlyList<RaceParticipant> Translate(SqlCommand command, IDataRowReader reader)
        {
            var raceParticipants = new List<RaceParticipant>();

            while (reader.Read())
            {
                raceParticipants.Add(new RaceParticipant(
                    reader.GetInt32("RaceParticipantId"),
                    raceId,
                    reader.GetInt32("RunnerId"),
                    reader.GetInt32("Time"),
                    reader.GetValue<double>("AverageHeartRate")));
            }

            return raceParticipants;
        }
    }
}
