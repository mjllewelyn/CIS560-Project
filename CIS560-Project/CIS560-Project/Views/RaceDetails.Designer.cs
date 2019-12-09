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
            this.uxRaceDetailsGrid = new System.Windows.Forms.DataGridView();
            this.uxFilterButton = new System.Windows.Forms.Button();
            this.uxRaceIdBox = new System.Windows.Forms.TextBox();
            this.uxRaceIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRaceDetailsLabel
            // 
            this.uxRaceDetailsLabel.AutoSize = true;
            this.uxRaceDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRaceDetailsLabel.Location = new System.Drawing.Point(52, 59);
            this.uxRaceDetailsLabel.Name = "uxRaceDetailsLabel";
            this.uxRaceDetailsLabel.Size = new System.Drawing.Size(131, 40);
            this.uxRaceDetailsLabel.TabIndex = 0;
            this.uxRaceDetailsLabel.Text = "Racers";
            // 
            // uxEnterARaceButton
            // 
            this.uxEnterARaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterARaceButton.Location = new System.Drawing.Point(235, 63);
            this.uxEnterARaceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxEnterARaceButton.Name = "uxEnterARaceButton";
            this.uxEnterARaceButton.Size = new System.Drawing.Size(189, 48);
            this.uxEnterARaceButton.TabIndex = 1;
            this.uxEnterARaceButton.Text = "Enter a Race";
            this.uxEnterARaceButton.UseVisualStyleBackColor = true;
            this.uxEnterARaceButton.Click += new System.EventHandler(this.uxEnterARaceButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(383, 390);
            this.uxBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(189, 48);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxEnterTimesButton
            // 
            this.uxEnterTimesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterTimesButton.Location = new System.Drawing.Point(114, 390);
            this.uxEnterTimesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxEnterTimesButton.Name = "uxEnterTimesButton";
            this.uxEnterTimesButton.Size = new System.Drawing.Size(189, 48);
            this.uxEnterTimesButton.TabIndex = 3;
            this.uxEnterTimesButton.Text = "Update Time";
            this.uxEnterTimesButton.UseVisualStyleBackColor = true;
            this.uxEnterTimesButton.Click += new System.EventHandler(this.uxEnterTimesButton_Click);
            // 
            // uxRaceDetailsGrid
            // 
            this.uxRaceDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRaceDetailsGrid.Location = new System.Drawing.Point(59, 124);
            this.uxRaceDetailsGrid.Name = "uxRaceDetailsGrid";
            this.uxRaceDetailsGrid.RowTemplate.Height = 28;
            this.uxRaceDetailsGrid.Size = new System.Drawing.Size(590, 250);
            this.uxRaceDetailsGrid.TabIndex = 4;
            // 
            // uxFilterButton
            // 
            this.uxFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFilterButton.Location = new System.Drawing.Point(578, 63);
            this.uxFilterButton.Name = "uxFilterButton";
            this.uxFilterButton.Size = new System.Drawing.Size(121, 41);
            this.uxFilterButton.TabIndex = 5;
            this.uxFilterButton.Text = "Filter";
            this.uxFilterButton.UseVisualStyleBackColor = true;
            this.uxFilterButton.Click += new System.EventHandler(this.uxFilterButton_Click);
            // 
            // uxRaceIdBox
            // 
            this.uxRaceIdBox.Location = new System.Drawing.Point(472, 73);
            this.uxRaceIdBox.Name = "uxRaceIdBox";
            this.uxRaceIdBox.Size = new System.Drawing.Size(100, 26);
            this.uxRaceIdBox.TabIndex = 6;
            // 
            // uxRaceIdLabel
            // 
            this.uxRaceIdLabel.AutoSize = true;
            this.uxRaceIdLabel.Location = new System.Drawing.Point(472, 47);
            this.uxRaceIdLabel.Name = "uxRaceIdLabel";
            this.uxRaceIdLabel.Size = new System.Drawing.Size(61, 20);
            this.uxRaceIdLabel.TabIndex = 7;
            this.uxRaceIdLabel.Text = "RaceId";
            // 
            // RaceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 460);
            this.Controls.Add(this.uxRaceIdLabel);
            this.Controls.Add(this.uxRaceIdBox);
            this.Controls.Add(this.uxFilterButton);
            this.Controls.Add(this.uxRaceDetailsGrid);
            this.Controls.Add(this.uxEnterTimesButton);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxEnterARaceButton);
            this.Controls.Add(this.uxRaceDetailsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RaceDetails";
            this.Text = "RaceDetails";
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceDetailsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRaceDetailsLabel;
        private System.Windows.Forms.Button uxEnterARaceButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.Button uxEnterTimesButton;
        private System.Windows.Forms.DataGridView uxRaceDetailsGrid;
        private System.Windows.Forms.Button uxFilterButton;
        private System.Windows.Forms.TextBox uxRaceIdBox;
        private System.Windows.Forms.Label uxRaceIdLabel;
    }
}