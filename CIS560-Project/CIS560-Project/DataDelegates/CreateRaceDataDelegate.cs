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
    internal class CreateRaceDataDelegate : NonQueryDataDelegate<Race>
    {
        public readonly int creatorId;
        public readonly int locationId;
        public readonly DateTime dateTime;
        public readonly int distance;
        public readonly bool isArchived;

        public CreateRaceDataDelegate(int creatorId, int locationId, DateTime dateTime, int distance, bool isArchived)
            : base("CrossCountry.CreateRace")
        {
            this.creatorId = creatorId;
            this.locationId = locationId;
            this.dateTime = dateTime;
            this.distance = distance;
            this.isArchived = isArchived;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CreatorId", creatorId);
            command.Parameters.AddWithValue("LocationId", locationId);
            command.Parameters.AddWithValue("DateTime", dateTime);
            command.Parameters.AddWithValue("Distance", distance);
            command.Parameters.AddWithValue("IsArchived", isArchived);

            var t = command.Parameters.Add("RaceId", SqlDbType.Int);
            t.Direction = ParameterDirection.Output;
        }

        public override Race Translate(SqlCommand command)
        {
            return new Race((int)command.Parameters["RaceId"].Value, creatorId, locationId, dateTime, distance, isArchived);
        }
    }
}
