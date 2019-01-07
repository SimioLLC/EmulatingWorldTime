namespace EmulatingWorldTime
{
    partial class FormEmulator
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmulator = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.updnClockSpeed = new System.Windows.Forms.NumericUpDown();
            this.rbFaster = new System.Windows.Forms.RadioButton();
            this.rbSlower = new System.Windows.Forms.RadioButton();
            this.timerLogs = new System.Windows.Forms.Timer(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEmulator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnClockSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(18, 20);
            this.labelStatus.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmulator);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 397);
            this.tabControl1.TabIndex = 2;
            // 
            // tabEmulator
            // 
            this.tabEmulator.Controls.Add(this.groupBox1);
            this.tabEmulator.Location = new System.Drawing.Point(4, 25);
            this.tabEmulator.Name = "tabEmulator";
            this.tabEmulator.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmulator.Size = new System.Drawing.Size(792, 368);
            this.tabEmulator.TabIndex = 0;
            this.tabEmulator.Text = "Emulator";
            this.tabEmulator.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSpeed);
            this.groupBox1.Controls.Add(this.updnClockSpeed);
            this.groupBox1.Controls.Add(this.rbFaster);
            this.groupBox1.Controls.Add(this.rbSlower);
            this.groupBox1.Location = new System.Drawing.Point(8, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emulation Speed";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(6, 100);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(49, 17);
            this.labelSpeed.TabIndex = 3;
            this.labelSpeed.Text = "Speed";
            // 
            // updnClockSpeed
            // 
            this.updnClockSpeed.DecimalPlaces = 2;
            this.updnClockSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updnClockSpeed.Location = new System.Drawing.Point(286, 98);
            this.updnClockSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.updnClockSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.updnClockSpeed.Name = "updnClockSpeed";
            this.updnClockSpeed.Size = new System.Drawing.Size(75, 22);
            this.updnClockSpeed.TabIndex = 2;
            this.updnClockSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updnClockSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // rbFaster
            // 
            this.rbFaster.AutoSize = true;
            this.rbFaster.Location = new System.Drawing.Point(6, 60);
            this.rbFaster.Name = "rbFaster";
            this.rbFaster.Size = new System.Drawing.Size(174, 21);
            this.rbFaster.TabIndex = 1;
            this.rbFaster.TabStop = true;
            this.rbFaster.Text = "Faster than Clock Time";
            this.rbFaster.UseVisualStyleBackColor = true;
            this.rbFaster.CheckedChanged += new System.EventHandler(this.rbFaster_CheckedChanged);
            // 
            // rbSlower
            // 
            this.rbSlower.AutoSize = true;
            this.rbSlower.Location = new System.Drawing.Point(6, 33);
            this.rbSlower.Name = "rbSlower";
            this.rbSlower.Size = new System.Drawing.Size(176, 21);
            this.rbSlower.TabIndex = 0;
            this.rbSlower.TabStop = true;
            this.rbSlower.Text = "Slower than Clock Time";
            this.rbSlower.UseVisualStyleBackColor = true;
            this.rbSlower.CheckedChanged += new System.EventHandler(this.rbSlower_CheckedChanged);
            // 
            // timerLogs
            // 
            this.timerLogs.Interval = 1000;
            this.timerLogs.Tick += new System.EventHandler(this.timerLogs_Tick);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.logsToolStripMenuItem.Text = "&Logs...";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // FormEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmulator";
            this.Text = "Emulator Controller";
            this.Load += new System.EventHandler(this.FormEmulator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabEmulator.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnClockSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmulator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown updnClockSpeed;
        private System.Windows.Forms.RadioButton rbFaster;
        private System.Windows.Forms.RadioButton rbSlower;
        private System.Windows.Forms.Timer timerLogs;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
    }
}