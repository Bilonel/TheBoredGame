
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(298, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = "3";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(648, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BestScoreLabel);
            this.panel1.Location = new System.Drawing.Point(274, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 77);
            this.panel1.TabIndex = 2;
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BestScoreLabel.Location = new System.Drawing.Point(4, 46);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(182, 31);
            this.BestScoreLabel.TabIndex = 0;
            this.BestScoreLabel.Text = "Best Score: 0";
            this.BestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gameOverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.gameOverPanel.Controls.Add(this.score);
            this.gameOverPanel.Controls.Add(this.label3);
            this.gameOverPanel.Controls.Add(this.refresh);
            this.gameOverPanel.Location = new System.Drawing.Point(217, -1);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(300, 452);
            this.gameOverPanel.TabIndex = 5;
            this.gameOverPanel.Visible = false;
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(3, 149);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(294, 143);
            this.score.TabIndex = 2;
            this.score.Text = "SCORE: 100";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 51);
            this.label3.TabIndex = 0;
            this.label3.Text = "GAME OVER";
            // 
            // refresh
            // 
            this.refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = global::OOP_Lab_II.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(118, 331);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(65, 64);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 1;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Screen_Load);
            this.Shown += new System.EventHandler(this.Screen_Shown);
            this.panel1.ResumeLayout(false);
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.Label BestScoreLabel;
    }
}