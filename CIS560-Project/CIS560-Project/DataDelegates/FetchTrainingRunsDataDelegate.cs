using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using CIS560_Project.Models;

namespace CIS560_Project.DataDelegates
{
    internal class FetchTrainingRunsDataDelegate : DataReaderDelegate<IReadOnlyList<TrainingRun>>
    {
        private readonly int runnerId;

        public FetchTrainingRunsDataDelegate(int runnerId)
            : base("CrossCountry.FetchTrainingRuns")
        {
            this.runnerId = runnerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
        }

        public override IReadOnlyList<TrainingRun> Translate(SqlCommand command, IDataRowReader reader)
        {
            var trainingRuns = new List<TrainingRun>();

            while (reader.Read())
            {
                trainingRuns.Add(new TrainingRun(
                    reader.GetInt32("TrainingRunId"),
                    runnerId,
                    reader.GetValue<DateTime>("Date"),
                    reader.GetInt32("Distance"),
                    reader.GetInt32("Time"),
                    reader.GetValue<double>("AverageHeartRate"),
                    reader.GetValue<bool>("isArchived")));
            }

            return trainingRuns;
        }
    }
}
