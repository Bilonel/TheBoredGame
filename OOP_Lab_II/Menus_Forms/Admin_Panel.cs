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
        }
        private void confırm_button_click(object sender, EventArgs e)
        {
           if(dataTransfer.Instance.check_password(confirm_text.Text))
            {
                try
                {
                    dataTransfer.Instance.dataTable = (Data.linkedDataSet.tbl_usersDataTable)dataGridView1.DataSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                confirm_panel.Visible = false;
            }
            else
            {
                MessageBox.Show("Password is Wrong !");
                confirm_text.Text = "";
            }    
        }

        private void add_new_account_click(object sender, EventArgs e)
        {
            popup_Panel_username.Visible = true;
        }
        private void add_new_account_button_click(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message.ToString());
            }
            dataGridView1.DataSource = dt;
        }

        private void popup_Panel_username_Leave(object sender, EventArgs e)
        {
            popup_Panel_username.Visible = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==1)
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()))).Replace("-", "");
        }

        private void confirm_panel_Leave(object sender, EventArgs e)
        {
            confirm_panel.Visible = false;
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = dataTransfer.Instance.dataTable;
            dataGridView1.Columns[0].ReadOnly = true;
            username_label.Text = dataTransfer.Instance.get_account().info.username;
        }
    }
}
