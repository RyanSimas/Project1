﻿namespace DbIntegrationTest
{
    partial class Form1
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
            this.DBCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DBCall
            // 
            this.DBCall.Location = new System.Drawing.Point(308, 197);
            this.DBCall.Name = "DBCall";
            this.DBCall.Size = new System.Drawing.Size(75, 23);
            this.DBCall.TabIndex = 0;
            this.DBCall.Text = "button1";
            this.DBCall.UseVisualStyleBackColor = true;
            this.DBCall.Click += new System.EventHandler(this.DBCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DBCall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DBCall;
    }
}

