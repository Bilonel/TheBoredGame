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
            this.dataGridView1.DataSource = dataTransfer.Instance.dataTable;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataTransfer.Instance.dataTable = (Data.linkedDataSet.tbl_usersDataTable)dataGridView1.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            popup_Panel_username.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            popup_Panel_username.Visible = false;
            DataTable dt = dataTransfer.Instance.dataTable;
            DataRow dr = dt.NewRow();
            dr[0] = newUsername.Text;
            dr[8] = "user";
            try
            {
                dt.Rows.Add(dr);
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
    }
}
