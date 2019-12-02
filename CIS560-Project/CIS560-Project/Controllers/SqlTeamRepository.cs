using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    class SqlTeamRepository : ITeamRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTeamRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Team> RetrieveTeams()
        {
            return executor.ExecuteReader(new RetrieveTeamsDataDelegate());
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

        public Team CreateTeam(string name, int coachId, DateTime createdOn, DateTime updatedOn, int startYear, int endYear)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(coachId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(coachId));

            if (string.IsNullOrWhiteSpace(createdOn.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(createdOn));

            if (string.IsNullOrWhiteSpace(updatedOn.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(updatedOn));

            if (string.IsNullOrWhiteSpace(startYear.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(startYear));

            if (string.IsNullOrWhiteSpace(endYear.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(endYear));

            var d = new CreateTeamDataDelegate(name, coachId, createdOn, updatedOn, startYear, endYear);
            return executor.ExecuteNonQuery(d);
        }
    }
}
