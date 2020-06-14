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

        private void runcustomadbcmdbutton_Click(object sender, EventArgs e)
        {
            var command = textBox1.Text;
            if (command.StartsWith("adb "))
                command = command.Remove(0, 4);
            runAdbCommand(command);
        }

        public void runAdbCommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = Environment.CurrentDirectory + "\\adb\\adb.exe";
            cmd.StartInfo.Arguments = command;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\adb\\";
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();

            StreamWriter sw = File.AppendText("debugC.log");
            sw.Write("Action name = " + command + '\n');
            sw.Write(output);
            sw.Write("\n--------------------------------------------------------------------\n");
            sw.Flush();
            sw.Close();

            richTextBox1.Text = output;
        }

        private void customAdbCommandForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
