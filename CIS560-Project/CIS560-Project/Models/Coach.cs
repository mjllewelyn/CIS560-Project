using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Coach : User
    {
        public DateTime StartYear { get; }
        public DateTime EndYear { get; set; }

        public Coach() { }

        public Coach(DateTime startYear)
        {
            StartYear = startYear;
        }
    }
}
