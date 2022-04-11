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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            confirm_panel.Visible = true;
            confirm_panel.Focus();
            confirm_text.Focus();
        }
        private void confırm_button_click(object sender, EventArgs e)
        {
           if(dataTransfer.Instance.check_password(confirm_text.Text))
            {
                try
                {
                    dataTransfer.Instance.dataTable = (Data.linkedDataSet.tbl_usersDataTable)dataGridView1.DataSource;
                    WarnBox.ForeColor = Color.DarkGreen;
                    WarnBox.Text = "SAVED";
                }
                catch (Exception ex)
                {
                    WarnBox.Text = (ex.Message.ToString());
                }
                confirm_panel.Visible = false;
            }
            else
            {
                WarnBox.ForeColor = Color.OrangeRed;
                WarnBox.Text = "Access Denied !";
                confirm_text.Text = "";
            }    
        }

        private void add_new_account_click(object sender, EventArgs e)
        {
            popup_Panel_username.Visible = true;
            popup_Panel_username.Focus();
            newUsername.Focus();
        }
        private void apply_new_user_click(object sender, EventArgs e)
        {
            DataTable dt = dataTransfer.Instance.dataTable;
            DataRow dr = dt.NewRow();
            dr[0] = newUsername.Text;
            dr[8] = "user";
            try
            {
                dt.Rows.Add(dr);
                popup_Panel_username.Visible = false;
            }
            catch (Exception ex)
            {
                WarnBox.ForeColor = Color.OrangeRed;
                WarnBox.Text=ex.Message.ToString();
            }
            dataGridView1.DataSource = dt;
        }

        private void Panel_Leave(object sender, EventArgs e)
        {
            ((Panel)sender).Visible = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==1)
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()))).Replace("-", "");
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = dataTransfer.Instance.dataTable;
            dataGridView1.Columns[0].ReadOnly = true;
            username_label.Text = dataTransfer.Instance.get_account().info.username;

            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.AutoPopDelay = 7000;
            tt.SetToolTip(this.btnSave, "Click to Save");
            tt.SetToolTip(this.add_new_button, "Click to Add a New Account");
            tt.SetToolTip(this.button2, "Click to Apply to new Username");
            tt.SetToolTip(this.confirm_button, "Click to Confirm");
            tt.SetToolTip(this.confirm_text, "Enter your password");
            tt.SetToolTip(this.newUsername, "Enter new Username");
            tt.SetToolTip(this.help, "?Delete: Select a row then press delete on your keyboard."
                +"\n?Edit: Double click to cells except usernames."
                +"\n?Add: Click the button below."
                );
        }
    }
}
