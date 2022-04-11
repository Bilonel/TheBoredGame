using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_II.Menus_Forms
{
    public partial class User_Panel : Form
    {
        Data.linkedDataSet.tbl_usersRow user_row;
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
                    this.user_row._Name_Surname = name.Text;
                    this.user_row.password = password.Text;
                    this.user_row._E_mail = mail.Text;
                    this.user_row.Phone_Number = phone.Text;
                    this.user_row.country = country.Text;
                    this.user_row.city = city.Text;
                    this.user_row.Address = address.Text;
                    dataTransfer.Instance.update(user_row);
                    dataTransfer.Instance.get_account().info = dataTransfer.Instance.get_user_row(username_label.Text);
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
            user_row = dataTransfer.Instance.get_account().info;
            username_label.Text = user_row.username;
            name.Text = user_row._Name_Surname;
            password.Text = user_row.password;
            mail.Text = user_row._E_mail;
            phone.Text = user_row.Phone_Number;
            country.Text = user_row.country;
            city.Text = user_row.city;
            address.Text = user_row.Address;
            //ToolTips
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
