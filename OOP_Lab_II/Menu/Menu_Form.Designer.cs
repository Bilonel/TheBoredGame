namespace OOP_Lab_II.Menu
{
    partial class Menu_Form
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
            this.playButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.fullscreenButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.creditsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.save_password_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.popup = new System.Windows.Forms.Panel();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.exitPopup = new System.Windows.Forms.Button();
            this.muteButton = new System.Windows.Forms.Button();
            this.profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.save_password_panel.SuspendLayout();
            this.popup.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::OOP_Lab_II.Properties.Resources.playButton;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(115, 175);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(285, 125);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.play_click);
            this.playButton.Enter += new System.EventHandler(this.button_Enter);
            this.playButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.playButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // multiButton
            // 
            this.multiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiButton.BackColor = System.Drawing.Color.Transparent;
            this.multiButton.BackgroundImage = global::OOP_Lab_II.Properties.Resources.multiButton;
            this.multiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiButton.FlatAppearance.BorderSize = 0;
            this.multiButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.multiButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.multiButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.multiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiButton.Location = new System.Drawing.Point(403, 175);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(285, 125);
            this.multiButton.TabIndex = 2;
            this.multiButton.UseVisualStyleBackColor = false;
            this.multiButton.Click += new System.EventHandler(this.multiButton_Click);
            this.multiButton.Enter += new System.EventHandler(this.button_Enter);
            this.multiButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.multiButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // fullscreenButton
            // 
            this.fullscreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscreenButton.BackColor = System.Drawing.Color.Transparent;
            this.fullscreenButton.BackgroundImage = global::OOP_Lab_II.Properties.Resources.fullscreen;
            this.fullscreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullscreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullscreenButton.FlatAppearance.BorderSize = 0;
            this.fullscreenButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.fullscreenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fullscreenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fullscreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullscreenButton.Location = new System.Drawing.Point(319, 35);
            this.fullscreenButton.Name = "fullscreenButton";
            this.fullscreenButton.Size = new System.Drawing.Size(90, 75);
            this.fullscreenButton.TabIndex = 5;
            this.fullscreenButton.UseVisualStyleBackColor = false;
            this.fullscreenButton.Click += new System.EventHandler(this.fullscreenButton_Click);
            this.fullscreenButton.Enter += new System.EventHandler(this.button_Enter);
            this.fullscreenButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.fullscreenButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionsButton.BackColor = System.Drawing.Color.Transparent;
            this.optionsButton.BackgroundImage = global::OOP_Lab_II.Properties.Resources.optionsButton;
            this.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Location = new System.Drawing.Point(257, 304);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(285, 125);
            this.optionsButton.TabIndex = 1;
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            this.optionsButton.Enter += new System.EventHandler(this.button_Enter);
            this.optionsButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.optionsButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // creditsButton
            // 
            this.creditsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creditsButton.BackColor = System.Drawing.Color.Transparent;
            this.creditsButton.BackgroundImage = global::OOP_Lab_II.Properties.Resources.credits;
            this.creditsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.creditsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsButton.FlatAppearance.BorderSize = 0;
            this.creditsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.creditsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.creditsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.creditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditsButton.Location = new System.Drawing.Point(442, 35);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(90, 75);
            this.creditsButton.TabIndex = 6;
            this.creditsButton.UseVisualStyleBackColor = false;
            this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
            this.creditsButton.Enter += new System.EventHandler(this.button_Enter);
            this.creditsButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.creditsButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::OOP_Lab_II.Properties.Resources.exitButton;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(680, 35);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 75);
            this.exitButton.TabIndex = 7;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.button_Enter);
            this.exitButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.exitButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.Transparent;
            this.profile.BackgroundImage = global::OOP_Lab_II.Properties.Resources.profilePanel;
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.Controls.Add(this.usernameLabel);
            this.profile.Controls.Add(this.avatarBox);
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.Location = new System.Drawing.Point(40, 17);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(233, 112);
            this.profile.TabIndex = 8;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            this.profile.MouseEnter += new System.EventHandler(this.panel_enter);
            this.profile.MouseLeave += new System.EventHandler(this.panel_leave);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Orange;
            this.usernameLabel.Location = new System.Drawing.Point(91, 36);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 29);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "aaaa";
            this.usernameLabel.Click += new System.EventHandler(this.profile_Click);
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.Color.Transparent;
            this.avatarBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatarBox.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.avatarBox.Location = new System.Drawing.Point(16, 26);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(70, 58);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            this.avatarBox.Click += new System.EventHandler(this.profile_Click);
            // 
            // save_password_panel
            // 
            this.save_password_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save_password_panel.BackColor = System.Drawing.Color.Orange;
            this.save_password_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.save_password_panel.Controls.Add(this.button2);
            this.save_password_panel.Controls.Add(this.button1);
            this.save_password_panel.Controls.Add(this.textBox1);
            this.save_password_panel.Location = new System.Drawing.Point(29, 385);
            this.save_password_panel.Name = "save_password_panel";
            this.save_password_panel.Size = new System.Drawing.Size(258, 103);
            this.save_password_panel.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(132, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.save_password_panel_close);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(20)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(38, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.save_password);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Orange;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(4, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 56);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Do you wanna save your password ?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // popup
            // 
            this.popup.BackColor = System.Drawing.Color.Transparent;
            this.popup.BackgroundImage = global::OOP_Lab_II.Properties.Resources.popup;
            this.popup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.popup.Controls.Add(this.windowPanel);
            this.popup.Controls.Add(this.exitPopup);
            this.popup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popup.Location = new System.Drawing.Point(0, 0);
            this.popup.Name = "popup";
            this.popup.Size = new System.Drawing.Size(800, 500);
            this.popup.TabIndex = 11;
            this.popup.Visible = false;
            // 
            // windowPanel
            // 
            this.windowPanel.Location = new System.Drawing.Point(152, 90);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(500, 350);
            this.windowPanel.TabIndex = 0;
            // 
            // exitPopup
            // 
            this.exitPopup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPopup.FlatAppearance.BorderSize = 0;
            this.exitPopup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitPopup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitPopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitPopup.Location = new System.Drawing.Point(650, 50);
            this.exitPopup.Name = "exitPopup";
            this.exitPopup.Size = new System.Drawing.Size(40, 40);
            this.exitPopup.TabIndex = 1;
            this.exitPopup.UseVisualStyleBackColor = true;
            this.exitPopup.Click += new System.EventHandler(this.exitPopup_Click);
            // 
            // muteButton
            // 
            this.muteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.muteButton.BackColor = System.Drawing.Color.Transparent;
            this.muteButton.BackgroundImage = global::OOP_Lab_II.Properties.Resources.Mute;
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.muteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteButton.FlatAppearance.BorderSize = 0;
            this.muteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.muteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.muteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteButton.Location = new System.Drawing.Point(564, 35);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(90, 75);
            this.muteButton.TabIndex = 12;
            this.muteButton.UseVisualStyleBackColor = false;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            this.muteButton.Enter += new System.EventHandler(this.button_Enter);
            this.muteButton.MouseEnter += new System.EventHandler(this.button_Enter);
            this.muteButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::OOP_Lab_II.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.popup);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.save_password_panel);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.fullscreenButton);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.save_password_panel.ResumeLayout(false);
            this.save_password_panel.PerformLayout();
            this.popup.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button fullscreenButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel profile;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel save_password_panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel popup;
        private System.Windows.Forms.Button exitPopup;
        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.Button muteButton;
    }
}