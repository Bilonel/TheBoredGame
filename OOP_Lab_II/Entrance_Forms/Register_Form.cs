using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II.Forms
{
    public partial class Register_Form : Form
    {
        // Constructor
        public Register_Form()
        {
            InitializeComponent();
        }
        //Methods

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataTransfer.Instance.register(usernameTextbox.Text, passwordTextbox.Text, nameSurnameTextbox.Text, emailTextbox.Text, phoneNumberTextbox.Text, countryTextbox.Text, cityTextbox.Text, addressTextbox.Text);
                WarnBox.ForeColor = Color.DarkOliveGreen;
                WarnBox.Text = "Succesfully Registered..";
                clear_all_text();

            }
            catch (System.Data.OleDb.OleDbException excep)
            {
                WarnBox.ForeColor = Color.OrangeRed;
                WarnBox.Text = excep.Message.ToString();
            }
        }
        private void clear_all_text()
        {
            for (int i = 0; i < 8; i++)
                this.Controls[i].Text = "";
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.registerButton, "Press to Register");
            toolTip1.SetToolTip(this.cancel_button, "Press to exit");
        }
    }
}
