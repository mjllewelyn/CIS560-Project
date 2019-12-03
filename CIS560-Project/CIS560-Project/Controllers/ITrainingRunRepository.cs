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

        TrainingRun CreateTrainingRun(int runnerId, DateTime date, int distance, double time, double averageHeartRate = 0.0, bool isArchived = false);
    }
}
