namespace dbms
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            this.fname = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.go_to_signin = new System.Windows.Forms.LinkLabel();
            this.lname = new System.Windows.Forms.TextBox();
            this.phone_no = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.tsignup = new System.Windows.Forms.LinkLabel();
            this.confirm_pass = new System.Windows.Forms.TextBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(73, 60);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(245, 26);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name";
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            this.fname.Enter += new System.EventHandler(this.fname_Enter);
            this.fname.Leave += new System.EventHandler(this.fname_Leave);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.Location = new System.Drawing.Point(130, 441);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(132, 28);
            this.register.TabIndex = 1;
            this.register.Text = "REGISTER";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // go_to_signin
            // 
            this.go_to_signin.AutoSize = true;
            this.go_to_signin.LinkColor = System.Drawing.Color.Gold;
            this.go_to_signin.Location = new System.Drawing.Point(3, 456);
            this.go_to_signin.Name = "go_to_signin";
            this.go_to_signin.Size = new System.Drawing.Size(54, 13);
            this.go_to_signin.TabIndex = 2;
            this.go_to_signin.TabStop = true;
            this.go_to_signin.Text = "GO BACK";
            this.go_to_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.go_to_signin_LinkClicked);
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(73, 101);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(245, 26);
            this.lname.TabIndex = 3;
            this.lname.Text = "Last Name";
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            this.lname.Enter += new System.EventHandler(this.lname_Enter);
            this.lname.Layout += new System.Windows.Forms.LayoutEventHandler(this.lname_Layout);
            this.lname.Leave += new System.EventHandler(this.lname_Leave);
            // 
            // phone_no
            // 
            this.phone_no.BackColor = System.Drawing.SystemColors.MenuBar;
            this.phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phone_no.Location = new System.Drawing.Point(73, 151);
            this.phone_no.Name = "phone_no";
            this.phone_no.Size = new System.Drawing.Size(245, 26);
            this.phone_no.TabIndex = 4;
            this.phone_no.Text = "Phone Number";
            this.phone_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone_no.TextChanged += new System.EventHandler(this.phone_no_TextChanged);
            this.phone_no.Enter += new System.EventHandler(this.phone_no_Enter);
            this.phone_no.Leave += new System.EventHandler(this.phone_no_Leave);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.MenuBar;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username.Location = new System.Drawing.Point(73, 296);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(245, 26);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.password.Location = new System.Drawing.Point(73, 343);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(247, 26);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.SystemColors.MenuBar;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "FE",
            "SE",
            "TE",
            "BE"});
            this.year.Location = new System.Drawing.Point(73, 248);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(245, 28);
            this.year.TabIndex = 8;
            this.year.Text = "                   Year";
            this.year.Enter += new System.EventHandler(this.year_Enter);
            this.year.Leave += new System.EventHandler(this.year_Leave);
            // 
            // tsignup
            // 
            this.tsignup.AutoSize = true;
            this.tsignup.LinkColor = System.Drawing.Color.Gold;
            this.tsignup.Location = new System.Drawing.Point(3, 434);
            this.tsignup.Name = "tsignup";
            this.tsignup.Size = new System.Drawing.Size(85, 13);
            this.tsignup.TabIndex = 9;
            this.tsignup.TabStop = true;
            this.tsignup.Text = "I\'M A TEACHER";
            this.tsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tsignup_LinkClicked);
            // 
            // confirm_pass
            // 
            this.confirm_pass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirm_pass.Location = new System.Drawing.Point(73, 388);
            this.confirm_pass.Name = "confirm_pass";
            this.confirm_pass.Size = new System.Drawing.Size(247, 26);
            this.confirm_pass.TabIndex = 11;
            this.confirm_pass.Text = "Confirm Password";
            this.confirm_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirm_pass.Enter += new System.EventHandler(this.confirm_pass_Enter);
            this.confirm_pass.Leave += new System.EventHandler(this.confirm_pass_Leave);
            // 
            // dept
            // 
            this.dept.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dept.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "COMPUTER",
            "INFORMATION TECHNOLOGY",
            "ETC",
            "MECHANICAL",
            "CIVIL",
            "MARINE",
            "AIRCRAFT MAINTAINANCE"});
            this.dept.Location = new System.Drawing.Point(73, 199);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(245, 28);
            this.dept.TabIndex = 12;
            this.dept.Text = "                 Department";
            this.dept.Enter += new System.EventHandler(this.dept_Enter);
            this.dept.Leave += new System.EventHandler(this.dept_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tsignup);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.go_to_signin);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.confirm_pass);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.phone_no);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 484);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(326, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(326, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "STUDENT REGISTRATION DESK";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(464, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.LinkLabel go_to_signin;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox phone_no;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.LinkLabel tsignup;
        private System.Windows.Forms.TextBox confirm_pass;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}