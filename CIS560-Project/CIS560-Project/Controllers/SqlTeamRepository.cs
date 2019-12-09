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
    class SqlTeamRepository : ITeamRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTeamRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Team GetTeam(int teamId)
        {
            var d = new GetTeamDataDelegate(teamId);
            return executor.ExecuteReader(d);
        }

        public Team FetchTeam(string name)
        {
            var d = new FetchTeamDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Team> FetchCoachTeams(int coachId)
        {
            var d = new FetchCoachTeamsDataDelegate(coachId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Team> GetTeamsForRace(int raceId)
        {
            var d = new GetTeamsForRaceDataDelegate(raceId);
            return executor.ExecuteReader(d);
        }

        public void CreateTeam(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            var d = new CreateTeamDataDelegate(name);
            executor.ExecuteNonQuery(d);
        }

        public void RetireTeam(int teamId)
        {
            if (string.IsNullOrWhiteSpace(teamId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(teamId));

            var d = new RetireTeamDataDelegate(teamId);
            executor.ExecuteNonQuery(d);
        }
    }
}
