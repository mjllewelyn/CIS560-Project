using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    interface IRunnerRepository
    {
        IReadOnlyList<Runner> RetrieveRunners();

        IReadOnlyList<RunnerNameAndTeam> RetrieveRunnerNamesAndTeams();

        Runner GetRunner(int runnerId);

        IReadOnlyList<Runner> GetTeamRunners(int teamId);

        IReadOnlyList<Runner> GetRunnersNoTeam();

        RunnerSummary GetRunnerSummary(int runnerId);
    }
}
