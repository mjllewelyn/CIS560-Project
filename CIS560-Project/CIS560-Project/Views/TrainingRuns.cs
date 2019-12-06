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

namespace CIS560_Project
{
    public partial class TrainingRuns : Form
    {
        
        public TrainingRuns(IReadOnlyList<TrainingRun> readOnlyList)
        {
            InitializeComponent();
            FillListView(readOnlyList);
        }

        private void uxLogRunButton_Click(object sender, EventArgs e)
        {
            Hide();
            var runs = new uxLogTrainingRun();
            runs.Closed += (s, args) => Close();
            runs.Show();
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void FillListView(IReadOnlyList<TrainingRun> readOnlyList)
        {
            BindingSource source = new BindingSource(readOnlyList, "TrainingRun");
            uxTrainingRunsDataGrid.DataSource = source;
        }
    }
}
