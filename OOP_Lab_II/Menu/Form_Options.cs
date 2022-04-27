﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace OOP_Lab_II.Menu
{
    public partial class Form_Options : Form
    {
        // Field
        XmlDocument XMLdoc;
        private int difficulty_index;
        private int shapes_index;
        private int color_index;
        // Consturctors
        public Form_Options()
        {
            InitializeComponent();
            Load_Settings();
        }
        // Methods
        private void Load_Settings()
        {
            XMLdoc = new XmlDocument();
            XMLdoc.Load("Data/localSave.xml");
            
            difficulty_index = int.Parse(XMLdoc.SelectSingleNode("/Settings/Difficulty/value").InnerText);
            width_box.Text = XMLdoc.SelectSingleNode("/Settings/Difficulty_x/value").InnerText;
            height_box.Text = XMLdoc.SelectSingleNode("/Settings/Difficulty_y/value").InnerText;
            shapes_index = int.Parse(XMLdoc.SelectSingleNode("/Settings/Shapes/value").InnerText);
            color_index = int.Parse(XMLdoc.SelectSingleNode("/Settings/Color/value").InnerText);
            /// CHECK ITEMS
            //
            //Difficulty
            diffBox.SelectedItem = diffBox.Items[difficulty_index];
            //Shapes
            for (int i = 0; i < shapeList.Items.Count; i++)
                shapeList.SetItemChecked(i, (int)(shapes_index / Math.Pow(10, i)) % 2 == 1);
            //Color
            for (int i = 0; i < colorList.Items.Count; i++)
                colorList.SetItemChecked(i, (int)(color_index / Math.Pow(10, i)) % 2 == 1);
        }
        private void Save_Settings()
        {
            switch (difficulty_index)   // Filling width box and height box.
            {
                case 0: width_box.Text = height_box.Text = "5"; break;
                case 1: width_box.Text = height_box.Text = "10"; break;
                case 2: width_box.Text = height_box.Text = "20"; break;
            }
            XMLdoc.SelectSingleNode("/Settings/Difficulty/value").InnerText = difficulty_index.ToString();
            XMLdoc.SelectSingleNode("/Settings/Shapes/value").InnerText =shapes_index.ToString();
            XMLdoc.SelectSingleNode("/Settings/Color/value").InnerText = color_index.ToString();
            XMLdoc.SelectSingleNode("/Settings/Difficulty_x/value").InnerText = width_box.Text;
            XMLdoc.SelectSingleNode("/Settings/Difficulty_y/value").InnerText = height_box.Text;
            XMLdoc.Save("Data/localSave.xml");
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void save_Click(object sender, EventArgs e)
        {
            difficulty_index = diffBox.SelectedIndex;
            shapes_index = Convert.ToInt32(shapeList.GetItemChecked(0)) + 10 * Convert.ToInt32(shapeList.GetItemChecked(1)) + 100*Convert.ToInt32(shapeList.GetItemChecked(2));
            color_index= Convert.ToInt32(colorList.GetItemChecked(0)) + 10 * Convert.ToInt32(colorList.GetItemChecked(1)) + 100 * Convert.ToInt32(colorList.GetItemChecked(2));
            try
            {
                Save_Settings();
                warnBox.ForeColor = Color.DarkGreen;
                warnBox.Text = "Saved";
            }
            catch (Exception ex)
            {
                warnBox.ForeColor = Color.OrangeRed;
                warnBox.Text = ex.Message.ToString();
            }
        }

        private void bottom_panel_resize(object sender, EventArgs e)
        {
            save_button.Size = new System.Drawing.Size(bottom_panel.Size.Width / 2-60, 46);
        }

        private void Form_Options_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.width_box, "Enter the Width of Table");
            toolTip1.SetToolTip(this.height_box, "Enter the Height of Table");
            toolTip1.SetToolTip(this.save_button, "Press to Save");
            //toolTip1.SetToolTip(this.new_button, "Some Options");
        }

        private void diffBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            custom_panel.Visible = diffBox.SelectedIndex == 3;
        }
    }
}