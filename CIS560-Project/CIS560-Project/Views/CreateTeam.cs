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
    public partial class CreateTeam : Form
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void uxSaveButton_Click(object sender, EventArgs e)
        {
            ITeamRepository teamController = new SqlTeamRepository(Program.connectionString);
            teamController.CreateTeam(uxNameTextBox.Text);
            Hide();
            var teamDetails = new Teams();
            teamDetails.Closed += (s, args) => Close();
            teamDetails.Show();
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            var teamDetails = new Teams();
            teamDetails.Closed += (s, args) => Close();
            teamDetails.Show();
        }
    }
}
