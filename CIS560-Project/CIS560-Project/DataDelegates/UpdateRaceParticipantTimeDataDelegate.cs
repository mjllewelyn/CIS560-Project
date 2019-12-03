using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using DataAccess;
using System.Data.SqlClient;

namespace CIS560_Project.DataDelegates
{
    class UpdateRaceParticipantTimeDataDelegate : DataDelegate
    {
        private readonly int raceParticipantId;
        private readonly int time;

        public UpdateRaceParticipantTimeDataDelegate(int raceParticipantId, int time)
            : base ("RaceParticipant.UpdateRaceParticipantTime")
        {
            this.raceParticipantId = raceParticipantId;
            this.time = time;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("RaceParticipantId", raceParticipantId);
            command.Parameters.AddWithValue("Time", time);
        }
    }
}
