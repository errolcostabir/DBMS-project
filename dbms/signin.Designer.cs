namespace dbms
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.sign_in = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.paswd = new System.Windows.Forms.TextBox();
            this.sign_up = new System.Windows.Forms.LinkLabel();
            this.teacher = new System.Windows.Forms.RadioButton();
            this.student = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.show_pass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sign_in
            // 
            this.sign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.sign_in.FlatAppearance.BorderSize = 0;
            this.sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in.ForeColor = System.Drawing.Color.White;
            this.sign_in.Location = new System.Drawing.Point(131, 384);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(90, 29);
            this.sign_in.TabIndex = 0;
            this.sign_in.Text = "LOGIN";
            this.sign_in.UseVisualStyleBackColor = false;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            this.sign_in.MouseLeave += new System.EventHandler(this.sign_in_MouseLeave);
            this.sign_in.MouseHover += new System.EventHandler(this.sign_in_MouseHover);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.MenuBar;
            this.username.Font = new System.Drawing.Font("Ink Free", 12F);
            this.username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.username.Location = new System.Drawing.Point(63, 261);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(232, 27);
            this.username.TabIndex = 1;
            this.username.Text = "USERNAME";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // paswd
            // 
            this.paswd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.paswd.Font = new System.Drawing.Font("Ink Free", 12F);
            this.paswd.ForeColor = System.Drawing.Color.Gray;
            this.paswd.Location = new System.Drawing.Point(63, 305);
            this.paswd.Name = "paswd";
            this.paswd.Size = new System.Drawing.Size(232, 27);
            this.paswd.TabIndex = 2;
            this.paswd.Text = "PASSWORD";
            this.paswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paswd.TextChanged += new System.EventHandler(this.paswd_TextChanged);
            this.paswd.Enter += new System.EventHandler(this.paswd_Enter);
            this.paswd.Leave += new System.EventHandler(this.paswd_Leave);
            this.paswd.MouseEnter += new System.EventHandler(this.paswd_MouseEnter);
            this.paswd.MouseLeave += new System.EventHandler(this.paswd_MouseLeave);
            // 
            // sign_up
            // 
            this.sign_up.ActiveLinkColor = System.Drawing.Color.White;
            this.sign_up.AutoSize = true;
            this.sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up.LinkColor = System.Drawing.Color.Gold;
            this.sign_up.Location = new System.Drawing.Point(96, 473);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(125, 13);
            this.sign_up.TabIndex = 3;
            this.sign_up.TabStop = true;
            this.sign_up.Text = "GO TO REGISTRATION";
            this.sign_up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sign_up_LinkClicked);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.BackColor = System.Drawing.Color.Transparent;
            this.teacher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.teacher.Location = new System.Drawing.Point(81, 349);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(76, 17);
            this.teacher.TabIndex = 4;
            this.teacher.TabStop = true;
            this.teacher.Text = "TEACHER";
            this.teacher.UseVisualStyleBackColor = false;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.student.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.student.Location = new System.Drawing.Point(199, 349);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(77, 17);
            this.student.TabIndex = 5;
            this.student.TabStop = true;
            this.student.Text = "STUDENT";
            this.student.UseVisualStyleBackColor = false;
            this.student.CheckedChanged += new System.EventHandler(this.student_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(160, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(45, 101);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(154, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.show_pass);
            this.panel1.Controls.Add(this.student);
            this.panel1.Controls.Add(this.sign_up);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.sign_in);
            this.panel1.Controls.Add(this.teacher);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.paswd);
            this.panel1.Location = new System.Drawing.Point(63, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 455);
            this.panel1.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(207, 432);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GO TO REGISTRATION";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 59);
            this.label1.TabIndex = 14;
            this.label1.Text = "LOGIN HERE";
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Transparent;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_button.Location = new System.Drawing.Point(308, 0);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(27, 24);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.Text = "X";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // show_pass
            // 
            this.show_pass.BackColor = System.Drawing.Color.Transparent;
            this.show_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_pass.BackgroundImage")));
            this.show_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.show_pass.FlatAppearance.BorderSize = 0;
            this.show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_pass.Location = new System.Drawing.Point(301, 305);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(27, 27);
            this.show_pass.TabIndex = 13;
            this.show_pass.UseVisualStyleBackColor = false;
            this.show_pass.Click += new System.EventHandler(this.show_pass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox paswd;
        private System.Windows.Forms.LinkLabel sign_up;
        private System.Windows.Forms.RadioButton teacher;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button show_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

