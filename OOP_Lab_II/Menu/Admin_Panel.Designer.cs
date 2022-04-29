
namespace OOP_Lab_II.Menu
{
    partial class Admin_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.WarnBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirm_panel = new System.Windows.Forms.Panel();
            this.confirm_subpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.confirm_text = new System.Windows.Forms.TextBox();
            this.confirm_label = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.confirm_panel.SuspendLayout();
            this.confirm_subpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Controls.Add(this.username_label);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(377, 55);
            this.panel_top.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(87, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_label.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(133, 8);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(99, 38);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Bilonel";
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.WarnBox);
            this.panel9.Controls.Add(this.btnSave);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 268);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(377, 50);
            this.panel9.TabIndex = 13;
            // 
            // WarnBox
            // 
            this.WarnBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(75)))), ((int)(((byte)(90)))));
            this.WarnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarnBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WarnBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WarnBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.WarnBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.WarnBox.Location = new System.Drawing.Point(0, 30);
            this.WarnBox.Margin = new System.Windows.Forms.Padding(2);
            this.WarnBox.Name = "WarnBox";
            this.WarnBox.ReadOnly = true;
            this.WarnBox.Size = new System.Drawing.Size(375, 18);
            this.WarnBox.TabIndex = 12;
            this.WarnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(24, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(324, 24);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirm_panel);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 213);
            this.panel1.TabIndex = 15;
            // 
            // confirm_panel
            // 
            this.confirm_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.confirm_panel.Controls.Add(this.confirm_subpanel);
            this.confirm_panel.Location = new System.Drawing.Point(27, 41);
            this.confirm_panel.Name = "confirm_panel";
            this.confirm_panel.Size = new System.Drawing.Size(323, 113);
            this.confirm_panel.TabIndex = 18;
            this.confirm_panel.Visible = false;
            this.confirm_panel.Leave += new System.EventHandler(this.Panel_Leave);
            // 
            // confirm_subpanel
            // 
            this.confirm_subpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_subpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.confirm_subpanel.Controls.Add(this.label3);
            this.confirm_subpanel.Controls.Add(this.confirm_button);
            this.confirm_subpanel.Controls.Add(this.confirm_text);
            this.confirm_subpanel.Controls.Add(this.confirm_label);
            this.confirm_subpanel.Location = new System.Drawing.Point(5, 5);
            this.confirm_subpanel.Name = "confirm_subpanel";
            this.confirm_subpanel.Size = new System.Drawing.Size(313, 103);
            this.confirm_subpanel.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Access";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirm_button
            // 
            this.confirm_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.confirm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirm_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirm_button.ForeColor = System.Drawing.Color.Black;
            this.confirm_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirm_button.Location = new System.Drawing.Point(280, 51);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(25, 28);
            this.confirm_button.TabIndex = 2;
            this.confirm_button.Text = "✓";
            this.confirm_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confırm_button_click);
            // 
            // confirm_text
            // 
            this.confirm_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.confirm_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirm_text.Location = new System.Drawing.Point(161, 46);
            this.confirm_text.Name = "confirm_text";
            this.confirm_text.PasswordChar = '*';
            this.confirm_text.Size = new System.Drawing.Size(150, 38);
            this.confirm_text.TabIndex = 1;
            // 
            // confirm_label
            // 
            this.confirm_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_label.AutoSize = true;
            this.confirm_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.confirm_label.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_label.ForeColor = System.Drawing.Color.Black;
            this.confirm_label.Location = new System.Drawing.Point(2, 41);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(133, 34);
            this.confirm_label.TabIndex = 0;
            this.confirm_label.Text = "Password:";
            this.confirm_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.help.AutoSize = true;
            this.help.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.help.Cursor = System.Windows.Forms.Cursors.Help;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.help.ForeColor = System.Drawing.Color.Black;
            this.help.Location = new System.Drawing.Point(337, 143);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(27, 28);
            this.help.TabIndex = 19;
            this.help.Text = "?";
            this.help.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountType,
            this.Username,
            this.Password,
            this.NameSurname,
            this.Email,
            this.Phone,
            this.Country,
            this.City,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Size = new System.Drawing.Size(371, 207);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // AccountType
            // 
            this.AccountType.HeaderText = "AccountType";
            this.AccountType.Name = "AccountType";
            this.AccountType.Width = 96;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 80;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 78;
            // 
            // NameSurname
            // 
            this.NameSurname.HeaderText = "Name";
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Width = 60;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Width = 63;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.Width = 68;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Width = 49;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 70;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(377, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.confirm_panel.ResumeLayout(false);
            this.confirm_subpanel.ResumeLayout(false);
            this.confirm_subpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel confirm_panel;
        private System.Windows.Forms.Panel confirm_subpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.TextBox confirm_text;
        private System.Windows.Forms.Label confirm_label;
        private System.Windows.Forms.TextBox WarnBox;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}