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
    public partial class RaceDetails : Form
    {
        IRunnerRepository runnerController = new SqlRunnerRepository(Program.connectionString);
        IRaceParticipantRepository raceParticipantController = new SqlRaceParticipantRepository(Program.connectionString);

        public RaceDetails()
        {
            List<RaceForRunner> readOnlyList = new List<RaceForRunner>();
            var runners = runnerController.RetrieveRunners();
            foreach(Runner r in runners)
            {
                foreach(RaceForRunner race in raceParticipantController.FetchRacesForRunner(r.RunnerId))
                {
                    readOnlyList.Add(race);
                }
            }
            InitializeComponent();
            FillListView(readOnlyList);
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
            Hide();
            var races = new uxRaces();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxEnterTimesButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new EnterTimes();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void FillListView(List<RaceForRunner> list)
        {
            BindingSource source = new BindingSource();
            source.DataSource = list;
            uxRaceDetailsGrid.DataSource = source;
        }

        private void FillParticipantListView(List<RaceParticipant> list)
        {
            BindingSource source = new BindingSource();
            source.DataSource = list;
            uxRaceDetailsGrid.DataSource = source;
        }

        private void uxFilterButton_Click(object sender, EventArgs e)
        {
            int raceId = Convert.ToInt32(uxRaceIdBox.Text);
            List<RaceParticipant> readOnlyList = new List<RaceParticipant>();
            foreach (RaceParticipant race in raceParticipantController.FetchRunnersForRace(raceId))
            {
                readOnlyList.Add(race);
            }
            FillParticipantListView(readOnlyList);
        }
    }
}
