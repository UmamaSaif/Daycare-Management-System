﻿namespace DBPROJ4
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(790, 467);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 73;
            button3.Text = "Signup";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(462, 467);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 72;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(346, 467);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 71;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(358, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 46);
            textBox3.TabIndex = 70;
            textBox3.Text = "Login/Signup";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 417);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 69;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 376);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 68;
            label2.Text = "Email:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(346, 417);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(227, 23);
            textBox5.TabIndex = 67;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.UseSystemPasswordChar = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(346, 373);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(227, 23);
            textBox6.TabIndex = 66;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(374, 319);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(159, 23);
            textBox7.TabIndex = 65;
            textBox7.Text = "Admin Login";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(907, 202);
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(932, 507);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(pictureBox2);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private PictureBox pictureBox2;
    }
}