using System;
using System.Collections.Generic;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II.Menu
{
    public partial class Form_Play : Form
    {
        public static bool inGame=false;
        private Form_Options OptionsForm;
        public Form_Play()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            popup.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(OptionsForm != null && OptionsForm.OptionsValidation()))
                return;
            OptionsForm.save_Click(sender, e);
            ((Panel)this.ParentForm.Controls.Find("popup", true).GetValue(0)).Visible=false;
            this.ParentForm.Visible = false;
            Menu_Form.sound.Stop();
            (new Game.GameScreen(OptionsForm.Difficulty)).ShowDialog();
            while ( Game.GameScreen.refreshed)
                (new Game.GameScreen(OptionsForm.Difficulty)).ShowDialog();
            this.ParentForm.Visible = true;
            Menu_Form.sound.PlayLooping();
        }

        private void Form_Play_Load(object sender, EventArgs e)
        {
            OptionsForm = new Form_Options();
            OptionsForm.TopLevel = false;
            OptionsForm.Dock = DockStyle.Fill;
            this.popup.Controls.Add(this.OptionsForm);
            OptionsForm.Show();
        }
    }
}
