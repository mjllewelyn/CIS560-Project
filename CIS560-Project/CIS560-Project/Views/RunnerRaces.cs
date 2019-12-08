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
    public partial class RunnerRaces : Form
    {
        public RunnerRaces(IReadOnlyList<RaceForRunner> readOnlyList)
        {
            InitializeComponent();
            FillListView(readOnlyList);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void FillListView(IReadOnlyList<RaceForRunner> readOnlyList)
        {
            BindingSource source = new BindingSource();
            source.DataSource = readOnlyList;
            uxRaceDataGrid.DataSource = source;
        }
    }
}
