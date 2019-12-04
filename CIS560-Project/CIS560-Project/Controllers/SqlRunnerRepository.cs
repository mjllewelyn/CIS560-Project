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
    class SqlRunnerRepository : IRunnerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlRunnerRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Runner> RetrieveRunners()
        {
            return executor.ExecuteReader(new RetrieveRunnersDataDelegate());
        }

        public Runner GetRunner(int runnerId)
        {
            var d = new GetRunnerDataDelegate(runnerId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Runner> GetTeamRunners(int teamId)
        {
            var d = new GetTeamRunnersDataDelegate(teamId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Runner> GetRunnersNoTeam()
        {
            var d = new GetRunnersNoTeamDataDelegate();
            return executor.ExecuteReader(d);
        }
    }
}
