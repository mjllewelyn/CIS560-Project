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
    internal class GetLocationIdFromNameDataDelegate : DataReaderDelegate<int>
    {
        private readonly string name;

        public GetLocationIdFromNameDataDelegate(string name)
            : base("CrossCountry.GetLocationIdFromName")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override int Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return 0;
            return reader.GetInt32("LocationId");
        }
    }
}
