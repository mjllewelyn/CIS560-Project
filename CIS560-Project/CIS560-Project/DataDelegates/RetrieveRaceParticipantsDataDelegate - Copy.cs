using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;
using DataAccess;

namespace CIS560_Project.DataDelegates
{
    internal class RetrieveRaceParticipantsDataDelegate : DataReaderDelegate<RaceParticipant>
    {
        public RetrieveRaceParticipantsDataDelegate()
            : base("RaceParticipant.RetrieveRaceParticipants")
        {

        }
        public override RaceParticipant Translate(SqlCommand command, IDataRowReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
