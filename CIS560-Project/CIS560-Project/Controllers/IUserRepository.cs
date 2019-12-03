using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_Project.Models;

namespace CIS560_Project.Controllers
{
    interface IUserRepository
    {
        User GetUser(string email);

        bool ValidateUser(string email, string password);

        User RetireUser(int userId);

        IReadOnlyList<User> GetCoachsRunnersUser(int coachId);
    }
}
