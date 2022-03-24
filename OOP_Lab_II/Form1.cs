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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUserName.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "admin" && txtPassword.Text == "admin") || txtUserName.Text == "user" && txtPassword.Text == "user")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                WarnBox.Text=" Incorrect Username or Password";
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
