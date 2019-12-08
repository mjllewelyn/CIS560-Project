namespace CIS560_Project
{
    partial class TeamDetails
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
            this.uxTeamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamLabel.Location = new System.Drawing.Point(53, 47);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(186, 36);
            this.uxTeamLabel.TabIndex = 0;
            this.uxTeamLabel.Text = "Team Details";
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxTeamLabel);
            this.Name = "Team";
            this.Text = "Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTeamLabel;
    }
}