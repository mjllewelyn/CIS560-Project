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
            Application.Run(new uxLogTrainingRun());
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Application.Run(new uxRunnerHomePage());
        }

        private void FillListView(IReadOnlyList<TrainingRun> readOnlyList)
        {
            BindingSource source = new BindingSource(readOnlyList, "trainingRun");
            uxTrainingRunsDataGrid.DataSource = source;
        }
    }
}
