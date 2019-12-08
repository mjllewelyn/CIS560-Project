using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using CIS560_Project.Models;

namespace CIS560_Project.DataDelegates
{
    internal class CreateTeamDataDelegate : NonQueryDataDelegate<Team>
    {
        public readonly string name;
        public readonly int coachId;
        public readonly DateTime createdOn;
        public readonly DateTime updatedOn;
        public readonly int startYear;
        public readonly int endYear;

        public CreateTeamDataDelegate(string name, int coachId, DateTime createdOn, DateTime updatedOn, int startYear, int endYear)
            : base("CrossCountry.CreateTeam")
        {
            this.name = name;
            this.coachId = coachId;
            this.createdOn = createdOn;
            this.updatedOn = updatedOn;
            this.startYear = startYear;
            this.endYear = endYear;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("CoachId", coachId);
            command.Parameters.AddWithValue("CreatedOn", createdOn);
            command.Parameters.AddWithValue("UpdatedOn", updatedOn);
            command.Parameters.AddWithValue("StartYear", startYear);
            command.Parameters.AddWithValue("EndYear", endYear);

            var t = command.Parameters.Add("TeamId", SqlDbType.Int);
            t.Direction = ParameterDirection.Output;
        }

        public override Team Translate(SqlCommand command)
        {
            return new Team((int)command.Parameters["TeamId"].Value, coachId, name, startYear, endYear, createdOn, updatedOn);
        }
    }
}
