namespace CIS560_Project
{
    partial class Teams
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
            this.uxTeamsLabel = new System.Windows.Forms.Label();
            this.uxCreateTeamButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxTeamsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxTeamsLabel
            // 
            this.uxTeamsLabel.AutoSize = true;
            this.uxTeamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamsLabel.Location = new System.Drawing.Point(35, 36);
            this.uxTeamsLabel.Name = "uxTeamsLabel";
            this.uxTeamsLabel.Size = new System.Drawing.Size(103, 36);
            this.uxTeamsLabel.TabIndex = 0;
            this.uxTeamsLabel.Text = "Teams";
            // 
            // uxCreateTeamButton
            // 
            this.uxCreateTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateTeamButton.Location = new System.Drawing.Point(97, 280);
            this.uxCreateTeamButton.Name = "uxCreateTeamButton";
            this.uxCreateTeamButton.Size = new System.Drawing.Size(163, 38);
            this.uxCreateTeamButton.TabIndex = 1;
            this.uxCreateTeamButton.Text = "Create Team";
            this.uxCreateTeamButton.UseVisualStyleBackColor = true;
            this.uxCreateTeamButton.Click += new System.EventHandler(this.uxCreateTeamButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(305, 280);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(163, 38);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxTeamsListBox
            // 
            this.uxTeamsListBox.FormattingEnabled = true;
            this.uxTeamsListBox.ItemHeight = 16;
            this.uxTeamsListBox.Location = new System.Drawing.Point(86, 104);
            this.uxTeamsListBox.Name = "uxTeamsListBox";
            this.uxTeamsListBox.Size = new System.Drawing.Size(382, 148);
            this.uxTeamsListBox.TabIndex = 3;
            this.uxTeamsListBox.SelectedIndexChanged += new System.EventHandler(this.uxTeamsListBox_SelectedIndexChanged);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.uxTeamsListBox);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxCreateTeamButton);
            this.Controls.Add(this.uxTeamsLabel);
            this.Name = "Teams";
            this.Text = "Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTeamsLabel;
        private System.Windows.Forms.Button uxCreateTeamButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.ListBox uxTeamsListBox;
    }
}