namespace dbms
{
    partial class teachhomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teachhomepage));
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.teachername = new System.Windows.Forms.Label();
            this.updatemarkspanel = new System.Windows.Forms.Panel();
            this.itbutton = new System.Windows.Forms.Button();
            this.mechbutton = new System.Windows.Forms.Button();
            this.etcbutton = new System.Windows.Forms.Button();
            this.updatemarkbutton = new System.Windows.Forms.Button();
            this.compbutton = new System.Windows.Forms.Button();
            this.detailspan = new System.Windows.Forms.Panel();
            this.changepwbutton = new System.Windows.Forms.Button();
            this.detailsbutton = new System.Windows.Forms.Button();
            this.changephnobutton = new System.Windows.Forms.Button();
            this.subjectdetailspanel = new System.Windows.Forms.Panel();
            this.questbankbutton = new System.Windows.Forms.Button();
            this.studdoubtsbutton = new System.Windows.Forms.Button();
            this.subdetailsbutton = new System.Windows.Forms.Button();
            this.detailstimer = new System.Windows.Forms.Timer(this.components);
            this.updatetimer = new System.Windows.Forms.Timer(this.components);
            this.detailtime = new System.Windows.Forms.Timer(this.components);
            this.teachlogout = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatemarkspanel.SuspendLayout();
            this.detailspan.SuspendLayout();
            this.subjectdetailspanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Welcomelabel.Location = new System.Drawing.Point(187, 27);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(167, 40);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "Welcome";
            this.Welcomelabel.Click += new System.EventHandler(this.Welcomelabel_Click);
            // 
            // teachername
            // 
            this.teachername.AutoSize = true;
            this.teachername.BackColor = System.Drawing.Color.Transparent;
            this.teachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teachername.Location = new System.Drawing.Point(372, 27);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(117, 40);
            this.teachername.TabIndex = 1;
            this.teachername.Text = "tname";
            // 
            // updatemarkspanel
            // 
            this.updatemarkspanel.Controls.Add(this.itbutton);
            this.updatemarkspanel.Controls.Add(this.mechbutton);
            this.updatemarkspanel.Controls.Add(this.etcbutton);
            this.updatemarkspanel.Controls.Add(this.updatemarkbutton);
            this.updatemarkspanel.Controls.Add(this.compbutton);
            this.updatemarkspanel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemarkspanel.Location = new System.Drawing.Point(247, 98);
            this.updatemarkspanel.MaximumSize = new System.Drawing.Size(200, 153);
            this.updatemarkspanel.MinimumSize = new System.Drawing.Size(200, 32);
            this.updatemarkspanel.Name = "updatemarkspanel";
            this.updatemarkspanel.Size = new System.Drawing.Size(200, 32);
            this.updatemarkspanel.TabIndex = 3;
            // 
            // itbutton
            // 
            this.itbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.itbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itbutton.Location = new System.Drawing.Point(0, 122);
            this.itbutton.Name = "itbutton";
            this.itbutton.Size = new System.Drawing.Size(200, 33);
            this.itbutton.TabIndex = 4;
            this.itbutton.Text = "IT DEPARTMENT";
            this.itbutton.UseVisualStyleBackColor = false;
            // 
            // mechbutton
            // 
            this.mechbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.mechbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mechbutton.Location = new System.Drawing.Point(0, 91);
            this.mechbutton.Name = "mechbutton";
            this.mechbutton.Size = new System.Drawing.Size(200, 33);
            this.mechbutton.TabIndex = 3;
            this.mechbutton.Text = "MECHANICAL DEPARTMENT";
            this.mechbutton.UseVisualStyleBackColor = false;
            // 
            // etcbutton
            // 
            this.etcbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.etcbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.etcbutton.Location = new System.Drawing.Point(0, 60);
            this.etcbutton.Name = "etcbutton";
            this.etcbutton.Size = new System.Drawing.Size(200, 33);
            this.etcbutton.TabIndex = 2;
            this.etcbutton.Text = "ELECTRICAL DEPARTMENT";
            this.etcbutton.UseVisualStyleBackColor = false;
            // 
            // updatemarkbutton
            // 
            this.updatemarkbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.updatemarkbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatemarkbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatemarkbutton.Location = new System.Drawing.Point(0, -1);
            this.updatemarkbutton.Name = "updatemarkbutton";
            this.updatemarkbutton.Size = new System.Drawing.Size(200, 33);
            this.updatemarkbutton.TabIndex = 0;
            this.updatemarkbutton.Text = "UPDATE MARKS";
            this.updatemarkbutton.UseVisualStyleBackColor = false;
            this.updatemarkbutton.Click += new System.EventHandler(this.updatemarkbutton_Click);
            // 
            // compbutton
            // 
            this.compbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.compbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compbutton.Location = new System.Drawing.Point(0, 31);
            this.compbutton.Name = "compbutton";
            this.compbutton.Size = new System.Drawing.Size(200, 33);
            this.compbutton.TabIndex = 1;
            this.compbutton.Text = "COMPUTER DEPARTMENT";
            this.compbutton.UseVisualStyleBackColor = false;
            this.compbutton.Click += new System.EventHandler(this.compbutton_Click);
            // 
            // detailspan
            // 
            this.detailspan.Controls.Add(this.changepwbutton);
            this.detailspan.Controls.Add(this.detailsbutton);
            this.detailspan.Controls.Add(this.changephnobutton);
            this.detailspan.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailspan.Location = new System.Drawing.Point(459, 98);
            this.detailspan.MaximumSize = new System.Drawing.Size(200, 95);
            this.detailspan.MinimumSize = new System.Drawing.Size(200, 32);
            this.detailspan.Name = "detailspan";
            this.detailspan.Size = new System.Drawing.Size(200, 32);
            this.detailspan.TabIndex = 3;
            // 
            // changepwbutton
            // 
            this.changepwbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.changepwbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepwbutton.Location = new System.Drawing.Point(0, 63);
            this.changepwbutton.Name = "changepwbutton";
            this.changepwbutton.Size = new System.Drawing.Size(200, 33);
            this.changepwbutton.TabIndex = 2;
            this.changepwbutton.Text = "CHANGE PASSWORD";
            this.changepwbutton.UseVisualStyleBackColor = false;
            // 
            // detailsbutton
            // 
            this.detailsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.detailsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detailsbutton.Location = new System.Drawing.Point(0, -1);
            this.detailsbutton.Name = "detailsbutton";
            this.detailsbutton.Size = new System.Drawing.Size(200, 33);
            this.detailsbutton.TabIndex = 0;
            this.detailsbutton.Text = "update ";
            this.detailsbutton.UseVisualStyleBackColor = false;
            this.detailsbutton.Click += new System.EventHandler(this.detailsbutton_Click);
            // 
            // changephnobutton
            // 
            this.changephnobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.changephnobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changephnobutton.Location = new System.Drawing.Point(0, 31);
            this.changephnobutton.Name = "changephnobutton";
            this.changephnobutton.Size = new System.Drawing.Size(200, 33);
            this.changephnobutton.TabIndex = 1;
            this.changephnobutton.Text = "CHANGE PHONE NUMBER";
            this.changephnobutton.UseVisualStyleBackColor = false;
            // 
            // subjectdetailspanel
            // 
            this.subjectdetailspanel.Controls.Add(this.questbankbutton);
            this.subjectdetailspanel.Controls.Add(this.studdoubtsbutton);
            this.subjectdetailspanel.Controls.Add(this.subdetailsbutton);
            this.subjectdetailspanel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectdetailspanel.Location = new System.Drawing.Point(20, 98);
            this.subjectdetailspanel.MaximumSize = new System.Drawing.Size(200, 105);
            this.subjectdetailspanel.MinimumSize = new System.Drawing.Size(200, 32);
            this.subjectdetailspanel.Name = "subjectdetailspanel";
            this.subjectdetailspanel.Size = new System.Drawing.Size(200, 32);
            this.subjectdetailspanel.TabIndex = 4;
            // 
            // questbankbutton
            // 
            this.questbankbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.questbankbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.questbankbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questbankbutton.Location = new System.Drawing.Point(0, 62);
            this.questbankbutton.Name = "questbankbutton";
            this.questbankbutton.Size = new System.Drawing.Size(200, 33);
            this.questbankbutton.TabIndex = 2;
            this.questbankbutton.Text = "QUESTION BANK";
            this.questbankbutton.UseVisualStyleBackColor = false;
            // 
            // studdoubtsbutton
            // 
            this.studdoubtsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.studdoubtsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studdoubtsbutton.Location = new System.Drawing.Point(0, 31);
            this.studdoubtsbutton.Name = "studdoubtsbutton";
            this.studdoubtsbutton.Size = new System.Drawing.Size(200, 33);
            this.studdoubtsbutton.TabIndex = 1;
            this.studdoubtsbutton.Text = "STUDENT DOUBTS";
            this.studdoubtsbutton.UseVisualStyleBackColor = false;
            this.studdoubtsbutton.Click += new System.EventHandler(this.studdoubtsbutton_Click);
            // 
            // subdetailsbutton
            // 
            this.subdetailsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.subdetailsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subdetailsbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subdetailsbutton.Location = new System.Drawing.Point(0, -1);
            this.subdetailsbutton.Name = "subdetailsbutton";
            this.subdetailsbutton.Size = new System.Drawing.Size(200, 33);
            this.subdetailsbutton.TabIndex = 0;
            this.subdetailsbutton.Text = "SUBJECT DETAILS";
            this.subdetailsbutton.UseVisualStyleBackColor = false;
            this.subdetailsbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subdetailsbutton_MouseClick);
            // 
            // detailstimer
            // 
            this.detailstimer.Interval = 9;
            this.detailstimer.Tick += new System.EventHandler(this.detailstimer_Tick);
            // 
            // updatetimer
            // 
            this.updatetimer.Interval = 9;
            this.updatetimer.Tick += new System.EventHandler(this.updatetimer_Tick);
            // 
            // detailtime
            // 
            this.detailtime.Interval = 9;
            this.detailtime.Tick += new System.EventHandler(this.detailtime_Tick);
            // 
            // teachlogout
            // 
            this.teachlogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.teachlogout.AutoSize = true;
            this.teachlogout.BackColor = System.Drawing.Color.Transparent;
            this.teachlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachlogout.LinkColor = System.Drawing.Color.White;
            this.teachlogout.Location = new System.Drawing.Point(612, 308);
            this.teachlogout.Name = "teachlogout";
            this.teachlogout.Size = new System.Drawing.Size(70, 16);
            this.teachlogout.TabIndex = 5;
            this.teachlogout.TabStop = true;
            this.teachlogout.Text = "LOGOUT";
            this.teachlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teachlogout_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subjectdetailspanel);
            this.panel1.Controls.Add(this.teachername);
            this.panel1.Controls.Add(this.detailspan);
            this.panel1.Controls.Add(this.Welcomelabel);
            this.panel1.Controls.Add(this.teachlogout);
            this.panel1.Controls.Add(this.updatemarkspanel);
            this.panel1.Location = new System.Drawing.Point(43, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 341);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // teachhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teachhomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teachhomepage";
            this.Load += new System.EventHandler(this.teachhomepage_Load);
            this.updatemarkspanel.ResumeLayout(false);
            this.detailspan.ResumeLayout(false);
            this.subjectdetailspanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label teachername;
        private System.Windows.Forms.Panel updatemarkspanel;
        private System.Windows.Forms.Panel detailspan;
        private System.Windows.Forms.Panel subjectdetailspanel;
        private System.Windows.Forms.Button questbankbutton;
        private System.Windows.Forms.Button studdoubtsbutton;
        private System.Windows.Forms.Button subdetailsbutton;
        private System.Windows.Forms.Button updatemarkbutton;
        private System.Windows.Forms.Button itbutton;
        private System.Windows.Forms.Button mechbutton;
        private System.Windows.Forms.Button etcbutton;
        private System.Windows.Forms.Button compbutton;
        private System.Windows.Forms.Button changepwbutton;
        private System.Windows.Forms.Button changephnobutton;
        private System.Windows.Forms.Button detailsbutton;
        private System.Windows.Forms.Timer detailstimer;
        private System.Windows.Forms.Timer updatetimer;
        private System.Windows.Forms.Timer detailtime;
        private System.Windows.Forms.LinkLabel teachlogout;
        private System.Windows.Forms.Panel panel1;
    }
}