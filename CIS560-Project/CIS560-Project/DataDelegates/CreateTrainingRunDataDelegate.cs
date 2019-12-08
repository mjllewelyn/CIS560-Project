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
    internal class CreateTrainingRunDataDelegate : DataDelegate
    {
        public readonly int runnerId;
        public readonly DateTime date;
        public readonly int distance;
        public readonly int time;
        public readonly int averageHR;
        public readonly int isArchived;

        public CreateTrainingRunDataDelegate(DateTime date, int distance, int time, int averageHR, int isArchived)
            : base("CrossCountry.CreateTrainingRun")
        {
            runnerId = Program.currentUser.UserId;
            this.date = date;
            this.distance = distance;
            this.time = time;
            this.averageHR = averageHR;
            this.isArchived = isArchived;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
            command.Parameters.AddWithValue("Date", date);
            command.Parameters.AddWithValue("Distance", distance);
            command.Parameters.AddWithValue("Time", time);
            command.Parameters.AddWithValue("AverageHeartRate", averageHR);
            command.Parameters.AddWithValue("IsArchived", isArchived);
        }
    }
}
