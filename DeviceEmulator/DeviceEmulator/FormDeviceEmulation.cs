using LoggertonHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceEmulator
{
    public partial class FormDeviceEmulation : Form
    {
        private CheckBox checkBox1;

        private DateTime TimeRequestFound { get; set; }

        public FormDeviceEmulation()
        {
            InitializeComponent();


        }

        private void FormEmulation_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true; // do this last

            buttonResponse.Enabled = false;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Every so often, look for a request file.
        /// We'll get some info about the entity, and place the key in the response text box,
        /// and await the user to push the button to send the response.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Look for request file
                string folderPath = EntityDataSingleton.Instance.FolderPath;

                if (!Directory.Exists(folderPath))
                    return;

                textTimeSinceRequest.Text = "N/A";
                if (TimeRequestFound != DateTime.MinValue)
                {
                    double deltaTime = DateTime.UtcNow.Subtract(TimeRequestFound).TotalSeconds;
                    textTimeSinceRequest.Text = deltaTime.ToString("0.0");
                }

                // If we are currently processing then return.
                if (buttonResponse.Enabled)
                    return;

                string[] files = Directory.GetFiles(folderPath, "request*.txt");
                if (files.Length == 0)
                {
                    textRequest.Text = "No files found";
                    buttonResponse.Enabled = false;
                    return;
                }

                // A file was found. Put the data on the screen and permit the user to send the response.
                string requestFile = files[0];
                string foundRequestFile = Path.GetFileNameWithoutExtension(requestFile);
                textRequest.Text = foundRequestFile; // Get the first one

                string key = GetKeyFromFilename(foundRequestFile);

                // Construct what the response file will be
                string responseFile =$"Response-{key}.txt";
                textResponse.Text = responseFile;

                buttonResponse.Enabled = true;
                TimeRequestFound = DateTime.UtcNow;

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Err={ex}");
            }

            // Update logs
            textLogs.Text = Loggerton.Instance.GetLogs(EnumLogFlags.All);
        }

        /// <summary>
        /// Filename of the form Request-{entityName}.text
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private string GetKeyFromFilename(string filename)
        {
            string[] tokens = Path.GetFileNameWithoutExtension(filename).Split('-');
            return tokens[1].ToLower();
        }

        

        /// <summary>
        /// Clear values when a response is sent.
        /// </summary>
        private void ClearAll()
        {
            buttonResponse.Enabled = false;
            textTimeSinceRequest.Text = "";
            textRequest.Text = "";
            textResponse.Text = "";

            TimeRequestFound = DateTime.MinValue;
        }

        /// <summary>
        /// Simulate the device responding.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResponse_Click(object sender, EventArgs e)
        {
            try
            {
                string responseFile = textResponse.Text;

                string key = GetKeyFromFilename(responseFile);


                DateTime justNow = DateTime.UtcNow;

                string folderPath = "";

                string requestFilePath = Path.Combine(folderPath, $"Request-{key}.txt");
                string responseFilePath = Path.Combine(folderPath, $"Response-{key}.txt");
                logit(EnumLogFlags.Information, $"Response file written to={responseFilePath}");

                // Put a request file, and then poll for the response.
                File.WriteAllText(responseFilePath, "(device response: info the device sends back)");

                File.Delete(requestFilePath);
                logit(EnumLogFlags.Information, $"Deleted Request file={requestFilePath}");

                ClearAll();

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Err={ex}");
            }
        }

        private void logit(EnumLogFlags flag, string message)
        {
            Loggerton.Instance.LogIt(flag, message);
        }


        private void textTimeSinceRequest_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormDeviceEmulation
            // 
            this.ClientSize = new System.Drawing.Size(498, 354);
            this.Name = "FormDeviceEmulation";
            this.ResumeLayout(false);

        }

        //private void InitializeComponent()
        //{
        //    this.checkBox1 = new System.Windows.Forms.CheckBox();
        //    this.SuspendLayout();
        //    // 
        //    // checkBox1
        //    // 
        //    this.checkBox1.AutoSize = true;
        //    this.checkBox1.Location = new System.Drawing.Point(200, 130);
        //    this.checkBox1.Name = "checkBox1";
        //    this.checkBox1.Size = new System.Drawing.Size(98, 21);
        //    this.checkBox1.TabIndex = 0;
        //    this.checkBox1.Text = "checkBox1";
        //    this.checkBox1.UseVisualStyleBackColor = true;
        //    // 
        //    // FormDeviceEmulation
        //    // 
        //    this.ClientSize = new System.Drawing.Size(835, 506);
        //    this.Controls.Add(this.checkBox1);
        //    this.Name = "FormDeviceEmulation";
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
    }
}
