using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Race
    {
        public int RaceId { get; }
        public int CreatorId { get; }
        public int LocationId { get; }
        public DateTime DateTime { get; }
        public int Distance { get; }
        public bool IsArchived { get; set; }
        public int ChangeInElevation { get; set; }

        public Race() { }

        public Race(int raceId, int creatorId, int locationId, DateTime dateTime, int distance)
        {
            RaceId = raceId;
            CreatorId = creatorId;
            LocationId = locationId;
            DateTime = dateTime;
            Distance = distance;
        }
    }
}
