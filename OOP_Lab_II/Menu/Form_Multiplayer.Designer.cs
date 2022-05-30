
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
            this.avatar1 = new System.Windows.Forms.PictureBox();
            this.player1Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.avatar2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).BeginInit();
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
            this.findButton.Size = new System.Drawing.Size(349, 62);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "HOST";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.HostButton_Click);
            // 
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
            // 
            // Form_Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(601, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.avatar2);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.avatar1);
            this.Controls.Add(this.findButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Multiplayer";
            this.Text = "Form_Multiplayer";
            this.Load += new System.EventHandler(this.Form_Multiplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.PictureBox avatar1;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.PictureBox avatar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}