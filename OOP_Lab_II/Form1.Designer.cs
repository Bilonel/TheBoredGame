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
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.PasswordImage = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(248, 225);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(265, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.FlatAppearance.BorderSize = 5;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(248, 304);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(265, 37);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ShowPassword.Location = new System.Drawing.Point(392, 271);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(121, 20);
            this.ShowPassword.TabIndex = 3;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UserImage
            // 
            this.UserImage.Image = ((System.Drawing.Image)(resources.GetObject("UserImage.Image")));
            this.UserImage.Location = new System.Drawing.Point(203, 160);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(38, 38);
            this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImage.TabIndex = 4;
            this.UserImage.TabStop = false;
            this.UserImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PasswordImage
            // 
            this.PasswordImage.Image = ((System.Drawing.Image)(resources.GetObject("PasswordImage.Image")));
            this.PasswordImage.Location = new System.Drawing.Point(203, 225);
            this.PasswordImage.Name = "PasswordImage";
            this.PasswordImage.Size = new System.Drawing.Size(38, 38);
            this.PasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordImage.TabIndex = 5;
            this.PasswordImage.TabStop = false;
            this.PasswordImage.Click += new System.EventHandler(this.PasswordImage_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(248, 160);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(265, 38);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.PasswordImage);
            this.Controls.Add(this.UserImage);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.txtPassword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.PictureBox PasswordImage;
        private System.Windows.Forms.TextBox txtUserName;
    }
}

