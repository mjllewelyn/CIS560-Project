using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_Project.Models;

namespace CIS560_Project
{
    
    static class Program
    {
        static public User currentUser = new User();
        public const string connectionString = @"Server=DESKTOP-FI4BV8L\MSSQLSERVER2;Database=master;Integrated Security=SSPI;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new uxSignIn());
            User curentUser = new User();
        }

        public static void GoHome(Form f)
        {
            f.Hide();
            if (currentUser.UserType == 1)
            {
                var homepage = new uxRunnerHomePage();
                homepage.Closed += (s, args) => f.Close();
                homepage.Show();
            }
            else
            {
                var homepage = new CoachWelcome();
                homepage.Closed += (s, args) => f.Close();
                homepage.Show();
            }
        }

        public static string GetTimeString(int time)
        {
            int hours = time / 3600;
            time -= hours * 3600;
            int mins = time / 60;
            time -= mins * 60; //time now = secs
            string str = "";
            if (hours > 0)
                str += hours + " hrs ";
            return str + mins + " mins " + time + " secs";
        }
    }
}
