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
    internal class GetRunnerDataDelegate : DataReaderDelegate<Runner>
    {
        private readonly int runnerId;
        public GetRunnerDataDelegate(int runnerId)
            : base("CrossCountry.GetRunner")
        {
            this.runnerId = runnerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
        }

        public override Runner Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            int endYear = 0;
            if (!reader.IsDbNull("EndYear"))
                endYear = reader.GetInt32("EndYear");
            
            return new Runner(
                    runnerId,
                    reader.GetInt32("TeamId"),
                    reader.GetInt32("StartYear"),
                    endYear);
        }
    }
}
