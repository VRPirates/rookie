using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows;
using System.Net.Http;
using System.Reflection;

namespace AndroidSideloader
{
    public partial class customAdbCommandForm : Form
    {
        public customAdbCommandForm()
        {
            InitializeComponent();
        }

        string output;

        public void runAdbCommand(string command)
        {
            Thread t1 = new Thread(() =>
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\adb\\";
                cmd.Start();
                cmd.StandardInput.WriteLine(command);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                output = cmd.StandardOutput.ReadToEnd();
                StreamWriter sw = File.AppendText("debugC.log");
                sw.Write(output);
                sw.Write("\n--------------------------------------------------------------------\n");
                sw.Flush();
                sw.Close();
            });
            t1.IsBackground = true;
            t1.Start();

            t1.Join();

            richTextBox1.Text = output;
        }

        private void runcustomadbcmdbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Split(' ').Length>1)
                runAdbCommand(textBox1.Text);
            else
                MessageBox.Show("You must enter at least 1 argument");
        }
    }
}
