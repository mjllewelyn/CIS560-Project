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
    internal class RetrieveRacesDataDelegate : DataReaderDelegate<IReadOnlyList<Race>>
    {
        public RetrieveRacesDataDelegate()
            : base("Race.RetrieveRaces")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Race> Translate(SqlCommand command, IDataRowReader reader)
        {
            var races = new List<Race>();

            while (reader.Read())
            {
                races.Add(new Race(
                    reader.GetInt32("CreatorId"),
                    reader.GetInt32("LocationId"),
                    reader.GetValue<DateTime>("DateTime"),
                    reader.GetInt32("Distance")));
            }

            return races;
        }
    }
}
