using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    class SqlRaceParticipantRepository : IRaceParticipantRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlRaceParticipantRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<RaceParticipant> RetrieveRaceParticipants()
        {
            return executor.ExecuteReader(new RetrieveRaceParticipantsDataDelegate());
        }

        public RaceParticipant GetRaceParticipant(int raceParticipantId)
        {
            var d = new GetRaceParticipantDataDelegate(raceParticipantId);
            return executor.ExecuteReader(d);
        }

        public RaceParticipant FetchRaceParticipant(int raceId)
        {
            var d = new FetchRaceParticipantDataDelegate(raceId);
            return executor.ExecuteReader(d);
        }

        public RaceParticipant FetchRaceRunner(int runnerId)
        {
            var d = new FetchRaceRunnerDataDelegate(runnerId);
            return executor.ExecuteReader(d);
        }

        public RaceParticipant CreateRaceParticipant(int raceId, int runnerId, double time = 0.0, double averageHeartRate = 0.0)
        {
            if (string.IsNullOrWhiteSpace(raceId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(raceId));

            if (string.IsNullOrWhiteSpace(runnerId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(runnerId));

            var d = new CreateRaceParticipantDataDelegate(raceId, runnerId, time, averageHeartRate);
            return executor.ExecuteNonQuery(d);
        }
    }
}
