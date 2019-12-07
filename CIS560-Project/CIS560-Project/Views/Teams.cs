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
    public partial class Teams : Form
    {
        private readonly User user;
        public Teams(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void uxCreateTeamButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }
    }
}
