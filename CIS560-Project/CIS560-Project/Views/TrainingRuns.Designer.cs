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
            this.uxTrainingRunsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxTrainingRunsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTrainingRunsLabel
            // 
            this.uxTrainingRunsLabel.AutoSize = true;
            this.uxTrainingRunsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTrainingRunsLabel.Location = new System.Drawing.Point(14, 25);
            this.uxTrainingRunsLabel.Name = "uxTrainingRunsLabel";
            this.uxTrainingRunsLabel.Size = new System.Drawing.Size(241, 40);
            this.uxTrainingRunsLabel.TabIndex = 0;
            this.uxTrainingRunsLabel.Text = "Training Runs";
            // 
            // uxLogRunButton
            // 
            this.uxLogRunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogRunButton.Location = new System.Drawing.Point(214, 419);
            this.uxLogRunButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxLogRunButton.Name = "uxLogRunButton";
            this.uxLogRunButton.Size = new System.Drawing.Size(165, 54);
            this.uxLogRunButton.TabIndex = 1;
            this.uxLogRunButton.Text = "Log Run";
            this.uxLogRunButton.UseVisualStyleBackColor = true;
            this.uxLogRunButton.Click += new System.EventHandler(this.uxLogRunButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(451, 419);
            this.uxBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(165, 54);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxTrainingRunsDataGrid
            // 
            this.uxTrainingRunsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxTrainingRunsDataGrid.Location = new System.Drawing.Point(20, 74);
            this.uxTrainingRunsDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxTrainingRunsDataGrid.Name = "uxTrainingRunsDataGrid";
            this.uxTrainingRunsDataGrid.RowTemplate.Height = 24;
            this.uxTrainingRunsDataGrid.Size = new System.Drawing.Size(807, 324);
            this.uxTrainingRunsDataGrid.TabIndex = 6;
            // 
            // TrainingRuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.uxTrainingRunsDataGrid);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxLogRunButton);
            this.Controls.Add(this.uxTrainingRunsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TrainingRuns";
            this.Text = "TrainingRuns";
            ((System.ComponentModel.ISupportInitialize)(this.uxTrainingRunsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTrainingRunsLabel;
        private System.Windows.Forms.Button uxLogRunButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.DataGridView uxTrainingRunsDataGrid;
    }
}