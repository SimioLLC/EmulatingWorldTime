using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggertonHelpers
{
    public partial class FormLoggerton : Form
    {
        public FormLoggerton()
        {
            InitializeComponent();
        }

        private void textLogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLogs_DoubleClick(object sender, EventArgs e)
        {
            Loggerton.Instance.ClearLogs();
        }

        private void FormLoggerton_Load(object sender, EventArgs e)
        {
            timerLogs.Enabled = true;
            this.Visible = false;
        }

        private void timerLogs_Tick(object sender, EventArgs e)
        {
            if (Loggerton.Instance == null)
                return;

            EnumLogFlags flags = BuildFlags();
            string excludes = textExcludes.Text;

            textLogs.Text = Loggerton.Instance.GetLogs(flags);
        }

        private void cbLogFlags_CheckedChanged(object sender, EventArgs e)
        {
            EnumLogFlags flags = BuildFlags();
            string excludes = textExcludes.Text;
            textLogs.Text = Loggerton.Instance.GetLogs(flags);
            
        }

        private EnumLogFlags BuildFlags()
        {
            EnumLogFlags flags = EnumLogFlags.None;

            if (cbInformation.Checked)
                flags |= EnumLogFlags.Information;
            if (cbEvent.Checked)
                flags |= EnumLogFlags.Event;
            if (cbWarning.Checked)
                flags |= EnumLogFlags.Warning;
            if (cbError.Checked)
                flags |= EnumLogFlags.Error;

            return flags;
        }

        private void buttonApplyExcludes_Click(object sender, EventArgs e)
        {
            Loggerton.Instance.SetExcludes(textExcludes.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormLoggerton
        //    // 
        //    this.ClientSize = new System.Drawing.Size(426, 319);
        //    this.Name = "FormLoggerton";
        //    this.ResumeLayout(false);

        //}
    }
}
