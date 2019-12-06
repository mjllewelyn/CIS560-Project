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
    internal class FetchRacesForRunnerDataDelegate : DataReaderDelegate<IReadOnlyList<RaceParticipant>>
    {
        private readonly int runnerId;

        public FetchRacesForRunnerDataDelegate(int runnerId)
            : base("CrossCountry.FetchRacesForRunner")
        {
            this.runnerId = runnerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
        }

        public override IReadOnlyList<RaceParticipant> Translate(SqlCommand command, IDataRowReader reader)
        {
            var raceParticipants = new List<RaceParticipant>();

            while (reader.Read())
            {
                raceParticipants.Add(new RaceParticipant(
                    reader.GetInt32("RaceParticipantId"),
                    reader.GetInt32("RaceId"),
                    runnerId,
                    reader.GetInt32("Time"),
                    reader.GetValue<double>("AverageHeartRate")));
            }

            return raceParticipants;
        }
    }
}
