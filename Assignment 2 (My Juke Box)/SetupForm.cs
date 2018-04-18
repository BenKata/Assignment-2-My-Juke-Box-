using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2__My_Juke_Box_
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cancelsetup_Click(object sender, EventArgs e)
        {
            // Closes the about form
            Close();
        }

        private void btn_setupOk_Click(object sender, EventArgs e)
        {
            // Closes the about form
            Close();
        }
    }
}
