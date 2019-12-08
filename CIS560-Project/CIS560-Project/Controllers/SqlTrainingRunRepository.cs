using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;
using CIS560_Project.DataDelegates;

namespace CIS560_Project.Controllers
{
    class SqlTrainingRunRepository : ITrainingRunRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTrainingRunRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public TrainingRun GetTrainingRun(int trainingRunId)
        {
            var d = new GetTrainingRunDataDelegate(trainingRunId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<TrainingRun> FetchTrainingRuns(int runnerId)
        {
            var d = new FetchTrainingRunsDataDelegate(runnerId);
            return executor.ExecuteReader(d);
        }

        public void CreateTrainingRun(int runnerId, DateTime date, int distance, int time, int averageHeartRate = 0, int isArchived = 0)
        {
            if (string.IsNullOrWhiteSpace(runnerId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(runnerId));

            if (string.IsNullOrWhiteSpace(date.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(date));

            if (string.IsNullOrWhiteSpace(distance.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(distance));

            if (string.IsNullOrWhiteSpace(time.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(time));

            var d = new CreateTrainingRunDataDelegate(date, distance, time, averageHeartRate, isArchived);
            executor.ExecuteNonQuery(d);
        }
    }
}
