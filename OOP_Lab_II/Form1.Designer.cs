namespace OOP_Lab_II
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.WarnBox = new System.Windows.Forms.TextBox();
            this.EXIT_LOGIN = new System.Windows.Forms.Button();
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.Location = new System.Drawing.Point(173, 204);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = " password";
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(161, 266);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(265, 34);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowPassword.Location = new System.Drawing.Point(363, 207);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(58, 20);
            this.ShowPassword.TabIndex = 3;
            this.ShowPassword.Text = "Show";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserName.Location = new System.Drawing.Point(173, 153);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(249, 27);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = " username";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // WarnBox
            // 
            this.WarnBox.BackColor = System.Drawing.Color.IndianRed;
            this.WarnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarnBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WarnBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold);
            this.WarnBox.ForeColor = System.Drawing.Color.Gold;
            this.WarnBox.Location = new System.Drawing.Point(141, 342);
            this.WarnBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WarnBox.Name = "WarnBox";
            this.WarnBox.ReadOnly = true;
            this.WarnBox.Size = new System.Drawing.Size(320, 24);
            this.WarnBox.TabIndex = 5;
            this.WarnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EXIT_LOGIN
            // 
            this.EXIT_LOGIN.BackColor = System.Drawing.Color.Brown;
            this.EXIT_LOGIN.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.EXIT_LOGIN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.EXIT_LOGIN.FlatAppearance.BorderSize = 0;
            this.EXIT_LOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.EXIT_LOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.EXIT_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EXIT_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_LOGIN.ForeColor = System.Drawing.Color.White;
            this.EXIT_LOGIN.Location = new System.Drawing.Point(797, 610);
            this.EXIT_LOGIN.Margin = new System.Windows.Forms.Padding(4);
            this.EXIT_LOGIN.Name = "EXIT_LOGIN";
            this.EXIT_LOGIN.Size = new System.Drawing.Size(148, 34);
            this.EXIT_LOGIN.TabIndex = 6;
            this.EXIT_LOGIN.Text = "EXIT";
            this.EXIT_LOGIN.UseVisualStyleBackColor = false;
            this.EXIT_LOGIN.Click += new System.EventHandler(this.EXIT_LOGIN_Click);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(OOP_Lab_II.Form1);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(OOP_Lab_II.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 707);
            this.ControlBox = false;
            this.Controls.Add(this.EXIT_LOGIN);
            this.Controls.Add(this.WarnBox);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.TextBox WarnBox;
        private System.Windows.Forms.Button EXIT_LOGIN;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
    }
}

