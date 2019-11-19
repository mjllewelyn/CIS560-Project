using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CIS560_Project.DataDelegates
{
    internal class CreateTrainingRunDataDelegate : NonQueryDataDelegate<TrainingRun>
    {
        public readonly string date;
        public readonly string distance;
        public readonly string time;
        public readonly string averageHR;

        public CreateTrainingRunDataDelegate(string date, string distance, string time, string averageHR)
            : base("TrainingRun.CreateTrainingRun")
        {
            this.date = date;
            this.distance = distance;
            this.time = time;
            this.averageHR = averageHR;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Distance", distance);
            command.Parameters.AddWithValue("Time", time);
            command.Parameters.AddWithValue("AverageHR", averageHR);

            var t = command.Parameters.Add("TrainingRunId", SqlDbType.Int);
            t.Direction = ParameterDirection.Output;
        }

        public override TrainingRun Translate(SqlCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
