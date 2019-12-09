namespace CIS560_Project
{
    partial class TeamDetails
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
            this.uxTeamLabel = new System.Windows.Forms.Label();
            this.uxTeamRunnersDataGrid = new System.Windows.Forms.DataGridView();
            this.uxRetireButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamRunnersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTeamLabel
            // 
            this.uxTeamLabel.AutoSize = true;
            this.uxTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTeamLabel.Location = new System.Drawing.Point(53, 47);
            this.uxTeamLabel.Name = "uxTeamLabel";
            this.uxTeamLabel.Size = new System.Drawing.Size(186, 36);
            this.uxTeamLabel.TabIndex = 0;
            this.uxTeamLabel.Text = "Team Details";
            // 
            // uxTeamRunnersDataGrid
            // 
            this.uxTeamRunnersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxTeamRunnersDataGrid.Location = new System.Drawing.Point(59, 105);
            this.uxTeamRunnersDataGrid.Name = "uxTeamRunnersDataGrid";
            this.uxTeamRunnersDataGrid.RowTemplate.Height = 24;
            this.uxTeamRunnersDataGrid.Size = new System.Drawing.Size(439, 189);
            this.uxTeamRunnersDataGrid.TabIndex = 1;
            // 
            // uxRetireButton
            // 
            this.uxRetireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRetireButton.Location = new System.Drawing.Point(143, 336);
            this.uxRetireButton.Name = "uxRetireButton";
            this.uxRetireButton.Size = new System.Drawing.Size(122, 51);
            this.uxRetireButton.TabIndex = 2;
            this.uxRetireButton.Text = "Retire";
            this.uxRetireButton.UseVisualStyleBackColor = true;
            this.uxRetireButton.Click += new System.EventHandler(this.uxRetireButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(286, 336);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(122, 51);
            this.uxBackButton.TabIndex = 3;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // TeamDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxRetireButton);
            this.Controls.Add(this.uxTeamRunnersDataGrid);
            this.Controls.Add(this.uxTeamLabel);
            this.Name = "TeamDetails";
            this.Text = "Team";
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamRunnersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTeamLabel;
        private System.Windows.Forms.DataGridView uxTeamRunnersDataGrid;
        private System.Windows.Forms.Button uxRetireButton;
        private System.Windows.Forms.Button uxBackButton;
    }
}