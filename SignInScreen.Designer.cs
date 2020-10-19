namespace GammersParadise
{
    partial class SignInScreen
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.DOBTB = new System.Windows.Forms.TextBox();
            this.UserNTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.SignInSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(286, 126);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(285, 155);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(288, 208);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(55, 13);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "Username";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(312, 181);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(30, 13);
            this.DOBLabel.TabIndex = 3;
            this.DOBLabel.Text = "DOB";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(290, 234);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(312, 257);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // FNameTB
            // 
            this.FNameTB.Location = new System.Drawing.Point(348, 126);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(100, 20);
            this.FNameTB.TabIndex = 6;
            // 
            // LNameTB
            // 
            this.LNameTB.Location = new System.Drawing.Point(348, 152);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(100, 20);
            this.LNameTB.TabIndex = 7;
            // 
            // DOBTB
            // 
            this.DOBTB.Location = new System.Drawing.Point(348, 178);
            this.DOBTB.Name = "DOBTB";
            this.DOBTB.Size = new System.Drawing.Size(100, 20);
            this.DOBTB.TabIndex = 8;
            // 
            // UserNTB
            // 
            this.UserNTB.Location = new System.Drawing.Point(348, 205);
            this.UserNTB.Name = "UserNTB";
            this.UserNTB.Size = new System.Drawing.Size(100, 20);
            this.UserNTB.TabIndex = 9;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(348, 231);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 10;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(348, 257);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(100, 20);
            this.EmailTB.TabIndex = 11;
            // 
            // SignInSubmitButton
            // 
            this.SignInSubmitButton.Location = new System.Drawing.Point(359, 314);
            this.SignInSubmitButton.Name = "SignInSubmitButton";
            this.SignInSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SignInSubmitButton.TabIndex = 13;
            this.SignInSubmitButton.Text = "Submit";
            this.SignInSubmitButton.UseVisualStyleBackColor = true;
            this.SignInSubmitButton.Click += new System.EventHandler(this.SignInSubmitButton_Click);
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignInSubmitButton);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserNTB);
            this.Controls.Add(this.DOBTB);
            this.Controls.Add(this.LNameTB);
            this.Controls.Add(this.FNameTB);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstName);
            this.Name = "SignInScreen";
            this.Text = "SignInScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.TextBox DOBTB;
        private System.Windows.Forms.TextBox UserNTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Button SignInSubmitButton;
    }
}