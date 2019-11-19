using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class Location
    {
        public int LocationId { get; }
        public string Name { get; }
        public string City { get; }
        public string StateProv { get; }

        public Location() { }

        public Location(int locationId, string name, string city, string stateProv)
        {
            LocationId = locationId;
            Name = name;
            City = city;
            StateProv = stateProv;
        }
    }
}
