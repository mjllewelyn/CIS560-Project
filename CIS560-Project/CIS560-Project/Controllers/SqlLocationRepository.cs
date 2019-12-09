using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;
using CIS560_Project.DataDelegates;

namespace CIS560_Project.Controllers
{
    class SqlLocationRepository : ILocationRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlLocationRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Location> FetchLocations()
        {
            var d = new FetchLocationsDataDelegate();
            return executor.ExecuteReader(d);
        }

        public Location GetLocation(int locationId)
        {
            var d = new GetLocationDataDelegate(locationId);
            return executor.ExecuteReader(d);
        }

        public int GetLocationIdFromName(string name)
        {
            var d = new GetLocationIdFromNameDataDelegate(name);
            return executor.ExecuteReader(d);
        }
    }
}
