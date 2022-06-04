
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
            this.findButton.Size = new System.Drawing.Size(350, 62);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "HOST";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
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
            // 
            // Form_Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(601, 543);
            this.Controls.Add(this.InitedPanel);
            this.Controls.Add(this.HostsPanel);
            this.Controls.Add(this.GamesPanel);
            this.Controls.Add(this.showGamesButton);
            this.Controls.Add(this.showHostsButton);
            this.Controls.Add(this.findButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Multiplayer";
            this.Text = "Form_Multiplayer";
            this.Load += new System.EventHandler(this.Form_Multiplayer_Load);
            this.InitedPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button findButton;
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
    }
}