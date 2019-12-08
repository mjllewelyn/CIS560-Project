namespace CIS560_Project
{
    partial class uxRunnerHomePage
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
            this.uxWelcomeLabel = new System.Windows.Forms.Label();
            this.uxProfileButton = new System.Windows.Forms.Button();
            this.uxRacesButton = new System.Windows.Forms.Button();
            this.uxRunsButton = new System.Windows.Forms.Button();
            this.uxTeamRecordsButton = new System.Windows.Forms.Button();
            this.uxSignOutButton = new System.Windows.Forms.Button();
            this.uxTeamRosterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelcomeLabel.Location = new System.Drawing.Point(60, 55);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(0, 36);
            this.uxWelcomeLabel.TabIndex = 0;
            // 
            // uxProfileButton
            // 
            this.uxProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxProfileButton.Location = new System.Drawing.Point(66, 124);
            this.uxProfileButton.Name = "uxProfileButton";
            this.uxProfileButton.Size = new System.Drawing.Size(162, 43);
            this.uxProfileButton.TabIndex = 1;
            this.uxProfileButton.Text = "Profile";
            this.uxProfileButton.UseVisualStyleBackColor = true;
            this.uxProfileButton.Click += new System.EventHandler(this.uxProfileButton_Click);
            // 
            // uxRacesButton
            // 
            this.uxRacesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRacesButton.Location = new System.Drawing.Point(66, 277);
            this.uxRacesButton.Name = "uxRacesButton";
            this.uxRacesButton.Size = new System.Drawing.Size(162, 43);
            this.uxRacesButton.TabIndex = 2;
            this.uxRacesButton.Text = "Races";
            this.uxRacesButton.UseVisualStyleBackColor = true;
            this.uxRacesButton.Click += new System.EventHandler(this.uxRacesButton_Click);
            // 
            // uxRunsButton
            // 
            this.uxRunsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunsButton.Location = new System.Drawing.Point(66, 202);
            this.uxRunsButton.Name = "uxRunsButton";
            this.uxRunsButton.Size = new System.Drawing.Size(162, 43);
            this.uxRunsButton.TabIndex = 3;
            this.uxRunsButton.Text = "Runs";
            this.uxRunsButton.UseVisualStyleBackColor = true;
            this.uxRunsButton.Click += new System.EventHandler(this.uxRunsButton_Click);
            // 
            // uxTeamRecordsButton
            // 
            this.uxTeamRecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamRecordsButton.Location = new System.Drawing.Point(284, 202);
            this.uxTeamRecordsButton.Name = "uxTeamRecordsButton";
            this.uxTeamRecordsButton.Size = new System.Drawing.Size(162, 43);
            this.uxTeamRecordsButton.TabIndex = 6;
            this.uxTeamRecordsButton.Text = "Team Records";
            this.uxTeamRecordsButton.UseVisualStyleBackColor = true;
            this.uxTeamRecordsButton.Click += new System.EventHandler(this.uxTeamRecordsButton_Click);
            // 
            // uxSignOutButton
            // 
            this.uxSignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSignOutButton.Location = new System.Drawing.Point(284, 277);
            this.uxSignOutButton.Name = "uxSignOutButton";
            this.uxSignOutButton.Size = new System.Drawing.Size(162, 43);
            this.uxSignOutButton.TabIndex = 5;
            this.uxSignOutButton.Text = "Sign Out";
            this.uxSignOutButton.UseVisualStyleBackColor = true;
            this.uxSignOutButton.Click += new System.EventHandler(this.uxSignOutButton_Click);
            // 
            // uxTeamRosterButton
            // 
            this.uxTeamRosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamRosterButton.Location = new System.Drawing.Point(284, 124);
            this.uxTeamRosterButton.Name = "uxTeamRosterButton";
            this.uxTeamRosterButton.Size = new System.Drawing.Size(162, 43);
            this.uxTeamRosterButton.TabIndex = 4;
            this.uxTeamRosterButton.Text = "Team Roster";
            this.uxTeamRosterButton.UseVisualStyleBackColor = true;
            this.uxTeamRosterButton.Click += new System.EventHandler(this.uxTeamRosterButton_Click);
            // 
            // uxRunnerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 385);
            this.Controls.Add(this.uxTeamRecordsButton);
            this.Controls.Add(this.uxSignOutButton);
            this.Controls.Add(this.uxTeamRosterButton);
            this.Controls.Add(this.uxRunsButton);
            this.Controls.Add(this.uxRacesButton);
            this.Controls.Add(this.uxProfileButton);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Name = "uxRunnerHomePage";
            this.Text = "RunnerHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWelcomeLabel;
        private System.Windows.Forms.Button uxProfileButton;
        private System.Windows.Forms.Button uxRacesButton;
        private System.Windows.Forms.Button uxRunsButton;
        private System.Windows.Forms.Button uxTeamRecordsButton;
        private System.Windows.Forms.Button uxSignOutButton;
        private System.Windows.Forms.Button uxTeamRosterButton;
    }
}