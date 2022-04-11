
namespace OOP_Lab_II.Forms
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.extra_button = new System.Windows.Forms.Button();
            this.shape_button = new System.Windows.Forms.Button();
            this.diff_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.diff_panel = new System.Windows.Forms.Panel();
            this.difficulty_text = new System.Windows.Forms.TextBox();
            this.custom_panel = new System.Windows.Forms.Panel();
            this.height_box = new System.Windows.Forms.TextBox();
            this.width_box = new System.Windows.Forms.TextBox();
            this.x_textBox = new System.Windows.Forms.TextBox();
            this.diff_list = new System.Windows.Forms.CheckedListBox();
            this.difficulty_main_panel = new System.Windows.Forms.Panel();
            this.shape_main_panel = new System.Windows.Forms.Panel();
            this.warnBox = new System.Windows.Forms.TextBox();
            this.color_panel = new System.Windows.Forms.Panel();
            this.color_text = new System.Windows.Forms.TextBox();
            this.colorList = new System.Windows.Forms.CheckedListBox();
            this.shape_panel = new System.Windows.Forms.Panel();
            this.shape_text = new System.Windows.Forms.TextBox();
            this.shapeList = new System.Windows.Forms.CheckedListBox();
            this.top_panel.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.diff_panel.SuspendLayout();
            this.custom_panel.SuspendLayout();
            this.difficulty_main_panel.SuspendLayout();
            this.shape_main_panel.SuspendLayout();
            this.color_panel.SuspendLayout();
            this.shape_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.DimGray;
            this.top_panel.Controls.Add(this.extra_button);
            this.top_panel.Controls.Add(this.shape_button);
            this.top_panel.Controls.Add(this.diff_button);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(400, 46);
            this.top_panel.TabIndex = 0;
            this.top_panel.Resize += new System.EventHandler(this.top_panel_resize);
            // 
            // extra_button
            // 
            this.extra_button.AutoSize = true;
            this.extra_button.BackColor = System.Drawing.Color.Gray;
            this.extra_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extra_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.extra_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extra_button.Location = new System.Drawing.Point(268, 0);
            this.extra_button.Name = "extra_button";
            this.extra_button.Size = new System.Drawing.Size(134, 46);
            this.extra_button.TabIndex = 2;
            this.extra_button.Text = "ooo";
            this.extra_button.UseVisualStyleBackColor = false;
            this.extra_button.Click += new System.EventHandler(this.extra_click);
            // 
            // shape_button
            // 
            this.shape_button.AutoSize = true;
            this.shape_button.BackColor = System.Drawing.Color.Gray;
            this.shape_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shape_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.shape_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shape_button.Location = new System.Drawing.Point(134, 0);
            this.shape_button.Name = "shape_button";
            this.shape_button.Size = new System.Drawing.Size(134, 46);
            this.shape_button.TabIndex = 3;
            this.shape_button.Text = "SHAPE";
            this.shape_button.UseVisualStyleBackColor = false;
            this.shape_button.Click += new System.EventHandler(this.shapes_click);
            // 
            // diff_button
            // 
            this.diff_button.AutoSize = true;
            this.diff_button.BackColor = System.Drawing.Color.Gray;
            this.diff_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diff_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.diff_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diff_button.ForeColor = System.Drawing.Color.Black;
            this.diff_button.Location = new System.Drawing.Point(0, 0);
            this.diff_button.Name = "diff_button";
            this.diff_button.Size = new System.Drawing.Size(134, 46);
            this.diff_button.TabIndex = 1;
            this.diff_button.Text = "DIFFICULTY";
            this.diff_button.UseVisualStyleBackColor = false;
            this.diff_button.Click += new System.EventHandler(this.difficulty_click);
            // 
            // save_button
            // 
            this.save_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.save_button.AutoSize = true;
            this.save_button.BackColor = System.Drawing.Color.DarkGray;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_button.ForeColor = System.Drawing.Color.OliveDrab;
            this.save_button.Location = new System.Drawing.Point(20, 17);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(170, 47);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "SAVE";
            this.save_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancel_button.AutoSize = true;
            this.cancel_button.BackColor = System.Drawing.Color.DarkGray;
            this.cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancel_button.ForeColor = System.Drawing.Color.Sienna;
            this.cancel_button.Location = new System.Drawing.Point(210, 17);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(170, 47);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "CANCEL";
            this.cancel_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.close_Click);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.Gray;
            this.bottom_panel.Controls.Add(this.cancel_button);
            this.bottom_panel.Controls.Add(this.save_button);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 346);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(400, 74);
            this.bottom_panel.TabIndex = 10;
            this.bottom_panel.Resize += new System.EventHandler(this.bottom_panel_resize);
            // 
            // diff_panel
            // 
            this.diff_panel.BackColor = System.Drawing.Color.DarkGray;
            this.diff_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diff_panel.Controls.Add(this.difficulty_text);
            this.diff_panel.Controls.Add(this.custom_panel);
            this.diff_panel.Controls.Add(this.diff_list);
            this.diff_panel.Location = new System.Drawing.Point(34, 69);
            this.diff_panel.Name = "diff_panel";
            this.diff_panel.Size = new System.Drawing.Size(210, 146);
            this.diff_panel.TabIndex = 3;
            // 
            // difficulty_text
            // 
            this.difficulty_text.BackColor = System.Drawing.Color.Gray;
            this.difficulty_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.difficulty_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.difficulty_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.difficulty_text.ForeColor = System.Drawing.Color.DarkGray;
            this.difficulty_text.Location = new System.Drawing.Point(0, 0);
            this.difficulty_text.MaxLength = 3;
            this.difficulty_text.Name = "difficulty_text";
            this.difficulty_text.ReadOnly = true;
            this.difficulty_text.Size = new System.Drawing.Size(208, 19);
            this.difficulty_text.TabIndex = 14;
            this.difficulty_text.Text = "Difficulty";
            this.difficulty_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custom_panel
            // 
            this.custom_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.custom_panel.AutoSize = true;
            this.custom_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.custom_panel.BackColor = System.Drawing.Color.DarkGray;
            this.custom_panel.Controls.Add(this.height_box);
            this.custom_panel.Controls.Add(this.width_box);
            this.custom_panel.Controls.Add(this.x_textBox);
            this.custom_panel.Location = new System.Drawing.Point(115, 114);
            this.custom_panel.Name = "custom_panel";
            this.custom_panel.Size = new System.Drawing.Size(90, 30);
            this.custom_panel.TabIndex = 13;
            // 
            // height_box
            // 
            this.height_box.BackColor = System.Drawing.Color.White;
            this.height_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.height_box.Location = new System.Drawing.Point(56, 7);
            this.height_box.MaxLength = 3;
            this.height_box.Name = "height_box";
            this.height_box.Size = new System.Drawing.Size(31, 20);
            this.height_box.TabIndex = 6;
            this.height_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // width_box
            // 
            this.width_box.BackColor = System.Drawing.Color.White;
            this.width_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.width_box.Location = new System.Drawing.Point(3, 7);
            this.width_box.MaxLength = 3;
            this.width_box.Name = "width_box";
            this.width_box.Size = new System.Drawing.Size(31, 20);
            this.width_box.TabIndex = 5;
            this.width_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x_textBox
            // 
            this.x_textBox.BackColor = System.Drawing.Color.DarkGray;
            this.x_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.x_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_textBox.ForeColor = System.Drawing.Color.White;
            this.x_textBox.Location = new System.Drawing.Point(29, 6);
            this.x_textBox.MaxLength = 3;
            this.x_textBox.Name = "x_textBox";
            this.x_textBox.ReadOnly = true;
            this.x_textBox.Size = new System.Drawing.Size(31, 19);
            this.x_textBox.TabIndex = 13;
            this.x_textBox.Text = "X";
            this.x_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // diff_list
            // 
            this.diff_list.BackColor = System.Drawing.Color.DarkGray;
            this.diff_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diff_list.CheckOnClick = true;
            this.diff_list.ColumnWidth = 50;
            this.diff_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.diff_list.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(16)));
            this.diff_list.ForeColor = System.Drawing.Color.White;
            this.diff_list.FormattingEnabled = true;
            this.diff_list.HorizontalExtent = 50;
            this.diff_list.Items.AddRange(new object[] {
            "EASY",
            "NORMAL",
            "HARD",
            "CUSTOM"});
            this.diff_list.Location = new System.Drawing.Point(0, 28);
            this.diff_list.Name = "diff_list";
            this.diff_list.Size = new System.Drawing.Size(208, 116);
            this.diff_list.TabIndex = 4;
            this.diff_list.ThreeDCheckBoxes = true;
            this.diff_list.UseCompatibleTextRendering = true;
            this.diff_list.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedList_Single_ItemCheck);
            // 
            // difficulty_main_panel
            // 
            this.difficulty_main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.difficulty_main_panel.BackColor = System.Drawing.Color.DarkGray;
            this.difficulty_main_panel.Controls.Add(this.diff_panel);
            this.difficulty_main_panel.Location = new System.Drawing.Point(0, 47);
            this.difficulty_main_panel.Name = "difficulty_main_panel";
            this.difficulty_main_panel.Size = new System.Drawing.Size(400, 299);
            this.difficulty_main_panel.TabIndex = 14;
            this.difficulty_main_panel.Visible = false;
            // 
            // shape_main_panel
            // 
            this.shape_main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shape_main_panel.BackColor = System.Drawing.Color.DarkGray;
            this.shape_main_panel.Controls.Add(this.warnBox);
            this.shape_main_panel.Controls.Add(this.color_panel);
            this.shape_main_panel.Controls.Add(this.shape_panel);
            this.shape_main_panel.Location = new System.Drawing.Point(0, 47);
            this.shape_main_panel.Name = "shape_main_panel";
            this.shape_main_panel.Size = new System.Drawing.Size(400, 299);
            this.shape_main_panel.TabIndex = 15;
            this.shape_main_panel.Visible = false;
            // 
            // warnBox
            // 
            this.warnBox.BackColor = System.Drawing.Color.DarkGray;
            this.warnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.warnBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.warnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warnBox.ForeColor = System.Drawing.Color.Green;
            this.warnBox.Location = new System.Drawing.Point(0, 264);
            this.warnBox.Multiline = true;
            this.warnBox.Name = "warnBox";
            this.warnBox.ReadOnly = true;
            this.warnBox.Size = new System.Drawing.Size(400, 35);
            this.warnBox.TabIndex = 16;
            this.warnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // color_panel
            // 
            this.color_panel.BackColor = System.Drawing.Color.DarkGray;
            this.color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_panel.Controls.Add(this.color_text);
            this.color_panel.Controls.Add(this.colorList);
            this.color_panel.Location = new System.Drawing.Point(247, 65);
            this.color_panel.Name = "color_panel";
            this.color_panel.Size = new System.Drawing.Size(102, 120);
            this.color_panel.TabIndex = 15;
            // 
            // color_text
            // 
            this.color_text.BackColor = System.Drawing.Color.Gray;
            this.color_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.color_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.color_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.color_text.ForeColor = System.Drawing.Color.DarkGray;
            this.color_text.Location = new System.Drawing.Point(0, 0);
            this.color_text.MaxLength = 3;
            this.color_text.Name = "color_text";
            this.color_text.ReadOnly = true;
            this.color_text.Size = new System.Drawing.Size(100, 19);
            this.color_text.TabIndex = 14;
            this.color_text.Text = "Colors";
            this.color_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorList
            // 
            this.colorList.BackColor = System.Drawing.Color.DarkGray;
            this.colorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorList.CheckOnClick = true;
            this.colorList.ColumnWidth = 50;
            this.colorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorList.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(16)));
            this.colorList.ForeColor = System.Drawing.Color.White;
            this.colorList.FormattingEnabled = true;
            this.colorList.HorizontalExtent = 50;
            this.colorList.Items.AddRange(new object[] {
            "RED",
            "GREEN",
            "BLUE"});
            this.colorList.Location = new System.Drawing.Point(0, 31);
            this.colorList.Name = "colorList";
            this.colorList.Size = new System.Drawing.Size(100, 87);
            this.colorList.TabIndex = 4;
            this.colorList.ThreeDCheckBoxes = true;
            this.colorList.UseCompatibleTextRendering = true;
            // 
            // shape_panel
            // 
            this.shape_panel.BackColor = System.Drawing.Color.DarkGray;
            this.shape_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shape_panel.Controls.Add(this.shape_text);
            this.shape_panel.Controls.Add(this.shapeList);
            this.shape_panel.Location = new System.Drawing.Point(46, 64);
            this.shape_panel.Name = "shape_panel";
            this.shape_panel.Size = new System.Drawing.Size(131, 120);
            this.shape_panel.TabIndex = 3;
            // 
            // shape_text
            // 
            this.shape_text.BackColor = System.Drawing.Color.Gray;
            this.shape_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shape_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.shape_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shape_text.ForeColor = System.Drawing.Color.DarkGray;
            this.shape_text.Location = new System.Drawing.Point(0, 0);
            this.shape_text.MaxLength = 3;
            this.shape_text.Name = "shape_text";
            this.shape_text.ReadOnly = true;
            this.shape_text.Size = new System.Drawing.Size(129, 19);
            this.shape_text.TabIndex = 14;
            this.shape_text.Text = "Shapes";
            this.shape_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapeList
            // 
            this.shapeList.BackColor = System.Drawing.Color.DarkGray;
            this.shapeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeList.CheckOnClick = true;
            this.shapeList.ColumnWidth = 50;
            this.shapeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shapeList.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(16)));
            this.shapeList.ForeColor = System.Drawing.Color.White;
            this.shapeList.FormattingEnabled = true;
            this.shapeList.HorizontalExtent = 50;
            this.shapeList.Items.AddRange(new object[] {
            "SQUARE",
            "TRIANGLE",
            "ROUND"});
            this.shapeList.Location = new System.Drawing.Point(0, 31);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(129, 87);
            this.shapeList.TabIndex = 4;
            this.shapeList.ThreeDCheckBoxes = true;
            this.shapeList.UseCompatibleTextRendering = true;
            // 
            // Form_Options
            // 
            this.AcceptButton = this.save_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.ControlBox = false;
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.shape_main_panel);
            this.Controls.Add(this.difficulty_main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Options";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form_Options";
            this.Load += new System.EventHandler(this.Form_Options_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.diff_panel.ResumeLayout(false);
            this.diff_panel.PerformLayout();
            this.custom_panel.ResumeLayout(false);
            this.custom_panel.PerformLayout();
            this.difficulty_main_panel.ResumeLayout(false);
            this.shape_main_panel.ResumeLayout(false);
            this.shape_main_panel.PerformLayout();
            this.color_panel.ResumeLayout(false);
            this.color_panel.PerformLayout();
            this.shape_panel.ResumeLayout(false);
            this.shape_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button extra_button;
        private System.Windows.Forms.Button shape_button;
        private System.Windows.Forms.Button diff_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Panel diff_panel;
        private System.Windows.Forms.TextBox difficulty_text;
        private System.Windows.Forms.Panel custom_panel;
        private System.Windows.Forms.TextBox height_box;
        private System.Windows.Forms.TextBox width_box;
        private System.Windows.Forms.TextBox x_textBox;
        private System.Windows.Forms.CheckedListBox diff_list;
        private System.Windows.Forms.Panel difficulty_main_panel;
        private System.Windows.Forms.Panel shape_main_panel;
        private System.Windows.Forms.Panel shape_panel;
        private System.Windows.Forms.TextBox shape_text;
        private System.Windows.Forms.CheckedListBox shapeList;
        private System.Windows.Forms.Panel color_panel;
        private System.Windows.Forms.TextBox color_text;
        private System.Windows.Forms.CheckedListBox colorList;
        private System.Windows.Forms.TextBox warnBox;
    }
}