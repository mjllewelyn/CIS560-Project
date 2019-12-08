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

        IReadOnlyList<RaceParticipant> FetchRunnersForRace(int raceId);

        IReadOnlyList<RaceForRunner> FetchRacesForRunner(int runnerId);

        IReadOnlyList<RaceParticipant> GetTeamRecords(int teamId);

        void UpdateRaceParticipantTime(int raceParticipantId, int time);

        RaceParticipant CreateRaceParticipant(int raceId, int runnerId, int time = 0, int averageHeartRate = 0);
    }
}
