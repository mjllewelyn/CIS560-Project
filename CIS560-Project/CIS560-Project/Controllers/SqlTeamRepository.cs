﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    class SqlTeamRepository : ITeamRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTeamRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Team GetTeam(int teamId)
        {
            var d = new GetTeamDataDelegate(teamId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Team> FetchCoachTeams(int coachId)
        {
            var d = new FetchCoachTeamsDataDelegate(coachId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Team> GetTeamsForRace(int raceId)
        {
            var d = new GetTeamsForRaceDataDelegate(raceId);
            return executor.ExecuteReader(d);
        }

        public Team CreateTeam(string name, int coachId, DateTime createdOn, DateTime updatedOn, int startYear, int endYear)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(coachId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(coachId));

            if (string.IsNullOrWhiteSpace(createdOn.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(createdOn));

            if (string.IsNullOrWhiteSpace(updatedOn.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(updatedOn));

            if (string.IsNullOrWhiteSpace(startYear.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(startYear));

            if (string.IsNullOrWhiteSpace(endYear.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(endYear));

            var d = new CreateTeamDataDelegate(name, coachId, createdOn, updatedOn, startYear, endYear);
            return executor.ExecuteNonQuery(d);
        }

        public Team RetireTeam(int teamId)
        {
            if (string.IsNullOrWhiteSpace(teamId.ToString()))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(teamId));

            var d = new RetireTeamDataDelegate(teamId);
            return executor.ExecuteNonQuery(d);
        }
    }
}
