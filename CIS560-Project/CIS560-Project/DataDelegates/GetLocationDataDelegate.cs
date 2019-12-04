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
    internal class GetLocationDataDelegate : DataReaderDelegate<Location>
    {
        private readonly int locationId;

        public GetLocationDataDelegate(int locationId)
            : base("CrossCountry.GetLocation")
        {
            this.locationId = locationId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("LocationId", locationId);
        }

        public override Location Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Location(
                locationId,
                reader.GetString("Name"),
                reader.GetString("City"),
                reader.GetString("StateProv")
                );
        }
    }
}
