using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace AndroidSideloader
{
    public partial class UsernameForm : Form
    {
        public UsernameForm()
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

            createUserJson(textBox1.Text);

            pushUserJson();

            deleteUserJson();

            Form1.notify("Done");

        }

        public static void pushUserJson()
        {
            runAdbCommand("push \"" + Environment.CurrentDirectory + "\\user.json\" " + " /sdcard/");
            runAdbCommand("push \"" + Environment.CurrentDirectory + "\\vrmoo.cn.json\" " + " /sdcard/");
            runAdbCommand("push \"" + Environment.CurrentDirectory + "\\qq1091481055.json\" " + " /sdcard/");
            runAdbCommand("push \"" + Environment.CurrentDirectory + "\\dollarvr.com.json\" " + " /sdcard/");
        }

        public static void deleteUserJson()
        {
            File.Delete("user.json");
            File.Delete("vrmoo.cn.json");
            File.Delete("qq1091481055.json");
            File.Delete("dollarvr.com.json");
        }
        public static void createUserJson(string username)
        {
            File.WriteAllText("user.json", "{\"username\":\"" + username + "\"}");
            File.WriteAllText("vrmoo.cn.json", "{\"username\":\"" + username + "\"}");
            File.WriteAllText("qq1091481055.json", "{\n	\"username\":\"" + username + "\"\n	}");
            File.WriteAllText("dollarvr.com.json", "{\n	\"username\":\"" + username +  "\"\n	}");
        }
        
        public static void runAdbCommand(string command)
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
