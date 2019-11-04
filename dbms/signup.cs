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
using Oracle.DataAccess.Types;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.Odbc;
namespace dbms
{
    public partial class signup : Form
    {
        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;

        public signup()
        {
            InitializeComponent();
            CON1 = new OracleConnection("Data Source=localhost;User ID=DBMS;password=DBMS ");
        }

        private void go_to_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin newForm = new signin();
            newForm.Show(); this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
           
            if (fname.Text == "First Name" || lname.Text == "Last Name" || phone_no.Text == "Phone Number"||dept.Text=="Department"||year.Text=="Year"||username.Text=="Username"||password.Text=="Password")
            {
                MessageBox.Show("Enter All the Details ");
            }
            else
               if (password.Text == confirm_pass.Text)
            {
                I = 0;

                QUERY = "select * from sign_up where username='" + username.Text + "' ";
                CON1.Open();
                CMD = new OracleCommand(QUERY, CON1);

                RDR = CMD.ExecuteReader();

                while (RDR.Read())
                {
                    if (RDR["username"] == username.Text)
                        I = 1;
                    else
                        I = I;
                }
                RDR.Close();
                CON1.Close();

                if (I == 1)
                {
                    MessageBox.Show(" username exists");
                    username.Text = " ";
                    username.Focus();
                }
                else
                {
                    CON1.Open();
                    QUERY = "Insert into sign_up(fname,lname,phone_no,dept,year,username,password) values('" + fname.Text + "','" + lname.Text + "','"+phone_no.Text+"','"+dept.Text+"','"+year.Text+"' , '"+ username.Text+"','" + password.Text+"')";
                    CMD = new OracleCommand(QUERY, CON1);
                    CMD.CommandType = CommandType.Text;
                    TEMP = CMD.ExecuteNonQuery();
                    if (TEMP > 0)

                        MessageBox.Show(" REGISTRATION SUCCESSFULL");
                    else
                        MessageBox.Show("REGISTRATION FAILED");

                    clear();
                    next();
                }

            }
            else
            {
                MessageBox.Show("PASSWORDS DO NOT MATCH");
                password.Text = "";
                confirm_pass.Text = "";
               password.Focus();
            }


        }
        void clear()
        {
            fname.Text=lname.Text=phone_no.Text=dept.Text=year.Text = username.Text = password.Text = " ";
        }
        void next()
        {
            signin ss = new signin();
            ss.Show();
            this.Hide();
        }

        private void phone_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_Enter(object sender, EventArgs e)
        {
            if (fname.Text == "First Name")
            {
                fname.Text = "";
            }
        }

        private void fname_Leave(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                fname.Text = "First Name";
                
            }
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_Enter(object sender, EventArgs e)
        {
            if(lname.Text=="Last Name")
            {
                lname.Text = "";
            }
        }

        private void lname_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void lname_Leave(object sender, EventArgs e)
        {
            if (lname.Text == "")
            {
                lname.Text = "Last Name";
            }
        }

        private void phone_no_Leave(object sender, EventArgs e)
        {
            if (phone_no.Text == "")
            {
                phone_no.Text = "Phone Number";
            }
        }

        private void phone_no_Enter(object sender, EventArgs e)
        {
            if(phone_no.Text=="Phone Number")
            {
                phone_no.Text = "";
            }
        }

        private void dept_Enter(object sender, EventArgs e)
        {
            if (dept.Text == "Department")
            {
                dept.Text = "";
            }
        }

        private void dept_Leave(object sender, EventArgs e)
        {
            if (dept.Text == "")
            {
                dept.Text = "Department";
            }
        }

        private void year_Enter(object sender, EventArgs e)
        {
            if (year.Text == "Year")
            {
                year.Text = "";
            }
        }

        private void year_Leave(object sender, EventArgs e)
        {
            if (year.Text == "")
            {
                year.Text = "Year";
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
                password.UseSystemPasswordChar = false;
            }
        }

        private void confirm_pass_Enter(object sender, EventArgs e)
        {
            if(confirm_pass.Text=="Confirm Password")
            {
                confirm_pass.Text = "";
                confirm_pass.UseSystemPasswordChar = true;
            }
        }

        private void confirm_pass_Leave(object sender, EventArgs e)
        {
            if (confirm_pass.Text == "")
            {
                confirm_pass.Text = "Confirm Password";
                confirm_pass.UseSystemPasswordChar = false;
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(210, 44, 62, 80);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.UseSystemPasswordChar == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else if (password.UseSystemPasswordChar == false)
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tsignup newForm = new tsignup();
            newForm.Show(); this.Hide();
        }
    }
    }

