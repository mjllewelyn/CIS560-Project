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
    public partial class uxRunnerHomePage : Form
    {
        IRunnerRepository runnerController = new SqlRunnerRepository(Program.connectionString);
        ITrainingRunRepository trainingRunController = new SqlTrainingRunRepository(Program.connectionString);
        IRaceParticipantRepository raceController = new SqlRaceParticipantRepository(Program.connectionString);
        public uxRunnerHomePage()
        {
            InitializeComponent();
            uxWelcomeLabel.Text = "Welcome, Runner " + Program.currentUser.FirstName + " " + Program.currentUser.LastName;
        }

        private void uxProfileButton_Click(object sender, EventArgs e)
        {
            Hide();
            var profile = new Profile();
            profile.Closed += (s, args) => Close();
            profile.Show();
        }

        private void uxRunsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var runs = new TrainingRuns(trainingRunController.FetchTrainingRuns(Program.currentUser.UserId));
            runs.Closed += (s, args) => Close();
            runs.Show();
        }

        private void uxRacesButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new uxRaces();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxTeamRosterButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teams = new TeamDetails();
            teams.Closed += (s, args) => Close();
            teams.Show();
        }

        private void uxTeamRecordsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teams = new uxRecords(runnerController.GetRunner(Program.currentUser.UserId));
            teams.Closed += (s, args) => Close();
            teams.Show();
        }

        private void uxTeamRacesButton_Click(object sender, EventArgs e)
        {
           Hide();
           var races = new uxRaces();
            //raceController.FetchRacesForTeam(((Runner)Program.currentUser).TeamId)
           races.Closed += (s, args) => Close();
           races.Show();
        }

        private void uxSignOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new uxSignIn();
            login.Closed += (s, args) => Close();
            login.Show();
            Program.currentUser = null;
        }
    }
}
