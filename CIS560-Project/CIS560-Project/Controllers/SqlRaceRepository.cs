using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    class SqlRaceRepository : IRaceRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlRaceRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Race> RetrieveRaces()
        {
            return executor.ExecuteReader(new RetrieveRacesDataDelegate());
        }

        public Race GetRace(int raceId)
        {
            var d = new GetRaceDataDelegate(raceId);
            return executor.ExecuteReader(d);
        }

        public Race FetchRace(int locationId)
        {
            var d = new FetchRaceDataDelegate(locationId);
            return executor.ExecuteReader(d);
        }

        public Race CreateRace(int creatorId, int locationId, DateTime dateTime, int distance, bool isArchived = false)
        {
            if (string.IsNullOrWhiteSpace(creatorId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(creatorId));

            if (string.IsNullOrWhiteSpace(locationId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(locationId));

            if (string.IsNullOrWhiteSpace(dateTime.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(dateTime));

            if (string.IsNullOrWhiteSpace(distance.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(distance));

            var d = new CreateRaceDataDelegate(creatorId, locationId, dateTime, distance, isArchived);
            return executor.ExecuteNonQuery(d);
        }

        public Race ArchiveRace(int raceId)
        {
            var d = new ArchiveRaceDataDelegate(raceId);
            return executor.ExecuteNonQuery(d);
        }
    }
}
