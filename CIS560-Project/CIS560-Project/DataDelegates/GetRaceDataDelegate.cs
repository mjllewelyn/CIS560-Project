using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CIS560_Project.Models;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    internal class GetRaceDataDelegate : DataReaderDelegate<Race>
    {
        private readonly int raceId;
        public GetRaceDataDelegate(int raceId)
            : base("CrossCountry.GetRace")
        {
            this.raceId = raceId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceId", raceId);
        }

        public override Race Translate(SqlCommand command, IDataRowReader reader)
        {

            return new Race(
                    raceId,
                    reader.GetInt32("CreatorId"),
                    reader.GetInt32("LocationId"),
                    reader.GetValue<DateTime>("DateTime"),
                    reader.GetInt32("Distance"));
        }
    }
}
