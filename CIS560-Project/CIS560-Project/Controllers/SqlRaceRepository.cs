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
    class SqlRaceRepository : IRaceRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlRaceRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<RaceCoachView> RetrieveRaces()
        {
            return executor.ExecuteReader(new RetrieveRacesDataDelegate());
        }

        public Race GetRace(int raceId)
        {
            var d = new GetRaceDataDelegate(raceId);
            return executor.ExecuteReader(d);
        }

        public void CreateRace(int locationId, DateTime dateTime, int distance, int isArchived = 0)
        {
            if (string.IsNullOrWhiteSpace(locationId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(locationId));

            if (string.IsNullOrWhiteSpace(dateTime.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(dateTime));

            if (string.IsNullOrWhiteSpace(distance.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(distance));

            var d = new CreateRaceDataDelegate(locationId, dateTime, distance, isArchived);
            executor.ExecuteNonQuery(d);
        }

        public void ArchiveRace(int raceId)
        {
            var d = new ArchiveRaceDataDelegate(raceId);
            executor.ExecuteNonQuery(d);
        }
    }
}
