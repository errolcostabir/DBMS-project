namespace dbms
{
    partial class tsignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tsignup));
            this.fname = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.go_back = new System.Windows.Forms.LinkLabel();
            this.lname = new System.Windows.Forms.TextBox();
            this.phone_no = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dept = new System.Windows.Forms.ComboBox();
            this.confirm_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Ink Free", 12F);
            this.fname.Location = new System.Drawing.Point(75, 52);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(208, 27);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name";
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fname.Enter += new System.EventHandler(this.fname_Enter);
            this.fname.Leave += new System.EventHandler(this.fname_Leave);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.Location = new System.Drawing.Point(102, 414);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(154, 34);
            this.register.TabIndex = 1;
            this.register.Text = "REGISTER";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // go_back
            // 
            this.go_back.AutoSize = true;
            this.go_back.BackColor = System.Drawing.Color.Transparent;
            this.go_back.LinkColor = System.Drawing.Color.Gold;
            this.go_back.Location = new System.Drawing.Point(12, 435);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(54, 13);
            this.go_back.TabIndex = 2;
            this.go_back.TabStop = true;
            this.go_back.Text = "GO BACK";
            this.go_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Ink Free", 12F);
            this.lname.Location = new System.Drawing.Point(75, 100);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(208, 27);
            this.lname.TabIndex = 3;
            this.lname.Text = "Last Name";
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lname.Enter += new System.EventHandler(this.lname_Enter);
            this.lname.Leave += new System.EventHandler(this.lname_Leave);
            // 
            // phone_no
            // 
            this.phone_no.Font = new System.Drawing.Font("Ink Free", 12F);
            this.phone_no.Location = new System.Drawing.Point(75, 147);
            this.phone_no.Name = "phone_no";
            this.phone_no.Size = new System.Drawing.Size(208, 27);
            this.phone_no.TabIndex = 4;
            this.phone_no.Text = "Phone Number";
            this.phone_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone_no.Enter += new System.EventHandler(this.phone_no_Enter);
            this.phone_no.Leave += new System.EventHandler(this.phone_no_Leave);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Ink Free", 12F);
            this.username.Location = new System.Drawing.Point(75, 252);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(208, 27);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Ink Free", 12F);
            this.password.Location = new System.Drawing.Point(75, 300);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(208, 27);
            this.password.TabIndex = 7;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.confirm_pass);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.go_back);
            this.panel1.Controls.Add(this.dept);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.phone_no);
            this.panel1.Location = new System.Drawing.Point(46, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 464);
            this.panel1.TabIndex = 8;
            // 
            // dept
            // 
            this.dept.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "MECHANICAL",
            "COMPUTER",
            "ETC",
            "IT",
            "CIVIL"});
            this.dept.Location = new System.Drawing.Point(75, 199);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(208, 28);
            this.dept.TabIndex = 9;
            this.dept.Text = "              Department";
            this.dept.Enter += new System.EventHandler(this.dept_Enter_1);
            this.dept.Leave += new System.EventHandler(this.dept_Leave);
            // 
            // confirm_pass
            // 
            this.confirm_pass.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_pass.Location = new System.Drawing.Point(75, 350);
            this.confirm_pass.Name = "confirm_pass";
            this.confirm_pass.Size = new System.Drawing.Size(208, 27);
            this.confirm_pass.TabIndex = 10;
            this.confirm_pass.Text = "Confirm Password";
            this.confirm_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirm_pass.Enter += new System.EventHandler(this.confirm_pass_Enter);
            this.confirm_pass.Leave += new System.EventHandler(this.confirm_pass_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(289, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 15;
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
            this.button2.Location = new System.Drawing.Point(289, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "TEACHER REGISTRATION DESK";
            // 
            // tsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(464, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tsignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tsignup";
            this.Load += new System.EventHandler(this.tsignup_Load);
            this.Enter += new System.EventHandler(this.tsignup_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.LinkLabel go_back;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox phone_no;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.TextBox confirm_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}