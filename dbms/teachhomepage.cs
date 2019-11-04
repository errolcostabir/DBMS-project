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
    public partial class teachhomepage : Form
    {
        bool Hidden;
        public teachhomepage()
        {
           InitializeComponent();
            Hidden = false;
        }

        private void Welcomelabel_Click(object sender, EventArgs e)
        {

        }

        private void detailstimer_Tick(object sender, EventArgs e)
        {
            if(Hidden==true)
            {
                subjectdetailspanel.Height = subjectdetailspanel.Height + 5;
                if(subjectdetailspanel.Size==subjectdetailspanel.MaximumSize)
                {
                    detailstimer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                subjectdetailspanel.Height = subjectdetailspanel.Height - 5;
                if(subjectdetailspanel.Size==subjectdetailspanel.MinimumSize)
                {
                    detailstimer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }  

        private void subdetailsbutton_MouseClick(object sender, MouseEventArgs e)
        {
            detailstimer.Start();
        }

        private void updatemarkbutton_Click(object sender, EventArgs e)
        {
           updatetimer.Start();
        }

        private void detailsbutton_Click(object sender, EventArgs e)
        {
            passclass.Test = 1;
           
            update ss = new update();
            ss.Show();
            this.Hide();
            
        }

        private void updatetimer_Tick(object sender, EventArgs e)
        {
            if (Hidden == true)
            {
                updatemarkspanel.Height = updatemarkspanel.Height + 5;
                if (updatemarkspanel.Size == updatemarkspanel.MaximumSize)
                {
                    updatetimer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
             updatemarkspanel.Height = updatemarkspanel.Height - 5;
                if (updatemarkspanel.Size == updatemarkspanel.MinimumSize)
                {
                    updatetimer.Stop();
                    Hidden = true;
                     this.Refresh();
                }
            }
        }

        private void detailtime_Tick(object sender, EventArgs e)
        {

            if (Hidden == true)
            {
                detailspan.Height = detailspan.Height + 5;
                if (detailspan.Size == detailspan.MaximumSize)
                {
                    detailtime.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                detailspan.Height = detailspan.Height - 5;
                if (detailspan.Size == detailspan.MinimumSize)
                {
                    detailtime.Stop();
                    Hidden = true;
                     this.Refresh();
                }
            }
        }
        private void studdoubtsbutton_Click(object sender, EventArgs e)
        {
            doubts doubtspage = new doubts();
            doubtspage.Show();
            this.Hide();
        }

        private void teachhomepage_Load(object sender, EventArgs e)
        {
            teachername.Text = passclass.uname;
            panel1.BackColor = Color.FromArgb(210, 44, 62, 80);

        }

        private void teachlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin ss = new signin();
            ss.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void compbutton_Click(object sender, EventArgs e)
        {
                stumarksupdate ss = new stumarksupdate();
                ss.Show();
                this.Hide();
         
        }
    }
}
