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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.WarnBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(122, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = " password";
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(121, 216);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(199, 28);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowPassword.Location = new System.Drawing.Point(272, 168);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(50, 17);
            this.ShowPassword.TabIndex = 3;
            this.ShowPassword.Text = "Show";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(122, 124);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 26);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = " username";
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // WarnBox
            // 
            this.WarnBox.BackColor = System.Drawing.Color.IndianRed;
            this.WarnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarnBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarnBox.ForeColor = System.Drawing.Color.Maroon;
            this.WarnBox.Location = new System.Drawing.Point(106, 278);
            this.WarnBox.Margin = new System.Windows.Forms.Padding(2);
            this.WarnBox.Multiline = true;
            this.WarnBox.Name = "WarnBox";
            this.WarnBox.Size = new System.Drawing.Size(240, 24);
            this.WarnBox.TabIndex = 5;
            this.WarnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.WarnBox);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.txtPassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.TextBox WarnBox;
    }
}

