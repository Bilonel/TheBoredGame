
namespace OOP_Lab_II.Menu
{
    partial class Form_Options
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_panel = new System.Windows.Forms.Panel();
            this.colorList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.warnBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.shape_panel = new System.Windows.Forms.Panel();
            this.shapeList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diff_panel = new System.Windows.Forms.Panel();
            this.custom_panel = new System.Windows.Forms.Panel();
            this.height_box = new System.Windows.Forms.TextBox();
            this.width_box = new System.Windows.Forms.TextBox();
            this.xText = new System.Windows.Forms.TextBox();
            this.diffBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.color_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.shape_panel.SuspendLayout();
            this.diff_panel.SuspendLayout();
            this.custom_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.color_panel);
            this.panel1.Controls.Add(this.bottom_panel);
            this.panel1.Controls.Add(this.shape_panel);
            this.panel1.Controls.Add(this.diff_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 246);
            this.panel1.TabIndex = 10;
            // 
            // color_panel
            // 
            this.color_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.color_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.color_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_panel.Controls.Add(this.colorList);
            this.color_panel.Controls.Add(this.label3);
            this.color_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_panel.Location = new System.Drawing.Point(20, 131);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(394, 33);
            this.color_panel.TabIndex = 6;
            this.color_panel.Visible = false;
            // 
            // colorList
            // 
            this.colorList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.colorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorList.CheckOnClick = true;
            this.colorList.ColumnWidth = 75;
            this.colorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colorList.Items.AddRange(new object[] {
            "Orange",
            "Green",
            "Blue"});
            this.colorList.Location = new System.Drawing.Point(149, 7);
            this.colorList.MultiColumn = true;
            this.colorList.Name = "colorList";
            this.colorList.Size = new System.Drawing.Size(225, 18);
            this.colorList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "COLOR";
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(162)))), ((int)(((byte)(0)))));
            this.bottom_panel.Controls.Add(this.warnBox);
            this.bottom_panel.Controls.Add(this.save_button);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 172);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(435, 74);
            this.bottom_panel.TabIndex = 7;
            // 
            // warnBox
            // 
            this.warnBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.warnBox.BackColor = System.Drawing.Color.Orange;
            this.warnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warnBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.warnBox.Location = new System.Drawing.Point(20, 49);
            this.warnBox.Name = "warnBox";
            this.warnBox.ReadOnly = true;
            this.warnBox.Size = new System.Drawing.Size(388, 17);
            this.warnBox.TabIndex = 10;
            this.warnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.Location = new System.Drawing.Point(128, 7);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(174, 41);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_Click);
            // 
            // shape_panel
            // 
            this.shape_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.shape_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shape_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.shape_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shape_panel.Controls.Add(this.shapeList);
            this.shape_panel.Controls.Add(this.label2);
            this.shape_panel.Location = new System.Drawing.Point(20, 73);
            this.shape_panel.Name = "shape_panel";
            this.shape_panel.Size = new System.Drawing.Size(394, 33);
            this.shape_panel.TabIndex = 5;
            this.shape_panel.Visible = false;
            // 
            // shapeList
            // 
            this.shapeList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shapeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.shapeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeList.CheckOnClick = true;
            this.shapeList.ColumnWidth = 75;
            this.shapeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shapeList.Items.AddRange(new object[] {
            "Rect.",
            "Triang.",
            "Round"});
            this.shapeList.Location = new System.Drawing.Point(148, 7);
            this.shapeList.MultiColumn = true;
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(226, 18);
            this.shapeList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "SHAPES";
            // 
            // diff_panel
            // 
            this.diff_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diff_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diff_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.diff_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diff_panel.Controls.Add(this.custom_panel);
            this.diff_panel.Controls.Add(this.diffBox);
            this.diff_panel.Controls.Add(this.label1);
            this.diff_panel.Location = new System.Drawing.Point(20, 19);
            this.diff_panel.Name = "diff_panel";
            this.diff_panel.Size = new System.Drawing.Size(394, 33);
            this.diff_panel.TabIndex = 4;
            // 
            // custom_panel
            // 
            this.custom_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.custom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.custom_panel.Controls.Add(this.height_box);
            this.custom_panel.Controls.Add(this.width_box);
            this.custom_panel.Controls.Add(this.xText);
            this.custom_panel.Location = new System.Drawing.Point(307, 2);
            this.custom_panel.Name = "custom_panel";
            this.custom_panel.Size = new System.Drawing.Size(61, 26);
            this.custom_panel.TabIndex = 2;
            this.custom_panel.Visible = false;
            // 
            // height_box
            // 
            this.height_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.height_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.height_box.Location = new System.Drawing.Point(39, 6);
            this.height_box.MaxLength = 2;
            this.height_box.Name = "height_box";
            this.height_box.Size = new System.Drawing.Size(20, 16);
            this.height_box.TabIndex = 1;
            this.height_box.Text = "H";
            // 
            // width_box
            // 
            this.width_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.width_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.width_box.Location = new System.Drawing.Point(3, 6);
            this.width_box.MaxLength = 2;
            this.width_box.Name = "width_box";
            this.width_box.Size = new System.Drawing.Size(20, 16);
            this.width_box.TabIndex = 0;
            this.width_box.Text = "W";
            // 
            // xText
            // 
            this.xText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            this.xText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xText.Location = new System.Drawing.Point(27, 6);
            this.xText.MaxLength = 2;
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(20, 16);
            this.xText.TabIndex = 2;
            this.xText.Text = "x";
            // 
            // diffBox
            // 
            this.diffBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.diffBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.diffBox.DropDownHeight = 100;
            this.diffBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diffBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diffBox.FormattingEnabled = true;
            this.diffBox.IntegralHeight = false;
            this.diffBox.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Custom"});
            this.diffBox.Location = new System.Drawing.Point(195, 3);
            this.diffBox.Name = "diffBox";
            this.diffBox.Size = new System.Drawing.Size(106, 24);
            this.diffBox.TabIndex = 1;
            this.diffBox.SelectedIndexChanged += new System.EventHandler(this.diffBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIFFICULTY";
            // 
            // Form_Options
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(435, 246);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Options";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form_Options";
            this.Load += new System.EventHandler(this.Form_Options_Load);
            this.panel1.ResumeLayout(false);
            this.color_panel.ResumeLayout(false);
            this.color_panel.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.shape_panel.ResumeLayout(false);
            this.shape_panel.PerformLayout();
            this.diff_panel.ResumeLayout(false);
            this.diff_panel.PerformLayout();
            this.custom_panel.ResumeLayout(false);
            this.custom_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel shape_panel;
        private System.Windows.Forms.CheckedListBox shapeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel diff_panel;
        private System.Windows.Forms.ComboBox diffBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel custom_panel;
        private System.Windows.Forms.TextBox height_box;
        private System.Windows.Forms.TextBox width_box;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox warnBox;
        private System.Windows.Forms.Panel color_panel;
        private System.Windows.Forms.CheckedListBox colorList;
        private System.Windows.Forms.Label label3;
    }
}