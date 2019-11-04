using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
namespace dbms
{
    public partial class stumarksupdate : Form
    {

        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;

        public stumarksupdate()
        {
            InitializeComponent();
            CON1 = new OracleConnection("Data Source=localhost;User ID=DBMS;password=DBMS ");

        }

        private void SID_Enter(object sender, EventArgs e)
        {
            if (SID1.Text == "SID")
                SID1.Text = "";
        }

        private void SID_Leave(object sender, EventArgs e)
        {
            if (SID1.Text == "")
                SID1.Text = "SID";
        }

        private void Marks1_Enter(object sender, EventArgs e)
        {
            if (Marks1.Text == "Marks1")
                Marks1.Text = "";
        }

        private void Marks1_Leave(object sender, EventArgs e)
        {
            if (Marks1.Text == "")
                Marks1.Text = "Marks1";
        }

        private void Marks2_Enter(object sender, EventArgs e)
        {
            if (Marks2.Text == "Marks2")
                Marks2.Text = "";
        }

        private void Marks2_Leave(object sender, EventArgs e)
        {
            if (Marks2.Text == "")
                Marks2.Text = "Marks2";
        }

        private void Marks3_Enter(object sender, EventArgs e)
        {
            if (Marks3.Text == "Marks3")
                Marks3.Text = "";
        }

        private void Marks3_Leave(object sender, EventArgs e)
        {
            if (Marks3.Text == "")
                Marks3.Text = "Marks3";
        }

        private void stumarksupdate_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stumarksupdate_Load_1(object sender, EventArgs e)
        {
            CON1.Open();
            CMD = new OracleCommand();
            CMD.Connection = CON1;
            string QUERY = "Select * From student_marks where department = 'COMPUTER' ";
            OracleDataAdapter sda = new OracleDataAdapter(QUERY, CON1);
            DataTable dt = new DataTable("student_marks");
            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (SID1.Text == "SID" || Marks1.Text == "Marks1" || Marks2.Text == "Marks2" || Marks3.Text == "Marks3")
            {
                MessageBox.Show("Enter All the Details ");
            }
            else
            {
                I = 0;
                QUERY = "select * from student_marks where SID ='" + SID1.Text + "'";
                CMD = new OracleCommand(QUERY, CON1);
                RDR = CMD.ExecuteReader();
                while (RDR.Read())
                {
                    
                    if (RDR["SID"].ToString() == SID1.Text)
                    { 
                        I = 1;
                        break;
                    }
                    else
                        I = 0;
                    
                }
                RDR.Close();
                  if (I == 1)
                {
                        OracleCommand cmd = CON1.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update student_marks set A = :param2, B =:param3, C =:param4 where sid ='" + SID1.Text + "'";
                        cmd.Parameters.Add("param2", Marks1.Text);
                        cmd.Parameters.Add("param3", Marks2.Text);
                        cmd.Parameters.Add("param4", Marks3.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update successfull");
                    CON1.Close();

                }
                else
                {
                    QUERY = "Insert into student_marks(sid,A,B,C,department) values('" + SID1.Text + "','" + Marks1.Text + "','" + Marks2.Text + "','" + Marks3.Text + "','" + branch.Text + "')";
                    CMD = new OracleCommand(QUERY, CON1);
                    CMD.CommandType = CommandType.Text;
                    TEMP = CMD.ExecuteNonQuery();
                    if (TEMP > 0)

                        MessageBox.Show("MARKS ENTERED");
                    else
                        MessageBox.Show("ENTERING FAILED");

                    clear();
                    CON1.Close();
           
                }
            }
  
        }

        private void backlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            teachhomepage d = new teachhomepage();
            d.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
            if (MessageBox.Show("DO YOU REALLY WANT TO DELETE THE MARKS ????", "CONFIRM", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cmdText = "DELETE from student_marks WHERE sid  = :ID";
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand(cmdText, conn))
                {
                    conn.Open();
                    cmd.Parameters.Add("ID", SID1.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("DELETED MARKS");
                stumarksupdate su = new stumarksupdate();
                su.Show();
                this.Hide();
            }
        }

        void clear()
        {
            SID1.Text = Marks1.Text = Marks2.Text = Marks3.Text = " ";
        }

    }
    
}
