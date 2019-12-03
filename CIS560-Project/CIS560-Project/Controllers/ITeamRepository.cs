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
        Team GetTeam(int teamId);

        IReadOnlyList<Team> FetchCoachTeams(int coachId);

        IReadOnlyList<Team> GetTeamsForRace(int raceId);

        Team CreateTeam(string name, int coachId, DateTime createdOn, DateTime updatedOn, int startYear, int endYear);

        Team RetireTeam(int teamId);
    }
}
