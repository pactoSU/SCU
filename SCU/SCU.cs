using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCU
{
    public partial class SCU : Form
    {
        public SCU()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    selectFileDialog.Text = filePath;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void selectFileDialog_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void echo_Click(object sender, EventArgs e)
        {
            string echoExe = "echoscu.exe";
            string filePath = binariesPath.Text + "\\" +echoExe;
            string parameters = " ";
            if (verboseToggle.Checked){
                parameters += " -v ";
            }    
            parameters += hostName.Text + " " + portNumber.Text;

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void send_Click(object sender, EventArgs e)
        {
            string sendExe = "storescu.exe";
            string filePath = binariesPath.Text + "\\" +sendExe;
            string parameters = " ";
            if (verboseToggle.Checked){
                parameters += " -v ";
            }
            parameters += hostName.Text + " " + portNumber.Text + " " + selectFileDialog.Text;
            
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
            catch(Exception ex)
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
