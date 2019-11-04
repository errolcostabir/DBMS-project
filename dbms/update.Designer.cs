namespace dbms
{
    partial class update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update));
            this.go_back = new System.Windows.Forms.Button();
            this.change_pass = new System.Windows.Forms.TextBox();
            this.change_phone = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phone_change = new System.Windows.Forms.CheckBox();
            this.pass_change = new System.Windows.Forms.CheckBox();
            this.update_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_pass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // go_back
            // 
            this.go_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.go_back.FlatAppearance.BorderSize = 0;
            this.go_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.go_back.Location = new System.Drawing.Point(65, 442);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(75, 23);
            this.go_back.TabIndex = 0;
            this.go_back.Text = "GO BACK";
            this.go_back.UseVisualStyleBackColor = false;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // change_pass
            // 
            this.change_pass.Location = new System.Drawing.Point(84, 58);
            this.change_pass.Name = "change_pass";
            this.change_pass.Size = new System.Drawing.Size(161, 20);
            this.change_pass.TabIndex = 1;
            this.change_pass.UseSystemPasswordChar = true;
            // 
            // change_phone
            // 
            this.change_phone.Location = new System.Drawing.Point(84, 62);
            this.change_phone.MaxLength = 10;
            this.change_phone.Name = "change_phone";
            this.change_phone.Size = new System.Drawing.Size(161, 20);
            this.change_phone.TabIndex = 2;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.la.Location = new System.Drawing.Point(10, 34);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(118, 16);
            this.la.TabIndex = 3;
            this.la.Text = "PHONE NUMBER";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pass.Location = new System.Drawing.Point(6, 39);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(122, 16);
            this.pass.TabIndex = 4;
            this.pass.Text = "NEW PASSWORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.phone_change);
            this.panel1.Controls.Add(this.pass_change);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.go_back);
            this.panel1.Location = new System.Drawing.Point(91, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 484);
            this.panel1.TabIndex = 5;
            // 
            // phone_change
            // 
            this.phone_change.AutoSize = true;
            this.phone_change.BackColor = System.Drawing.Color.Transparent;
            this.phone_change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phone_change.Location = new System.Drawing.Point(15, 381);
            this.phone_change.Name = "phone_change";
            this.phone_change.Size = new System.Drawing.Size(162, 17);
            this.phone_change.TabIndex = 10;
            this.phone_change.Text = "CHANGE PHONE NUMBER";
            this.phone_change.UseVisualStyleBackColor = false;
            // 
            // pass_change
            // 
            this.pass_change.AutoSize = true;
            this.pass_change.BackColor = System.Drawing.Color.Transparent;
            this.pass_change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pass_change.Location = new System.Drawing.Point(15, 358);
            this.pass_change.Name = "pass_change";
            this.pass_change.Size = new System.Drawing.Size(137, 17);
            this.pass_change.TabIndex = 9;
            this.pass_change.Text = "CHANGE PASSWORD";
            this.pass_change.UseVisualStyleBackColor = false;
            // 
            // update_button
            // 
            this.update_button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.update_button.AllowDrop = true;
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_button.Location = new System.Drawing.Point(158, 442);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.change_phone);
            this.groupBox2.Controls.Add(this.la);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(3, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 118);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHANGE PHONE NUMBER";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.change_pass);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.confirm_pass);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHANGE PASSWORD";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(248, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(248, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONFIRM PASSWORD";
            // 
            // confirm_pass
            // 
            this.confirm_pass.Location = new System.Drawing.Point(84, 119);
            this.confirm_pass.Name = "confirm_pass";
            this.confirm_pass.Size = new System.Drawing.Size(161, 20);
            this.confirm_pass.TabIndex = 5;
            this.confirm_pass.UseSystemPasswordChar = true;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button go_back;
        private System.Windows.Forms.TextBox change_pass;
        private System.Windows.Forms.TextBox change_phone;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox phone_change;
        private System.Windows.Forms.CheckBox pass_change;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirm_pass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}