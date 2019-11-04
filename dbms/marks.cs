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
    public partial class marks : Form
    {
        public marks()
        {
            InitializeComponent();
        }

        private void go_to_dash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard ss = new dashboard();
            ss.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string query = "Select * From student_marks where sid = '" + passclass.id + "'";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable("student_marks");
            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void getsid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
