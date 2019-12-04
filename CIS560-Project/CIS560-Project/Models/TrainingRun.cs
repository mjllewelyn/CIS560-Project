using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class TrainingRun
    {
        public int TrainingRunId { get; }
        public int RunnerId { get; }
        public DateTime Date { get; }
        public int Distance { get; }
        public int Time { get; }
        public double AverageHeartRate { get; }
        public bool IsArchived { get; }


        public TrainingRun() { }

        public TrainingRun(int trainingRunId, int runnerId, DateTime date, int distance, int time, double averageHeartRate=0.0, bool isArchived=false)
        {
            TrainingRunId = trainingRunId;
            RunnerId = runnerId;
            Date = date;
            Distance = distance;
            Time = time;
            AverageHeartRate = averageHeartRate;
            IsArchived = isArchived;
        }
    }
}
