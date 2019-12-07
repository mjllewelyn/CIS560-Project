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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uxRaceDetailsButton = new System.Windows.Forms.Button();
            this.uxCreateRaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.uxEnterARaceButton.Location = new System.Drawing.Point(86, 333);
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
            this.uxBackButton.Location = new System.Drawing.Point(269, 391);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(164, 47);
            this.uxBackButton.TabIndex = 2;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(481, 194);
            this.dataGridView1.TabIndex = 3;
            // 
            // uxRaceDetailsButton
            // 
            this.uxRaceDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRaceDetailsButton.Location = new System.Drawing.Point(86, 391);
            this.uxRaceDetailsButton.Name = "uxRaceDetailsButton";
            this.uxRaceDetailsButton.Size = new System.Drawing.Size(164, 47);
            this.uxRaceDetailsButton.TabIndex = 4;
            this.uxRaceDetailsButton.Text = "Race Details";
            this.uxRaceDetailsButton.UseVisualStyleBackColor = true;
            this.uxRaceDetailsButton.Click += new System.EventHandler(this.uxRaceDetailsButton_Click);
            // 
            // uxCreateRaceButton
            // 
            this.uxCreateRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateRaceButton.Location = new System.Drawing.Point(269, 338);
            this.uxCreateRaceButton.Name = "uxCreateRaceButton";
            this.uxCreateRaceButton.Size = new System.Drawing.Size(164, 47);
            this.uxCreateRaceButton.TabIndex = 5;
            this.uxCreateRaceButton.Text = "Create a Race";
            this.uxCreateRaceButton.UseVisualStyleBackColor = true;
            this.uxCreateRaceButton.Click += new System.EventHandler(this.uxCreateRaceButton_Click);
            // 
            // uxRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxCreateRaceButton);
            this.Controls.Add(this.uxRaceDetailsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxEnterARaceButton);
            this.Controls.Add(this.uxRacesLabel);
            this.Name = "uxRaces";
            this.Text = "Races";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxRacesLabel;
        private System.Windows.Forms.Button uxEnterARaceButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uxRaceDetailsButton;
        private System.Windows.Forms.Button uxCreateRaceButton;
    }
}