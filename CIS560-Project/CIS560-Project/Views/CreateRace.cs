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

namespace CIS560_Project
{
    public partial class uxCreateRace : Form
    {
        IRaceRepository raceController = new SqlRaceRepository(Program.connectionString);
        public uxCreateRace()
        {
            InitializeComponent();
        }

        private void uxSaveRaceButton_Click(object sender, EventArgs e)
        {
            //raceController.CreateRace(Program.currentUser.UserId, );
            Application.Run(new uxRaces());
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Application.Run(new uxRaces());

        }
    }
}
