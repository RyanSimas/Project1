namespace GammersParadise
{
    partial class LogInScreen
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PaswordTextbox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(204, 150);
            this.UserNameLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.UserNameLabel.MinimumSize = new System.Drawing.Size(120, 20);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(120, 24);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "Username";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.CausesValidation = false;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(354, 150);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(197, 20);
            this.UsernameTextBox.TabIndex = 3;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PaswordTextbox
            // 
            this.PaswordTextbox.Location = new System.Drawing.Point(354, 198);
            this.PaswordTextbox.Name = "PaswordTextbox";
            this.PaswordTextbox.Size = new System.Drawing.Size(197, 20);
            this.PaswordTextbox.TabIndex = 4;
            this.PaswordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(365, 297);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // LogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PaswordTextbox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameLabel);
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "LogInScreen";
            this.Text = "LogInScreen";
            this.Load += new System.EventHandler(this.LogInScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PaswordTextbox;
        private System.Windows.Forms.Button SubmitButton;
    }
}