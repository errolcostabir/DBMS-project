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
    public partial class itsallhere : Form
    {
        public itsallhere()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            attendence a = new attendence();
            a.Show(); 
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            alcquestionpaper a = new alcquestionpaper();
            a.Show(); 
        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            dashboard a = new dashboard();
            a.Show(); this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            alctextbook a = new alctextbook();
            a.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
             vlsitextbook a= new vlsitextbook();
            a.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
           vlsiquestionpaper a = new vlsiquestionpaper();
            a.Show(); 
        }

        private void Itsallhere_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 44, 62, 80);
        }
    }
}
