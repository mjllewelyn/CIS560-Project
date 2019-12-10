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
    internal class GetRunnerSummaryDataDelegate : DataReaderDelegate<RunnerSummary>
    {
        private readonly int runnerId;

        public GetRunnerSummaryDataDelegate(int runnerId)
            : base("CrossCountry.GetRunnerSummary")
        {
            this.runnerId = runnerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
        }

        public override RunnerSummary Translate(SqlCommand command, IDataRowReader reader)
        {

            if (reader.Read())
            {
                return new RunnerSummary(
                        reader.GetInt32("AverageDistance"),
                        reader.GetInt32("AverageTime"));
            }
            else
            {
                return null;
            }
        }
    }
}
