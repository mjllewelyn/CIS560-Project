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
    public partial class EnterTimes : Form
    {
        public EnterTimes()
        {
            InitializeComponent();
        }

        private void uxSaveButton_Click(object sender, EventArgs e)
        {
            IRaceParticipantRepository raceParticipantController = new SqlRaceParticipantRepository(Program.connectionString);
            raceParticipantController.UpdateRaceParticipantTime(Convert.ToInt32(uxRaceParticipantIdBox.Text), Convert.ToInt32(uxTimeBox.Text));
            Hide();
            var races = new RaceDetails();
            races.Closed += (s, args) => Close();
            races.Show();
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            var races = new RaceDetails();
            races.Closed += (s, args) => Close();
            races.Show();
        }
    }
}
