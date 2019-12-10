namespace CIS560_Project
{
    partial class UpdateRunnerTeam
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
            this.uxTeamIdBox = new System.Windows.Forms.TextBox();
            this.uxRunnerIdBox = new System.Windows.Forms.TextBox();
            this.uxTeamIdLabel = new System.Windows.Forms.Label();
            this.uxRunnerIdLabel = new System.Windows.Forms.Label();
            this.uxRunnerTeamTitle = new System.Windows.Forms.Label();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTeamIdBox
            // 
            this.uxTeamIdBox.Location = new System.Drawing.Point(124, 181);
            this.uxTeamIdBox.Name = "uxTeamIdBox";
            this.uxTeamIdBox.Size = new System.Drawing.Size(100, 26);
            this.uxTeamIdBox.TabIndex = 13;
            // 
            // uxRunnerIdBox
            // 
            this.uxRunnerIdBox.Location = new System.Drawing.Point(124, 114);
            this.uxRunnerIdBox.Name = "uxRunnerIdBox";
            this.uxRunnerIdBox.Size = new System.Drawing.Size(100, 26);
            this.uxRunnerIdBox.TabIndex = 12;
            // 
            // uxTeamIdLabel
            // 
            this.uxTeamIdLabel.AutoSize = true;
            this.uxTeamIdLabel.Location = new System.Drawing.Point(120, 158);
            this.uxTeamIdLabel.Name = "uxTeamIdLabel";
            this.uxTeamIdLabel.Size = new System.Drawing.Size(63, 20);
            this.uxTeamIdLabel.TabIndex = 11;
            this.uxTeamIdLabel.Text = "TeamId";
            // 
            // uxRunnerIdLabel
            // 
            this.uxRunnerIdLabel.AutoSize = true;
            this.uxRunnerIdLabel.Location = new System.Drawing.Point(120, 80);
            this.uxRunnerIdLabel.Name = "uxRunnerIdLabel";
            this.uxRunnerIdLabel.Size = new System.Drawing.Size(76, 20);
            this.uxRunnerIdLabel.TabIndex = 10;
            this.uxRunnerIdLabel.Text = "RunnerId";
            // 
            // uxRunnerTeamTitle
            // 
            this.uxRunnerTeamTitle.AutoSize = true;
            this.uxRunnerTeamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunnerTeamTitle.Location = new System.Drawing.Point(12, 22);
            this.uxRunnerTeamTitle.Name = "uxRunnerTeamTitle";
            this.uxRunnerTeamTitle.Size = new System.Drawing.Size(363, 40);
            this.uxRunnerTeamTitle.TabIndex = 9;
            this.uxRunnerTeamTitle.Text = "Update Runner Team";
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(124, 325);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(116, 40);
            this.uxCancelButton.TabIndex = 8;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(124, 253);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(116, 40);
            this.uxSaveButton.TabIndex = 7;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // UpdateRunnerTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 410);
            this.Controls.Add(this.uxTeamIdBox);
            this.Controls.Add(this.uxRunnerIdBox);
            this.Controls.Add(this.uxTeamIdLabel);
            this.Controls.Add(this.uxRunnerIdLabel);
            this.Controls.Add(this.uxRunnerTeamTitle);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxSaveButton);
            this.Name = "UpdateRunnerTeam";
            this.Text = "UpdateRunnerTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTeamIdBox;
        private System.Windows.Forms.TextBox uxRunnerIdBox;
        private System.Windows.Forms.Label uxTeamIdLabel;
        private System.Windows.Forms.Label uxRunnerIdLabel;
        private System.Windows.Forms.Label uxRunnerTeamTitle;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Button uxSaveButton;
    }
}