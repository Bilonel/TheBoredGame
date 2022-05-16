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
        string[] row;
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
                    this.row[3] = password.Text;
                    this.row[4] = name.Text;
                    this.row[5] = mail.Text;
                    this.row[6] = phone.Text;
                    this.row[7] = country.Text;
                    this.row[8] = city.Text;
                    this.row[9] = address.Text;
                    dataTransfer.Instance.updateUser(row);
                    dataTransfer.Instance.get_account().info = dataTransfer.Instance.readUser(username_label.Text);
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
            row = dataTransfer.Instance.get_account().info;
            scoreLabel.Text = "High Score:" + row[0];
            username_label.Text = row[2].ToUpper();
            password.Text = row[3];
            name.Text = row[4];
            mail.Text = row[5];
            phone.Text = row[6];
            country.Text = row[7];
            city.Text = row[8];
            address.Text = row[9];
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
