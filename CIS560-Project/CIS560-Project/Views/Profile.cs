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

        private readonly User user;
        public Profile(User user)
        {
            this.user = user;
            InitializeComponent();
            FillProfile();
        }

        private void FillProfile()
        {
            uxNameTextBox.Text = Program.currentUser.FirstName + " " + Program.currentUser.LastName;
            uxEmailTextBox.Text = Program.currentUser.Email;
            if (Program.currentUser.UserType == 1)
            {
                uxUserTypeTextBox.Text = "Runner";
                uxRunningSinceTextBox.Text = ((Runner)user).StartYear.ToString();
            }
            else
            {
                uxUserTypeTextBox.Text = "Coach";
                uxRunningSinceTextBox.Text = ((Coach)user).StartYear.ToString();
            }
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
