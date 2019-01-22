namespace DeviceEmulator
{
    partial class FormDeviceEmulation
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDeviceEmulation = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textTimeSinceRequest = new System.Windows.Forms.TextBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResponse = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.textLogs = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDeviceEmulation.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(18, 20);
            this.labelStatus.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDeviceEmulation);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 379);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDeviceEmulation
            // 
            this.tabDeviceEmulation.Controls.Add(this.label3);
            this.tabDeviceEmulation.Controls.Add(this.textTimeSinceRequest);
            this.tabDeviceEmulation.Controls.Add(this.textResponse);
            this.tabDeviceEmulation.Controls.Add(this.label2);
            this.tabDeviceEmulation.Controls.Add(this.textRequest);
            this.tabDeviceEmulation.Controls.Add(this.label1);
            this.tabDeviceEmulation.Controls.Add(this.buttonResponse);
            this.tabDeviceEmulation.Location = new System.Drawing.Point(4, 25);
            this.tabDeviceEmulation.Name = "tabDeviceEmulation";
            this.tabDeviceEmulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceEmulation.Size = new System.Drawing.Size(944, 350);
            this.tabDeviceEmulation.TabIndex = 1;
            this.tabDeviceEmulation.Text = "Device Emulation";
            this.tabDeviceEmulation.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Since Request";
            // 
            // textTimeSinceRequest
            // 
            this.textTimeSinceRequest.Location = new System.Drawing.Point(250, 90);
            this.textTimeSinceRequest.Name = "textTimeSinceRequest";
            this.textTimeSinceRequest.Size = new System.Drawing.Size(349, 22);
            this.textTimeSinceRequest.TabIndex = 5;
            this.textTimeSinceRequest.TextChanged += new System.EventHandler(this.textTimeSinceRequest_TextChanged);
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(250, 60);
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(718, 22);
            this.textResponse.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Response";
            // 
            // textRequest
            // 
            this.textRequest.Location = new System.Drawing.Point(250, 30);
            this.textRequest.Name = "textRequest";
            this.textRequest.Size = new System.Drawing.Size(718, 22);
            this.textRequest.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request";
            // 
            // buttonResponse
            // 
            this.buttonResponse.Location = new System.Drawing.Point(250, 160);
            this.buttonResponse.Name = "buttonResponse";
            this.buttonResponse.Size = new System.Drawing.Size(158, 43);
            this.buttonResponse.TabIndex = 0;
            this.buttonResponse.Text = "Respond";
            this.toolTip1.SetToolTip(this.buttonResponse, "Push this when you wish to respond");
            this.buttonResponse.UseVisualStyleBackColor = true;
            this.buttonResponse.Click += new System.EventHandler(this.buttonResponse_Click);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.textLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 25);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(944, 350);
            this.tabLogs.TabIndex = 0;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // textLogs
            // 
            this.textLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLogs.Location = new System.Drawing.Point(3, 3);
            this.textLogs.Multiline = true;
            this.textLogs.Name = "textLogs";
            this.textLogs.ReadOnly = true;
            this.textLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLogs.Size = new System.Drawing.Size(938, 344);
            this.textLogs.TabIndex = 0;
            this.textLogs.Text = "(No logs yet...)";
            // 
            // timer1
            // 
            this.timer1.Interval = 333;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormEmulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmulation";
            this.Text = "Emulation Information";
            this.Load += new System.EventHandler(this.FormEmulation_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDeviceEmulation.ResumeLayout(false);
            this.tabDeviceEmulation.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDeviceEmulation;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResponse;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.TextBox textLogs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTimeSinceRequest;
    }
}