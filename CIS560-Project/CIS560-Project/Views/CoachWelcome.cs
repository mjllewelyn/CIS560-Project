using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_Project.Controllers;
using CIS560_Project.Models;

namespace CIS560_Project
{
    public partial class CoachWelcome : Form
    {
        ICoachRepository coachController = new SqlCoachRepository(Program.connectionString);
        ITrainingRunRepository trainingRunController = new SqlTrainingRunRepository(Program.connectionString);
        IRaceParticipantRepository raceController = new SqlRaceParticipantRepository(Program.connectionString);
        public CoachWelcome()
        {
            InitializeComponent();
            uxWelcomeLabel.Text = "Welcome, Coach " + Program.currentUser.FirstName + " " + Program.currentUser.LastName;
        }

        private void uxProfileButton_Click(object sender, EventArgs e)
        {
            Hide();
            var profile = new Profile(coachController.GetCoach(Program.currentUser.UserId));
            profile.Closed += (s, args) => Close();
            profile.Show();
        }

        private void uxTeamsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teams = new Teams(coachController.GetCoach(Program.currentUser.UserId));
            teams.Closed += (s, args) => Close();
            teams.Show();
        }

        private void uxRecordsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teams = new uxRecords(coachController.GetCoach(Program.currentUser.UserId));
            teams.Closed += (s, args) => Close();
            teams.Show();
        }

        private void uxRacesButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new uxRaces(raceController.FetchRacesForRunner(Program.currentUser.UserId));
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxRunnersButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new uxRaces(raceController.FetchRacesForRunner(Program.currentUser.UserId));
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxSignoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new uxSignIn();
            login.Closed += (s, args) => Close();
            login.Show();
            Program.currentUser = null;
        }
    }
}
