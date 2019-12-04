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

        }

        private void uxLogRunButton_Click(object sender, EventArgs e)
        {

        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {

        }

        private void FillListView(IReadOnlyList<TrainingRun> readOnlyList)
        {
            BindingSource source = new BindingSource(readOnlyList, "trainingRun");
        }
    }
}
