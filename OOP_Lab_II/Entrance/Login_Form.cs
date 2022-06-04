using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_Lab_II.Entrance
{
    public partial class Login_Form : Form
    {
        //Field
        public bool UserSuccessfullyAuthenticated = false; // saying to 'program class' "go on main menu"
        private XmlDocument xmlDoc;
        //Methods
        public Login_Form()
        {
            InitializeComponent();
            txtUserName.Focus();
            this.AcceptButton = LoginButton;
        }

        private void login_click(object sender, EventArgs e)
        {
            if (dataTransfer.Instance.get_account(txtUserName.Text)!=null)
            {
                if (dataTransfer.Instance.check_password(txtPassword.Text))
                {
                    UserSuccessfullyAuthenticated = true;
                    xmlDoc.SelectSingleNode("Settings/LastUsername/value").InnerText = txtUserName.Text;
                    if(xmlDoc.SelectSingleNode("Settings/Password/value").InnerText != txtPassword.Text)
                    {
                        xmlDoc.SelectSingleNode("Settings/Password/value").InnerText = txtPassword.Text;
                        xmlDoc.SelectSingleNode("Settings/Password/apply").InnerText = "0";
                    }
                    xmlDoc.Save("Data/localSave.xml");
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
        private void password_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = ((TextBox)sender).Name;
            }
        }
        private void username_leave(object sender, EventArgs e)
        {
            password_Leave(sender, e);
            if (xmlDoc.SelectSingleNode("Settings/LastUsername/value").InnerText == txtUserName.Text
                && xmlDoc.SelectSingleNode("Settings/Password/value").InnerText != "")
            {
                txtUserName.Text = xmlDoc.SelectSingleNode("Settings/LastUsername/value").InnerText;
                txtPassword.Text = xmlDoc.SelectSingleNode("Settings/Password/value").InnerText;
            }
        }

        private void register_button(object sender, EventArgs e)
        {
            new Entrance.Register_Form().Show();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.LoginButton, "Press to Login");
            toolTip1.SetToolTip(this.exitButton, "Press to Exit from App");
            xmlDoc = new XmlDocument();
            xmlDoc.Load("Data/localSave.xml");
            if (xmlDoc.SelectSingleNode("Settings/LastUsername/value").InnerText !="0")
                txtUserName.AutoCompleteCustomSource.Add(xmlDoc.SelectSingleNode("Settings/LastUsername/value").InnerText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row2 = new string[10];
            row2[0] = "112";
            row2[1] = "admin";
            row2[2] = "admin";
            row2[3] = "admin";
            row2[4] = "Adminlerden Admin";
            row2[5] = "";
            row2[6] = "";
            row2[7] = "";
            row2[8] = "";
            row2[9] = "";
            string[] row = new string[10];
            row[0] = "58";
            row[1] = "admin";
            row[2] = "Bilonel";
            row[3] = "bilal123";
            row[4] = "Bilal Demir";
            row[5] = "";
            row[6] = "";
            row[7] = "";
            row[8] = "";
            row[9] = "";

            dataTransfer.Instance.updateUser(row);
            dataTransfer.Instance.updateUser(row2);
        }
    }
}
