namespace Source
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.student1 = new Source.Student();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(69, 45);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(100, 25);
            this.lbl_timer.TabIndex = 0;
            this.lbl_timer.Text = "Timer Tick";
            this.toolTip1.SetToolTip(this.lbl_timer, "DateTime Now");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(278, 45);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(221, 32);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.UseWaitCursor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 76);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Source.Properties.Resources.icons8_love_arrow_64;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Checked = true;
            this.newToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.folderToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 848);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1395, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeftAutoMirrorImage = true;
            this.statusLabel.Size = new System.Drawing.Size(118, 17);
            this.statusLabel.Text = "toolStripStatusLabel1";
            this.statusLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(622, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 33);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(635, 199);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 399);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(144, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 315);
            this.panel1.TabIndex = 5;
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(635, 171);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(23, 25);
            this.lbl_red.TabIndex = 6;
            this.lbl_red.Text = "0";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Location = new System.Drawing.Point(726, 171);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(23, 25);
            this.lbl_green.TabIndex = 8;
            this.lbl_green.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(726, 199);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 399);
            this.trackBar2.SmallChange = 5;
            this.trackBar2.TabIndex = 7;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Location = new System.Drawing.Point(814, 171);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(23, 25);
            this.lbl_blue.TabIndex = 10;
            this.lbl_blue.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(814, 199);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 399);
            this.trackBar3.SmallChange = 5;
            this.trackBar3.TabIndex = 9;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(757, 671);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(477, 17);
            this.hScrollBar1.TabIndex = 11;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1205, 145);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 435);
            this.vScrollBar1.TabIndex = 12;
            // 
            // student1
            // 
            this.student1.Location = new System.Drawing.Point(46, 145);
            this.student1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.student1.Name = "student1";
            this.student1.Size = new System.Drawing.Size(612, 64);
            this.student1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1395, 870);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.student1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_timer);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lbl_timer;
        private ProgressBar progressBar1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator saveToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private NumericUpDown numericUpDown1;
        private TrackBar trackBar1;
        private Panel panel1;
        private Label lbl_red;
        private Label lbl_green;
        private TrackBar trackBar2;
        private Label lbl_blue;
        private TrackBar trackBar3;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private Student student1;
    }
}