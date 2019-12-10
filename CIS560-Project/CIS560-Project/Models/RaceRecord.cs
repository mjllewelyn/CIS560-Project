using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class RaceRecord
    {
        public string runnerName { get; }
        public string time { get; }
        public int distance { get; }
        public DateTime date { get; }
        public string locationName { get; }

    public RaceRecord(string runnerName, int time, int distance, DateTime date, string locationName)
        {
            this.runnerName = runnerName;
            this.time = Program.GetTimeString(time);
            this.distance = distance;
            this.date = date;
            this.locationName = locationName;
        }
    }
}
