namespace CIS560_Project
{
    partial class RaceSummary
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
            this.uxRaceIdLabel = new System.Windows.Forms.Label();
            this.uxRaceIdBox = new System.Windows.Forms.TextBox();
            this.uxFilterButton = new System.Windows.Forms.Button();
            this.uxRaceSummaryDetailsGrid = new System.Windows.Forms.DataGridView();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxRaceSummaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceSummaryDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRaceIdLabel
            // 
            this.uxRaceIdLabel.AutoSize = true;
            this.uxRaceIdLabel.Location = new System.Drawing.Point(494, 31);
            this.uxRaceIdLabel.Name = "uxRaceIdLabel";
            this.uxRaceIdLabel.Size = new System.Drawing.Size(61, 20);
            this.uxRaceIdLabel.TabIndex = 14;
            this.uxRaceIdLabel.Text = "RaceId";
            // 
            // uxRaceIdBox
            // 
            this.uxRaceIdBox.Location = new System.Drawing.Point(494, 57);
            this.uxRaceIdBox.Name = "uxRaceIdBox";
            this.uxRaceIdBox.Size = new System.Drawing.Size(100, 26);
            this.uxRaceIdBox.TabIndex = 13;
            // 
            // uxFilterButton
            // 
            this.uxFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFilterButton.Location = new System.Drawing.Point(600, 47);
            this.uxFilterButton.Name = "uxFilterButton";
            this.uxFilterButton.Size = new System.Drawing.Size(121, 41);
            this.uxFilterButton.TabIndex = 12;
            this.uxFilterButton.Text = "Filter";
            this.uxFilterButton.UseVisualStyleBackColor = true;
            this.uxFilterButton.Click += new System.EventHandler(this.uxFilterButton_Click);
            // 
            // uxRaceSummaryDetailsGrid
            // 
            this.uxRaceSummaryDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRaceSummaryDetailsGrid.Location = new System.Drawing.Point(81, 108);
            this.uxRaceSummaryDetailsGrid.Name = "uxRaceSummaryDetailsGrid";
            this.uxRaceSummaryDetailsGrid.RowTemplate.Height = 28;
            this.uxRaceSummaryDetailsGrid.Size = new System.Drawing.Size(590, 112);
            this.uxRaceSummaryDetailsGrid.TabIndex = 11;
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(272, 260);
            this.uxBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(189, 48);
            this.uxBackButton.TabIndex = 9;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxRaceSummaryLabel
            // 
            this.uxRaceSummaryLabel.AutoSize = true;
            this.uxRaceSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRaceSummaryLabel.Location = new System.Drawing.Point(74, 43);
            this.uxRaceSummaryLabel.Name = "uxRaceSummaryLabel";
            this.uxRaceSummaryLabel.Size = new System.Drawing.Size(265, 40);
            this.uxRaceSummaryLabel.TabIndex = 8;
            this.uxRaceSummaryLabel.Text = "Race Summary";
            // 
            // RaceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 331);
            this.Controls.Add(this.uxRaceIdLabel);
            this.Controls.Add(this.uxRaceIdBox);
            this.Controls.Add(this.uxFilterButton);
            this.Controls.Add(this.uxRaceSummaryDetailsGrid);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxRaceSummaryLabel);
            this.Name = "RaceSummary";
            this.Text = "RaceSummary";
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceSummaryDetailsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRaceIdLabel;
        private System.Windows.Forms.TextBox uxRaceIdBox;
        private System.Windows.Forms.Button uxFilterButton;
        private System.Windows.Forms.DataGridView uxRaceSummaryDetailsGrid;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Label uxRaceSummaryLabel;
    }
}