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
    internal class ArchiveRaceDataDelegate : DataDelegate
    {
        public readonly int raceId;

        public ArchiveRaceDataDelegate(int raceId)
            : base("CrossCountry.ArchiveRace")
        {
            this.raceId = raceId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceId", raceId);
        }
    }
}
