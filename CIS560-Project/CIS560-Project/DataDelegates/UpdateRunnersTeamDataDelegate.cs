using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CIS560_Project.Models;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    class UpdateRunnersTeamDataDelegate : DataDelegate
    {
        public readonly int runnerId;
        public readonly int teamId;

        public UpdateRunnersTeamDataDelegate(int runnerId, int teamId)
            : base("CrossCountry.UpdateRunnersTeam")
        {
            this.runnerId = runnerId;
            this.teamId = teamId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RunnerId", runnerId);
            command.Parameters.AddWithValue("TeamId", teamId);
        }
    }
}
