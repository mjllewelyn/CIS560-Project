using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    public class RaceForRunner
    {
        public string LocationName { get; }
        public DateTime DateAndTime { get; }
        public int Distance { get; }
        public string Time { get; }
        public int AverageHeartRate { get; }

        public RaceForRunner (string name, DateTime dateTime, int distance, int time, int averageHeartRate)
        {
            LocationName = name;
            DateAndTime = dateTime;
            Distance = distance;
            Time = Program.GetTimeString(time);
            AverageHeartRate = averageHeartRate;
        }
    }
}
