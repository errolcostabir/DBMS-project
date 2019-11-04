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
    public partial class vlsiquestionpaper : Form
    {
        public vlsiquestionpaper()
        {
            InitializeComponent();
            var fileName = "C:/Users/XAVIER MATHIAS/Documents/dbmsprojectpdf/vhdlMAY2019.pdf";
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
