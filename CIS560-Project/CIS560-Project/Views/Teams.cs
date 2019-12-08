﻿using System;
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
        ITeamRepository teamController = new SqlTeamRepository(Program.connectionString);
        public Teams()
        {
            InitializeComponent();
            FillList();
        }

        private void uxCreateTeamButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Program.GoHome(this);
        }

        private void uxTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxTeamsListBox.SelectedItem.ToString();
            //teamController.GetTeam
        }

        private void FillList()
        {
            IReadOnlyList<Team> teams = teamController.FetchCoachTeams(Program.currentUser.UserId);
            
            foreach (Team team in teams) {
                uxTeamsListBox.Items.Add(team.Name);
            }
        }
    }
}
