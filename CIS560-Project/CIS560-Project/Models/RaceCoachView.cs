using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class RaceCoachView
    {
        public int RaceId { get; }
        public string CreatorName { get; }
        public string LocationName { get; }
        public DateTime DateTime { get; }
        public int Distance { get; }

        public RaceCoachView(int raceId, string creatorName, string locationName, DateTime dateTime, int distance)
        {
            RaceId = raceId;
            CreatorName = creatorName;
            LocationName = locationName;
            DateTime = dateTime;
            Distance = distance;
        }
    }
}
