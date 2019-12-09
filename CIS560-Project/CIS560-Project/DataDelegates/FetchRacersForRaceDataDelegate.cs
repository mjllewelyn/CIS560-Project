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
    class FetchRacersForRaceDataDelegate : DataReaderDelegate<IReadOnlyList<Racer>>
    {
        private readonly int raceId;

        public FetchRacersForRaceDataDelegate(int raceId)
            : base("CrossCountry.FetchRacersForRace")
        {
            this.raceId = raceId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceId", raceId);
        }

        public override IReadOnlyList<Racer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var raceParticipants = new List<Racer>();

            while (reader.Read())
            {
                raceParticipants.Add(new Racer(
                    reader.GetInt32("RaceParticipantId"),
                    reader.GetString("Name"),
                    reader.GetInt32("Time"),
                    reader.GetValue<int>("AvgHeartRate")));
            }

            return raceParticipants;
        }
    }
}
