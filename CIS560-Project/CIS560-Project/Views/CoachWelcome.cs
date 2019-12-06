using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_Project
{
    public partial class CoachWelcome : Form
    {
        public CoachWelcome()
        {
            InitializeComponent();
            uxWelcomeLabel.Text = "Welcome, Coach " + Program.currentUser.FirstName + " " + Program.currentUser.LastName;
        }

        private void uxProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void uxTeamsButton_Click(object sender, EventArgs e)
        {

        }

        private void uxRecordsButton_Click(object sender, EventArgs e)
        {

        }

        private void uxRacesButton_Click(object sender, EventArgs e)
        {

        }

        private void uxRunnersButton_Click(object sender, EventArgs e)
        {

        }

        private void uxSignoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new uxSignIn();
            login.Closed += (s, args) => Close();
            login.Show();
        }
    }
}
