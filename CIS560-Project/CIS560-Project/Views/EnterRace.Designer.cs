namespace CIS560_Project
{
    partial class uxEnterRace
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
            this.uxEnterRaceLabel = new System.Windows.Forms.Label();
            this.uxLocationLabel = new System.Windows.Forms.Label();
            this.uxLocationListBox = new System.Windows.Forms.ListBox();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDateListBox = new System.Windows.Forms.ListBox();
            this.uxEnterButton = new System.Windows.Forms.Button();
            this.uxCancelButton = new System.Windows.Forms.Button();
            this.uxRunnersLabel = new System.Windows.Forms.Label();
            this.uxRunnersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // uxEnterRaceLabel
            // 
            this.uxEnterRaceLabel.AutoSize = true;
            this.uxEnterRaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterRaceLabel.Location = new System.Drawing.Point(57, 9);
            this.uxEnterRaceLabel.Name = "uxEnterRaceLabel";
            this.uxEnterRaceLabel.Size = new System.Drawing.Size(163, 36);
            this.uxEnterRaceLabel.TabIndex = 0;
            this.uxEnterRaceLabel.Text = "Enter Race";
            // 
            // uxLocationLabel
            // 
            this.uxLocationLabel.AutoSize = true;
            this.uxLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLocationLabel.Location = new System.Drawing.Point(58, 45);
            this.uxLocationLabel.Name = "uxLocationLabel";
            this.uxLocationLabel.Size = new System.Drawing.Size(86, 25);
            this.uxLocationLabel.TabIndex = 1;
            this.uxLocationLabel.Text = "Location";
            // 
            // uxLocationListBox
            // 
            this.uxLocationListBox.FormattingEnabled = true;
            this.uxLocationListBox.ItemHeight = 16;
            this.uxLocationListBox.Location = new System.Drawing.Point(63, 73);
            this.uxLocationListBox.Name = "uxLocationListBox";
            this.uxLocationListBox.Size = new System.Drawing.Size(224, 84);
            this.uxLocationListBox.TabIndex = 2;
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateLabel.Location = new System.Drawing.Point(58, 160);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(53, 25);
            this.uxDateLabel.TabIndex = 3;
            this.uxDateLabel.Text = "Date";
            // 
            // uxDateListBox
            // 
            this.uxDateListBox.FormattingEnabled = true;
            this.uxDateListBox.ItemHeight = 16;
            this.uxDateListBox.Location = new System.Drawing.Point(63, 188);
            this.uxDateListBox.Name = "uxDateListBox";
            this.uxDateListBox.Size = new System.Drawing.Size(224, 84);
            this.uxDateListBox.TabIndex = 4;
            // 
            // uxEnterButton
            // 
            this.uxEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterButton.Location = new System.Drawing.Point(54, 409);
            this.uxEnterButton.Name = "uxEnterButton";
            this.uxEnterButton.Size = new System.Drawing.Size(114, 44);
            this.uxEnterButton.TabIndex = 5;
            this.uxEnterButton.Text = "Enter";
            this.uxEnterButton.UseVisualStyleBackColor = true;
            this.uxEnterButton.Click += new System.EventHandler(this.uxEnterButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCancelButton.Location = new System.Drawing.Point(184, 409);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(114, 44);
            this.uxCancelButton.TabIndex = 6;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseVisualStyleBackColor = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxRunnersLabel
            // 
            this.uxRunnersLabel.AutoSize = true;
            this.uxRunnersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRunnersLabel.Location = new System.Drawing.Point(58, 275);
            this.uxRunnersLabel.Name = "uxRunnersLabel";
            this.uxRunnersLabel.Size = new System.Drawing.Size(85, 25);
            this.uxRunnersLabel.TabIndex = 7;
            this.uxRunnersLabel.Text = "Runners";
            // 
            // uxRunnersCheckedListBox
            // 
            this.uxRunnersCheckedListBox.FormattingEnabled = true;
            this.uxRunnersCheckedListBox.Location = new System.Drawing.Point(63, 304);
            this.uxRunnersCheckedListBox.Name = "uxRunnersCheckedListBox";
            this.uxRunnersCheckedListBox.Size = new System.Drawing.Size(224, 89);
            this.uxRunnersCheckedListBox.TabIndex = 8;
            // 
            // uxEnterRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 496);
            this.Controls.Add(this.uxRunnersCheckedListBox);
            this.Controls.Add(this.uxRunnersLabel);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxEnterButton);
            this.Controls.Add(this.uxDateListBox);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxLocationListBox);
            this.Controls.Add(this.uxLocationLabel);
            this.Controls.Add(this.uxEnterRaceLabel);
            this.Name = "uxEnterRace";
            this.Text = "EnterRace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxEnterRaceLabel;
        private System.Windows.Forms.Label uxLocationLabel;
        private System.Windows.Forms.ListBox uxLocationListBox;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.ListBox uxDateListBox;
        private System.Windows.Forms.Button uxEnterButton;
        private System.Windows.Forms.Button uxCancelButton;
        private System.Windows.Forms.Label uxRunnersLabel;
        private System.Windows.Forms.CheckedListBox uxRunnersCheckedListBox;
    }
}