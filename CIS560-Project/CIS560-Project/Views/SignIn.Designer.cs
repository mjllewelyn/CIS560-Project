namespace CIS560_Project
{
    partial class uxSignIn
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
            this.uxEmailTextBox = new System.Windows.Forms.TextBox();
            this.uxSignInLabel = new System.Windows.Forms.Label();
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uxSignInButton = new System.Windows.Forms.Button();
            this.uxErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxEmailTextBox
            // 
            this.uxEmailTextBox.Location = new System.Drawing.Point(136, 216);
            this.uxEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxEmailTextBox.Name = "uxEmailTextBox";
            this.uxEmailTextBox.Size = new System.Drawing.Size(280, 26);
            this.uxEmailTextBox.TabIndex = 0;
            // 
            // uxSignInLabel
            // 
            this.uxSignInLabel.AutoSize = true;
            this.uxSignInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSignInLabel.Location = new System.Drawing.Point(155, 95);
            this.uxSignInLabel.Name = "uxSignInLabel";
            this.uxSignInLabel.Size = new System.Drawing.Size(128, 40);
            this.uxSignInLabel.TabIndex = 1;
            this.uxSignInLabel.Text = "Sign In";
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Location = new System.Drawing.Point(136, 188);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.uxEmailLabel.TabIndex = 2;
            this.uxEmailLabel.Text = "Email";
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(136, 305);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.uxPasswordLabel.TabIndex = 4;
            this.uxPasswordLabel.Text = "Password";
            // 
            // uxPasswordTextBox
            // 
            this.uxPasswordTextBox.Location = new System.Drawing.Point(136, 334);
            this.uxPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.PasswordChar = '*';
            this.uxPasswordTextBox.Size = new System.Drawing.Size(280, 26);
            this.uxPasswordTextBox.TabIndex = 3;
            // 
            // uxSignInButton
            // 
            this.uxSignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSignInButton.Location = new System.Drawing.Point(191, 416);
            this.uxSignInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uxSignInButton.Name = "uxSignInButton";
            this.uxSignInButton.Size = new System.Drawing.Size(147, 60);
            this.uxSignInButton.TabIndex = 5;
            this.uxSignInButton.Text = "Sign In";
            this.uxSignInButton.UseVisualStyleBackColor = true;
            this.uxSignInButton.Click += new System.EventHandler(this.uxSignInButton_Click);
            // 
            // uxErrorLabel
            // 
            this.uxErrorLabel.AutoSize = true;
            this.uxErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.uxErrorLabel.Location = new System.Drawing.Point(140, 145);
            this.uxErrorLabel.Name = "uxErrorLabel";
            this.uxErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.uxErrorLabel.TabIndex = 6;
            // 
            // uxSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 565);
            this.Controls.Add(this.uxErrorLabel);
            this.Controls.Add(this.uxSignInButton);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxPasswordTextBox);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxSignInLabel);
            this.Controls.Add(this.uxEmailTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uxSignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxEmailTextBox;
        private System.Windows.Forms.Label uxSignInLabel;
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.TextBox uxPasswordTextBox;
        private System.Windows.Forms.Button uxSignInButton;
        private System.Windows.Forms.Label uxErrorLabel;
    }
}

