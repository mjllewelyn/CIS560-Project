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
        IReadOnlyList<Race> RetrieveRaces();

        Race GetRace(int raceId);

        Race FetchRace(int locationId);

        Race CreateRace(int creatorId, int locationId, DateTime dateTime, int distance, bool isArchived = false);
    }
}
