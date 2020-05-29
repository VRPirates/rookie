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

    public partial class Form1 : Form
    {
        #if DEBUG
            bool debugMode = true;
        #else
            bool debugMode = false;
        #endif
        string path;
        string obbPath = "";
        string obbFile;
        string allText;
      
        bool exit = false;
        string debugPath = "debug.log";
        public string adbPath = Environment.CurrentDirectory + "\\adb\\";
        string[] line;
        public Form1()
        {
            InitializeComponent();
        }

        public void runAdbCommand(string command)
        {
            progressBar1.Value = 0;
            exit = false;
            MessageBox.Show("Action Started, may take some time...");
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.WorkingDirectory = adbPath;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            allText = cmd.StandardOutput.ReadToEnd();
            StreamWriter sw = File.AppendText(debugPath);
            sw.Write(allText);
            sw.Write("\n--------------------------------------------------------------------\n");
            sw.Flush();
            sw.Close();
            line = allText.Split('\n');
            exit = true;
        }


        void runLoadingBar(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            //fi.Length file size in bytes
            PerformanceCounter disk = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_total");
    
            var bytes = 0f;
            progressBar1.Maximum = (int)(fi.Length/128);
                while (exit==false)
                {
                    bytes += disk.NextValue();
                    try { progressBar1.Value = (int)(bytes); } catch { progressBar1.Maximum *= 2; }
                    Thread.Sleep(1000);
                }
            progressBar1.Value = progressBar1.Maximum;
        }

        private void startsideloadbutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Android apps (*.apk)|*.apk";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    path = openFileDialog.FileName;
                else
                    return;
            }

            if (path=="" || path.EndsWith(".apk")==false)
                MessageBox.Show("You must select an apk");
            else
            {

                Thread t1 = new Thread(() =>
                {
                    runAdbCommand("adb.exe install -r " + '"' + path + '"');
                });
                t1.IsBackground = true;
                t1.Start();

                runLoadingBar(path);

                if (line[line.Length - 3].Contains("Success")==false)
                {
                    MessageBox.Show("An error has occured, send the debug.log to rookie.lol");
                }
                else
                    MessageBox.Show(line[line.Length - 3]);
            }

        }

        private void devicesbutton_Click(object sender, EventArgs e)
        {
            runAdbCommand("adb.exe devices");
            if (line[line.Length - 4].Contains("List of devices attached") == false)
                MessageBox.Show(line[line.Length - 4]);
            else
                MessageBox.Show("No android device attached");
        }

        private void instructionsbutton_Click(object sender, EventArgs e)
        {
            string instructions = @"1. Plug in your Oculus Quest
2. Press adb devices and allow adb to connect from quest headset (one time only)
3. Press adb devices again and you should see a code and then 'device' (optional)
4. Select your apk with select apk button.
5. Press Sideload and wait...
6. If the game has an obb folder, select it by using select obb then press copy obb";
            MessageBox.Show(instructions);
        }

        private void obbcopybutton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    obbFile = files[0];
                    obbPath = fbd.SelectedPath;

                }
                else return;
            }

            if (obbPath.Length>0)
            {

                Thread t1 = new Thread(() =>
                {
                    runAdbCommand("adb push " + '"' + obbPath + '"' + " /sdcard/Android/obb");
                });
                t1.IsBackground = true;
                t1.Start();

                runLoadingBar(obbFile);

                MessageBox.Show(line[line.Length - 3]);
            }
            else
            {
                MessageBox.Show("You forgot to select the obb folder");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (debugMode == false)
                debugbutton.Visible = false;
            if (Directory.Exists(adbPath)==false)
            {
                MessageBox.Show("You need to have the adb folder in the same folder as this software");
                Environment.Exit(600);
            }
            if (debugMode==false)
                checkForUpdate();
            intToolTips();
        }
        void intToolTips()
        {
            ToolTip FlashFirmwareToolTip = new ToolTip();
            FlashFirmwareToolTip.SetToolTip(this.flashfirmwarebutton, "Make sure to put the firmware with the name UPDATE.zip in the software directory");
        }
        void checkForUpdate()
        {
            try
            {
                string localVersion = "0.2";
                HttpClient client = new HttpClient();
                string currentVersion = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
                currentVersion = currentVersion.Remove(currentVersion.Length - 1);
                if (localVersion != currentVersion)
                    MessageBox.Show("Your version is outdated, the latest version is " + currentVersion + " you can download it from https://github.com/nerdunit/", "OUTDATED");
            }
            catch
            {
            //No need for messages, the user has no internet
            }
        }

        private void flashfirmwarebutton_Click(object sender, EventArgs e)
        {
            const string message =
    "This is a dangerous action, be sure you know what you are doing! This feature is not tested and the loading bar may bug out Do NOT disconnect the quest, wait for the messagebox to show up first Press yes to continue";
            const string caption = "WARNING";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Android Firmware (*.zip)|*.zip";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    path = openFileDialog.FileName;
                else
                    return;
            }

            File.Copy(path, Environment.CurrentDirectory + "\\UPDATE.zip");


            Thread t1 = new Thread(() =>
            {
                runAdbCommand("adb reboot bootloader");
                Thread.Sleep(1000 * 15);
                runAdbCommand("fastboot oem reboot-sideload");
                Thread.Sleep(1000 * 15);
                runAdbCommand("adb sideload UPDATE.zip");
            });
            t1.IsBackground = true;
            t1.Start();

            Thread.Sleep(1000 * 30);
            runLoadingBar(path);

            MessageBox.Show("Let the Quest sit for a bit, it will fully reboot back into Quest Home, then put it on and reboot, (hold power button a bit and select reboot)");
            MessageBox.Show(allText);
        }

        private void backupbutton_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("adb pull " + '"' + "/sdcard/Android/data" + '"');
            });
            t1.IsBackground = true;
            t1.Start();

            while (exit == false)
                Thread.Sleep(1000);

            Directory.Move(adbPath + "data", Environment.CurrentDirectory + "\\data");

            MessageBox.Show(line[line.Length - 3]);
        }

        private void debugbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void restorebutton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    obbPath = fbd.SelectedPath;
                }
                else return;
            }

                Thread t1 = new Thread(() =>
                {
                    runAdbCommand("adb push " + '"' + obbPath + '"' + " /sdcard/Android/");
                });
                t1.IsBackground = true;
                t1.Start();

                while (exit == false)
                    Thread.Sleep(1000);

                MessageBox.Show(line[line.Length - 3]);
        }

        private void customadbcmdbutton_Click(object sender, EventArgs e)
        {
            customAdbCommandForm adbCommandForm = new customAdbCommandForm();
            adbCommandForm.Show();
        }
    }
}
