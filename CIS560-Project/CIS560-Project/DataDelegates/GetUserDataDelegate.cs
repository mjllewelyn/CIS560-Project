using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.DataDelegates
{
    internal class GetUserDataDelegate : DataReaderDelegate<User>
    {
        private readonly string email;

        public GetUserDataDelegate(string email)
            : base("User.GetUser")
        {
            this.email = email;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Email", email);
        }

        public override User Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new User(
               reader.GetInt32("UserId"),
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetInt32("UserType"),
               reader.GetString("LastName"),
               email,
               DateTime.Now,
               DateTime.Now);
        }
    }
}
