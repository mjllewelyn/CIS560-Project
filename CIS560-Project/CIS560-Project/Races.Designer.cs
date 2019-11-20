namespace CIS560_Project
{
    partial class uxRaces
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
            this.uxRacesLabel = new System.Windows.Forms.Label();
            this.uxEnterARaceButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxRacesLabel
            // 
            this.uxRacesLabel.AutoSize = true;
            this.uxRacesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRacesLabel.Location = new System.Drawing.Point(40, 46);
            this.uxRacesLabel.Name = "uxRacesLabel";
            this.uxRacesLabel.Size = new System.Drawing.Size(99, 36);
            this.uxRacesLabel.TabIndex = 0;
            this.uxRacesLabel.Text = "Races";
            // 
            // uxEnterARaceButton
            // 
            this.uxEnterARaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterARaceButton.Location = new System.Drawing.Point(63, 285);
            this.uxEnterARaceButton.Name = "uxEnterARaceButton";
            this.uxEnterARaceButton.Size = new System.Drawing.Size(164, 47);
            this.uxEnterARaceButton.TabIndex = 1;
            this.uxEnterARaceButton.Text = "Enter a Race";
            this.uxEnterARaceButton.UseVisualStyleBackColor = true;
            this.uxEnterARaceButton.Click += new System.EventHandler(this.uxEnterARaceButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(253, 285);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(164, 47);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxEnterARaceButton);
            this.Controls.Add(this.uxRacesLabel);
            this.Name = "uxRaces";
            this.Text = "Races";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRacesLabel;
        private System.Windows.Forms.Button uxEnterARaceButton;
        private System.Windows.Forms.Button uxBackButton;
    }
}