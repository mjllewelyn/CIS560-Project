namespace CIS560_Project
{
    partial class Runners
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
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxRunnerTitle = new System.Windows.Forms.Label();
            this.uxRunnerDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxRunnerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(327, 365);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(112, 51);
            this.uxBackButton.TabIndex = 5;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxRunnerTitle
            // 
            this.uxRunnerTitle.AutoSize = true;
            this.uxRunnerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunnerTitle.Location = new System.Drawing.Point(56, 34);
            this.uxRunnerTitle.Name = "uxRunnerTitle";
            this.uxRunnerTitle.Size = new System.Drawing.Size(153, 40);
            this.uxRunnerTitle.TabIndex = 4;
            this.uxRunnerTitle.Text = "Runners";
            // 
            // uxRunnerDataGrid
            // 
            this.uxRunnerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRunnerDataGrid.Location = new System.Drawing.Point(63, 93);
            this.uxRunnerDataGrid.Name = "uxRunnerDataGrid";
            this.uxRunnerDataGrid.Size = new System.Drawing.Size(682, 246);
            this.uxRunnerDataGrid.TabIndex = 3;
            // 
            // Runners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxRunnerTitle);
            this.Controls.Add(this.uxRunnerDataGrid);
            this.Name = "Runners";
            this.Text = "Runners";
            ((System.ComponentModel.ISupportInitialize)(this.uxRunnerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Label uxRunnerTitle;
        private System.Windows.Forms.DataGridView uxRunnerDataGrid;
    }
}