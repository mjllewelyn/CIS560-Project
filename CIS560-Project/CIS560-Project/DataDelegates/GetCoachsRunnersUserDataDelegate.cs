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
    internal class GetCoachsRunnersUserDataDelegate : DataReaderDelegate<IReadOnlyList<User>>
    {
        private readonly int coachId;

        public GetCoachsRunnersUserDataDelegate(int coachId)
            : base("CrossCountry.GetTeamsForRace")
        {
            this.coachId = coachId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CoachId", coachId);
        }

        public override IReadOnlyList<User> Translate(SqlCommand command, IDataRowReader reader)
        {
            var users = new List<User>();

            while (reader.Read())
            {
                users.Add(new User(
                    reader.GetInt32("UserId"),
                    reader.GetString("Email"),
                    reader.GetString("PassHash"),
                    reader.GetInt32("UserType"),
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetValue<DateTime>("CreatedOn"),
                    reader.GetValue<DateTime>("UpdatedOn")));
            }

            return users;
        }
    }
}
