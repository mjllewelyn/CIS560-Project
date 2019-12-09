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

        Team FetchTeam(string name);

        IReadOnlyList<Team> FetchCoachTeams(int coachId);

        IReadOnlyList<Team> GetTeamsForRace(int raceId);

        void CreateTeam(string name);

        void UpdateRunnersTeam(int runnerId, int teamId);

        void RetireTeam(int teamId);
    }
}
