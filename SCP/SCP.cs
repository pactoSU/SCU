using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCP
{
    public partial class SCP : Form
    {
        public SCP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void storeSCP_Click(object sender, EventArgs e)
        {
            string echoExe = "storescp.exe";
            string filePath = binariesPath.Text + "\\" + echoExe;
            string parameters = portNumber.Text;

            MessageBox.Show(filePath + parameters);
            var echoProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    Arguments = parameters,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            try
            {
                echoProcess.Start();
                while (!echoProcess.StandardOutput.EndOfStream)
                {
                    string line = echoProcess.StandardOutput.ReadLine();
                    outputWindow.Text += line + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void binariesPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderName = folderBrowser.SelectedPath;
                binariesPath.Text = folderName;

            }
        }
    }
}
