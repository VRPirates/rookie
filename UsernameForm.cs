using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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


        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == defaultText || textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter your username first");
                return;
            }

            //Make and push user json in a new thread to not block the ui
            Thread t1 = new Thread(() => { createUserJson(textBox1.Text); });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

            MainForm.notify("Done");

        }

        public static List<string> userJsons = new List<string>(new string[] { "user.json", "vrmoo.cn.json", "qq1091481055.json", "dollarvr.com.json" });

        public static void createUserJson(string username)
        {
            ADB.RunAdbCommandToString($"shell settings put global username {username}");
            foreach (var jsonFileName in userJsons)
            {
                createUserJsonByName(username, jsonFileName);
                ADB.RunAdbCommandToString("push \"" + Environment.CurrentDirectory + $"\\{jsonFileName}\" " + " /sdcard/");
                File.Delete(jsonFileName);
            }

        }
        public static void createUserJsonByName(string username, string jsonName)
        {
            //Should make a new object or dictionary if there will be more user.json files
            switch (jsonName)
            {
                case "user.json":
                    File.WriteAllText("user.json", "{\"username\":\"" + username + "\"}");
                    break;
                case "vrmoo.cn.json":
                    File.WriteAllText("vrmoo.cn.json", "{\"username\":\"" + username + "\"}");
                    break;
                case "qq1091481055.json":
                    File.WriteAllText("qq1091481055.json", "{\n	\"username\":\"" + username + "\"\n	}");
                    break;
                case "dollarvr.com.json":
                    File.WriteAllText("dollarvr.com.json", "{\n	\"username\":\"" + username + "\"\n	}");
                    break;
            }


        }
       
    }
}
