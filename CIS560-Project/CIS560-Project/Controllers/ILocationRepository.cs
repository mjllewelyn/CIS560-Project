﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    interface ILocationRepository
    {
        IReadOnlyList<Location> FetchLocations();
        Location GetLocation(int locationId);
        int GetLocationIdFromName(string name);
    }
}
