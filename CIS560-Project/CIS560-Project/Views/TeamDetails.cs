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
    public partial class TeamDetails : Form
    {
        private int teamId;
        IRaceParticipantRepository raceParticipantController = new SqlRaceParticipantRepository(Program.connectionString);
        ITeamRepository teamController = new SqlTeamRepository(Program.connectionString);
        IRunnerRepository runnerController = new SqlRunnerRepository(Program.connectionString);

        public TeamDetails(int teamId)
        {
            this.teamId = teamId;
            InitializeComponent();
            FillGrid();
            if (Program.currentUser.UserType == 1)
            {
                this.Controls.Remove(uxRetireButton);
            }
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (Program.currentUser.UserType == 1)
            {
                Program.GoHome(this);
            } else
            { 
                var teams = new Teams();
                teams.Closed += (s, args) => Close();
                teams.Show();
            }
            
        }

        private void FillGrid()
        {
            IReadOnlyList<Runner> runners = runnerController.GetTeamRunners(teamId);
            List<RaceRecord> raceParticipants = new List<RaceRecord>();
            foreach (Runner runner in runners)
            {
                raceParticipants.Add(raceParticipantController.GetTeamRecords(runner.RunnerId));
            }
            BindingSource source = new BindingSource();
            source.DataSource = raceParticipants;
            uxTeamRunnersDataGrid.DataSource = source;
        }

        private void uxRetireButton_Click(object sender, EventArgs e)
        {
            teamController.RetireTeam(teamId);
            var teams = new Teams();
            teams.Closed += (s, args) => Close();
            teams.Show();
        }
    }
}
