namespace Client
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.connectState = new System.Windows.Forms.Label();
            this.receivedText = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Location = new System.Drawing.Point(27, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(137, 56);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // connectState
            // 
            this.connectState.AutoSize = true;
            this.connectState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectState.Location = new System.Drawing.Point(168, 23);
            this.connectState.Name = "connectState";
            this.connectState.Size = new System.Drawing.Size(0, 31);
            this.connectState.TabIndex = 18;
            // 
            // receivedText
            // 
            this.receivedText.AutoSize = true;
            this.receivedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.receivedText.Location = new System.Drawing.Point(198, 265);
            this.receivedText.Name = "receivedText";
            this.receivedText.Size = new System.Drawing.Size(0, 31);
            this.receivedText.TabIndex = 19;
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(146, 190);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(153, 20);
            this.messageText.TabIndex = 20;
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendBtn.Location = new System.Drawing.Point(31, 190);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(98, 26);
            this.SendBtn.TabIndex = 21;
            this.SendBtn.Text = "SEND";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameBox.Location = new System.Drawing.Point(27, 23);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(171, 31);
            this.nameBox.TabIndex = 22;
            this.nameBox.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(146, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 56);
            this.button1.TabIndex = 23;
            this.button1.Text = "New Client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.receivedText);
            this.Controls.Add(this.connectState);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label connectState;
        private System.Windows.Forms.Label receivedText;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button1;
    }
}

