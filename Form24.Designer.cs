﻿namespace DBPROJ4
{
    partial class Form24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form24));
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            button6 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(314, 472);
            button9.Name = "button9";
            button9.Size = new Size(187, 23);
            button9.TabIndex = 95;
            button9.Text = "Delete Staff Record";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(314, 433);
            button8.Name = "button8";
            button8.Size = new Size(187, 23);
            button8.TabIndex = 94;
            button8.Text = "Update Staff Details";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(314, 385);
            button7.Name = "button7";
            button7.Size = new Size(187, 23);
            button7.TabIndex = 93;
            button7.Text = "View Staff Members";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Location = new Point(314, 340);
            button5.Name = "button5";
            button5.Size = new Size(187, 23);
            button5.TabIndex = 92;
            button5.Text = "Add Staff Member";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            textBox2.Location = new Point(271, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 36);
            textBox2.TabIndex = 91;
            textBox2.Text = "Manage Staff";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button6
            // 
            button6.Location = new Point(816, 472);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 90;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(176, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(489, 50);
            textBox1.TabIndex = 89;
            textBox1.Text = "Admin Dashboard";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(905, 187);
            pictureBox2.TabIndex = 88;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(128, 461);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 96;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form24
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(932, 507);
            Controls.Add(button1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Name = "Form24";
            Text = "Form24";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button9;
        private Button button8;
        private Button button7;
        private Button button5;
        private TextBox textBox2;
        private Button button6;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}