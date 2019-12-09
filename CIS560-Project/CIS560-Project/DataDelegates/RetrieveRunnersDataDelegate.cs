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
    internal class RetrieveRunnersDataDelegate : DataReaderDelegate<IReadOnlyList<Runner>>
    {
        public RetrieveRunnersDataDelegate()
            : base("CrossCountry.RetrieveRunners")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<Runner> Translate(SqlCommand command, IDataRowReader reader)
        {
            var runners = new List<Runner>();
            if (!reader.Read())
                return null;
            do
            {
                int EndYear = 0;
                if (!reader.IsDbNull("EndYear"))
                    EndYear = reader.GetInt32("EndYear");
                runners.Add(new Runner(
                    reader.GetInt32("RunnerId"),
                    reader.GetInt32("TeamId"),
                    reader.GetInt32("StartYear"),
                    EndYear));
            } while (reader.Read());

            return runners;
        }
    }
}
