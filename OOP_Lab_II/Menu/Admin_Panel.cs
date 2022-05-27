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
                    dataTransfer.Instance.setAll(dataGridView1);
                    WarnBox.ForeColor = Color.Green;
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
                WarnBox.ForeColor = Color.Yellow;
                WarnBox.Text = "Access Denied !";
                confirm_text.Text = "";
            }    
        }

        private void Panel_Leave(object sender, EventArgs e)
        {
            ((Panel)sender).Visible = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = System.BitConverter.ToString((new System.Security.Cryptography.SHA256Managed()).ComputeHash(System.Text.Encoding.UTF8.GetBytes(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()))).Replace("-", "");
            else if(e.ColumnIndex==2)
                dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = true;
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            dataTransfer.Instance.getAll(dataGridView1);
            dataGridView1.Columns[2].ReadOnly = true;
            username_label.Text = dataTransfer.Instance.get_account().info[2].ToUpper();
            this.dataGridView1.ForeColor = Color.Black;

            ToolTip tt = new ToolTip();
            tt.ShowAlways = true;
            tt.AutoPopDelay = 7000;
            tt.SetToolTip(this.btnSave, "Click to Save");
            tt.SetToolTip(this.confirm_button, "Click to Confirm");
            tt.SetToolTip(this.confirm_text, "Enter your password");
            tt.SetToolTip(this.help, "?Delete: Select a row then press delete on your keyboard."
                +"\n?Edit: Double click to cells except usernames."
                +"\n?Add: Click the button below."
                );
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[e.Row.Index-1].Cells[2].ReadOnly = false;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are Deleting an Account, Are You Sure?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
