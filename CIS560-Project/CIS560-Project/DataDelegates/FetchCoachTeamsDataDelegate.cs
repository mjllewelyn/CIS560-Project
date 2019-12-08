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
            if (!reader.Read())
                return null;
            do
            {
                int EndYear = 0;
                if (!reader.IsDbNull("EndYear"))
                    EndYear = reader.GetInt32("EndYear");
                teams.Add(new Team(
                    reader.GetInt32("TeamId"),
                    coachId,
                    reader.GetString("Name"),
                    reader.GetInt32("StartYear"),
                    EndYear,
                    reader.GetValue<DateTimeOffset>("CreatedOn"),
                    reader.GetValue<DateTimeOffset>("UpdatedOn")
                    ));
            } while (reader.Read());

            return teams;
        }
    }
}
