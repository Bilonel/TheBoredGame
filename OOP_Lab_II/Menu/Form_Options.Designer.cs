
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_panel = new System.Windows.Forms.Panel();
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
            this.colorList = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.color_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.shape_panel.SuspendLayout();
            this.diff_panel.SuspendLayout();
            this.custom_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.AutoSize = true;
            this.cancel_button.BackColor = System.Drawing.Color.Wheat;
            this.cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancel_button.ForeColor = System.Drawing.Color.Sienna;
            this.cancel_button.Location = new System.Drawing.Point(361, 0);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(39, 23);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "CANCEL";
            this.cancel_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.color_panel);
            this.panel1.Controls.Add(this.bottom_panel);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.shape_panel);
            this.panel1.Controls.Add(this.diff_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 420);
            this.panel1.TabIndex = 10;
            // 
            // color_panel
            // 
            this.color_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.color_panel.BackColor = System.Drawing.Color.Gold;
            this.color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_panel.Controls.Add(this.colorList);
            this.color_panel.Controls.Add(this.label3);
            this.color_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_panel.Location = new System.Drawing.Point(52, 151);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(303, 34);
            this.color_panel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "COLOR";
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.Khaki;
            this.bottom_panel.Controls.Add(this.warnBox);
            this.bottom_panel.Controls.Add(this.save_button);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 303);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(400, 117);
            this.bottom_panel.TabIndex = 7;
            // 
            // warnBox
            // 
            this.warnBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.warnBox.BackColor = System.Drawing.Color.Gold;
            this.warnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warnBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.warnBox.Location = new System.Drawing.Point(6, 90);
            this.warnBox.Name = "warnBox";
            this.warnBox.ReadOnly = true;
            this.warnBox.Size = new System.Drawing.Size(388, 17);
            this.warnBox.TabIndex = 10;
            this.warnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.save_button.BackColor = System.Drawing.Color.Gold;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_button.Location = new System.Drawing.Point(119, 27);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(174, 44);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_Click);
            // 
            // shape_panel
            // 
            this.shape_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.shape_panel.BackColor = System.Drawing.Color.Gold;
            this.shape_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shape_panel.Controls.Add(this.shapeList);
            this.shape_panel.Controls.Add(this.label2);
            this.shape_panel.Location = new System.Drawing.Point(52, 111);
            this.shape_panel.Name = "shape_panel";
            this.shape_panel.Size = new System.Drawing.Size(303, 34);
            this.shape_panel.TabIndex = 5;
            // 
            // shapeList
            // 
            this.shapeList.BackColor = System.Drawing.Color.Khaki;
            this.shapeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeList.CheckOnClick = true;
            this.shapeList.ColumnWidth = 53;
            this.shapeList.Items.AddRange(new object[] {
            "Rect.",
            "Triang.",
            "Round"});
            this.shapeList.Location = new System.Drawing.Point(123, 8);
            this.shapeList.MultiColumn = true;
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(159, 15);
            this.shapeList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "SHAPES";
            // 
            // diff_panel
            // 
            this.diff_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diff_panel.BackColor = System.Drawing.Color.Gold;
            this.diff_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diff_panel.Controls.Add(this.custom_panel);
            this.diff_panel.Controls.Add(this.diffBox);
            this.diff_panel.Controls.Add(this.label1);
            this.diff_panel.Location = new System.Drawing.Point(52, 71);
            this.diff_panel.Name = "diff_panel";
            this.diff_panel.Size = new System.Drawing.Size(303, 34);
            this.diff_panel.TabIndex = 4;
            // 
            // custom_panel
            // 
            this.custom_panel.BackColor = System.Drawing.Color.Gold;
            this.custom_panel.Controls.Add(this.height_box);
            this.custom_panel.Controls.Add(this.width_box);
            this.custom_panel.Controls.Add(this.xText);
            this.custom_panel.Location = new System.Drawing.Point(237, 3);
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
            this.xText.BackColor = System.Drawing.Color.Gold;
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
            this.diffBox.BackColor = System.Drawing.Color.Khaki;
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
            this.diffBox.Location = new System.Drawing.Point(125, 4);
            this.diffBox.Name = "diffBox";
            this.diffBox.Size = new System.Drawing.Size(106, 24);
            this.diffBox.TabIndex = 1;
            this.diffBox.SelectedIndexChanged += new System.EventHandler(this.diffBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIFFICULTY";
            // 
            // colorList
            // 
            this.colorList.BackColor = System.Drawing.Color.Khaki;
            this.colorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorList.CheckOnClick = true;
            this.colorList.ColumnWidth = 53;
            this.colorList.Items.AddRange(new object[] {
            "Orange",
            "Green",
            "Blue"});
            this.colorList.Location = new System.Drawing.Point(124, 8);
            this.colorList.MultiColumn = true;
            this.colorList.Name = "colorList";
            this.colorList.Size = new System.Drawing.Size(159, 15);
            this.colorList.TabIndex = 3;
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(400, 420);
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
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel color_panel;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.CheckedListBox colorList;
    }
}