using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    class SqlRunnerRepository : IRunnerRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlRunnerRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Runner GetRunner(int runnerId)
        {
            var d = new GetRunnerDataDelegate(runnerId);
            return executor.ExecuteReader(d);
        }
    }
}
