using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace AndroidSideloader
{
    public partial class usernameForm : Form
    {
        public usernameForm()
        {
            InitializeComponent();
        }

        string defaultText;

        private void usernameForm_Load(object sender, EventArgs e)
        {
            defaultText = textBox1.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == defaultText || textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter your username first");
                return;
            }

            File.WriteAllText("user.json", "{\"username\":\"" + textBox1.Text + "\"}");

            runAdbCommand("push \"" + Environment.CurrentDirectory + "\\user.json\" " + " /sdcard/");

            File.Delete("user.json");

            File.WriteAllText("vrmoo.cn.json", "{\"username\":\"" + textBox1.Text + "\"}");

            runAdbCommand("push \"" + Environment.CurrentDirectory + "\\vrmoo.cn.json\" " + " /sdcard/");

            File.Delete("vrmoo.cn.json");


            File.WriteAllText("qq1091481055.json", "{\n	\"username\":\"" + textBox1.Text + "\"\n	}");

            runAdbCommand("push \"" + Environment.CurrentDirectory + "\\qq1091481055.json\" " + " /sdcard/");

            File.Delete("qq1091481055.json");

            Form1.notify("Done");

        }

        private void runAdbCommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = Environment.CurrentDirectory + "\\adb\\adb.exe";
            cmd.StartInfo.Arguments = command;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.WorkingDirectory = Form1.adbPath;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            string allText = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();


            StreamWriter sw = File.AppendText(Form1.debugPath);
            sw.Write("Action name = " + command + '\n');
            sw.Write(allText);
            sw.Write("\n--------------------------------------------------------------------\n");
            sw.Flush();
            sw.Close();
        }
    }
}
