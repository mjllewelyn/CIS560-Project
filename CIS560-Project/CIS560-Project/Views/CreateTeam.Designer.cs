namespace CIS560_Project
{
    partial class CreateTeam
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
            this.uxCreateTeamLabel = new System.Windows.Forms.Label();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxNameTextBox = new System.Windows.Forms.TextBox();
            this.uxMembersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.uxMembersLabel = new System.Windows.Forms.Label();
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxCreateTeamLabel
            // 
            this.uxCreateTeamLabel.AutoSize = true;
            this.uxCreateTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateTeamLabel.Location = new System.Drawing.Point(54, 59);
            this.uxCreateTeamLabel.Name = "uxCreateTeamLabel";
            this.uxCreateTeamLabel.Size = new System.Drawing.Size(227, 40);
            this.uxCreateTeamLabel.TabIndex = 0;
            this.uxCreateTeamLabel.Text = "Create Team";
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNameLabel.Location = new System.Drawing.Point(61, 155);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(78, 29);
            this.uxNameLabel.TabIndex = 1;
            this.uxNameLabel.Text = "Name";
            // 
            // uxNameTextBox
            // 
            this.uxNameTextBox.Location = new System.Drawing.Point(66, 190);
            this.uxNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxNameTextBox.Name = "uxNameTextBox";
            this.uxNameTextBox.Size = new System.Drawing.Size(286, 26);
            this.uxNameTextBox.TabIndex = 2;
            // 
            // uxMembersCheckedListBox
            // 
            this.uxMembersCheckedListBox.FormattingEnabled = true;
            this.uxMembersCheckedListBox.Location = new System.Drawing.Point(61, 358);
            this.uxMembersCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxMembersCheckedListBox.Name = "uxMembersCheckedListBox";
            this.uxMembersCheckedListBox.Size = new System.Drawing.Size(291, 46);
            this.uxMembersCheckedListBox.TabIndex = 3;
            // 
            // uxMembersLabel
            // 
            this.uxMembersLabel.AutoSize = true;
            this.uxMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMembersLabel.Location = new System.Drawing.Point(56, 325);
            this.uxMembersLabel.Name = "uxMembersLabel";
            this.uxMembersLabel.Size = new System.Drawing.Size(115, 29);
            this.uxMembersLabel.TabIndex = 4;
            this.uxMembersLabel.Text = "Members";
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(61, 243);
            this.uxSaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(134, 44);
            this.uxSaveButton.TabIndex = 5;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(218, 243);
            this.uxCancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(134, 44);
            this.uxCancelButton.TabIndex = 6;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 309);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxMembersLabel);
            this.Controls.Add(this.uxMembersCheckedListBox);
            this.Controls.Add(this.uxNameTextBox);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxCreateTeamLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxCreateTeamLabel;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.TextBox uxNameTextBox;
        private System.Windows.Forms.CheckedListBox uxMembersCheckedListBox;
        private System.Windows.Forms.Label uxMembersLabel;
        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Button uxCancelButton;
    }
}