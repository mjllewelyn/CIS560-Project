using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using System.Data.SqlClient;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    class RaceSummaryDataDelegate : DataReaderDelegate<IReadOnlyList<RaceSummaryObject>>
    {
        private readonly int raceId;

        public RaceSummaryDataDelegate(int raceId)
            : base("CrossCountry.RaceSummary")
        {
            this.raceId = raceId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceId", raceId);
        }

        public override IReadOnlyList<RaceSummaryObject> Translate(SqlCommand command, IDataRowReader reader)
        {
            var races = new List<RaceSummaryObject>();
            if (!reader.Read())
                return null;
            do
            {
                races.Add(new RaceSummaryObject(
                    reader.GetInt32("NumberOfRacers"),
                    reader.GetInt32("AveragePace"),
                    reader.GetInt32("WinningTime")
                    ));
            } while (reader.Read());

            return races;
        }
    }
}
