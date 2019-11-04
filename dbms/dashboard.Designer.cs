namespace dbms
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.go_to_marks = new System.Windows.Forms.RadioButton();
            this.go_to_enquiry = new System.Windows.Forms.RadioButton();
            this.go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dash_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.slide = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Button();
            this.close_app = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.del_acc = new System.Windows.Forms.Button();
            this.slide_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // go_to_marks
            // 
            this.go_to_marks.AutoSize = true;
            this.go_to_marks.BackColor = System.Drawing.Color.Transparent;
            this.go_to_marks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_to_marks.Location = new System.Drawing.Point(404, 251);
            this.go_to_marks.Name = "go_to_marks";
            this.go_to_marks.Size = new System.Drawing.Size(200, 17);
            this.go_to_marks.TabIndex = 0;
            this.go_to_marks.TabStop = true;
            this.go_to_marks.Text = "I WOULD LIKE TO SEE MY MARKS";
            this.go_to_marks.UseVisualStyleBackColor = false;
            this.go_to_marks.CheckedChanged += new System.EventHandler(this.go_to_marks_CheckedChanged);
            // 
            // go_to_enquiry
            // 
            this.go_to_enquiry.AutoSize = true;
            this.go_to_enquiry.BackColor = System.Drawing.Color.Transparent;
            this.go_to_enquiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.go_to_enquiry.Location = new System.Drawing.Point(404, 274);
            this.go_to_enquiry.Name = "go_to_enquiry";
            this.go_to_enquiry.Size = new System.Drawing.Size(214, 17);
            this.go_to_enquiry.TabIndex = 1;
            this.go_to_enquiry.TabStop = true;
            this.go_to_enquiry.Text = "TAKE ME TO THE ENQUIRY CENTER";
            this.go_to_enquiry.UseVisualStyleBackColor = false;
            this.go_to_enquiry.CheckedChanged += new System.EventHandler(this.go_to_enquiry_CheckedChanged);
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.go.FlatAppearance.BorderSize = 0;
            this.go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(463, 327);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(97, 32);
            this.go.TabIndex = 2;
            this.go.Text = "LET\'S GO";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(367, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name.Location = new System.Drawing.Point(529, 155);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 45);
            this.name.TabIndex = 6;
            this.name.Text = "la";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dash_timer
            // 
            this.dash_timer.Interval = 30;
            this.dash_timer.Tick += new System.EventHandler(this.dash_timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.go);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.go_to_enquiry);
            this.panel1.Controls.Add(this.go_to_marks);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(82, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 384);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(549, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "sid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(371, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your Student Id Is:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-97, -48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // slide
            // 
            this.slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(75)))), ((int)(((byte)(98)))));
            this.slide.Controls.Add(this.pictureBox3);
            this.slide.Controls.Add(this.update);
            this.slide.Controls.Add(this.close_app);
            this.slide.Controls.Add(this.logout);
            this.slide.Controls.Add(this.del_acc);
            this.slide.Location = new System.Drawing.Point(46, -1);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(159, 456);
            this.slide.TabIndex = 8;
            this.slide.Paint += new System.Windows.Forms.PaintEventHandler(this.slide_Paint_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // update
            // 
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.update.ForeColor = System.Drawing.Color.FloralWhite;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(6, 304);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(147, 35);
            this.update.TabIndex = 15;
            this.update.Text = "UPDATE INFO";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // close_app
            // 
            this.close_app.FlatAppearance.BorderSize = 0;
            this.close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.close_app.ForeColor = System.Drawing.Color.FloralWhite;
            this.close_app.Location = new System.Drawing.Point(3, 421);
            this.close_app.Name = "close_app";
            this.close_app.Size = new System.Drawing.Size(151, 35);
            this.close_app.TabIndex = 14;
            this.close_app.Text = " CLOSE";
            this.close_app.UseVisualStyleBackColor = true;
            this.close_app.Click += new System.EventHandler(this.close_app_Click);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.logout.ForeColor = System.Drawing.Color.FloralWhite;
            this.logout.Location = new System.Drawing.Point(3, 383);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(151, 35);
            this.logout.TabIndex = 13;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // del_acc
            // 
            this.del_acc.FlatAppearance.BorderSize = 0;
            this.del_acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_acc.ForeColor = System.Drawing.Color.FloralWhite;
            this.del_acc.Location = new System.Drawing.Point(3, 342);
            this.del_acc.Name = "del_acc";
            this.del_acc.Size = new System.Drawing.Size(151, 35);
            this.del_acc.TabIndex = 12;
            this.del_acc.Text = "DELETE ACCOUNT";
            this.del_acc.UseVisualStyleBackColor = true;
            this.del_acc.Click += new System.EventHandler(this.del_acc_Click);
            // 
            // slide_button
            // 
            this.slide_button.BackColor = System.Drawing.Color.Transparent;
            this.slide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slide_button.BackgroundImage")));
            this.slide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.slide_button.FlatAppearance.BorderSize = 0;
            this.slide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slide_button.Location = new System.Drawing.Point(3, 3);
            this.slide_button.Name = "slide_button";
            this.slide_button.Size = new System.Drawing.Size(47, 37);
            this.slide_button.TabIndex = 9;
            this.slide_button.UseVisualStyleBackColor = false;
            this.slide_button.Click += new System.EventHandler(this.slide_button_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.slide_button);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 456);
            this.panel2.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(404, 304);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(171, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "GO TO DOCUMENTS STORE";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.slide);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.slide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton go_to_marks;
        private System.Windows.Forms.RadioButton go_to_enquiry;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer dash_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel slide;
        private System.Windows.Forms.Button slide_button;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button del_acc;
        private System.Windows.Forms.Button close_app;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}