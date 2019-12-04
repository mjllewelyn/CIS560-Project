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
    internal class RetireTeamDataDelegate : DataDelegate
    {
        public readonly int teamId;

        public RetireTeamDataDelegate(int teamId)
            : base("CrossCountry.RetireTeam")
        {
            this.teamId = teamId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TeamId", teamId);
        }
    }
}
