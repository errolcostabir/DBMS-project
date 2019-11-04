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
    public partial class attendence : Form
    {
        public attendence()
        {
            InitializeComponent();
            var fileName = "E:/dbmsprojectpdf/attendence.pdf";
            axAcroPDF1.LoadFile(fileName);
        }

        private void AxAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
             itsallhere b = new itsallhere();
            b.Show(); this.Hide();
        }
    }
}
