using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Team
    {
        public int TeamId { get; }
        public string Name { get; }
        public int CoachId { get; }
        public DateTime CreatedOn { get; }
        public DateTime UpdatedOn { get; }
        public int StartYear { get; }
        public int EndYear { get; }

        public Team() { }

        public Team(int teamId, string name, int coachId, DateTime createdOn, DateTime updatedOn, int startYear, int endYear)
        {
            TeamId = teamId;
            Name = name;
            CoachId = coachId;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            StartYear = startYear;
            EndYear = endYear;
        }

    }
}
