using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class RaceRecord
    {
        public string raceName;
        public int time, distance;
        public DateTime date;
        public string locationName;

        public RaceRecord(string raceName, int time, int distance, DateTime date, string locationName)
        {
            this.raceName = raceName;
            this.time = time;
            this.distance = distance;
            this.date = date;
            this.locationName = locationName;
        }
    }
}
