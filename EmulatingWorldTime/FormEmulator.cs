using LoggertonHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmulatingWorldTime
{
    public partial class FormEmulator : Form
    {

        public Double ClockSpeed { get
            {
                double clockFactor = Convert.ToDouble(updnClockSpeed.Value);

                if (isFaster)
                    return 1F / clockFactor;
                else
                    return clockFactor;
            } }

        private bool isFaster;

        public FormEmulator()
        {
            InitializeComponent();
        }

        private void rbSlower_CheckedChanged(object sender, EventArgs e)
        {
            updnClockSpeed.Minimum = 1.0M;
            updnClockSpeed.Maximum = 20.0M;
            updnClockSpeed.Increment = 0.5M;
            updnClockSpeed.Value = 1.0M;

            labelSpeed.Text = "How many times slower?";
            isFaster = false;
        }

        private void rbFaster_CheckedChanged(object sender, EventArgs e)
        {
            updnClockSpeed.Minimum = 1.0M;
            updnClockSpeed.Maximum = 20.0M;
            updnClockSpeed.Increment = 0.5M;
            updnClockSpeed.Value = 1.0M;

            labelSpeed.Text = "How many times faster?";
            isFaster = true;
        }

        public void SetSlower()
        {
            this.rbSlower.Checked = true;
        }
        public void SetFaster()
        {
            this.rbFaster.Checked = true;
        }

        public void DoEvents()
        {
            Application.DoEvents();
        }

        private void FormEmulator_Load(object sender, EventArgs e)
        {

        }

        private void timerLogs_Tick(object sender, EventArgs e)
        {
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoggerton form = new FormLoggerton();
            form.ShowDialog();

        }
    }
}
