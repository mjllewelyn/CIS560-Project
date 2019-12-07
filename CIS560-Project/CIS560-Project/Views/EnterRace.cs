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
    public partial class uxEnterRace : Form
    {
        ILocationRepository locationController = new SqlLocationRepository(Program.connectionString);
        IRaceRepository raceController = new SqlRaceRepository(Program.connectionString);

        public uxEnterRace()
        {
            InitializeComponent();
            FillLocationList();
        }

        private void uxEnterButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void FillLocationList()
        {
            locationController.GetLocations();

        }

        private void uxLocationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //something.FillDateList()
        }

        private void FillDateList()
        {
            //raceController.GetDatesForLocation
        }
    }
}
