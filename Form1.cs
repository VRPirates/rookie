using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows;
using System.Net.Http;
using System.Reflection;
using System.Net;



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

            Process cmd = new Process();
            cmd.StartInfo.FileName = Environment.CurrentDirectory + "\\adb\\adb.exe";
            cmd.StartInfo.Arguments = command;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.WorkingDirectory = adbPath;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            allText = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            
            StreamWriter sw = File.AppendText(debugPath);
            sw.Write("Action name = " + command + '\n');
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
            progressBar1.Maximum = (int)(fi.Length / 128);
            while (exit == false)
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

            if (path == "" || path.EndsWith(".apk") == false)
                MessageBox.Show("You must select an apk");
            else
            {
                MessageBox.Show("Action Started, may take some time...");
                Thread t1 = new Thread(() =>
                {
                    runAdbCommand("install -r " + '"' + path + '"');
                });
                t1.IsBackground = true;
                t1.Start();

                runLoadingBar(path);

                MessageBox.Show(allText);
            }

        }

        private void devicesbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Action Started, may take some time...");
            runAdbCommand("devices");
            MessageBox.Show(allText);
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

        public void ExtractFile(string sourceArchive, string destination)
        {
            string zPath = "7z.exe"; //add to proj and set CopyToOuputDir
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = zPath;
                pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination);
                Process x = Process.Start(pro);
                x.WaitForExit();
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
                MessageBox.Show("Action Started, may take some time...");
                Thread t1 = new Thread(() =>
                {
                    runAdbCommand("push " + '"' + obbPath + '"' + " /sdcard/Android/obb");
                });
                t1.IsBackground = true;
                t1.Start();

                runLoadingBar(obbFile);

                MessageBox.Show(allText);
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
                MessageBox.Show("Please wait for the software to download and install the adb");
                try
                {
                    using (var client = new WebClient())
                    {
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.exe", "7z.exe");
                        client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.dll", "7z.dll");
                        client.DownloadFile("http://github.com/nerdunit/androidsideloader/releases/download/v0.3/adb.7z", "adb.7z");
                    }
                    ExtractFile(Environment.CurrentDirectory + "\\adb.7z", Environment.CurrentDirectory);
                    File.Delete("adb.7z");
                    File.Delete("7z.dll");
                    File.Delete("7z.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot download adb because you are not connected to the internet!");
                    StreamWriter sw = File.AppendText(debugPath);
                    sw.Write("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
                    sw.Write(ex.ToString() + "\n");
                    sw.Flush();
                    sw.Close();
                    Environment.Exit(600);
                }
                
            }
            if (debugMode==false)
                checkForUpdate();
            intToolTips();
        }
        void intToolTips()
        {
            ToolTip ListAppsToolTip = new ToolTip();
            ListAppsToolTip.SetToolTip(this.ListApps, "Press this to show what packages you have installed");
        }
        void checkForUpdate()
        {
            try
            {
                string localVersion = "0.5";
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


        private void backupbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Action Started, may take some time...");
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("pull " + '"' + "/sdcard/Android/data" + '"');
            });
            t1.IsBackground = true;
            t1.Start();

            while (exit == false)
                Thread.Sleep(1000);

            Directory.Move(adbPath + "data", Environment.CurrentDirectory + "\\data");

            MessageBox.Show(allText);
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
                MessageBox.Show("Action Started, may take some time...");
                Thread t1 = new Thread(() =>
                {
                    runAdbCommand("push " + '"' + obbPath + '"' + " /sdcard/Android/");
                });
                t1.IsBackground = true;
                t1.Start();

                while (exit == false)
                    Thread.Sleep(1000);

                MessageBox.Show(allText);
        }

        private void customadbcmdbutton_Click(object sender, EventArgs e)
        {
            customAdbCommandForm adbCommandForm = new customAdbCommandForm();
            adbCommandForm.Show();
        }

        private void ListApps_Click(object sender, EventArgs e)
        {
            allText = "";

            comboBox1.Items.Clear();
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell pm list packages");
            });
            t1.IsBackground = true;
            t1.Start();

            while (exit == false)
                Thread.Sleep(1000);

            foreach (string obj in line)
            {
                comboBox1.Items.Add(obj);
            }

            if (allText.Length > 0)
                MessageBox.Show("Fetched apks with success");
        }

        private void getApkButton_Click(object sender, EventArgs e)
        {
            string package;
            allText = "";
            try
            {
                package = comboBox1.SelectedItem.ToString().Remove(0,8); //remove package:
                package = package.Remove(package.Length - 1);
            } catch { MessageBox.Show("You must first run list items"); return; }

            //MessageBox.Show(package);
            exit = false;
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell pm path " + package);
            });
            t1.IsBackground = true;
            t1.Start();

            while (exit == false)
                Thread.Sleep(1000);
            allText = allText.Remove(allText.Length - 1);
            //MessageBox.Show(allText);

            string apkPath = allText.Remove(0, 8); //remove package:
            apkPath = apkPath.Remove(apkPath.Length - 1);
            //MessageBox.Show(adbPath);
            exit = false;
            Thread t2 = new Thread(() =>
            {
                runAdbCommand("pull " + apkPath);
            });
            t2.IsBackground = true;
            t2.Start();

            while (exit == false)
                Thread.Sleep(1000);

            string currApkPath = apkPath;
            while (currApkPath.Contains("/"))
                currApkPath = currApkPath.Substring(currApkPath.IndexOf("/") + 1);

            if (File.Exists(Environment.CurrentDirectory + "\\" + package + ".apk"))
                File.Delete(Environment.CurrentDirectory + "\\" + package + ".apk");

            File.Copy(Environment.CurrentDirectory + "\\adb\\" + currApkPath, Environment.CurrentDirectory + "\\" + package + ".apk");

            File.Delete(Environment.CurrentDirectory + "\\adb\\" + currApkPath);


            MessageBox.Show("Done");
        }
    }
}
