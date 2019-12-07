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
    
    public partial class uxLogTrainingRun : Form
    {
        ITrainingRunRepository controller = new SqlTrainingRunRepository(Program.connectionString);
        public uxLogTrainingRun()
        {
            InitializeComponent();
        }

        private void uxLogRunButton_Click(object sender, EventArgs e)
        {
            if (controller.CreateTrainingRun(Program.currentUser.UserId, uxDateTimePicker.Value, Convert.ToInt32(uxDistanceTextBox.Text), Convert.ToInt32(uxTimeTextBox.Text), Convert.ToDouble(uxAverageHRTextBox.Text)) != null)
            {
                Program.GoHome(this);
            }
            else
            {
                uxErrorLabel.Text = "Invalid input. Please try again.";
            }
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }
    }
}
