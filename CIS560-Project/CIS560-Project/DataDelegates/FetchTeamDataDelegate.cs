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
    internal class FetchTeamDataDelegate : DataReaderDelegate<Team>
    {
        private readonly string name;
        public FetchTeamDataDelegate(string name)
            : base("CrossCountry.FetchTeam")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Team Translate(SqlCommand command, IDataRowReader reader)
        {
            int EndYear = 0;
            if (reader.Read())
            {
                if (!reader.IsDbNull("EndYear"))
                {
                    EndYear = reader.GetInt32("EndYear");
                }
                return new Team(
                        reader.GetInt32("TeamId"),
                        reader.GetInt32("CoachId"),
                        name,
                        reader.GetInt32("StartYear"),
                        EndYear,
                        reader.GetValue<DateTimeOffset>("CreatedOn"),
                        reader.GetValue<DateTimeOffset>("UpdatedOn")
                        );
            } else
            {
                return null;
            }
        }
    }
}
