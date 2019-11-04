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
    public partial class alctextbook : Form
    {
        public alctextbook()
        {
            InitializeComponent();
            var fileName = "E:/dbmsprojectpdf/PeterLinz.5ed.pdf";
            axAcroPDF1.LoadFile(fileName);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            itsallhere a = new itsallhere();
            a.Show(); this.Hide();
        }

        private void AxAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}
