using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); 
        }

        private void settings_button_click(object sender, EventArgs e)
        {
        }

        private void exit_button_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex==0)
                this.Size = new System.Drawing.Size(1280,720);
            else if (toolStripComboBox1.SelectedIndex == 2)
                this.Size = new System.Drawing.Size(600, 400);
            else
                this.Size = new System.Drawing.Size(800, 600);
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
