namespace CIS560_Project
{
    partial class RunnerRaces
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
            this.uxRaceDataGrid = new System.Windows.Forms.DataGridView();
            this.uxRaceTitle = new System.Windows.Forms.Label();
            this.uxBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRaceDataGrid
            // 
            this.uxRaceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRaceDataGrid.Location = new System.Drawing.Point(56, 91);
            this.uxRaceDataGrid.Name = "uxRaceDataGrid";
            this.uxRaceDataGrid.Size = new System.Drawing.Size(682, 246);
            this.uxRaceDataGrid.TabIndex = 0;
            // 
            // uxRaceTitle
            // 
            this.uxRaceTitle.AutoSize = true;
            this.uxRaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRaceTitle.Location = new System.Drawing.Point(49, 32);
            this.uxRaceTitle.Name = "uxRaceTitle";
            this.uxRaceTitle.Size = new System.Drawing.Size(119, 40);
            this.uxRaceTitle.TabIndex = 1;
            this.uxRaceTitle.Text = "Races";
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(320, 363);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(112, 51);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // RunnerRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxRaceTitle);
            this.Controls.Add(this.uxRaceDataGrid);
            this.Name = "RunnerRaces";
            this.Text = "RunnerRaces";
            ((System.ComponentModel.ISupportInitialize)(this.uxRaceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxRaceDataGrid;
        private System.Windows.Forms.Label uxRaceTitle;
        private System.Windows.Forms.Button uxBackButton;
    }
}