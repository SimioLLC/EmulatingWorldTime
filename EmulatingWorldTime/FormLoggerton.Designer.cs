namespace LoggertonHelpers
{
    partial class FormLoggerton
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
            this.textLogs = new System.Windows.Forms.TextBox();
            this.timerLogs = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApplyExcludes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWarning = new System.Windows.Forms.CheckBox();
            this.cbInformation = new System.Windows.Forms.CheckBox();
            this.cbEvent = new System.Windows.Forms.CheckBox();
            this.cbError = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textExcludes = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLogs
            // 
            this.textLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLogs.Location = new System.Drawing.Point(0, 84);
            this.textLogs.Multiline = true;
            this.textLogs.Name = "textLogs";
            this.textLogs.ReadOnly = true;
            this.textLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLogs.Size = new System.Drawing.Size(1099, 614);
            this.textLogs.TabIndex = 0;
            this.textLogs.TextChanged += new System.EventHandler(this.textLogs_TextChanged);
            this.textLogs.DoubleClick += new System.EventHandler(this.textLogs_DoubleClick);
            // 
            // timerLogs
            // 
            this.timerLogs.Interval = 1000;
            this.timerLogs.Tick += new System.EventHandler(this.timerLogs_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonApplyExcludes);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textExcludes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 84);
            this.panel1.TabIndex = 1;
            // 
            // buttonApplyExcludes
            // 
            this.buttonApplyExcludes.Location = new System.Drawing.Point(566, 45);
            this.buttonApplyExcludes.Name = "buttonApplyExcludes";
            this.buttonApplyExcludes.Size = new System.Drawing.Size(87, 32);
            this.buttonApplyExcludes.TabIndex = 7;
            this.buttonApplyExcludes.Text = "Apply";
            this.buttonApplyExcludes.UseVisualStyleBackColor = true;
            this.buttonApplyExcludes.Click += new System.EventHandler(this.buttonApplyExcludes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbWarning);
            this.groupBox1.Controls.Add(this.cbInformation);
            this.groupBox1.Controls.Add(this.cbEvent);
            this.groupBox1.Controls.Add(this.cbError);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Types to Include";
            // 
            // cbWarning
            // 
            this.cbWarning.AutoSize = true;
            this.cbWarning.Location = new System.Drawing.Point(256, 25);
            this.cbWarning.Name = "cbWarning";
            this.cbWarning.Size = new System.Drawing.Size(83, 21);
            this.cbWarning.TabIndex = 2;
            this.cbWarning.Text = "Warning";
            this.cbWarning.UseVisualStyleBackColor = true;
            this.cbWarning.CheckedChanged += new System.EventHandler(this.cbLogFlags_CheckedChanged);
            // 
            // cbInformation
            // 
            this.cbInformation.AutoSize = true;
            this.cbInformation.Location = new System.Drawing.Point(17, 25);
            this.cbInformation.Name = "cbInformation";
            this.cbInformation.Size = new System.Drawing.Size(100, 21);
            this.cbInformation.TabIndex = 0;
            this.cbInformation.Text = "Information";
            this.cbInformation.UseVisualStyleBackColor = true;
            this.cbInformation.CheckedChanged += new System.EventHandler(this.cbLogFlags_CheckedChanged);
            // 
            // cbEvent
            // 
            this.cbEvent.AutoSize = true;
            this.cbEvent.Location = new System.Drawing.Point(163, 25);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(66, 21);
            this.cbEvent.TabIndex = 1;
            this.cbEvent.Text = "Event";
            this.cbEvent.UseVisualStyleBackColor = true;
            this.cbEvent.CheckedChanged += new System.EventHandler(this.cbLogFlags_CheckedChanged);
            // 
            // cbError
            // 
            this.cbError.AutoSize = true;
            this.cbError.Location = new System.Drawing.Point(369, 25);
            this.cbError.Name = "cbError";
            this.cbError.Size = new System.Drawing.Size(62, 21);
            this.cbError.TabIndex = 3;
            this.cbError.Text = "Error";
            this.cbError.UseVisualStyleBackColor = true;
            this.cbError.CheckedChanged += new System.EventHandler(this.cbLogFlags_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Excludes";
            // 
            // textExcludes
            // 
            this.textExcludes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textExcludes.Location = new System.Drawing.Point(566, 17);
            this.textExcludes.Name = "textExcludes";
            this.textExcludes.Size = new System.Drawing.Size(521, 22);
            this.textExcludes.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textExcludes, "Comma list of regex exclude patterns");
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1000, 46);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(87, 32);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormLoggerton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 698);
            this.Controls.Add(this.textLogs);
            this.Controls.Add(this.panel1);
            this.Name = "FormLoggerton";
            this.Text = "FormLoggerton";
            this.Load += new System.EventHandler(this.FormLoggerton_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLogs;
        private System.Windows.Forms.Timer timerLogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbError;
        private System.Windows.Forms.CheckBox cbWarning;
        private System.Windows.Forms.CheckBox cbEvent;
        private System.Windows.Forms.CheckBox cbInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textExcludes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonApplyExcludes;
        private System.Windows.Forms.Button buttonClose;
    }
}