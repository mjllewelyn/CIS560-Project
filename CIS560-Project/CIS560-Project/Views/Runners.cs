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
    public partial class Runners : Form
    {
        public Runners()
        {
            InitializeComponent();
            FillListView();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void FillListView()
        {
            IRunnerRepository runnerController = new SqlRunnerRepository(Program.connectionString);
            IReadOnlyList<RunnerNameAndTeam> runners = runnerController.RetrieveRunnerNamesAndTeams();

            BindingSource source = new BindingSource();
            source.DataSource = runners;
            uxRunnerDataGrid.DataSource = source;
        }
    }
}
