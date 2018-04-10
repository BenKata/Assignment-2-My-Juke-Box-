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
    public partial class Form1 : Form
    {
        // Global varaibles 
        int NumberofGenre;
        ListBox[] Media_Lib;




        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Loading up the About form
            AboutForm About = new AboutForm();
            About.ShowDialog();

        }

        private void Load_up()
        {   // Start up method, resets the number of genre to 1 and adds a listbox to the array and adds General to it
            NumberofGenre = 1;
            if (NumberofGenre > 1)
            {
                Media_Lib = new ListBox[NumberofGenre];
            }
            Media_Lib[1] = new ListBox();
            Media_Lib[1].Items.Add("General");
        }
    }



    
}
