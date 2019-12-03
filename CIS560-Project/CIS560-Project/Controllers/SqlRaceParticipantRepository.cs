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
    class SqlRaceParticipantRepository : IRaceParticipantRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlRaceParticipantRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public RaceParticipant GetRaceParticipant(int raceParticipantId)
        {
            var d = new GetRaceParticipantDataDelegate(raceParticipantId);
            return executor.ExecuteReader(d);
        }

        public List<RaceParticipant> FetchRunnersForRace(int raceId)
        {
            var d = new FetchRunnersForRaceDataDelegate(raceId);
            return executor.ExecuteReader(d);
        }

        public List<RaceParticipant> FetchRacesForRunner(int runnerId)
        {
            var d = new FetchRacesForRunnerDataDelegate(runnerId);
            return executor.ExecuteReader(d);
        }

        public List<RaceParticipant> GetTeamRecords(int teamId)
        {
            var d = new GetTeamRecordsDataDelegate(teamId);
            return executor.ExecuteReader(d);
        }

        public RaceParticipant UpdateRaceParticipantTime(int raceId, int runnerId, int time)
        {
            var d = new UpdateRaceParticipantTimeDataDelegate(raceId, runnerId, time);
            return executor.ExecuteNonQuery(d);
        }

        public List<RaceParticipant> CreateRaceParticipants(List<Runner> runners, int raceId)
        {
            List<RaceParticipant> participants = new List<RaceParticipant>();
            foreach(Runner r in runners)
            {
                participants.Add(CreateRaceParticipant(raceId, r.UserId));
            }
            return participants;
        }

        public RaceParticipant CreateRaceParticipant(int raceId, int runnerId, int time = 0, double averageHeartRate = 0.0)
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
