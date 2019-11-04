using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
namespace dbms
{
    public partial class signin : Form
    {
        private object name;

        public signin()
        {
            InitializeComponent();
        }

        private void sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup newForm = new signup();
            newForm.Show(); this.Hide();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
         
   if (teacher.Checked)
            {               
                string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string query = "Select username,password From t_signup where username = '" + username.Text.Trim() + "' and password = '" + paswd.Text.Trim() + "'";
                OracleDataAdapter sda = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    cmd.CommandText = "select fname,tid from t_signup where username = '" + username.Text.Trim() + "'";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    passclass.uname = dr["fname"].ToString();
                    passclass.id = dr["tid"].ToString();
                    teachhomepage ss = new teachhomepage();
                    ss.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Check your Username and Password");
                }
            }
            else if (student.Checked)
            {                
                string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
                OracleConnection conn = new OracleConnection(oradb);  // C#
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                string query = "Select username,password From sign_up where username = '" + username.Text.Trim() + "' and password = '" + paswd.Text.Trim() + "'";
                OracleDataAdapter sda = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    
                    cmd.CommandText = "select fname,sid from sign_up where username = '" + username.Text.Trim() + "'";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    passclass.uname = dr["fname"].ToString();
                    passclass.id = dr["sid"].ToString();

                    this.Hide();
                    dashboard ss = new dashboard();
                    ss.Show();
                    
                }
                else
                {
                    MessageBox.Show("Please Check your Username and Password");
                }
            }
        }

        private void student_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "USERNAME")
            {
                username.Text = "";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "USERNAME";
            }
        }

        private void paswd_Enter(object sender, EventArgs e)
        {

            if (paswd.Text == "PASSWORD")
            {
                paswd.Text = "";
                paswd.UseSystemPasswordChar = true;
             }
        }

        private void paswd_Leave(object sender, EventArgs e)
        {
            if (paswd.Text == "")
            {
                paswd.Text = "PASSWORD";
                paswd.UseSystemPasswordChar = false;
              
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paswd_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void signin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(210, 44, 62, 80);

        }
      
        private void paswd_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void paswd_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void show_pass_Click(object sender, EventArgs e)
        {
            if (paswd.UseSystemPasswordChar == true)
            {
                paswd.UseSystemPasswordChar = false;
            }
            else if (paswd.UseSystemPasswordChar == false)
            {
                paswd.UseSystemPasswordChar = true;
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup newForm = new signup();
            newForm.Show(); this.Hide();
        }

        private void sign_in_MouseHover(object sender, EventArgs e)
        {
            sign_in.BackColor = Color.FromArgb(26, 188, 156);
        }

        private void sign_in_MouseLeave(object sender, EventArgs e)
        {
            sign_in.BackColor = Color.FromArgb(26, 117, 255);
        }
    }
}
