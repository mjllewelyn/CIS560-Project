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
        IRunnerRepository runnerController = new SqlRunnerRepository(Program.connectionString);
        public TeamDetails(int teamId)
        {
            this.teamId = teamId;
            InitializeComponent();
            FillGrid();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var profile = new Teams();
            profile.Closed += (s, args) => Close();
            profile.Show();
        }

        private void FillGrid()
        {
            IReadOnlyList<Runner> runners = runnerController.GetTeamRunners(teamId);
            BindingSource source = new BindingSource();
            source.DataSource = runners;
            uxTeamRunnersDataGrid.DataSource = source;

        }
    }
}
