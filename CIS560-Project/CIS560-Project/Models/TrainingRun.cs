using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class TrainingRun
    {
        public int TrainingRunId { get; }
        public int RunnerId { get; }
        public DateTime Date { get; }
        public int Distance { get; }
        public TimeSpan Time { get; }
        public double AverageHeartRate { get; set; }
        public int ChangeInElevation { get; set; }
        public bool IsArchived { get; set; }


        public TrainingRun() { }

        public TrainingRun(int trainingRunId, int runnerId, DateTime date, int distance, TimeSpan time)
        {
            TrainingRunId = trainingRunId;
            RunnerId = runnerId;
            Date = date;
            Distance = distance;
            Time = time;
        }
    }
}
