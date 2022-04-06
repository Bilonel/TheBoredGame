
namespace OOP_Lab_II.Menus_Forms
{
    partial class User_Panel
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
            this.btnSave = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.address_label = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.btnAddress = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.city_label = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.btnCity = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.country__label = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.btnCountry = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.btnPhone = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mail__label = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.password_label = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.confirm_panel = new System.Windows.Forms.Panel();
            this.confirm_subpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.confirm_text = new System.Windows.Forms.TextBox();
            this.confirm_label = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.confirm_panel.SuspendLayout();
            this.confirm_subpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Controls.Add(this.username_label);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(584, 81);
            this.panel_top.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(141, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 54);
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
            this.username_label.Font = new System.Drawing.Font("Comic Sans MS", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(221, 16);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(133, 50);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Bilonel";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(128, 16);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(324, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnSave);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 421);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(584, 80);
            this.panel9.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.address_label);
            this.panel7.Controls.Add(this.address);
            this.panel7.Controls.Add(this.btnAddress);
            this.panel7.Location = new System.Drawing.Point(2, 262);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(581, 40);
            this.panel7.TabIndex = 8;
            // 
            // address_label
            // 
            this.address_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.address_label.AutoSize = true;
            this.address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.address_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.address_label.Location = new System.Drawing.Point(139, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(82, 26);
            this.address_label.TabIndex = 2;
            this.address_label.Text = "Address";
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.address.BackColor = System.Drawing.Color.Silver;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Enabled = false;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.address.ForeColor = System.Drawing.Color.Black;
            this.address.Location = new System.Drawing.Point(221, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(201, 26);
            this.address.TabIndex = 1;
            // 
            // btnAddress
            // 
            this.btnAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddress.BackColor = System.Drawing.Color.White;
            this.btnAddress.BackgroundImage = global::OOP_Lab_II.Properties.Resources.edit;
            this.btnAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddress.Location = new System.Drawing.Point(422, 0);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(29, 26);
            this.btnAddress.TabIndex = 8;
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.city_label);
            this.panel5.Controls.Add(this.city);
            this.panel5.Controls.Add(this.btnCity);
            this.panel5.Location = new System.Drawing.Point(2, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 40);
            this.panel5.TabIndex = 7;
            // 
            // city_label
            // 
            this.city_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.city_label.AutoSize = true;
            this.city_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.city_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.city_label.Location = new System.Drawing.Point(179, 0);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(42, 26);
            this.city_label.TabIndex = 2;
            this.city_label.Text = "City";
            // 
            // city
            // 
            this.city.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.city.BackColor = System.Drawing.Color.Silver;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city.Enabled = false;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city.ForeColor = System.Drawing.Color.Black;
            this.city.Location = new System.Drawing.Point(221, 0);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(201, 26);
            this.city.TabIndex = 1;
            // 
            // btnCity
            // 
            this.btnCity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCity.BackColor = System.Drawing.Color.White;
            this.btnCity.BackgroundImage = global::OOP_Lab_II.Properties.Resources.edit;
            this.btnCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCity.Location = new System.Drawing.Point(422, 0);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(29, 26);
            this.btnCity.TabIndex = 7;
            this.btnCity.UseVisualStyleBackColor = false;
            this.btnCity.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.country__label);
            this.panel6.Controls.Add(this.country);
            this.panel6.Controls.Add(this.btnCountry);
            this.panel6.Location = new System.Drawing.Point(2, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(581, 40);
            this.panel6.TabIndex = 6;
            // 
            // country__label
            // 
            this.country__label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.country__label.AutoSize = true;
            this.country__label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.country__label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.country__label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.country__label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.country__label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.country__label.Location = new System.Drawing.Point(144, 0);
            this.country__label.Name = "country__label";
            this.country__label.Size = new System.Drawing.Size(77, 26);
            this.country__label.TabIndex = 2;
            this.country__label.Text = "Country";
            // 
            // country
            // 
            this.country.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.country.BackColor = System.Drawing.Color.Silver;
            this.country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.country.Enabled = false;
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.country.ForeColor = System.Drawing.Color.Black;
            this.country.Location = new System.Drawing.Point(221, 0);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(201, 26);
            this.country.TabIndex = 1;
            // 
            // btnCountry
            // 
            this.btnCountry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCountry.BackColor = System.Drawing.Color.White;
            this.btnCountry.BackgroundImage = global::OOP_Lab_II.Properties.Resources.edit;
            this.btnCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCountry.Location = new System.Drawing.Point(422, 0);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(29, 26);
            this.btnCountry.TabIndex = 6;
            this.btnCountry.UseVisualStyleBackColor = false;
            this.btnCountry.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.phone_label);
            this.panel3.Controls.Add(this.phone);
            this.panel3.Controls.Add(this.btnPhone);
            this.panel3.Location = new System.Drawing.Point(2, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(581, 40);
            this.panel3.TabIndex = 5;
            // 
            // phone_label
            // 
            this.phone_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phone_label.AutoSize = true;
            this.phone_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.phone_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.phone_label.Location = new System.Drawing.Point(153, 0);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(68, 26);
            this.phone_label.TabIndex = 2;
            this.phone_label.Text = "Phone";
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.phone.BackColor = System.Drawing.Color.Silver;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Enabled = false;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phone.ForeColor = System.Drawing.Color.Black;
            this.phone.Location = new System.Drawing.Point(221, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(201, 26);
            this.phone.TabIndex = 1;
            // 
            // btnPhone
            // 
            this.btnPhone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPhone.BackColor = System.Drawing.Color.White;
            this.btnPhone.BackgroundImage = global::OOP_Lab_II.Properties.Resources.edit;
            this.btnPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhone.Location = new System.Drawing.Point(422, 0);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(29, 26);
            this.btnPhone.TabIndex = 5;
            this.btnPhone.UseVisualStyleBackColor = false;
            this.btnPhone.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.mail__label);
            this.panel4.Controls.Add(this.mail);
            this.panel4.Controls.Add(this.btnMail);
            this.panel4.Location = new System.Drawing.Point(2, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(581, 40);
            this.panel4.TabIndex = 4;
            // 
            // mail__label
            // 
            this.mail__label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mail__label.AutoSize = true;
            this.mail__label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.mail__label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail__label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mail__label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail__label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.mail__label.Location = new System.Drawing.Point(175, 0);
            this.mail__label.Name = "mail__label";
            this.mail__label.Size = new System.Drawing.Size(46, 26);
            this.mail__label.TabIndex = 2;
            this.mail__label.Text = "Mail";
            // 
            // mail
            // 
            this.mail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mail.BackColor = System.Drawing.Color.Silver;
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.Enabled = false;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail.ForeColor = System.Drawing.Color.Black;
            this.mail.Location = new System.Drawing.Point(221, 0);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(201, 26);
            this.mail.TabIndex = 1;
            // 
            // btnMail
            // 
            this.btnMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMail.BackColor = System.Drawing.Color.White;
            this.btnMail.BackgroundImage = global::OOP_Lab_II.Properties.Resources.edit;
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMail.Location = new System.Drawing.Point(422, 0);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(29, 26);
            this.btnMail.TabIndex = 4;
            this.btnMail.UseVisualStyleBackColor = false;
            this.btnMail.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.password_label);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.btnPassword);
            this.panel2.Location = new System.Drawing.Point(2, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 40);
            this.panel2.TabIndex = 3;
            // 
            // password_label
            // 
            this.password_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.password_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.password_label.Location = new System.Drawing.Point(127, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(94, 26);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.password.BackColor = System.Drawing.Color.Silver;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Enabled = false;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(221, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(201, 26);
            this.password.TabIndex = 2;
            // 
            // btnPassword
            // 
            this.btnPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPassword.BackColor = System.Drawing.Color.White;
            this.btnPassword.BackgroundImage = global::OOP_Lab_II.Properties.Resources.edit;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPassword.Location = new System.Drawing.Point(422, 0);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(29, 26);
            this.btnPassword.TabIndex = 1;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.btnName);
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 40);
            this.panel1.TabIndex = 2;
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.name_label.Location = new System.Drawing.Point(158, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(63, 26);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name";
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.name.BackColor = System.Drawing.Color.Silver;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(221, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(201, 26);
            this.name.TabIndex = 1;
            // 
            // btnName
            // 
            this.btnName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnName.BackColor = System.Drawing.Color.White;
            this.btnName.BackgroundImage = global::OOP_Lab_II.Properties.Resources.edit;
            this.btnName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnName.Location = new System.Drawing.Point(422, 0);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(29, 26);
            this.btnName.TabIndex = 3;
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.confirm_panel);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.panel2);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 81);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(584, 340);
            this.panel8.TabIndex = 10;
            // 
            // confirm_panel
            // 
            this.confirm_panel.BackColor = System.Drawing.Color.Blue;
            this.confirm_panel.Controls.Add(this.confirm_subpanel);
            this.confirm_panel.Location = new System.Drawing.Point(105, 153);
            this.confirm_panel.Name = "confirm_panel";
            this.confirm_panel.Size = new System.Drawing.Size(383, 100);
            this.confirm_panel.TabIndex = 19;
            this.confirm_panel.Visible = false;
            // 
            // confirm_subpanel
            // 
            this.confirm_subpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.confirm_subpanel.Controls.Add(this.label3);
            this.confirm_subpanel.Controls.Add(this.confirm_button);
            this.confirm_subpanel.Controls.Add(this.confirm_text);
            this.confirm_subpanel.Controls.Add(this.confirm_label);
            this.confirm_subpanel.Location = new System.Drawing.Point(5, 5);
            this.confirm_subpanel.Name = "confirm_subpanel";
            this.confirm_subpanel.Size = new System.Drawing.Size(373, 90);
            this.confirm_subpanel.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Access";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.confirm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirm_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirm_button.Location = new System.Drawing.Point(324, 51);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(25, 27);
            this.confirm_button.TabIndex = 2;
            this.confirm_button.Text = "✓";
            this.confirm_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // confirm_text
            // 
            this.confirm_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.confirm_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirm_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirm_text.Location = new System.Drawing.Point(156, 46);
            this.confirm_text.Name = "confirm_text";
            this.confirm_text.Size = new System.Drawing.Size(198, 38);
            this.confirm_text.TabIndex = 1;
            // 
            // confirm_label
            // 
            this.confirm_label.AutoSize = true;
            this.confirm_label.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_label.ForeColor = System.Drawing.Color.Black;
            this.confirm_label.Location = new System.Drawing.Point(17, 41);
            this.confirm_label.Name = "confirm_label";
            this.confirm_label.Size = new System.Drawing.Size(133, 34);
            this.confirm_label.TabIndex = 0;
            this.confirm_label.Text = "Password:";
            this.confirm_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Panel";
            this.Text = "User_Panel";
            this.Load += new System.EventHandler(this.User_Panel_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.confirm_panel.ResumeLayout(false);
            this.confirm_subpanel.ResumeLayout(false);
            this.confirm_subpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label country__label;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label mail__label;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel confirm_panel;
        private System.Windows.Forms.Panel confirm_subpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.TextBox confirm_text;
        private System.Windows.Forms.Label confirm_label;
    }
}