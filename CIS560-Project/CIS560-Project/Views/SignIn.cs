using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_Project.Models;
using CIS560_Project.Controllers;

namespace CIS560_Project
{
    public partial class uxSignIn : Form
    {
        SqlUserRepository controller = new SqlUserRepository(Program.connectionString);
        public uxSignIn()
        {
            InitializeComponent();
        }

        private void uxSignInButton_Click(object sender, EventArgs e)
        {
            string email = uxEmailTextBox.Text;
            string password = uxPasswordTextBox.Text;
            // call method to login
            if (controller.ValidateUser(email, password))
            {
                Program.currentUser = controller.GetUser(email);
                if (Program.currentUser.UserType == 0) 
                {
                    Hide();
                    var coachWelcome = new CoachWelcome();
                    coachWelcome.Closed += (s, args) => Close();
                    coachWelcome.Show();
                }
                else 
                {
                    Hide();
                    var runnerWelcome = new uxRunnerHomePage();
                    runnerWelcome.Closed += (s, args) => Close();
                    runnerWelcome.Show();
                }
            }
            else
            {
                uxErrorLabel.Text = "Invalid Email/Password";
            }
        }
    }
}
