﻿using System;
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
        static IRunnerRepository runnerController = new SqlRunnerRepository(Program.connectionString);
        ITrainingRunRepository trainingRunController = new SqlTrainingRunRepository(Program.connectionString);
        IRaceParticipantRepository raceController = new SqlRaceParticipantRepository(Program.connectionString);

        private Runner runner = runnerController.GetRunner(Program.currentUser.UserId);

        public uxRunnerHomePage()
        {
            InitializeComponent();
            uxWelcomeLabel.Text = "Welcome, Runner " + Program.currentUser.FirstName + " " + Program.currentUser.LastName;
            if (runner.TeamId == 0)
            {
                uxTeamRosterButton.Enabled = false;
            }
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
            var races = new RunnerRaces(raceController.FetchRacesForRunner(Program.currentUser.UserId));
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxTeamRosterButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teams = new TeamDetails(runnerController.GetRunner(Program.currentUser.UserId).TeamId);
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
