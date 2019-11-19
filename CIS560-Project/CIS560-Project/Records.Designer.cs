namespace CIS560_Project
{
    partial class uxRecords
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
            this.uxRecordsLabel = new System.Windows.Forms.Label();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxRecordsLabel
            // 
            this.uxRecordsLabel.AutoSize = true;
            this.uxRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRecordsLabel.Location = new System.Drawing.Point(62, 77);
            this.uxRecordsLabel.Name = "uxRecordsLabel";
            this.uxRecordsLabel.Size = new System.Drawing.Size(127, 36);
            this.uxRecordsLabel.TabIndex = 0;
            this.uxRecordsLabel.Text = "Records";
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(223, 361);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(125, 36);
            this.uxBackButton.TabIndex = 1;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            // 
            // uxRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxRecordsLabel);
            this.Name = "uxRecords";
            this.Text = "Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRecordsLabel;
        private System.Windows.Forms.Button uxBackButton;
    }
}