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
    internal class FetchCoachTeamsDataDelegate : DataReaderDelegate<IReadOnlyList<Team>>
    {
        private readonly int coachId;

        public FetchCoachTeamsDataDelegate(int coachId)
            : base("CrossCountry.FetchCoachTeams")
        {
            this.coachId = coachId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CoachId", coachId);
        }

        public override IReadOnlyList<Team> Translate(SqlCommand command, IDataRowReader reader)
        {
            var teams = new List<Team>();

            while (reader.Read())
            {
                teams.Add(new Team(
                    reader.GetInt32("TeamId"),
                    reader.GetString("Name"),
                    coachId,
                    reader.GetValue<DateTime>("CreatedOn"),
                    reader.GetValue<DateTime>("UpdatedOn"),
                    reader.GetInt32("StartYear"),
                    reader.GetInt32("EndYear")));
            }

            return teams;
        }
    }
}
