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
    internal class RetrieveRacesDataDelegate : DataReaderDelegate<IReadOnlyList<RaceCoachView>>
    {
        public RetrieveRacesDataDelegate()
            : base("CrossCountry.RetrieveRaces")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<RaceCoachView> Translate(SqlCommand command, IDataRowReader reader)
        {
            var races = new List<RaceCoachView>();

            while (reader.Read())
            {
                races.Add(new RaceCoachView(
                    reader.GetInt32("RaceId"),
                    reader.GetString("CreatorName"),
                    reader.GetString("LocationName"),
                    reader.GetValue<DateTime>("DateTime"),
                    reader.GetInt32("Distance")));
            }

            return races;
        }
    }
}
