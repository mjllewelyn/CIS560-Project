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
    public partial class Teams : Form
    {
        public Teams()
        {
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
