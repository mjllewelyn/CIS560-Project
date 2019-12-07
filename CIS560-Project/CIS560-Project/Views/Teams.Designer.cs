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
            this.uxTeamsLabel.Location = new System.Drawing.Point(39, 45);
            this.uxTeamsLabel.Name = "uxTeamsLabel";
            this.uxTeamsLabel.Size = new System.Drawing.Size(127, 40);
            this.uxTeamsLabel.TabIndex = 0;
            this.uxTeamsLabel.Text = "Teams";
            // 
            // uxCreateTeamButton
            // 
            this.uxCreateTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateTeamButton.Location = new System.Drawing.Point(109, 350);
            this.uxCreateTeamButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxCreateTeamButton.Name = "uxCreateTeamButton";
            this.uxCreateTeamButton.Size = new System.Drawing.Size(183, 48);
            this.uxCreateTeamButton.TabIndex = 1;
            this.uxCreateTeamButton.Text = "Create Team";
            this.uxCreateTeamButton.UseVisualStyleBackColor = true;
            this.uxCreateTeamButton.Click += new System.EventHandler(this.uxCreateTeamButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(343, 350);
            this.uxBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(183, 48);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxTeamsListBox
            // 
            this.uxTeamsListBox.FormattingEnabled = true;
            this.uxTeamsListBox.ItemHeight = 20;
            this.uxTeamsListBox.Location = new System.Drawing.Point(97, 130);
            this.uxTeamsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxTeamsListBox.Name = "uxTeamsListBox";
            this.uxTeamsListBox.Size = new System.Drawing.Size(429, 104);
            this.uxTeamsListBox.TabIndex = 3;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 562);
            this.Controls.Add(this.uxTeamsListBox);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxCreateTeamButton);
            this.Controls.Add(this.uxTeamsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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