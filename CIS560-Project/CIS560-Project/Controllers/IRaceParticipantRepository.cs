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
        RaceParticipant GetRaceParticipant(int raceParticipantId);

        List<RaceParticipant> FetchRunnersForRace(int raceId);

        List<RaceParticipant> FetchRacesForRunner(int runnerId);

        RaceParticipant UpdateRaceParticipantTime(int raceId, int runnerId, int time);

        RaceParticipant CreateRaceParticipant(int raceId, int runnerId, int time = 0, double averageHeartRate = 0.0);
    }
}
