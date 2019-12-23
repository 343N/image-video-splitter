using System;

namespace Video_and_GIF_Splitter
{
	partial class MainForm
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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.segmentsVert = new System.Windows.Forms.NumericUpDown();
			this.segmentsHoriz = new System.Windows.Forms.NumericUpDown();
			this.segmentHoriz = new System.Windows.Forms.Label();
			this.segmentVert = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.exportImages = new System.Windows.Forms.SaveFileDialog();
			this.transparencySlider = new System.Windows.Forms.NumericUpDown();
			this.transparencyLabel = new System.Windows.Forms.Label();
			this.segmentWidth = new System.Windows.Forms.NumericUpDown();
			this.segmentHeight = new System.Windows.Forms.NumericUpDown();
			this.segmentWidthLabel = new System.Windows.Forms.Label();
			this.segmentHeightLabel = new System.Windows.Forms.Label();
			this.segmentSizeLabel = new System.Windows.Forms.Label();
			this.imageSizeReal = new System.Windows.Forms.Label();
			this.imageSizeScaled = new System.Windows.Forms.Label();
			this.autoSegment = new System.Windows.Forms.Button();
			this.autoSegmentSize = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentsVert)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentsHoriz)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transparencySlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentHeight)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1065, 535);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// segmentsVert
			// 
			this.segmentsVert.Location = new System.Drawing.Point(12, 52);
			this.segmentsVert.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.segmentsVert.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.segmentsVert.Name = "segmentsVert";
			this.segmentsVert.Size = new System.Drawing.Size(40, 20);
			this.segmentsVert.TabIndex = 3;
			this.segmentsVert.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.segmentsVert.ValueChanged += new System.EventHandler(this.segmentsVert_ValueChanged);
			// 
			// segmentsHoriz
			// 
			this.segmentsHoriz.Location = new System.Drawing.Point(12, 26);
			this.segmentsHoriz.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.segmentsHoriz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.segmentsHoriz.Name = "segmentsHoriz";
			this.segmentsHoriz.Size = new System.Drawing.Size(40, 20);
			this.segmentsHoriz.TabIndex = 4;
			this.segmentsHoriz.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.segmentsHoriz.ValueChanged += new System.EventHandler(this.segmentsHoriz_ValueChanged);
			// 
			// segmentHoriz
			// 
			this.segmentHoriz.AutoSize = true;
			this.segmentHoriz.BackColor = System.Drawing.SystemColors.Control;
			this.segmentHoriz.ForeColor = System.Drawing.SystemColors.ControlText;
			this.segmentHoriz.Location = new System.Drawing.Point(59, 28);
			this.segmentHoriz.Name = "segmentHoriz";
			this.segmentHoriz.Size = new System.Drawing.Size(97, 13);
			this.segmentHoriz.TabIndex = 5;
			this.segmentHoriz.Text = "Segment (columns)";
			// 
			// segmentVert
			// 
			this.segmentVert.AutoSize = true;
			this.segmentVert.BackColor = System.Drawing.SystemColors.Control;
			this.segmentVert.ForeColor = System.Drawing.SystemColors.ControlText;
			this.segmentVert.Location = new System.Drawing.Point(59, 54);
			this.segmentVert.Name = "segmentVert";
			this.segmentVert.Size = new System.Drawing.Size(85, 13);
			this.segmentVert.TabIndex = 6;
			this.segmentVert.Text = "Segments (rows)";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1281, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.checkBox1.Location = new System.Drawing.Point(12, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(124, 17);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Draw Segment Lines";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// exportImages
			// 
			this.exportImages.FileOk += new System.ComponentModel.CancelEventHandler(this.exportImages_FileOk);
			// 
			// transparencySlider
			// 
			this.transparencySlider.Enabled = false;
			this.transparencySlider.Location = new System.Drawing.Point(202, 50);
			this.transparencySlider.Name = "transparencySlider";
			this.transparencySlider.Size = new System.Drawing.Size(40, 20);
			this.transparencySlider.TabIndex = 9;
			this.transparencySlider.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			this.transparencySlider.Visible = false;
			// 
			// transparencyLabel
			// 
			this.transparencyLabel.AutoSize = true;
			this.transparencyLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.transparencyLabel.Enabled = false;
			this.transparencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.transparencyLabel.Location = new System.Drawing.Point(249, 52);
			this.transparencyLabel.Name = "transparencyLabel";
			this.transparencyLabel.Size = new System.Drawing.Size(140, 13);
			this.transparencyLabel.TabIndex = 10;
			this.transparencyLabel.Text = "Segment Line Transparency";
			this.transparencyLabel.Visible = false;
			// 
			// segmentWidth
			// 
			this.segmentWidth.Location = new System.Drawing.Point(12, 145);
			this.segmentWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.segmentWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.segmentWidth.Name = "segmentWidth";
			this.segmentWidth.Size = new System.Drawing.Size(40, 20);
			this.segmentWidth.TabIndex = 11;
			this.segmentWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.segmentWidth.ValueChanged += new System.EventHandler(this.segmentWidth_ValueChanged);
			// 
			// segmentHeight
			// 
			this.segmentHeight.Location = new System.Drawing.Point(12, 171);
			this.segmentHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.segmentHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.segmentHeight.Name = "segmentHeight";
			this.segmentHeight.Size = new System.Drawing.Size(40, 20);
			this.segmentHeight.TabIndex = 12;
			this.segmentHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.segmentHeight.ValueChanged += new System.EventHandler(this.segmentHeight_ValueChanged);
			// 
			// segmentWidthLabel
			// 
			this.segmentWidthLabel.AutoSize = true;
			this.segmentWidthLabel.BackColor = System.Drawing.SystemColors.Control;
			this.segmentWidthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.segmentWidthLabel.Location = new System.Drawing.Point(58, 147);
			this.segmentWidthLabel.Name = "segmentWidthLabel";
			this.segmentWidthLabel.Size = new System.Drawing.Size(80, 13);
			this.segmentWidthLabel.TabIndex = 13;
			this.segmentWidthLabel.Text = "Segment Width";
			// 
			// segmentHeightLabel
			// 
			this.segmentHeightLabel.AutoSize = true;
			this.segmentHeightLabel.BackColor = System.Drawing.SystemColors.Control;
			this.segmentHeightLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.segmentHeightLabel.Location = new System.Drawing.Point(58, 173);
			this.segmentHeightLabel.Name = "segmentHeightLabel";
			this.segmentHeightLabel.Size = new System.Drawing.Size(83, 13);
			this.segmentHeightLabel.TabIndex = 14;
			this.segmentHeightLabel.Text = "Segment Height";
			// 
			// segmentSizeLabel
			// 
			this.segmentSizeLabel.AutoSize = true;
			this.segmentSizeLabel.BackColor = System.Drawing.SystemColors.Control;
			this.segmentSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.segmentSizeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.segmentSizeLabel.Location = new System.Drawing.Point(8, 124);
			this.segmentSizeLabel.Name = "segmentSizeLabel";
			this.segmentSizeLabel.Size = new System.Drawing.Size(112, 18);
			this.segmentSizeLabel.TabIndex = 15;
			this.segmentSizeLabel.Text = "Segment Size";
			// 
			// imageSizeReal
			// 
			this.imageSizeReal.BackColor = System.Drawing.Color.Transparent;
			this.imageSizeReal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.imageSizeReal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.imageSizeReal.Location = new System.Drawing.Point(0, 475);
			this.imageSizeReal.Margin = new System.Windows.Forms.Padding(20);
			this.imageSizeReal.Name = "imageSizeReal";
			this.imageSizeReal.Padding = new System.Windows.Forms.Padding(5);
			this.imageSizeReal.Size = new System.Drawing.Size(216, 30);
			this.imageSizeReal.TabIndex = 16;
			this.imageSizeReal.Text = "Real Image Size: ";
			this.imageSizeReal.Click += new System.EventHandler(this.imageSizeReal_Click);
			// 
			// imageSizeScaled
			// 
			this.imageSizeScaled.BackColor = System.Drawing.Color.Transparent;
			this.imageSizeScaled.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.imageSizeScaled.ForeColor = System.Drawing.SystemColors.ControlText;
			this.imageSizeScaled.Location = new System.Drawing.Point(0, 505);
			this.imageSizeScaled.Margin = new System.Windows.Forms.Padding(20);
			this.imageSizeScaled.Name = "imageSizeScaled";
			this.imageSizeScaled.Padding = new System.Windows.Forms.Padding(5);
			this.imageSizeScaled.Size = new System.Drawing.Size(216, 30);
			this.imageSizeScaled.TabIndex = 17;
			this.imageSizeScaled.Text = "Scaled Image Size:";
			this.imageSizeScaled.Click += new System.EventHandler(this.imageSizeScaled_Click);
			// 
			// autoSegment
			// 
			this.autoSegment.Location = new System.Drawing.Point(12, 102);
			this.autoSegment.Name = "autoSegment";
			this.autoSegment.Size = new System.Drawing.Size(127, 23);
			this.autoSegment.TabIndex = 18;
			this.autoSegment.Text = "Auto-Segment to Size";
			this.autoSegment.UseVisualStyleBackColor = true;
			this.autoSegment.Click += new System.EventHandler(this.autoSegment_Click);
			// 
			// autoSegmentSize
			// 
			this.autoSegmentSize.Location = new System.Drawing.Point(12, 198);
			this.autoSegmentSize.Name = "autoSegmentSize";
			this.autoSegmentSize.Size = new System.Drawing.Size(124, 23);
			this.autoSegmentSize.TabIndex = 19;
			this.autoSegmentSize.Text = "Auto-Size Segments";
			this.autoSegmentSize.UseVisualStyleBackColor = true;
			this.autoSegmentSize.Click += new System.EventHandler(this.autoSegmentSize_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.CausesValidation = false;
			this.panel1.Controls.Add(this.autoSegmentSize);
			this.panel1.Controls.Add(this.imageSizeReal);
			this.panel1.Controls.Add(this.segmentHeightLabel);
			this.panel1.Controls.Add(this.imageSizeScaled);
			this.panel1.Controls.Add(this.segmentWidthLabel);
			this.panel1.Controls.Add(this.segmentSizeLabel);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.segmentHeight);
			this.panel1.Controls.Add(this.segmentsVert);
			this.panel1.Controls.Add(this.segmentWidth);
			this.panel1.Controls.Add(this.segmentsHoriz);
			this.panel1.Controls.Add(this.segmentHoriz);
			this.panel1.Controls.Add(this.segmentVert);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(216, 535);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(216, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1065, 535);
			this.panel2.TabIndex = 19;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1281, 559);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.autoSegment);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.transparencyLabel);
			this.Controls.Add(this.transparencySlider);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentsVert)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentsHoriz)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.transparencySlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.segmentHeight)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.NumericUpDown segmentsVert;
		private System.Windows.Forms.NumericUpDown segmentsHoriz;
		private System.Windows.Forms.Label segmentHoriz;
		private System.Windows.Forms.Label segmentVert;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog exportImages;
		private System.Windows.Forms.NumericUpDown transparencySlider;
		private System.Windows.Forms.Label transparencyLabel;
		private System.Windows.Forms.NumericUpDown segmentWidth;
		private System.Windows.Forms.NumericUpDown segmentHeight;
		private System.Windows.Forms.Label segmentWidthLabel;
		private System.Windows.Forms.Label segmentHeightLabel;
		private System.Windows.Forms.Label segmentSizeLabel;
		private System.Windows.Forms.Label imageSizeReal;
		private System.Windows.Forms.Label imageSizeScaled;
		private System.Windows.Forms.Button autoSegment;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button autoSegmentSize;
	}

}

