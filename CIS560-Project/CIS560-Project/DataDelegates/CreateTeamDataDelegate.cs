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
    internal class CreateTeamDataDelegate : DataDelegate
    {
        public readonly string name;
        public readonly int coachId;

        public CreateTeamDataDelegate(string name)
            : base("CrossCountry.CreateTeam")
        {
            this.name = name;
            coachId = Program.currentUser.UserId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("CoachId", coachId);
        }
    }
}
