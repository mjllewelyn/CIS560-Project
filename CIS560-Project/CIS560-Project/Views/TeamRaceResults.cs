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
    public partial class TeamRaceResults : Form
    {
        public TeamRaceResults()
        {
            InitializeComponent();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new uxRaces();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxFilterButton_Click(object sender, EventArgs e)
        {
            IRaceParticipantRepository raceParticipantController = new SqlRaceParticipantRepository(Program.connectionString);
            int raceId = Convert.ToInt32(uxRaceIdBox.Text);
            var raceParticipants = raceParticipantController.TeamPlacingForRace(raceId);
            FillData(raceParticipants);
           
        }

        private void FillData(IReadOnlyList<TeamPlacing> placings)
        {
            BindingSource source = new BindingSource();
            source.DataSource = placings;
            uxTeamRaceResultsGrid.DataSource = source;
        }
    }
}
