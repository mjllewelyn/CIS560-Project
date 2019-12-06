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
    public partial class Profile : Form
    {
        IUserRepository userController = new SqlUserRepository(Program.connectionString);

        private readonly Runner runner;
        public Profile(Runner runner)
        {
            this.runner = runner;
            InitializeComponent();
            FillProfile();
        }

        private void FillProfile()
        {
            uxNameTextBox.Text = Program.currentUser.FirstName + Program.currentUser.LastName;
            uxEmailTextBox.Text = Program.currentUser.Email;
            if (Program.currentUser.UserType == 0)
            {
                uxUserTypeTextBox.Text = "Runner";
            } else
            {
                uxUserTypeTextBox.Text = "Coach";
            }
            uxRunningSinceTextBox.Text = runner.StartYear.ToString();
        }

        private void uxRetireButton_Click(object sender, EventArgs e)
        {
            userController.RetireUser(Program.currentUser.UserId);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }
    }
}
