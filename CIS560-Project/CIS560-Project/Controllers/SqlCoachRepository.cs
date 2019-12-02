using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    class SqlCoachRepository : ICoachRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlCoachRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Coach GetCoach(int coachId)
        {
            var d = new GetCoachDataDelegate(coachId);
            return executor.ExecuteReader(d);
        }
    }
}
