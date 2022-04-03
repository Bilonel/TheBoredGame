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
            panel9.Size= new System.Drawing.Size(581, (this.Size.Height-500)/2 + 80);
            user_row = dataTransfer.Instance.get_account().info;
            username_label.Text = user_row.username;
            name.Text = user_row._Name_Surname;
            password.Text = user_row.password;
            mail.Text = user_row._E_mail;
            phone.Text = user_row.Phone_Number;
            country.Text = user_row.country;
            city.Text = user_row.city;
            address.Text = user_row.Address;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ((Button)sender).Parent.Controls[1].BackColor = Color.White;
            ((Button)sender).Parent.Controls[1].Enabled = true;
            ((Button)sender).Parent.Controls[1].Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.user_row._Name_Surname = name.Text;
            this.user_row.password = password.Text;
            this.user_row._E_mail = mail.Text;
            this.user_row.Phone_Number = phone.Text;
            this.user_row.country = country.Text;
            this.user_row.city = city.Text;
            this.user_row.Address = address.Text;
            try
            {
                dataTransfer.Instance.update(user_row);
                dataTransfer.Instance.get_account().info = dataTransfer.Instance.get_user_row(username_label.Text);
                MessageBox.Show("Informations Saved.");
            }
            catch (System.Data.OleDb.OleDbException exception)
            {
                MessageBox.Show((exception.Message.ToString()));
            }
        }
    }
}
