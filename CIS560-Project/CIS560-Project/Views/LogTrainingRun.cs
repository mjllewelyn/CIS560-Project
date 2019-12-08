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
            ITrainingRunRepository trainingRunController = new SqlTrainingRunRepository(Program.connectionString);
            Hide();
            var runs = new TrainingRuns(trainingRunController.FetchTrainingRuns(Program.currentUser.UserId));
            runs.Closed += (s, args) => Close();
            runs.Show();
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            ITrainingRunRepository trainingRunController = new SqlTrainingRunRepository(Program.connectionString);
            Hide();
            var runs = new TrainingRuns(trainingRunController.FetchTrainingRuns(Program.currentUser.UserId));
            runs.Closed += (s, args) => Close();
            runs.Show();
        }
    }
}
