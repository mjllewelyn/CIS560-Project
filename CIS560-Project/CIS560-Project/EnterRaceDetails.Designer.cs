namespace CIS560_Project
{
    partial class EnterRaceDetails
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
            this.uxEnterRaceDetailsLabel = new System.Windows.Forms.Label();
            this.uxSaveButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxEnterRaceDetailsLabel
            // 
            this.uxEnterRaceDetailsLabel.AutoSize = true;
            this.uxEnterRaceDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterRaceDetailsLabel.Location = new System.Drawing.Point(49, 55);
            this.uxEnterRaceDetailsLabel.Name = "uxEnterRaceDetailsLabel";
            this.uxEnterRaceDetailsLabel.Size = new System.Drawing.Size(261, 36);
            this.uxEnterRaceDetailsLabel.TabIndex = 0;
            this.uxEnterRaceDetailsLabel.Text = "Enter Race Details";
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(176, 367);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(115, 32);
            this.uxSaveButton.TabIndex = 1;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(317, 367);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(115, 32);
            this.uxCancelButton.TabIndex = 2;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            // 
            // EnterRaceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxEnterRaceDetailsLabel);
            this.Name = "EnterRaceDetails";
            this.Text = "EnterRaceDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxEnterRaceDetailsLabel;
        private System.Windows.Forms.Button uxSaveButton;
        private System.Windows.Forms.Button uxCancelButton;
    }
}