namespace CIS560_Project
{
    partial class uxRaces
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
            this.uxRacesLabel = new System.Windows.Forms.Label();
            this.uxEnterARaceButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxRaceDataGrid = new System.Windows.Forms.DataGridView();
            this.uxRaceDetailsButton = new System.Windows.Forms.Button();
            this.uxCreateRaceButton = new System.Windows.Forms.Button();
            this.uxTeamRaceResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRacesLabel
            // 
            this.uxRacesLabel.AutoSize = true;
            this.uxRacesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRacesLabel.Location = new System.Drawing.Point(45, 58);
            this.uxRacesLabel.Name = "uxRacesLabel";
            this.uxRacesLabel.Size = new System.Drawing.Size(119, 40);
            this.uxRacesLabel.TabIndex = 0;
            this.uxRacesLabel.Text = "Races";
            // 
            // uxEnterARaceButton
            // 
            this.uxEnterARaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterARaceButton.Location = new System.Drawing.Point(232, 416);
            this.uxEnterARaceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxEnterARaceButton.Name = "uxEnterARaceButton";
            this.uxEnterARaceButton.Size = new System.Drawing.Size(184, 59);
            this.uxEnterARaceButton.TabIndex = 1;
            this.uxEnterARaceButton.Text = "Enter a Race";
            this.uxEnterARaceButton.UseVisualStyleBackColor = true;
            this.uxEnterARaceButton.Click += new System.EventHandler(this.uxEnterARaceButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(352, 573);
            this.uxBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(184, 59);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxRaceDataGrid
            // 
            this.uxRaceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRaceDataGrid.Location = new System.Drawing.Point(26, 131);
            this.uxRaceDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxRaceDataGrid.Name = "uxRaceDataGrid";
            this.uxRaceDataGrid.RowTemplate.Height = 24;
            this.uxRaceDataGrid.Size = new System.Drawing.Size(810, 242);
            this.uxRaceDataGrid.TabIndex = 3;
            // 
            // uxRaceDetailsButton
            // 
            this.uxRaceDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRaceDetailsButton.Location = new System.Drawing.Point(232, 490);
            this.uxRaceDetailsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxRaceDetailsButton.Name = "uxRaceDetailsButton";
            this.uxRaceDetailsButton.Size = new System.Drawing.Size(184, 59);
            this.uxRaceDetailsButton.TabIndex = 4;
            this.uxRaceDetailsButton.Text = "Racers";
            this.uxRaceDetailsButton.UseVisualStyleBackColor = true;
            this.uxRaceDetailsButton.Click += new System.EventHandler(this.uxRaceDetailsButton_Click);
            // 
            // uxCreateRaceButton
            // 
            this.uxCreateRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateRaceButton.Location = new System.Drawing.Point(478, 416);
            this.uxCreateRaceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxCreateRaceButton.Name = "uxCreateRaceButton";
            this.uxCreateRaceButton.Size = new System.Drawing.Size(184, 59);
            this.uxCreateRaceButton.TabIndex = 5;
            this.uxCreateRaceButton.Text = "Create a Race";
            this.uxCreateRaceButton.UseVisualStyleBackColor = true;
            this.uxCreateRaceButton.Click += new System.EventHandler(this.uxCreateRaceButton_Click);
            // 
            // uxTeamRaceResults
            // 
            this.uxTeamRaceResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamRaceResults.Location = new System.Drawing.Point(478, 490);
            this.uxTeamRaceResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxTeamRaceResults.Name = "uxTeamRaceResults";
            this.uxTeamRaceResults.Size = new System.Drawing.Size(240, 59);
            this.uxTeamRaceResults.TabIndex = 6;
            this.uxTeamRaceResults.Text = "Team Race Results";
            this.uxTeamRaceResults.UseVisualStyleBackColor = true;
            this.uxTeamRaceResults.Click += new System.EventHandler(this.uxTeamRaceResults_Click);
            // 
            // uxRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 645);
            this.Controls.Add(this.uxTeamRaceResults);
            this.Controls.Add(this.uxCreateRaceButton);
            this.Controls.Add(this.uxRaceDetailsButton);
            this.Controls.Add(this.uxRaceDataGrid);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxEnterARaceButton);
            this.Controls.Add(this.uxRacesLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uxRaces";
            this.Text = "Races";
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRacesLabel;
        private System.Windows.Forms.Button uxEnterARaceButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.DataGridView uxRaceDataGrid;
        private System.Windows.Forms.Button uxRaceDetailsButton;
        private System.Windows.Forms.Button uxCreateRaceButton;
        private System.Windows.Forms.Button uxTeamRaceResults;
    }
}