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
    internal class GetTrainingRunDataDelegate : DataReaderDelegate<TrainingRun>
    {
        private readonly int trainingRunId;

        public GetTrainingRunDataDelegate(int trainingRunId)
            : base("CrossCountry.GetTrainingRun")
        {
            this.trainingRunId = trainingRunId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TrainingRunId", trainingRunId);
        }

        public override TrainingRun Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new TrainingRun(
                trainingRunId,
                reader.GetInt32("RunnerId"),
                reader.GetValue<DateTime>("Date"),
                reader.GetInt32("Distance"),
                reader.GetInt32("Time"),
                reader.GetValue<int>("AverageHeartRate"),
                reader.GetValue<int>("isArchived"));
        }
    }
}
