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
    public partial class Login_Form : Form
    {
        //Field
        public bool UserSuccessfullyAuthenticated = false; // saying to 'program class' "go on main menu"

        //Methods
        public Login_Form()
        {
            InitializeComponent();
            txtUserName.Focus();
            this.AcceptButton = LoginButton;
        }

        private void login_click(object sender, EventArgs e)
        {
            Data.linkedDataSet.tbl_usersRow userRow = dataTransfer.Instance.get_user_row(txtUserName.Text);
            if (userRow!=null)
            {
                if (userRow.password == txtPassword.Text)
                {
                    Account.getAccount(userRow.username);
                    UserSuccessfullyAuthenticated = true;
                    this.Close();
                }
                else
                    WarnBox.Text = " Incorret Password !";
            }
            else
                WarnBox.Text=" Incorrect Username !";
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void passwordChanged(object sender, EventArgs e)
        {
            checkPassword_changed(sender, e);
        }

        private void checkPassword_changed(object sender, EventArgs e)
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

        private void txt_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text== ((TextBox)sender).Name)
            {
                ((TextBox)sender).Text = "";
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = ((TextBox)sender).Name;
            }
        }

        private void register_button(object sender, EventArgs e)
        {
            new Forms.Register_Form().Show();
        }
    }
}
