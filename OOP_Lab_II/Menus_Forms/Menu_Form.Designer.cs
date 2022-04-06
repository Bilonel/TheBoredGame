namespace OOP_Lab_II
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
            this.multiplayerButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.profilPanel_back = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.profileButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.gameTitlePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuPanel.SuspendLayout();
            this.profilPanel_back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.gameTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // multiplayerButton
            // 
            this.multiplayerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.multiplayerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiplayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplayerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.multiplayerButton.FlatAppearance.BorderSize = 0;
            this.multiplayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplayerButton.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.multiplayerButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.multiplayerButton.Location = new System.Drawing.Point(9, 264);
            this.multiplayerButton.Name = "multiplayerButton";
            this.multiplayerButton.Size = new System.Drawing.Size(245, 45);
            this.multiplayerButton.TabIndex = 1;
            this.multiplayerButton.Text = "MULTIPLAYER";
            this.multiplayerButton.UseVisualStyleBackColor = false;
            this.multiplayerButton.Click += new System.EventHandler(this.multiplayer_click);
            this.multiplayerButton.Enter += new System.EventHandler(this.button_Enter);
            this.multiplayerButton.MouseEnter += new System.EventHandler(this.button_Enter);
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.optionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optionsButton.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.optionsButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.optionsButton.Location = new System.Drawing.Point(9, 325);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(245, 45);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.Text = "OPTIONS";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.options_click);
            this.optionsButton.Enter += new System.EventHandler(this.button_Enter);
            this.optionsButton.MouseEnter += new System.EventHandler(this.button_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.exitButton.Location = new System.Drawing.Point(9, 386);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(245, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exit_Click);
            this.exitButton.Enter += new System.EventHandler(this.button_Enter);
            this.exitButton.MouseEnter += new System.EventHandler(this.button_Enter);
            // 
            // windowPanel
            // 
            this.windowPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.windowPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.windowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowPanel.Location = new System.Drawing.Point(270, 0);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(574, 601);
            this.windowPanel.TabIndex = 4;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.Color.Silver;
            this.mainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainMenuPanel.Controls.Add(this.profilPanel_back);
            this.mainMenuPanel.Controls.Add(this.multiplayerButton);
            this.mainMenuPanel.Controls.Add(this.exitButton);
            this.mainMenuPanel.Controls.Add(this.playButton);
            this.mainMenuPanel.Controls.Add(this.optionsButton);
            this.mainMenuPanel.Controls.Add(this.gameTitlePanel);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(267, 601);
            this.mainMenuPanel.TabIndex = 5;
            // 
            // profilPanel_back
            // 
            this.profilPanel_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.profilPanel_back.Controls.Add(this.usernameLabel);
            this.profilPanel_back.Controls.Add(this.avatar);
            this.profilPanel_back.Controls.Add(this.profileButton);
            this.profilPanel_back.Location = new System.Drawing.Point(9, 501);
            this.profilPanel_back.Name = "profilPanel_back";
            this.profilPanel_back.Size = new System.Drawing.Size(252, 88);
            this.profilPanel_back.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLabel.Location = new System.Drawing.Point(101, 19);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 26);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatar.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.avatar.InitialImage = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.avatar.Location = new System.Drawing.Point(14, 14);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(68, 60);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profileButton.Location = new System.Drawing.Point(5, 5);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(242, 78);
            this.profileButton.TabIndex = 0;
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Gainsboro;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.playButton.Location = new System.Drawing.Point(9, 203);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(245, 45);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.multiplayer_click);
            this.playButton.Enter += new System.EventHandler(this.button_Enter);
            this.playButton.MouseEnter += new System.EventHandler(this.button_Enter);
            // 
            // gameTitlePanel
            // 
            this.gameTitlePanel.BackColor = System.Drawing.Color.DarkGray;
            this.gameTitlePanel.Controls.Add(this.pictureBox1);
            this.gameTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.gameTitlePanel.Name = "gameTitlePanel";
            this.gameTitlePanel.Size = new System.Drawing.Size(267, 156);
            this.gameTitlePanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OOP_Lab_II.Properties.Resources.cooltext407421524803244;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.ControlBox = false;
            this.Controls.Add(this.windowPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.mainMenuPanel.ResumeLayout(false);
            this.profilPanel_back.ResumeLayout(false);
            this.profilPanel_back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.gameTitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button multiplayerButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel gameTitlePanel;
        private System.Windows.Forms.Panel profilPanel_back;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button profileButton;
    }
}