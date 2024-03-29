﻿namespace CIS560_Project
{
    partial class CoachWelcome
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
            this.uxRunnersButton = new System.Windows.Forms.Button();
            this.uxRacesButton = new System.Windows.Forms.Button();
            this.uxSignoutButton = new System.Windows.Forms.Button();
            this.uxTeamsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxWelcomeLabel
            // 
            this.uxWelcomeLabel.AutoSize = true;
            this.uxWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelcomeLabel.Location = new System.Drawing.Point(58, 78);
            this.uxWelcomeLabel.Name = "uxWelcomeLabel";
            this.uxWelcomeLabel.Size = new System.Drawing.Size(0, 40);
            this.uxWelcomeLabel.TabIndex = 0;
            // 
            // uxProfileButton
            // 
            this.uxProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxProfileButton.Location = new System.Drawing.Point(65, 208);
            this.uxProfileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxProfileButton.Name = "uxProfileButton";
            this.uxProfileButton.Size = new System.Drawing.Size(187, 56);
            this.uxProfileButton.TabIndex = 1;
            this.uxProfileButton.Text = "Profile";
            this.uxProfileButton.UseVisualStyleBackColor = true;
            this.uxProfileButton.Click += new System.EventHandler(this.uxProfileButton_Click);
            // 
            // uxRunnersButton
            // 
            this.uxRunnersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunnersButton.Location = new System.Drawing.Point(296, 284);
            this.uxRunnersButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxRunnersButton.Name = "uxRunnersButton";
            this.uxRunnersButton.Size = new System.Drawing.Size(187, 56);
            this.uxRunnersButton.TabIndex = 2;
            this.uxRunnersButton.Text = "Runners";
            this.uxRunnersButton.UseVisualStyleBackColor = true;
            this.uxRunnersButton.Click += new System.EventHandler(this.uxRunnersButton_Click);
            // 
            // uxRacesButton
            // 
            this.uxRacesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRacesButton.Location = new System.Drawing.Point(296, 208);
            this.uxRacesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxRacesButton.Name = "uxRacesButton";
            this.uxRacesButton.Size = new System.Drawing.Size(187, 56);
            this.uxRacesButton.TabIndex = 3;
            this.uxRacesButton.Text = "Races";
            this.uxRacesButton.UseVisualStyleBackColor = true;
            this.uxRacesButton.Click += new System.EventHandler(this.uxRacesButton_Click);
            // 
            // uxSignoutButton
            // 
            this.uxSignoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSignoutButton.Location = new System.Drawing.Point(178, 377);
            this.uxSignoutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSignoutButton.Name = "uxSignoutButton";
            this.uxSignoutButton.Size = new System.Drawing.Size(187, 56);
            this.uxSignoutButton.TabIndex = 4;
            this.uxSignoutButton.Text = "Signout";
            this.uxSignoutButton.UseVisualStyleBackColor = true;
            this.uxSignoutButton.Click += new System.EventHandler(this.uxSignoutButton_Click);
            // 
            // uxTeamsButton
            // 
            this.uxTeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamsButton.Location = new System.Drawing.Point(65, 284);
            this.uxTeamsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxTeamsButton.Name = "uxTeamsButton";
            this.uxTeamsButton.Size = new System.Drawing.Size(187, 56);
            this.uxTeamsButton.TabIndex = 6;
            this.uxTeamsButton.Text = "Teams";
            this.uxTeamsButton.UseVisualStyleBackColor = true;
            this.uxTeamsButton.Click += new System.EventHandler(this.uxTeamsButton_Click);
            // 
            // CoachWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 471);
            this.Controls.Add(this.uxTeamsButton);
            this.Controls.Add(this.uxSignoutButton);
            this.Controls.Add(this.uxRacesButton);
            this.Controls.Add(this.uxRunnersButton);
            this.Controls.Add(this.uxProfileButton);
            this.Controls.Add(this.uxWelcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CoachWelcome";
            this.Text = "CoachWelcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWelcomeLabel;
        private System.Windows.Forms.Button uxProfileButton;
        private System.Windows.Forms.Button uxRunnersButton;
        private System.Windows.Forms.Button uxRacesButton;
        private System.Windows.Forms.Button uxSignoutButton;
        private System.Windows.Forms.Button uxTeamsButton;
    }
}