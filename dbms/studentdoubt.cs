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
    public partial class studentdoubt : Form
    {

        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;
        public studentdoubt()
        {
            InitializeComponent();
        }

        private void sendanswer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard ss = new dashboard();
            ss.Show();
            this.Hide();
        }

        private void studentdoubt_Load(object sender, EventArgs e)
        {
            Fillcombo();
            panel2.BackColor = Color.FromArgb(210, 44, 62, 80);
            panel1.BackColor = Color.FromArgb(210, 44, 62, 80);

        }

        public void Fillcombo()
        {
            string oradb = "Data Source=localhost;User ID=DBMS;password=DBMS";
            string query = "select * from t_signup";
            OracleConnection condatabase = new OracleConnection(oradb);
            OracleCommand cmddatabase = new OracleCommand(query, condatabase);
                condatabase.Open();
                OracleDataReader myReader = cmddatabase.ExecuteReader(); ;
                myReader = cmddatabase.ExecuteReader();
                while (myReader.Read())
                {
                string sname = myReader["tid"].ToString();
                    load_tid.Items.Add(sname.ToString());
                }

         }

        private void view_ans_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string query = "Select answers From doubts where id = '" + que_no.Text + "'";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
               cmd.CommandText = "select questions,answers from doubts where id = '" + que_no.Text.Trim() + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                passclass.Answers = dr["questions"].ToString();
                passclass.Quetion = dr["answers"].ToString();
                textBox1.Text=passclass.Answers;
                richTextBox1.Text = passclass.Quetion;

            }
            else
            {
                MessageBox.Show("Please enter a different id");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CON1 = new OracleConnection("Data Source=localhost;User ID=DBMS;password=DBMS ");


            I = 0;

            QUERY = "select * from doubts where id='" + que_no.Text + "' ";
            CON1.Open();
            CMD = new OracleCommand(QUERY, CON1);

            RDR = CMD.ExecuteReader();

            while (RDR.Read())
            {
                if (RDR["id"] == que_no.Text)
                    I = 1;
                else
                    I = I;
            }
            RDR.Close();
            CON1.Close();

            if (I == 1)
            {
                MessageBox.Show("Question Number Exist");
                que_no.Text = " ";
                que_no.Focus();
            }
            else
            {

                CON1.Open();
                QUERY = "Insert into doubts(id,sid,tid,questions) values('" + que_no.Text + "','" + sid.Text + "','" + load_tid.Text + "','" + textBox1.Text + "')";
                CMD = new OracleCommand(QUERY, CON1);
                CMD.CommandType = CommandType.Text;
                TEMP = CMD.ExecuteNonQuery();
                if (TEMP > 0)

                    MessageBox.Show("Question is saved!!!!!!!!");
                else
                    MessageBox.Show("Couldnt save the Question!!!!!!:(");
            }

        }
    }
}
