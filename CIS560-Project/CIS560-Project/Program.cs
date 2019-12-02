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
    }
}
