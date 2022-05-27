namespace server
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.standBox = new System.Windows.Forms.ListBox();
            this.receviedMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pairsBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playersBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // standBox
            // 
            this.standBox.FormattingEnabled = true;
            this.standBox.Location = new System.Drawing.Point(48, 84);
            this.standBox.Name = "standBox";
            this.standBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.standBox.Size = new System.Drawing.Size(126, 173);
            this.standBox.TabIndex = 6;
            // 
            // receviedMessage
            // 
            this.receviedMessage.AutoSize = true;
            this.receviedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.receviedMessage.Location = new System.Drawing.Point(288, 461);
            this.receviedMessage.Name = "receviedMessage";
            this.receviedMessage.Size = new System.Drawing.Size(248, 42);
            this.receviedMessage.TabIndex = 7;
            this.receviedMessage.Text = "Gelen Mesaj :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STAND PLAYERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PAIRS";
            // 
            // pairsBox
            // 
            this.pairsBox.FormattingEnabled = true;
            this.pairsBox.Location = new System.Drawing.Point(229, 84);
            this.pairsBox.Name = "pairsBox";
            this.pairsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pairsBox.Size = new System.Drawing.Size(126, 173);
            this.pairsBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ALL PLAYERS";
            // 
            // playersBox
            // 
            this.playersBox.FormattingEnabled = true;
            this.playersBox.Location = new System.Drawing.Point(400, 84);
            this.playersBox.Name = "playersBox";
            this.playersBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.playersBox.Size = new System.Drawing.Size(126, 173);
            this.playersBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(373, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 61);
            this.button2.TabIndex = 13;
            this.button2.Text = "CONNECT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playersBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pairsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.receviedMessage);
            this.Controls.Add(this.standBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox standBox;
        private System.Windows.Forms.Label receviedMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox pairsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox playersBox;
        private System.Windows.Forms.Button button2;
    }
}

