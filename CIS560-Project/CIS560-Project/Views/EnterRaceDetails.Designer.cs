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
            this.uxEnterRaceDetailsLabel.Location = new System.Drawing.Point(55, 69);
            this.uxEnterRaceDetailsLabel.Name = "uxEnterRaceDetailsLabel";
            this.uxEnterRaceDetailsLabel.Size = new System.Drawing.Size(317, 40);
            this.uxEnterRaceDetailsLabel.TabIndex = 0;
            this.uxEnterRaceDetailsLabel.Text = "Enter Race Details";
            // 
            // uxSaveButton
            // 
            this.uxSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveButton.Location = new System.Drawing.Point(198, 459);
            this.uxSaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSaveButton.Name = "uxSaveButton";
            this.uxSaveButton.Size = new System.Drawing.Size(129, 40);
            this.uxSaveButton.TabIndex = 1;
            this.uxSaveButton.Text = "Save";
            this.uxSaveButton.UseVisualStyleBackColor = true;
            this.uxSaveButton.Click += new System.EventHandler(this.uxSaveButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(357, 459);
            this.uxCancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(129, 40);
            this.uxCancelButton.TabIndex = 2;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // EnterRaceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 562);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxSaveButton);
            this.Controls.Add(this.uxEnterRaceDetailsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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