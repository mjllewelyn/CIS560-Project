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
        public DateTimeOffset CreatedOn { get; }
        public DateTimeOffset UpdatedOn { get; }
        public int StartYear { get; }
        public int EndYear { get; }

        public Team() { }

        public Team(int teamId, int coachId, string name, int startYear, int endYear, DateTimeOffset createdOn, DateTimeOffset updatedOn)
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
