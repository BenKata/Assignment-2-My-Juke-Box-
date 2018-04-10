using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Allows file access libaries 
using System.IO;

namespace Assignment_2__My_Juke_Box_
{
    public partial class Form1 : Form
    {
        // Global varaibles 
        int NumberofGenre;
        string Appication_Path = Directory.GetCurrentDirectory();
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

        private bool Start_up()
        {   // Setting up the scroll bar on the GUI with the mini and max values
            hScroll_Genre.Minimum = 1;
            hScroll_Genre.Maximum = NumberofGenre;
            hScroll_Genre.SmallChange = 1;
            hScroll_Genre.Value = hScroll_Genre.Minimum;
            return true;
        }


        private bool
    }



    
}
