using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project.Models
{
    class User
    {
        public int UserId { get; }
        public string Email { get; }
        public string PasswordHash { get => encryptPassword(PasswordHash, false); set => encryptPassword(PasswordHash, true);  }
        public string UserType { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime CreatedOn { get; }
        public DateTime UpdatedOn { get; set; }

        public User() { }

        public User(int userId, string email, string password, string userType, string firstName, string lastName)
        {
            UserId = userId;
            Email = email;
            PasswordHash = password;
            UserType = userType;
            FirstName = firstName;
            LastName = lastName;
        }

        private string encryptPassword(string password, bool encrypt)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                if (encrypt)
                    sb.Append(password[i] + 10);
                else
                    sb.Append(password[i] - 10);
            }
            return sb.ToString();
        }
    }
}
