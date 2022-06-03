
namespace OOP_Lab_II.Menu
{
    partial class Form_Multiplayer
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
            this.findButton = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.avatar1 = new System.Windows.Forms.PictureBox();
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.avatar2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).BeginInit();
=======
            this.HostsPanel = new System.Windows.Forms.Panel();
            this.showHostsButton = new System.Windows.Forms.Button();
            this.showGamesButton = new System.Windows.Forms.Button();
            this.GamesPanel = new System.Windows.Forms.Panel();
            this.InitedPanel = new System.Windows.Forms.Panel();
            this.datLabel = new System.Windows.Forms.Label();
            this.acceptChallengeButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.InitedPanel.SuspendLayout();
>>>>>>> Test2_Coop
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.findButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.findButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.findButton.Location = new System.Drawing.Point(123, 456);
            this.findButton.Name = "findButton";
<<<<<<< HEAD
            this.findButton.Size = new System.Drawing.Size(349, 62);
=======
            this.findButton.Size = new System.Drawing.Size(350, 62);
>>>>>>> Test2_Coop
            this.findButton.TabIndex = 6;
            this.findButton.Text = "HOST";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
<<<<<<< HEAD
            // avatar1
            // 
            this.avatar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.avatar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.avatar1.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.avatar1.Location = new System.Drawing.Point(105, 50);
            this.avatar1.Name = "avatar1";
            this.avatar1.Size = new System.Drawing.Size(107, 119);
            this.avatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.avatar1.TabIndex = 7;
            this.avatar1.TabStop = false;
            // 
            // player1Name
            // 
            this.player1Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1Name.ForeColor = System.Drawing.Color.Black;
            this.player1Name.Location = new System.Drawing.Point(117, 186);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(82, 31);
            this.player1Name.TabIndex = 8;
            this.player1Name.Text = "user1";
            this.player1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Name
            // 
            this.player2Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2Name.ForeColor = System.Drawing.Color.Black;
            this.player2Name.Location = new System.Drawing.Point(393, 186);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(82, 31);
            this.player2Name.TabIndex = 10;
            this.player2Name.Text = "user1";
            this.player2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player2Name.Visible = false;
            // 
            // avatar2
            // 
            this.avatar2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.avatar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.avatar2.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.avatar2.Location = new System.Drawing.Point(381, 50);
            this.avatar2.Name = "avatar2";
            this.avatar2.Size = new System.Drawing.Size(107, 119);
            this.avatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.avatar2.TabIndex = 9;
            this.avatar2.TabStop = false;
            this.avatar2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(253, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 67);
            this.label3.TabIndex = 11;
            this.label3.Text = "VS";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(123, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ConnectButton_Click);
=======
            // HostsPanel
            // 
            this.HostsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HostsPanel.AutoScroll = true;
            this.HostsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.HostsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HostsPanel.Location = new System.Drawing.Point(123, 77);
            this.HostsPanel.Name = "HostsPanel";
            this.HostsPanel.Size = new System.Drawing.Size(350, 348);
            this.HostsPanel.TabIndex = 13;
            // 
            // showHostsButton
            // 
            this.showHostsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showHostsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.showHostsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showHostsButton.Enabled = false;
            this.showHostsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.showHostsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.showHostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showHostsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.showHostsButton.Location = new System.Drawing.Point(123, 50);
            this.showHostsButton.Margin = new System.Windows.Forms.Padding(10);
            this.showHostsButton.Name = "showHostsButton";
            this.showHostsButton.Size = new System.Drawing.Size(116, 28);
            this.showHostsButton.TabIndex = 14;
            this.showHostsButton.Text = "Host List";
            this.showHostsButton.UseVisualStyleBackColor = false;
            this.showHostsButton.Click += new System.EventHandler(this.showPanel_Click);
            // 
            // showGamesButton
            // 
            this.showGamesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showGamesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.showGamesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showGamesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.showGamesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.showGamesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showGamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showGamesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.showGamesButton.Location = new System.Drawing.Point(238, 50);
            this.showGamesButton.Margin = new System.Windows.Forms.Padding(20);
            this.showGamesButton.Name = "showGamesButton";
            this.showGamesButton.Size = new System.Drawing.Size(116, 28);
            this.showGamesButton.TabIndex = 15;
            this.showGamesButton.Text = "button3";
            this.showGamesButton.UseVisualStyleBackColor = false;
            this.showGamesButton.Click += new System.EventHandler(this.showPanel_Click);
            // 
            // GamesPanel
            // 
            this.GamesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GamesPanel.AutoScroll = true;
            this.GamesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.GamesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamesPanel.Location = new System.Drawing.Point(123, 77);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(349, 348);
            this.GamesPanel.TabIndex = 14;
            this.GamesPanel.Visible = false;
            // 
            // InitedPanel
            // 
            this.InitedPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InitedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.InitedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InitedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InitedPanel.Controls.Add(this.panel3);
            this.InitedPanel.Controls.Add(this.panel1);
            this.InitedPanel.Controls.Add(this.panel4);
            this.InitedPanel.Controls.Add(this.panel2);
            this.InitedPanel.Controls.Add(this.datLabel);
            this.InitedPanel.Controls.Add(this.acceptChallengeButton);
            this.InitedPanel.Controls.Add(this.MessageLabel);
            this.InitedPanel.Location = new System.Drawing.Point(90, 101);
            this.InitedPanel.Name = "InitedPanel";
            this.InitedPanel.Size = new System.Drawing.Size(412, 320);
            this.InitedPanel.TabIndex = 16;
            this.InitedPanel.Visible = false;
            // 
            // datLabel
            // 
            this.datLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.datLabel.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.datLabel.ForeColor = System.Drawing.Color.Black;
            this.datLabel.Location = new System.Drawing.Point(154, 197);
            this.datLabel.Name = "datLabel";
            this.datLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datLabel.Size = new System.Drawing.Size(106, 42);
            this.datLabel.TabIndex = 2;
            this.datLabel.Text = "lll";
            this.datLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // acceptChallengeButton
            // 
            this.acceptChallengeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.acceptChallengeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.acceptChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptChallengeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acceptChallengeButton.ForeColor = System.Drawing.Color.Black;
            this.acceptChallengeButton.Location = new System.Drawing.Point(134, 247);
            this.acceptChallengeButton.Name = "acceptChallengeButton";
            this.acceptChallengeButton.Size = new System.Drawing.Size(141, 46);
            this.acceptChallengeButton.TabIndex = 1;
            this.acceptChallengeButton.Text = "Accept";
            this.acceptChallengeButton.UseVisualStyleBackColor = false;
            this.acceptChallengeButton.Click += new System.EventHandler(this.acceptChallengeButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Black;
            this.MessageLabel.Location = new System.Drawing.Point(3, 33);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(404, 156);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = " Challenged To You";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(400, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 298);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 298);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 10);
            this.panel4.TabIndex = 4;
>>>>>>> Test2_Coop
            // 
            // Form_Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(601, 543);
<<<<<<< HEAD
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.avatar2);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.avatar1);
=======
            this.Controls.Add(this.InitedPanel);
            this.Controls.Add(this.HostsPanel);
            this.Controls.Add(this.GamesPanel);
            this.Controls.Add(this.showGamesButton);
            this.Controls.Add(this.showHostsButton);
>>>>>>> Test2_Coop
            this.Controls.Add(this.findButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Multiplayer";
            this.Text = "Form_Multiplayer";
            this.Load += new System.EventHandler(this.Form_Multiplayer_Load);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            this.InitedPanel.ResumeLayout(false);
            this.ResumeLayout(false);
>>>>>>> Test2_Coop

        }

        #endregion
        private System.Windows.Forms.Button findButton;
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox avatar1;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.PictureBox avatar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.Panel HostsPanel;
        private System.Windows.Forms.Button showHostsButton;
        private System.Windows.Forms.Button showGamesButton;
        private System.Windows.Forms.Panel GamesPanel;
        private System.Windows.Forms.Panel InitedPanel;
        private System.Windows.Forms.Button acceptChallengeButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label datLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
>>>>>>> Test2_Coop
    }
}