using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CIS560_Project.Models;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    internal class GetTeamDataDelegate : DataReaderDelegate<Team>
    {
        private readonly int teamId;
        public GetTeamDataDelegate(int teamId)
            : base("CrossCountry.GetTeam")
        {
            this.teamId = teamId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TeamId", teamId);
        }

        public override Team Translate(SqlCommand command, IDataRowReader reader)
        {

            return new Team(
                    teamId,
                    reader.GetString("Name"),
                    reader.GetInt32("CoachId"),
                    reader.GetValue<DateTime>("CreatedOn"),
                    reader.GetValue<DateTime>("UpdatedOn"),
                    reader.GetInt32("StartYear"),
                    reader.GetInt32("EndYear"));
        }
    }
}
