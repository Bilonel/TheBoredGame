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
                dataTransfer.Instance.save_to_db(usernameTextbox.Text, passwordTextbox.Text, nameSurnameTextbox.Text, emailTextbox.Text, phoneNumberTextbox.Text, countryTextbox.Text, cityTextbox.Text, addressTextbox.Text);
                MessageBox.Show("Succesfully Registered..");
            }
            catch (System.Data.OleDb.OleDbException excep)
            {
                MessageBox.Show(excep.Message.ToString());
            }
        }
    }
}
