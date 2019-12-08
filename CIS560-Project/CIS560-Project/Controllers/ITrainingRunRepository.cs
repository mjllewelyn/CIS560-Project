using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    interface ITrainingRunRepository
    {
        TrainingRun GetTrainingRun(int trainingRunId);

        IReadOnlyList<TrainingRun> FetchTrainingRuns(int runnerId);

        void CreateTrainingRun(int runnerId, DateTime date, int distance, int time, int averageHeartRate = 0, int isArchived = 0);
    }
}
