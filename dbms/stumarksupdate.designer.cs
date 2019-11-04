namespace dbms

{
    partial class stumarksupdate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTMARKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksset = new dbms.marksset();
            this.branch = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.SID1 = new System.Windows.Forms.TextBox();
            this.Marks1 = new System.Windows.Forms.TextBox();
            this.Marks2 = new System.Windows.Forms.TextBox();
            this.Marks3 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.backlink = new System.Windows.Forms.LinkLabel();
            this.sTUDENT_MARKSTableAdapter = new dbms.markssetTableAdapters.STUDENT_MARKSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTMARKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.dEPARTMENTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTUDENTMARKSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(112, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "SID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            this.aDataGridViewTextBoxColumn.HeaderText = "A";
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            // 
            // dEPARTMENTDataGridViewTextBoxColumn
            // 
            this.dEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT";
            this.dEPARTMENTDataGridViewTextBoxColumn.Name = "dEPARTMENTDataGridViewTextBoxColumn";
            // 
            // sTUDENTMARKSBindingSource
            // 
            this.sTUDENTMARKSBindingSource.DataMember = "STUDENT_MARKS";
            this.sTUDENTMARKSBindingSource.DataSource = this.marksset;
            // 
            // marksset
            // 
            this.marksset.DataSetName = "marksset";
            this.marksset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.BackColor = System.Drawing.Color.Transparent;
            this.branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.branch.Location = new System.Drawing.Point(266, 68);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(107, 20);
            this.branch.TabIndex = 1;
            this.branch.Text = "COMPUTER";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.BackColor = System.Drawing.Color.Transparent;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Department.Location = new System.Drawing.Point(390, 68);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(128, 20);
            this.Department.TabIndex = 2;
            this.Department.Text = "DEPARTMENT";
            // 
            // SID1
            // 
            this.SID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID1.Location = new System.Drawing.Point(112, 349);
            this.SID1.Name = "SID1";
            this.SID1.Size = new System.Drawing.Size(66, 20);
            this.SID1.TabIndex = 3;
            this.SID1.Text = "SID";
            this.SID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SID1.Enter += new System.EventHandler(this.SID_Enter);
            this.SID1.Leave += new System.EventHandler(this.SID_Leave);
            // 
            // Marks1
            // 
            this.Marks1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks1.Location = new System.Drawing.Point(240, 349);
            this.Marks1.Name = "Marks1";
            this.Marks1.Size = new System.Drawing.Size(100, 20);
            this.Marks1.TabIndex = 4;
            this.Marks1.Text = "Marks1";
            this.Marks1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Marks1.Enter += new System.EventHandler(this.Marks1_Enter);
            this.Marks1.Leave += new System.EventHandler(this.Marks1_Leave);
            // 
            // Marks2
            // 
            this.Marks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks2.Location = new System.Drawing.Point(385, 349);
            this.Marks2.Name = "Marks2";
            this.Marks2.Size = new System.Drawing.Size(100, 20);
            this.Marks2.TabIndex = 5;
            this.Marks2.Text = "Marks2";
            this.Marks2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Marks2.Enter += new System.EventHandler(this.Marks2_Enter);
            this.Marks2.Leave += new System.EventHandler(this.Marks2_Leave);
            // 
            // Marks3
            // 
            this.Marks3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks3.Location = new System.Drawing.Point(554, 349);
            this.Marks3.Name = "Marks3";
            this.Marks3.Size = new System.Drawing.Size(100, 20);
            this.Marks3.TabIndex = 6;
            this.Marks3.Text = "Marks3";
            this.Marks3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Marks3.Enter += new System.EventHandler(this.Marks3_Enter);
            this.Marks3.Leave += new System.EventHandler(this.Marks3_Leave);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update.Location = new System.Drawing.Point(405, 398);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(135, 39);
            this.update.TabIndex = 7;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // backlink
            // 
            this.backlink.AutoSize = true;
            this.backlink.BackColor = System.Drawing.Color.Transparent;
            this.backlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backlink.LinkColor = System.Drawing.Color.White;
            this.backlink.Location = new System.Drawing.Point(699, 421);
            this.backlink.Name = "backlink";
            this.backlink.Size = new System.Drawing.Size(47, 16);
            this.backlink.TabIndex = 8;
            this.backlink.TabStop = true;
            this.backlink.Text = "BACK";
            this.backlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backlink_LinkClicked);
            // 
            // sTUDENT_MARKSTableAdapter
            // 
            this.sTUDENT_MARKSTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(205, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "DELETE Marks";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stumarksupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backlink);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Marks3);
            this.Controls.Add(this.Marks2);
            this.Controls.Add(this.Marks1);
            this.Controls.Add(this.SID1);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stumarksupdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT MARKS UPDATE";
            this.Load += new System.EventHandler(this.stumarksupdate_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTMARKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.TextBox SID1;
        private System.Windows.Forms.TextBox Marks1;
        private System.Windows.Forms.TextBox Marks2;
        private System.Windows.Forms.TextBox Marks3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.LinkLabel backlink;
        private dbms.marksset marksset;
        private System.Windows.Forms.BindingSource sTUDENTMARKSBindingSource;
        private dbms.markssetTableAdapters.STUDENT_MARKSTableAdapter sTUDENT_MARKSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPARTMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

