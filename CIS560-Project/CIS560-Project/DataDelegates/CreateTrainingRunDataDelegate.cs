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
    internal class CreateTrainingRunDataDelegate : NonQueryDataDelegate<TrainingRun>
    {
        public readonly int runnerId;
        public readonly DateTime date;
        public readonly int distance;
        public readonly int time;
        public readonly double averageHR;

        public CreateTrainingRunDataDelegate(DateTime date, int distance, int time, double averageHR)
            : base("TrainingRun.CreateTrainingRun")
        {
            runnerId = Program.currentUser.UserId;
            this.date = date;
            this.distance = distance;
            this.time = time;
            this.averageHR = averageHR;

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
            command.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Distance", distance);
            command.Parameters.AddWithValue("Time", time);
            command.Parameters.AddWithValue("AverageHR", averageHR);

            var t = command.Parameters.Add("TrainingRunId", SqlDbType.Int);
            t.Direction = ParameterDirection.Output;
        }

        public override TrainingRun Translate(SqlCommand command)
        {
            return new TrainingRun((int)command.Parameters["TrainingRunId"].Value, runnerId, date, distance, time, averageHR);
        }
    }
}
