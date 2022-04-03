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
    }
}
