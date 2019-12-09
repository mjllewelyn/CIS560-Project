namespace CIS560_Project
{
    partial class TeamRaceResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxFilterButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxRaceIdBox = new System.Windows.Forms.TextBox();
            this.uxTeamRaceResultsTitle = new System.Windows.Forms.Label();
            this.uxRaceIdLabel = new System.Windows.Forms.Label();
            this.uxTeamRaceResultsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamRaceResultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFilterButton
            // 
            this.uxFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFilterButton.Location = new System.Drawing.Point(581, 36);
            this.uxFilterButton.Name = "uxFilterButton";
            this.uxFilterButton.Size = new System.Drawing.Size(115, 40);
            this.uxFilterButton.TabIndex = 0;
            this.uxFilterButton.Text = "Filter";
            this.uxFilterButton.UseVisualStyleBackColor = true;
            this.uxFilterButton.Click += new System.EventHandler(this.uxFilterButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(307, 353);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(115, 40);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxRaceIdBox
            // 
            this.uxRaceIdBox.Location = new System.Drawing.Point(475, 46);
            this.uxRaceIdBox.Name = "uxRaceIdBox";
            this.uxRaceIdBox.Size = new System.Drawing.Size(100, 26);
            this.uxRaceIdBox.TabIndex = 3;
            // 
            // uxTeamRaceResultsTitle
            // 
            this.uxTeamRaceResultsTitle.AutoSize = true;
            this.uxTeamRaceResultsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamRaceResultsTitle.Location = new System.Drawing.Point(40, 41);
            this.uxTeamRaceResultsTitle.Name = "uxTeamRaceResultsTitle";
            this.uxTeamRaceResultsTitle.Size = new System.Drawing.Size(333, 40);
            this.uxTeamRaceResultsTitle.TabIndex = 4;
            this.uxTeamRaceResultsTitle.Text = "Team Race Results";
            // 
            // uxRaceIdLabel
            // 
            this.uxRaceIdLabel.AutoSize = true;
            this.uxRaceIdLabel.Location = new System.Drawing.Point(471, 23);
            this.uxRaceIdLabel.Name = "uxRaceIdLabel";
            this.uxRaceIdLabel.Size = new System.Drawing.Size(61, 20);
            this.uxRaceIdLabel.TabIndex = 5;
            this.uxRaceIdLabel.Text = "RaceId";
            // 
            // uxTeamRaceResultsGrid
            // 
            this.uxTeamRaceResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxTeamRaceResultsGrid.Location = new System.Drawing.Point(47, 100);
            this.uxTeamRaceResultsGrid.Name = "uxTeamRaceResultsGrid";
            this.uxTeamRaceResultsGrid.RowTemplate.Height = 28;
            this.uxTeamRaceResultsGrid.Size = new System.Drawing.Size(703, 226);
            this.uxTeamRaceResultsGrid.TabIndex = 6;
            // 
            // TeamRaceResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxTeamRaceResultsGrid);
            this.Controls.Add(this.uxRaceIdLabel);
            this.Controls.Add(this.uxTeamRaceResultsTitle);
            this.Controls.Add(this.uxRaceIdBox);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxFilterButton);
            this.Name = "TeamRaceResults";
            this.Text = "TeamRaceResults";
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamRaceResultsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxFilterButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.TextBox uxRaceIdBox;
        private System.Windows.Forms.Label uxTeamRaceResultsTitle;
        private System.Windows.Forms.Label uxRaceIdLabel;
        private System.Windows.Forms.DataGridView uxTeamRaceResultsGrid;
    }
}