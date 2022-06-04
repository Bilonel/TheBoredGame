
namespace OOP_Lab_II.Game
{
    partial class GameScreen
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
            System.Windows.Forms.Button button1;
            this.p1_scorePanel = new System.Windows.Forms.Panel();
            this.p1_bestScore = new System.Windows.Forms.Label();
            this.p1_name = new System.Windows.Forms.Label();
            this.p1_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p2_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.p2_name = new System.Windows.Forms.Label();
            this.p2_scorePanel = new System.Windows.Forms.Panel();
            this.p2_bestScore = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            this.p1_scorePanel.SuspendLayout();
            this.p1_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p2_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.p2_scorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(292, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 22);
            button1.TabIndex = 1;
            button1.Text = "MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p1_scorePanel
            // 
            this.p1_scorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.p1_scorePanel.Controls.Add(this.p1_bestScore);
            this.p1_scorePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p1_scorePanel.Location = new System.Drawing.Point(0, 333);
            this.p1_scorePanel.Name = "p1_scorePanel";
            this.p1_scorePanel.Size = new System.Drawing.Size(120, 108);
            this.p1_scorePanel.TabIndex = 2;
            // 
            // p1_bestScore
            // 
            this.p1_bestScore.BackColor = System.Drawing.Color.Transparent;
            this.p1_bestScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p1_bestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p1_bestScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.p1_bestScore.Location = new System.Drawing.Point(0, 56);
            this.p1_bestScore.Name = "p1_bestScore";
            this.p1_bestScore.Size = new System.Drawing.Size(120, 52);
            this.p1_bestScore.TabIndex = 0;
            this.p1_bestScore.Text = "Best Score: -10";
            this.p1_bestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_name
            // 
            this.p1_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.p1_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.p1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p1_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.p1_name.Location = new System.Drawing.Point(0, 0);
            this.p1_name.Name = "p1_name";
            this.p1_name.Size = new System.Drawing.Size(120, 88);
            this.p1_name.TabIndex = 7;
            this.p1_name.Text = "label2";
            this.p1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_panel
            // 
            this.p1_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.p1_panel.Controls.Add(this.panel2);
            this.p1_panel.Controls.Add(this.panel1);
            this.p1_panel.Controls.Add(this.pictureBox1);
            this.p1_panel.Controls.Add(this.p1_name);
            this.p1_panel.Controls.Add(this.p1_scorePanel);
            this.p1_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.p1_panel.Location = new System.Drawing.Point(0, 0);
            this.p1_panel.Name = "p1_panel";
            this.p1_panel.Size = new System.Drawing.Size(120, 441);
            this.p1_panel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 10);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 10);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // p2_panel
            // 
            this.p2_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.p2_panel.Controls.Add(this.pictureBox2);
            this.p2_panel.Controls.Add(this.panel3);
            this.p2_panel.Controls.Add(this.panel4);
            this.p2_panel.Controls.Add(this.p2_name);
            this.p2_panel.Controls.Add(this.p2_scorePanel);
            this.p2_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.p2_panel.Location = new System.Drawing.Point(564, 0);
            this.p2_panel.Name = "p2_panel";
            this.p2_panel.Size = new System.Drawing.Size(120, 441);
            this.p2_panel.TabIndex = 9;
            this.p2_panel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::OOP_Lab_II.Properties.Resources.default_avatar;
            this.pictureBox2.Location = new System.Drawing.Point(0, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 10);
            this.panel4.TabIndex = 10;
            // 
            // p2_name
            // 
            this.p2_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.p2_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p2_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.p2_name.Location = new System.Drawing.Point(0, 0);
            this.p2_name.Name = "p2_name";
            this.p2_name.Size = new System.Drawing.Size(120, 88);
            this.p2_name.TabIndex = 7;
            this.p2_name.Text = "label4";
            this.p2_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_scorePanel
            // 
            this.p2_scorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.p2_scorePanel.Controls.Add(this.p2_bestScore);
            this.p2_scorePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p2_scorePanel.Location = new System.Drawing.Point(0, 333);
            this.p2_scorePanel.Name = "p2_scorePanel";
            this.p2_scorePanel.Size = new System.Drawing.Size(120, 108);
            this.p2_scorePanel.TabIndex = 2;
            // 
            // p2_bestScore
            // 
            this.p2_bestScore.BackColor = System.Drawing.Color.Transparent;
            this.p2_bestScore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p2_bestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p2_bestScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.p2_bestScore.Location = new System.Drawing.Point(0, 56);
            this.p2_bestScore.Name = "p2_bestScore";
            this.p2_bestScore.Size = new System.Drawing.Size(120, 52);
            this.p2_bestScore.TabIndex = 0;
            this.p2_bestScore.Text = "Best Score: 0";
            this.p2_bestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refresh
            // 
            this.refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::OOP_Lab_II.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(156, 356);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(81, 60);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 1;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 98);
            this.label3.TabIndex = 0;
            this.label3.Text = "G A M E   O V E R";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Dock = System.Windows.Forms.DockStyle.Top;
            this.score.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(0, 98);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(374, 255);
            this.score.TabIndex = 2;
            this.score.Text = "SCORE: 100";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gameOverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.gameOverPanel.Controls.Add(this.score);
            this.gameOverPanel.Controls.Add(this.label3);
            this.gameOverPanel.Controls.Add(this.refresh);
            this.gameOverPanel.Location = new System.Drawing.Point(155, 0);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(374, 443);
            this.gameOverPanel.TabIndex = 5;
            this.gameOverPanel.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = button1;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(button1);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.p2_panel);
            this.Controls.Add(this.p1_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameScreen_FormClosed);
            this.Load += new System.EventHandler(this.Screen_Load);
            this.Shown += new System.EventHandler(this.Screen_Shown);
            this.p1_scorePanel.ResumeLayout(false);
            this.p1_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p2_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.p2_scorePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.gameOverPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel p1_scorePanel;
        private System.Windows.Forms.Label p1_bestScore;
        private System.Windows.Forms.Label p1_name;
        private System.Windows.Forms.Panel p1_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel p2_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label p2_name;
        private System.Windows.Forms.Panel p2_scorePanel;
        private System.Windows.Forms.Label p2_bestScore;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label score;
        public System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}