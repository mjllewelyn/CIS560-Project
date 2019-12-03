using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    internal class GetCoachDataDelegate : DataReaderDelegate<Coach>
    {
        private readonly int coachId;

        public GetCoachDataDelegate(int coachId)
            : base("Coach.GetCoach")
        {
            this.coachId = coachId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CoachId", coachId);
        }

        public override Coach Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Coach(
                coachId,
                reader.GetInt32("StartYear"),
                reader.GetInt32("EndYear")
                );
        }
    }
}
