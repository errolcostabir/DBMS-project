using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{
    public partial class dashboard : Form
    {
        int panelWidth;
        bool Hidden;
        public dashboard()
        {
            InitializeComponent();
            panelWidth = slide.Width;
            slide.Width = 0;
            Hidden = true;
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (go_to_marks.Checked)
            {
                marks ss = new marks();
                ss.Show();
                this.Hide();
            }
            else if (go_to_enquiry.Checked)
            {
                studentdoubt ss = new studentdoubt();
                ss.Show();
                this.Hide();
            }
            else if (radioButton1.Checked)
            {
                itsallhere ss = new itsallhere();
                ss.Show();
                this.Hide();
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin ss = new signin();
            ss.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 44, 62, 80);
            name.Text = passclass.uname;
            label3.Text = passclass.id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           signin ss = new signin();
            ss.Show();
            this.Hide();
        }

        private void slide_button_Click(object sender, EventArgs e)
        {
            dash_timer.Start();
        }

        private void dash_timer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                slide.Width = slide.Width + 10;
                if (slide.Width >= panelWidth)
                {
                    dash_timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                slide.Width = slide.Width - 10;
                if (slide.Width <= 0)
                {
                    dash_timer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void close_form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slide_button_Click_1(object sender, EventArgs e)
        {
            dash_timer.Start();
        }
          

        private void close_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            signin ss = new signin();
            ss.Show();
            this.Hide();

        }

        private void slide_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void del_acc_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
            if(MessageBox.Show("DO YOU REALLY WANT TO DELETE THE ACCOUNT????", "CONFIRM", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cmdText = "DELETE from sign_up WHERE sid  = :ID";
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand(cmdText, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add("ID", passclass.id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("DELETED ACCOUNT");
                signin ss = new signin();
                ss.Show();
                this.Hide();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            passclass.Test = 0;
            update ss = new update();
            ss.Show();
            this.Hide();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void go_to_enquiry_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void go_to_marks_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
