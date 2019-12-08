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
    internal class FetchRacesForRunnerDataDelegate : DataReaderDelegate<IReadOnlyList<RaceForRunner>>
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

        public override IReadOnlyList<RaceForRunner> Translate(SqlCommand command, IDataRowReader reader)
        {
            var raceParticipants = new List<RaceForRunner>();

            while (reader.Read())
            {
                raceParticipants.Add(new RaceForRunner(
                    reader.GetString("Name"),
                    reader.GetValue<DateTime>("DateTime"),
                    reader.GetInt32("Distance"),
                    reader.GetInt32("Time"),
                    reader.GetInt32("AvgHeartRate")));
            }

            return raceParticipants;
        }
    }
}
