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
    internal class GetTeamRunnersDataDelegate : DataReaderDelegate<IReadOnlyList<Runner>>
    {
        private readonly int teamId;
        public GetTeamRunnersDataDelegate(int teamId)
            : base("CrossCountry.GetTeamRunners")
        {
            this.teamId = teamId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TeamId", teamId);
        }

        public override IReadOnlyList<Runner> Translate(SqlCommand command, IDataRowReader reader)
        {
            var runners = new List<Runner>();

            while (reader.Read())
            {
                int endYear = 0;
                if (!reader.IsDbNull("EndYear"))
                    endYear = reader.GetInt32("EndYear");
                runners.Add(new Runner(
                    reader.GetInt32("RunnerId"),
                    teamId,
                    reader.GetInt32("StartYear"),
                    endYear));
            }

            return runners;
        }
    }
}
