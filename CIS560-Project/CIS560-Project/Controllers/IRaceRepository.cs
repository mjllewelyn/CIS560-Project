using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    interface IRaceRepository
    {
        IReadOnlyList<RaceCoachView> RetrieveRaces();

        Race GetRace(int raceId);

        IReadOnlyList<RaceSummaryObject> GetRaceSummary(int raceId);

        void CreateRace(int locationId, DateTime dateTime, int distance, int isArchived = 0);

        void ArchiveRace(int raceId);
    }
}
