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
            this.AcceptButton = LoginButton;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (ShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void EXIT_LOGIN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == " username")
            {
                txtUserName.Text = "";
            }

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = " username";
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == " password")
            {
                txtPassword.Text = "";
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = " password";
            }
        }
    }
}
