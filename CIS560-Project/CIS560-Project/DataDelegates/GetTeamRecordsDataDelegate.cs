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
    internal class GetTeamRecordsDataDelegate : DataReaderDelegate<RaceRecord>
    {
        private readonly int runnerId;

        public GetTeamRecordsDataDelegate(int runnerId)
            : base("CrossCountry.GetRunnersRecord")
        {
            this.runnerId = runnerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
        }

        public override RaceRecord Translate(SqlCommand command, IDataRowReader reader)
        {

            if (reader.Read())
            {
                return new RaceRecord(
                        reader.GetString("Name"),
                        reader.GetInt32("Time"),
                        reader.GetInt32("Distance"),
                        reader.GetValue<DateTime>("Date"),
                        reader.GetString("LocationName"));
            }
            else
            {
                return null;
            }
        }
    }
}
