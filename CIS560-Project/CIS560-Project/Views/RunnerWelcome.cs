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
        }

        private void uxProfileButton_Click(object sender, EventArgs e)
        {
            Application.Run(new Profile(runnerController.GetRunner(Program.currentUser.UserId)));

        }

        private void uxRunsButton_Click(object sender, EventArgs e)
        {
            Application.Run(new TrainingRuns(trainingRunController.FetchTrainingRuns(Program.currentUser.UserId)));
        }

        private void uxRacesButton_Click(object sender, EventArgs e)
        {
            Application.Run(new uxRaces());
        }

        private void uxTeamRosterButton_Click(object sender, EventArgs e)
        {
            Application.Run(new team)
        }

        private void uxTeamRecordsButton_Click(object sender, EventArgs e)
        {

        }

        private void uxTeamRacesButton_Click(object sender, EventArgs e)
        {

        }

        private void uxSignOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
