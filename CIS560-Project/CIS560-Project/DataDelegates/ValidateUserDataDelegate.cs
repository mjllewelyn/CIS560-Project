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
    internal class ValidateUserDataDelegate : DataReaderDelegate<bool>
    {
        public readonly string email;
        public readonly string password;

        public ValidateUserDataDelegate(string email, string password)
            : base("CrossCountry.ValidateUser")
        {
            this.email = email;
            this.password = password;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("Password", password);
        }

        public override bool Translate(SqlCommand command, IDataRowReader reader)
        {
            if (reader.Read())
                return true;
            else
                return false;
        }
    }
}
