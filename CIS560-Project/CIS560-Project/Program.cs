﻿using System;
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
        public const string connectionString = @"Server=PHOBOS\SQLEXPRESS;Database=master;Integrated Security=SSPI;";
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
    }
}
