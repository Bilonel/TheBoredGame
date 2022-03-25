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
            InitializeSettings();
            

        }
        private void check_diffuclty_Settings(int index)
        {
           foreach (ToolStripMenuItem it in difficultyToolStripMenuItem.DropDownItems)
                it.Checked = false;
            ((ToolStripMenuItem)difficultyToolStripMenuItem.DropDownItems[index]).Checked = true;
        }
        private void check_shape_Settings()
        {
            string str = Properties.Settings.Default["Shape"].ToString();
            for (int index=0;index< 3;index++)
            {
                if (str[index] == '1')
                    ((ToolStripMenuItem)shapesToolStripMenuItem.DropDownItems[index]).Checked = true;
                else
                    ((ToolStripMenuItem)shapesToolStripMenuItem.DropDownItems[index]).Checked = false;
            }
        }
        private void load_shape_Settings()
        {
            string res="";
            foreach (ToolStripMenuItem it in shapesToolStripMenuItem.DropDownItems)
            {
                if (it.Checked == true)
                    res += "1";
                else
                    res += "0";
            }
            Properties.Settings.Default["Shape"] = res;
        }
        private void exit_button_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
                this.Size = new System.Drawing.Size(1280, 720);
            else if (toolStripComboBox1.SelectedIndex == 2)
                this.Size = new System.Drawing.Size(600, 400);
            else
                this.Size = new System.Drawing.Size(800, 600);
        }

        private void Custom_Click1(object sender, EventArgs e)
        {
            width_setting.Clear();
        }
        private void Custom_Click2(object sender, EventArgs e)
        {
            height_setting.Clear();
        }
        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Difficulty"] = "5x5";
            check_diffuclty_Settings(0);
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Difficulty"] = "10x10";
            check_diffuclty_Settings(1);
        }
        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Difficulty"] = "20x20";
            check_diffuclty_Settings(2);

        }
        private void customToolStripMenuItem_Save(object sender, EventArgs e)
        {
            Properties.Settings.Default["Difficulty"] = width_setting.Text + "x"+ height_setting.Text;
            check_diffuclty_Settings(3);
        }
        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_shape_Settings();
            Properties.Settings.Default.Save();
        }

    }
}
