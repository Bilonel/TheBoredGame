using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II.Menu
{
    public partial class User_Panel : Form
    {
        public User_Panel()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Controls[1].BackColor = Color.White;
            ((Button)sender).Parent.Controls[1].Enabled = true;
            ((Button)sender).Parent.Controls[1].Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            confirm_panel.Visible = true;
            confirm_panel.Focus();
            confirm_text.Focus();
        }
        private void confirm_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTransfer.Instance.check_password(confirm_text.Text))
                {
                    Account user = new User();
                    user.Password = password.Text;
                    user.NameSurname = name.Text;
                    user.Email = mail.Text;
                    user.Phone = phone.Text;
                    user.Country = country.Text;
                    user.City = city.Text;
                    user.Address = address.Text;
                    dataTransfer.Instance.updateUser(user);
                    WarnBox.ForeColor = Color.DarkGreen;
                    WarnBox.Text = "Saved";
                    confirm_panel.Visible = false;
                }
                else
                {
                    WarnBox.ForeColor = Color.OrangeRed;
                    WarnBox.Text = "Access Denied !";
                }
            }
            catch (System.Data.OleDb.OleDbException exception)
            {
                WarnBox.ForeColor = Color.OrangeRed;
                WarnBox.Text=exception.Message.ToString();
            }
        }

        private void User_Panel_Load(object sender, EventArgs e)
        {
            panel9.Size = new System.Drawing.Size(581, (this.Size.Height - 500) / 2 + 100);
            //
            // SET TEXT BOX AS USERS INFOS
            Account user = dataTransfer.Instance.get_account();
            scoreLabel.Text = "High Score:" + user.BestScore.ToString();
            username_label.Text = user.Username.ToUpper();
            password.Text = user.Password;
            name.Text = user.NameSurname;
            mail.Text = user.Email;
            phone.Text = user.Phone;
            country.Text = user.Country;
            city.Text = user.City;
            address.Text = user.Address;
            //
            //  CREATE TOOL TIPS
            //
            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.SetToolTip(btnName, "Edit Name");
            tt.SetToolTip(btnPassword, "Edit Password");
            tt.SetToolTip(btnMail, "Edit Mail");
            tt.SetToolTip(btnPhone, "Edit Phone Number");
            tt.SetToolTip(btnCountry, "Edit Country");
            tt.SetToolTip(btnCity, "Edit City");
            tt.SetToolTip(btnAddress, "Edit Address");
            tt.SetToolTip(btnSave, "Click to Save");
            tt.SetToolTip(confirm_button, "Click to Confirm");
            tt.SetToolTip(confirm_text, "Enter Your Password");
        }

        private void confirm_panel_Leave(object sender, EventArgs e)
        {
            confirm_panel.Visible = false;
        }
    }
}
