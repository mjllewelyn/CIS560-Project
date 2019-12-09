using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using System.Data.SqlClient;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    class RetrieveRunnerNamesAndTeamsDataDelegate : DataReaderDelegate<IReadOnlyList<RunnerNameAndTeam>>
    {
        public RetrieveRunnerNamesAndTeamsDataDelegate()
            : base("CrossCountry.RetrieveRunnerNamesAndTeams")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<RunnerNameAndTeam> Translate(SqlCommand command, IDataRowReader reader)
        {
            var runners = new List<RunnerNameAndTeam>();
            if (!reader.Read())
                return null;
            do
            {
                int EndYear = 0;
                if (!reader.IsDbNull("EndYear"))
                    EndYear = reader.GetInt32("EndYear");
                runners.Add(new RunnerNameAndTeam(
                    reader.GetString("RunnerName"),
                    reader.GetString("TeamName"),
                    reader.GetInt32("StartYear"),
                    EndYear));
            } while (reader.Read());

            return runners;
        }
    }
}
