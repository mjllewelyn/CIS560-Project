using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    interface IRaceParticipantRepository
    {
        IReadOnlyList<RaceParticipant> RetrieveRaceParticipants();

        RaceParticipant GetRaceParticipant(int raceParticipantId);

        RaceParticipant FetchRaceParticipant(int raceId);

        RaceParticipant FetchRaceRunner(int runnerId);

        RaceParticipant CreateRaceParticipant(int raceId, int runnerId, double time = 0.0, double averageHeartRate = 0.0);
    }
}
