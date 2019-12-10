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
    public partial class RaceSummary : Form
    {
        IRaceRepository raceController = new SqlRaceRepository(Program.connectionString);
        public RaceSummary()
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
            int raceId = Convert.ToInt32(uxRaceIdBox.Text);
            List<RaceSummaryObject> readOnlyList = new List<RaceSummaryObject>();
            foreach (RaceSummaryObject race in raceController.GetRaceSummary(raceId))
            {
                readOnlyList.Add(race);
            }

            BindingSource source = new BindingSource();
            source.DataSource = readOnlyList;
            uxRaceSummaryDetailsGrid.DataSource = source;
        }
    }
}
