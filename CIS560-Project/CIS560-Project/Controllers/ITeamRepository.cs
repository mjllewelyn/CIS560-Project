using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    interface ITeamRepository
    {
        IReadOnlyList<Team> RetrieveTeams();

        Team GetTeam(int teamId);

        Team FetchTeam(string name);

        Team CreateTeam(string name, int coachId, DateTime createdOn, DateTime updatedOn, int startYear, int endYear);
    }
}
