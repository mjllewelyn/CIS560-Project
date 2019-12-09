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
    public partial class uxCreateRace : Form
    {
        IRaceRepository raceController = new SqlRaceRepository(Program.connectionString);
        ILocationRepository locationController = new SqlLocationRepository(Program.connectionString);
        public uxCreateRace()
        {
            InitializeComponent();
            PopulateLocations(locationController.FetchLocations());
        }

        private void uxSaveRaceButton_Click(object sender, EventArgs e)
        {
            raceController.CreateRace(locationController.GetLocationIdFromName(uxLocationDropDown.SelectedItem.ToString()), DateTimeConverstion(uxDateTimePicker.Value.ToString(), uxTimeBox.Text), Convert.ToInt32(uxDistanceBox.Text));
            Hide();
            var races = new uxRaces();
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

        private void PopulateLocations(IReadOnlyList<Location> locations)
        {
            foreach (Location l in locations) {
                uxLocationDropDown.Items.Add(l.Name);
            }
        }

        private DateTime DateTimeConverstion(string Date, string Time)
        {
            DateTime dt = DateTime.Parse(Date.Split(' ')[0] + " " + Time);
            return dt;
        }
    }
}
