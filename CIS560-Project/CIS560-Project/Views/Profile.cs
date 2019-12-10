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
    public partial class Profile : Form
    {
        IUserRepository userController = new SqlUserRepository(Program.connectionString);
        IRunnerRepository runnerController = new SqlRunnerRepository(Program.connectionString);

        public Profile()
        {
            InitializeComponent();
            FillProfile();
        }

        private void FillProfile()
        {
            uxNameTextBox.Text = Program.currentUser.FirstName + " " + Program.currentUser.LastName;
            uxEmailTextBox.Text = Program.currentUser.Email;
            if (Program.currentUser.UserType == 1)
            {
                uxUserTypeTextBox.Text = "Runner";
                var runnerController = new SqlRunnerRepository(Program.connectionString);
                var runner = runnerController.GetRunner(Program.currentUser.UserId);
                uxRunningSinceTextBox.Text = runner.StartYear.ToString();
                RunnerSummary summary = runnerController.GetRunnerSummary(Program.currentUser.UserId);
                uxAvgDistTextBox.Text = summary.averageDistance.ToString();
                uxAvgPaceTextBox.Text = Program.GetTimeString(summary.averagePace);
                uxAvgTimeTextBox.Text = Program.GetTimeString(summary.averageTime);
            }
            else
            {
                uxUserTypeTextBox.Text = "Coach";
                var coachController = new SqlCoachRepository(Program.connectionString);
                var coach = coachController.GetCoach(Program.currentUser.UserId);
                uxRunningSinceTextBox.Text = coach.StartYear.ToString();
            }
        }

        private void uxRetireButton_Click(object sender, EventArgs e)
        {
            userController.RetireUser(Program.currentUser.UserId);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }
    }
}
