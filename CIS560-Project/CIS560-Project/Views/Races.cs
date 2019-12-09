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
    public partial class uxRaces : Form
    {
        IRaceRepository raceController = new SqlRaceRepository(Program.connectionString);

        public uxRaces()
        {
            var readOnlyList = raceController.RetrieveRaces();
            InitializeComponent();
            FillListView(readOnlyList);
            uxEnterARaceButton.Hide();
        }

        private void uxEnterARaceButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new uxEnterRace();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void uxCreateRaceButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new uxCreateRace();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxRaceDetailsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new RaceDetails();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void FillListView(IReadOnlyList<RaceCoachView> readOnlyList)
        {
            BindingSource source = new BindingSource();
            source.DataSource = readOnlyList;
            uxRaceDataGrid.DataSource = source;
        }

        private void uxTeamRaceResults_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new TeamRaceResults();
            races.Closed += (s, args) => Close();
            races.Show();
        }
    }
}
