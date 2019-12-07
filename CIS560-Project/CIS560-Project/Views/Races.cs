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
        IRaceParticipantRepository raceController = new SqlRaceParticipantRepository(Program.connectionString);

        public uxRaces()
        {
            raceController.FetchRacesForRunner(Program.currentUser.UserId);
            InitializeComponent();
        }

        private void uxEnterARaceButton_Click(object sender, EventArgs e)
        {
            Application.Run(new uxEnterRace());
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Application.Run(new uxRunnerHomePage());
        }

        private void uxCreateRaceButton_Click(object sender, EventArgs e)
        {
            Application.Run(new uxCreateRace());
        }

        private void uxRaceDetailsButton_Click(object sender, EventArgs e)
        {
            Application.Run(new RaceDetails());
        }
    }
}
