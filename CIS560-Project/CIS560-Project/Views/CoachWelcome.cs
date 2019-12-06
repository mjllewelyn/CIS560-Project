using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_Project
{
    public partial class CoachWelcome : Form
    {
        public CoachWelcome()
        {
            InitializeComponent();
            uxWelcomeLabel.Text = "Welcome, Coach " + Program.currentUser.FirstName + " " + Program.currentUser.LastName;
        }

        private void uxProfileButton_Click(object sender, EventArgs e)
        {
            /*Hide();
            var profile = new Profile(runnerController.GetRunner(Program.currentUser.UserId));
            profile.Closed += (s, args) => Close();
            profile.Show();*/
        }

        private void uxTeamsButton_Click(object sender, EventArgs e)
        {
            /*Hide();
            var teams = new teams(runnerController.GetRunner(Program.currentUser.UserId));
            teams.Closed += (s, args) => Close();
            teams.Show();*/
        }

        private void uxRecordsButton_Click(object sender, EventArgs e)
        {
            /*Hide();
            var records = new Profile(runnerController.GetRunner(Program.currentUser.UserId));
            records.Closed += (s, args) => Close();
            records.Show();*/
        }

        private void uxRacesButton_Click(object sender, EventArgs e)
        {
            /*Hide();
            var races = new Profile(runnerController.GetRunner(Program.currentUser.UserId));
            races.Closed += (s, args) => Close();
            races.Show();*/
        }

        private void uxRunnersButton_Click(object sender, EventArgs e)
        {
            /*Hide();
            var runners = new Profile(runnerController.GetRunner(Program.currentUser.UserId));
            runners.Closed += (s, args) => Close();
            runners.Show();*/
        }

        private void uxSignoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new uxSignIn();
            login.Closed += (s, args) => Close();
            login.Show();
        }
    }
}
