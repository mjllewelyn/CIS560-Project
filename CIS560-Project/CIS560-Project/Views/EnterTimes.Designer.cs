namespace CIS560_Project
{
    partial class EnterTimes
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
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxEnterTimesTitle = new System.Windows.Forms.Label();
            this.uxRaceParticipantIdLabel = new System.Windows.Forms.Label();
            this.uxTimeLabel = new System.Windows.Forms.Label();
            this.uxRaceParticipantIdBox = new System.Windows.Forms.TextBox();
            this.uxTimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(74, 262);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(116, 40);
            this.uxSaveButton.TabIndex = 0;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(74, 334);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(116, 40);
            this.uxCancelButton.TabIndex = 1;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxEnterTimesTitle
            // 
            this.uxEnterTimesTitle.AutoSize = true;
            this.uxEnterTimesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterTimesTitle.Location = new System.Drawing.Point(31, 35);
            this.uxEnterTimesTitle.Name = "uxEnterTimesTitle";
            this.uxEnterTimesTitle.Size = new System.Drawing.Size(223, 40);
            this.uxEnterTimesTitle.TabIndex = 2;
            this.uxEnterTimesTitle.Text = "Update Time";
            // 
            // uxRaceParticipantIdLabel
            // 
            this.uxRaceParticipantIdLabel.AutoSize = true;
            this.uxRaceParticipantIdLabel.Location = new System.Drawing.Point(70, 89);
            this.uxRaceParticipantIdLabel.Name = "uxRaceParticipantIdLabel";
            this.uxRaceParticipantIdLabel.Size = new System.Drawing.Size(136, 20);
            this.uxRaceParticipantIdLabel.TabIndex = 3;
            this.uxRaceParticipantIdLabel.Text = "RaceParticipantId";
            // 
            // uxTimeLabel
            // 
            this.uxTimeLabel.AutoSize = true;
            this.uxTimeLabel.Location = new System.Drawing.Point(70, 167);
            this.uxTimeLabel.Name = "uxTimeLabel";
            this.uxTimeLabel.Size = new System.Drawing.Size(43, 20);
            this.uxTimeLabel.TabIndex = 4;
            this.uxTimeLabel.Text = "Time";
            // 
            // uxRaceParticipantIdBox
            // 
            this.uxRaceParticipantIdBox.Location = new System.Drawing.Point(74, 123);
            this.uxRaceParticipantIdBox.Name = "uxRaceParticipantIdBox";
            this.uxRaceParticipantIdBox.Size = new System.Drawing.Size(100, 26);
            this.uxRaceParticipantIdBox.TabIndex = 5;
            // 
            // uxTimeBox
            // 
            this.uxTimeBox.Location = new System.Drawing.Point(74, 190);
            this.uxTimeBox.Name = "uxTimeBox";
            this.uxTimeBox.Size = new System.Drawing.Size(100, 26);
            this.uxTimeBox.TabIndex = 6;
            // 
            // EnterTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 408);
            this.Controls.Add(this.uxTimeBox);
            this.Controls.Add(this.uxRaceParticipantIdBox);
            this.Controls.Add(this.uxTimeLabel);
            this.Controls.Add(this.uxRaceParticipantIdLabel);
            this.Controls.Add(this.uxEnterTimesTitle);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxSaveButton);
            this.Name = "EnterTimes";
            this.Text = "EnterTimes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Label uxEnterTimesTitle;
        private System.Windows.Forms.Label uxRaceParticipantIdLabel;
        private System.Windows.Forms.Label uxTimeLabel;
        private System.Windows.Forms.TextBox uxRaceParticipantIdBox;
        private System.Windows.Forms.TextBox uxTimeBox;
    }
}