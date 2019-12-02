using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    class SqlUserRepository : IUserRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlUserRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public User GetUser(string email)
        {
            var d = new GetUserDataDelegate(email);
            return executor.ExecuteReader(d);
        }
    }
}
