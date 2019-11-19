namespace CIS560_Project
{
    partial class RaceDetails
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
            this.uxRaceDetailsLabel = new System.Windows.Forms.Label();
            this.uxEnterARaceButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxEnterTimesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxRaceDetailsLabel
            // 
            this.uxRaceDetailsLabel.AutoSize = true;
            this.uxRaceDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRaceDetailsLabel.Location = new System.Drawing.Point(46, 47);
            this.uxRaceDetailsLabel.Name = "uxRaceDetailsLabel";
            this.uxRaceDetailsLabel.Size = new System.Drawing.Size(182, 36);
            this.uxRaceDetailsLabel.TabIndex = 0;
            this.uxRaceDetailsLabel.Text = "Race Details";
            // 
            // uxEnterARaceButton
            // 
            this.uxEnterARaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterARaceButton.Location = new System.Drawing.Point(123, 312);
            this.uxEnterARaceButton.Name = "uxEnterARaceButton";
            this.uxEnterARaceButton.Size = new System.Drawing.Size(168, 38);
            this.uxEnterARaceButton.TabIndex = 1;
            this.uxEnterARaceButton.Text = "Enter a Race";
            this.uxEnterARaceButton.UseVisualStyleBackColor = true;
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(316, 312);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(168, 38);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            // 
            // uxEnterTimesButton
            // 
            this.uxEnterTimesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterTimesButton.Location = new System.Drawing.Point(409, 45);
            this.uxEnterTimesButton.Name = "uxEnterTimesButton";
            this.uxEnterTimesButton.Size = new System.Drawing.Size(168, 38);
            this.uxEnterTimesButton.TabIndex = 3;
            this.uxEnterTimesButton.Text = "Enter times";
            this.uxEnterTimesButton.UseVisualStyleBackColor = true;
            // 
            // RaceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.uxEnterTimesButton);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxEnterARaceButton);
            this.Controls.Add(this.uxRaceDetailsLabel);
            this.Name = "RaceDetails";
            this.Text = "RaceDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRaceDetailsLabel;
        private System.Windows.Forms.Button uxEnterARaceButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxEnterTimesButton;
    }
}