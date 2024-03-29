﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using CIS560_Project.Models;
using CIS560_Project.DataDelegates;

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

        public bool ValidateUser(string email, string password)
        {
            var d = new ValidateUserDataDelegate(email, password);
            return executor.ExecuteReader(d);
        }

        public void RetireUser(int userId)
        {
            var d = new RetireUserDataDelegate(userId);
            executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<User> GetCoachsRunnersUser(int coachId)
        {
            var d = new GetCoachsRunnersUserDataDelegate(coachId);
            return executor.ExecuteReader(d);
        }
    }
}
