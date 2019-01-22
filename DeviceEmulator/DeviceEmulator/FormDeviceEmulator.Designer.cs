namespace DeviceEmulator
{
    partial class FormDeviceEmulator
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

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormDeviceEmulator
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(1106, 654);
        //    this.Name = "FormDeviceEmulator";
        //    this.Text = "Device Emulator";
        //    this.ResumeLayout(false);

        //}

        #endregion


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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textFileLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonResponse = new System.Windows.Forms.Button();
            this.textTimeSinceRequest = new System.Windows.Forms.TextBox();
            this.textRequest = new System.Windows.Forms.TextBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDeviceEmulation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 741);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 24, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1666, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 37);
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 37);
            this.labelStatus.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1666, 49);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 41);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 42);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDeviceEmulation);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1666, 692);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDeviceEmulation
            // 
            this.tabDeviceEmulation.Controls.Add(this.panel1);
            this.tabDeviceEmulation.Location = new System.Drawing.Point(10, 47);
            this.tabDeviceEmulation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabDeviceEmulation.Name = "tabDeviceEmulation";
            this.tabDeviceEmulation.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabDeviceEmulation.Size = new System.Drawing.Size(1646, 635);
            this.tabDeviceEmulation.TabIndex = 1;
            this.tabDeviceEmulation.Text = "Device Emulation";
            this.tabDeviceEmulation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textFileLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonResponse);
            this.panel1.Controls.Add(this.textTimeSinceRequest);
            this.panel1.Controls.Add(this.textRequest);
            this.panel1.Controls.Add(this.textResponse);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1636, 625);
            this.panel1.TabIndex = 7;
            // 
            // textFileLocation
            // 
            this.textFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileLocation.Location = new System.Drawing.Point(359, 20);
            this.textFileLocation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textFileLocation.Name = "textFileLocation";
            this.textFileLocation.Size = new System.Drawing.Size(1256, 35);
            this.textFileLocation.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "File Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Since Request";
            // 
            // buttonResponse
            // 
            this.buttonResponse.Location = new System.Drawing.Point(359, 324);
            this.buttonResponse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonResponse.Name = "buttonResponse";
            this.buttonResponse.Size = new System.Drawing.Size(276, 78);
            this.buttonResponse.TabIndex = 0;
            this.buttonResponse.Text = "Respond";
            this.toolTip1.SetToolTip(this.buttonResponse, "Push this when you wish to respond");
            this.buttonResponse.UseVisualStyleBackColor = true;
            this.buttonResponse.Click += new System.EventHandler(this.buttonResponse_Click);
            // 
            // textTimeSinceRequest
            // 
            this.textTimeSinceRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTimeSinceRequest.Location = new System.Drawing.Point(359, 198);
            this.textTimeSinceRequest.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textTimeSinceRequest.Name = "textTimeSinceRequest";
            this.textTimeSinceRequest.Size = new System.Drawing.Size(666, 35);
            this.textTimeSinceRequest.TabIndex = 5;
            // 
            // textRequest
            // 
            this.textRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRequest.Location = new System.Drawing.Point(359, 89);
            this.textRequest.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textRequest.Name = "textRequest";
            this.textRequest.Size = new System.Drawing.Size(1256, 35);
            this.textRequest.TabIndex = 2;
            // 
            // textResponse
            // 
            this.textResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResponse.Location = new System.Drawing.Point(359, 143);
            this.textResponse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(1256, 35);
            this.textResponse.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Response";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.propertyGrid1);
            this.tabSettings.Location = new System.Drawing.Point(10, 47);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1646, 635);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(1646, 635);
            this.propertyGrid1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 333;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDeviceEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 783);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormDeviceEmulator";
            this.Text = "Emulation Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeviceEmulator_FormClosing);
            this.Load += new System.EventHandler(this.FormEmulation_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDeviceEmulation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTimeSinceRequest;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textFileLocation;
        private System.Windows.Forms.Label label4;
    }

}