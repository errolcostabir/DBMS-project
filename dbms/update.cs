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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }


        private void go_back_Click(object sender, EventArgs e)
        {
            if (passclass.Test == 1)
            {
                teachhomepage d = new teachhomepage();
                d.Show();
                this.Hide();
            }
            else if (passclass.Test == 0) { 
            dashboard ss = new dashboard();
            ss.Show();
            this.Hide();
             }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (passclass.Test == 1)
            {
                string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
                if (pass_change.Checked && phone_change.Checked)
                {
                    if (change_pass.Text == "" || confirm_pass.Text == "" || change_phone.Text == "")
                    {
                        MessageBox.Show("Enter all the fields");
                    }
                    else
                    {
                        if (change_pass.Text == confirm_pass.Text)
                        {
                            using (OracleConnection con = new OracleConnection(oradb))
                            {
                                con.Open();
                                OracleCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "update t_signup set password = :param1, phone_no = :param2 where tid = :keyValue";
                                cmd.Parameters.Add("param1", change_pass.Text);
                                cmd.Parameters.Add("param2", change_phone.Text);
                                cmd.Parameters.Add("keyValue", passclass.id);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Update successfull");
                            }
                            signin ss = new signin();
                            ss.Show();
                            this.Hide();
                        }
                        else if (change_pass.Text != confirm_pass.Text)
                        {
                            MessageBox.Show("passwords do not match");
                        }
                    }

                }
                else if (pass_change.Checked && (phone_change.Checked == false))
                {
                    if (change_pass.Text != confirm_pass.Text)
                    {
                        MessageBox.Show("passwords do no match");
                    }
                    else
                    {
                        using (OracleConnection con = new OracleConnection(oradb))
                        {
                            con.Open();
                            OracleCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update t_signup set password = :param1 where tid = :keyValue";
                            cmd.Parameters.Add("param1", change_pass.Text);
                            cmd.Parameters.Add("keyValue", passclass.id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update successfull");
                        }
                        signin ss = new signin();
                        ss.Show();
                        this.Hide();
                    }
                }
                else if (phone_change.Checked && (pass_change.Checked == false))
                {
                    using (OracleConnection con = new OracleConnection(oradb))
                    {
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update t_signup set phone_no = :param2 where tid = :keyValue";
                        cmd.Parameters.Add("param2", change_phone.Text);
                        cmd.Parameters.Add("keyValue", passclass.id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update successfull");
                    }
                    signin ss = new signin();
                    ss.Show();
                    this.Hide();
                }
            }
            else
            {
                string oradb = "Data Source=localhost;User Id=DBMS;Password=DBMS;";
                if (pass_change.Checked && phone_change.Checked)
                {
                    if (change_pass.Text == "" || confirm_pass.Text == "" || change_phone.Text == "")
                    {
                        MessageBox.Show("Enter all the fields");
                    }
                    else
                    {
                        if (change_pass.Text == confirm_pass.Text)
                        {
                            using (OracleConnection con = new OracleConnection(oradb))
                            {
                                con.Open();
                                OracleCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "update sign_up set password = :param1, phone_no = :param2 where sid = :keyValue";
                                cmd.Parameters.Add("param1", change_pass.Text);
                                cmd.Parameters.Add("param2", change_phone.Text);
                                cmd.Parameters.Add("keyValue", passclass.id);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Update successfull");
                            }
                            signin ss = new signin();
                            ss.Show();
                            this.Hide();
                        }
                        else if (change_pass.Text != confirm_pass.Text)
                        {
                            MessageBox.Show("passwords do not match");
                        }
                    }

                }
                else if (pass_change.Checked && (phone_change.Checked == false))
                {
                    if (change_pass.Text != confirm_pass.Text)
                    {
                        MessageBox.Show("passwords do no match");
                    }
                    else
                    {
                        using (OracleConnection con = new OracleConnection(oradb))
                        {
                            con.Open();
                            OracleCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update sign_up set password = :param1 where sid = :keyValue";
                            cmd.Parameters.Add("param1", change_pass.Text);
                            cmd.Parameters.Add("keyValue", passclass.id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update successfull");
                        }
                        signin ss = new signin();
                        ss.Show();
                        this.Hide();
                    }
                }
                else if (phone_change.Checked && (pass_change.Checked == false))
                {
                    using (OracleConnection con = new OracleConnection(oradb))
                    {
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update sign_up set phone_no = :param2 where sid = :keyValue";
                        cmd.Parameters.Add("param2", change_phone.Text);
                        cmd.Parameters.Add("keyValue", passclass.id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update successfull");
                    }
                    signin ss = new signin();
                    ss.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (change_pass.UseSystemPasswordChar == true)
            {
                change_pass.UseSystemPasswordChar = false;
            }
            else if (change_pass.UseSystemPasswordChar == false)
            {
                change_pass.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (confirm_pass.UseSystemPasswordChar == true)
            {
                confirm_pass.UseSystemPasswordChar = false;
            }
            else if (confirm_pass.UseSystemPasswordChar == false)
            {
                confirm_pass.UseSystemPasswordChar = true;
            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(225, 44, 62, 80);
        }
    }
}
