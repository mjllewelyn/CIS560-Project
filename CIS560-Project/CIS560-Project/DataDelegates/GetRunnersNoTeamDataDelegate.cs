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
    internal class GetRunnersNoTeamDataDelegate : DataReaderDelegate<IReadOnlyList<Runner>>
    {
        public GetRunnersNoTeamDataDelegate()
            : base("CrossCountry.GetRunnersNoTeam")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Runner> Translate(SqlCommand command, IDataRowReader reader)
        {
            var runners = new List<Runner>();

            while (reader.Read())
            {
                runners.Add(new Runner(
                    reader.GetInt32("RunnerId"),
                    reader.GetInt32("TeamId"),
                    reader.GetInt32("StartYear"),
                    reader.GetInt32("EndYear")));
            }

            return runners;
        }
    }
}
