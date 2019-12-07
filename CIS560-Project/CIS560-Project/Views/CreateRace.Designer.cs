namespace CIS560_Project
{
    partial class uxCreateRace
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
            this.uxCreateRaceLabel = new System.Windows.Forms.Label();
            this.uxLocationList = new System.Windows.Forms.ListBox();
            this.uxSaveRaceButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uxCreateRaceLabel
            // 
            this.uxCreateRaceLabel.AutoSize = true;
            this.uxCreateRaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCreateRaceLabel.Location = new System.Drawing.Point(36, 55);
            this.uxCreateRaceLabel.Name = "uxCreateRaceLabel";
            this.uxCreateRaceLabel.Size = new System.Drawing.Size(179, 36);
            this.uxCreateRaceLabel.TabIndex = 0;
            this.uxCreateRaceLabel.Text = "Create Race";
            // 
            // uxLocationList
            // 
            this.uxLocationList.FormattingEnabled = true;
            this.uxLocationList.ItemHeight = 16;
            this.uxLocationList.Location = new System.Drawing.Point(52, 115);
            this.uxLocationList.Name = "uxLocationList";
            this.uxLocationList.Size = new System.Drawing.Size(229, 84);
            this.uxLocationList.TabIndex = 1;
            // 
            // uxSaveRaceButton
            // 
            this.uxSaveRaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveRaceButton.Location = new System.Drawing.Point(31, 269);
            this.uxSaveRaceButton.Name = "uxSaveRaceButton";
            this.uxSaveRaceButton.Size = new System.Drawing.Size(120, 45);
            this.uxSaveRaceButton.TabIndex = 2;
            this.uxSaveRaceButton.Text = "Save";
            this.uxSaveRaceButton.UseVisualStyleBackColor = true;
            this.uxSaveRaceButton.Click += new System.EventHandler(this.uxSaveRaceButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBackButton.Location = new System.Drawing.Point(178, 269);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(120, 45);
            this.uxBackButton.TabIndex = 3;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Location = new System.Drawing.Point(52, 206);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(229, 22);
            this.uxDateTimePicker.TabIndex = 4;
            // 
            // uxCreateRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDateTimePicker);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxSaveRaceButton);
            this.Controls.Add(this.uxLocationList);
            this.Controls.Add(this.uxCreateRaceLabel);
            this.Name = "uxCreateRace";
            this.Text = "CreateRace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxCreateRaceLabel;
        private System.Windows.Forms.ListBox uxLocationList;
        private System.Windows.Forms.Button uxSaveRaceButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
    }
}