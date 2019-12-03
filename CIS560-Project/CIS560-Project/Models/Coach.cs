using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Coach : User
    {
        public int CoachId { get; }
        public int StartYear { get; }
        public int EndYear { get; }

        public Coach() { }

        public Coach(int coachId, int startYear, int endYear)
        {
            CoachId = coachId;
            StartYear = startYear;
            EndYear = endYear;
        }
    }
}
