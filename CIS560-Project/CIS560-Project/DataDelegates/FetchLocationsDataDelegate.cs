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
    class FetchLocationsDataDelegate : DataReaderDelegate<IReadOnlyList<Location>>
    {
        public FetchLocationsDataDelegate()
            : base("CrossCountry.FetchLocations")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Location> Translate(SqlCommand command, IDataRowReader reader)
        {
            var locations = new List<Location>();

            while (reader.Read())
            {
                locations.Add(new Location(
                    reader.GetInt32("LocationId"),
                    reader.GetString("Name"),
                    reader.GetString("City"),
                    reader.GetString("StateProvince")));
            }

            return locations;
        }
    }
}
