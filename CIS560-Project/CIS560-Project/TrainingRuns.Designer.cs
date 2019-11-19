namespace CIS560_Project
{
    partial class TrainingRuns
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
            this.uxTrainingRunsLabel = new System.Windows.Forms.Label();
            this.uxLogRunButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTrainingRunsLabel
            // 
            this.uxTrainingRunsLabel.AutoSize = true;
            this.uxTrainingRunsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTrainingRunsLabel.Location = new System.Drawing.Point(53, 68);
            this.uxTrainingRunsLabel.Name = "uxTrainingRunsLabel";
            this.uxTrainingRunsLabel.Size = new System.Drawing.Size(203, 36);
            this.uxTrainingRunsLabel.TabIndex = 0;
            this.uxTrainingRunsLabel.Text = "Training Runs";
            // 
            // uxLogRunButton
            // 
            this.uxLogRunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogRunButton.Location = new System.Drawing.Point(59, 335);
            this.uxLogRunButton.Name = "uxLogRunButton";
            this.uxLogRunButton.Size = new System.Drawing.Size(147, 43);
            this.uxLogRunButton.TabIndex = 1;
            this.uxLogRunButton.Text = "Log Run";
            this.uxLogRunButton.UseVisualStyleBackColor = true;
            this.uxLogRunButton.Click += new System.EventHandler(this.uxLogRunButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(234, 335);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(147, 43);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // TrainingRuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxLogRunButton);
            this.Controls.Add(this.uxTrainingRunsLabel);
            this.Name = "TrainingRuns";
            this.Text = "TrainingRuns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTrainingRunsLabel;
        private System.Windows.Forms.Button uxLogRunButton;
        private System.Windows.Forms.Button uxBackButton;
    }
}