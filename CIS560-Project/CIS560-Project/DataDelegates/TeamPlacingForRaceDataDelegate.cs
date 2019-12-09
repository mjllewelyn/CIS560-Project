using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using DataAccess;
using System.Data.SqlClient;

namespace CIS560_Project.DataDelegates
{
    class TeamPlacingForRaceDataDelegate : DataReaderDelegate<IReadOnlyList<TeamPlacing>>
    {
        private readonly int teamId;

        public TeamPlacingForRaceDataDelegate(int teamId)
            : base("CrossCountry.TeamPlacingForRace")
        {
            this.teamId = teamId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceId", teamId);
        }

        public override IReadOnlyList<TeamPlacing> Translate(SqlCommand command, IDataRowReader reader)
        {
            var raceParticipants = new List<TeamPlacing>();

            while (reader.Read())
            {
                raceParticipants.Add(new TeamPlacing(
                    reader.GetString("Name"),
                    reader.GetInt32("AverageTime")));
            }

            return raceParticipants;
        }
    }
}
