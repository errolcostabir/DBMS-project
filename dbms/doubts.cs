using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace dbms

{
    public partial class doubts : Form
    {
        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;
        public doubts()
        {
            InitializeComponent();
        }
                
        private void Form2_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(210, 44, 62, 80);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {     
                                                                     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void view_que_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string query = "Select questions From doubts where id = '" + textBox6.Text + "'";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                cmd.CommandText = "select sid,tid,questions from doubts where id = '" + textBox6.Text.Trim() + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                passclass.SID = dr["sid"].ToString();
                passclass.TID = dr["tid"].ToString();
                passclass.Quetion = dr["questions"].ToString();
                label2.Text = passclass.SID;
                label3.Text = passclass.TID;
                textBox1.Text = passclass.Quetion;
               
            }
            else
            {
                MessageBox.Show("Please enter a different id");
            }
        }

        private void send_answer_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";

            using (OracleConnection con = new OracleConnection(oradb))
            {
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update doubts set answers = :param1 where id = :keyValue";
                cmd.Parameters.Add("param1", richTextBox1.Text);
                cmd.Parameters.Add("keyValue", textBox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("answer send");
                richTextBox1.Clear();

            }
        }
        private void sendanswer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            teachhomepage ss = new teachhomepage();
            ss.Show();
            this.Hide();
        }
     
    }
}
