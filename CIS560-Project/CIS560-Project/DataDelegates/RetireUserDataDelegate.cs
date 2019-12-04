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
    internal class RetireUserDataDelegate : DataDelegate
    {
        public readonly int userId;

        public RetireUserDataDelegate(int userId)
            : base("CrossCountry.RetireUser")
        {
            this.userId = userId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("UserId", userId);
        }
    }
}
