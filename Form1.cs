using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Management;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Threading;
using System.Net;
using SergeUtils;
using JR.Utils.GUI.Forms;
using Newtonsoft.Json;
using System.Globalization;
using System.Linq;
using Spoofer;

namespace AndroidSideloader
{

    public partial class Form1 : Form
    {
#if DEBUG
        public static bool debugMode = true;
#else
        public static bool debugMode = false;
#endif
        string path;

        bool is1April = false;

        string rclonepw = "0aE0$D61#avO";

        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeTitle(string txt)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => this.Text = txt));
            else
                this.Text = txt;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        List<string> listBoxItems = new List<string>();

        void AprilPrank()
        {
            if (is1April)
            {
                ImageForm Form = new ImageForm();
                Form.Show();
                this.Invoke(() => { this.Hide(); });
                return;
            }
        }

        private async void startsideloadbutton_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
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
            AprilPrank();
            ADB.DeviceID = GetDeviceID();
            Thread t1 = new Thread(() =>
            {
                output += ADB.Sideload(path);
            });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

            showAvailableSpace();
        }
        List<string> Devices = new List<string>();
        async Task<int> CheckForDevice()
        {
            Devices.Clear();

            string output = string.Empty;
            ADB.DeviceID = GetDeviceID();
            Thread t1 = new Thread(() =>
            {
                output = ADB.RunAdbCommandToString("devices");
            });
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

            var line = output.Split('\n');
            
            int i = 0;

            devicesComboBox.Items.Clear();

            Logger.Log("Devices:");
            foreach (string currLine in line)
            {
                if (i>0 && currLine.Length>0)
                {
                    Devices.Add(currLine.Split('	')[0]);
                    devicesComboBox.Items.Add(currLine.Split('	')[0]);
                    Logger.Log(currLine.Split('	')[0] + "\n", false);
                }
                Debug.WriteLine(currLine);
                i++;
            }


            if (devicesComboBox.Items.Count>0)
                devicesComboBox.SelectedIndex = 0;

            return devicesComboBox.SelectedIndex;
        }

        private async void devicesbutton_Click(object sender, EventArgs e)
        {
            await CheckForDevice();

            ChangeTitlebarToDevice();

            showAvailableSpace();
        }
        
        public static void notify(string message)
        {
            if (Properties.Settings.Default.enableMessageBoxes == true)
                FlexibleMessageBox.Show(new Form { TopMost = true, StartPosition = FormStartPosition.CenterScreen }, message);
        }

        private async void obbcopybutton_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            var dialog = new FolderSelectDialog
            {
                Title = "Select your obb folder"
            };
            if (dialog.Show(Handle))
            {
                string[] files = Directory.GetFiles(dialog.FileName);

                Thread t1 = new Thread(() =>
                {
                    output += ADB.CopyOBB(dialog.FileName);
                });
                t1.IsBackground = true;
                t1.Start();

                while (t1.IsAlive)
                    await Task.Delay(100);

                showAvailableSpace();
            }
            else return;

            notify(output);
        }

        private async void ChangeTitlebarToDevice()
        {
            if (!Devices.Contains("unauthorized"))
            {
                if (Devices[0].Length > 1 && Devices[0].Contains("unauthorized"))
                    this.Invoke(() => { this.Text = "Rookie's Sideloader | Device Not Authorized"; });
                else if (Devices[0].Length > 1)
                    this.Invoke(() => { this.Text = "Rookie's Sideloader | Device Connected with ID | " + Devices[0].Replace("device", ""); });
                else
                    this.Invoke(() => { this.Text = "Rookie's Sideloader | No Device Connected"; });
            }
        }

        void downloadFiles()
        {
            using (var client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\warning.png"))
                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/secret", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\warning.png");


                if (!File.Exists("Sideloader Launcher.exe"))
                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/Sideloader%20Launcher.exe", "Sideloader Launcher.exe");

                if (!Directory.Exists(ADB.adbPath)) //if there is no adb folder, download and extract
                {
                    try
                    {
                        client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/adb.7z", "adb.7z");
                        oldTitle = this.Text;
                        ChangeTitle($"Rookie's Sideloader | Extracting archive {Environment.CurrentDirectory}\\adb.7z");
                        Zip.ExtractFile($"{Environment.CurrentDirectory}\\adb.7z", Environment.CurrentDirectory);
                        ChangeTitle(oldTitle);
                        File.Delete("adb.7z");
                    }
                    catch
                    {

                    }

                }

                if (!Directory.Exists(Environment.CurrentDirectory + "\\rclone"))
                {
                    string url;
                    if (Environment.Is64BitOperatingSystem)
                        url = "https://downloads.rclone.org/v1.53.1/rclone-v1.53.1-windows-amd64.zip";
                    else
                        url = "https://downloads.rclone.org/v1.53.1/rclone-v1.53.1-windows-386.zip";

                    client.DownloadFile(url, "rclone.zip");

                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/adb.7z", "adb.7z");
                    oldTitle = this.Text;
                    ChangeTitle("Rookie's Sideloader | Extracting archive " + $"{Environment.CurrentDirectory}\\rclone.zip");
                    Zip.ExtractFile(Environment.CurrentDirectory + "\\rclone.zip", Environment.CurrentDirectory);
                    ChangeTitle(oldTitle);

                    File.Delete("rclone.zip");

                    string[] folders = Directory.GetDirectories(Environment.CurrentDirectory);
                    foreach (string folder in folders)
                    {
                        if (folder.Contains("rclone"))
                        {
                            Directory.Move(folder, "rclone");
                            break;
                        }
                    }
                }
            }
        }

        async void showAvailableSpace()
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            string AvailableSpace = string.Empty;
            ADB.DeviceID = GetDeviceID();
            Thread t1 = new Thread(() =>
            {
                AvailableSpace = ADB.GetAvailableSpace();
            });
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

            progressBar.Style = ProgressBarStyle.Continuous;
            diskLabel.Invoke(() => { diskLabel.Text = AvailableSpace; });
        }

        public string GetDeviceID()
        {
            string deviceId = string.Empty;
            int index = -1;
            devicesComboBox.Invoke(() => { index = devicesComboBox.SelectedIndex; });
            if (index != -1)
                devicesComboBox.Invoke(() => { deviceId = devicesComboBox.SelectedItem.ToString(); });
            return deviceId;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ChangeTitle("Loading...");
            try { Spoofer.spoofer.Init(); } catch { }
            progressBar.Style = ProgressBarStyle.Marquee;

            if (Properties.Settings.Default.CallUpgrade)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.CallUpgrade = false;
                Properties.Settings.Default.Save();
            }

            this.CenterToScreen();

            etaLabel.Text = "";
            speedLabel.Text = "";
            diskLabel.Text = "";

            downloadFiles(); await Task.Delay(100);

            //this.Activate();

            await CheckForDevice();

            ChangeTitlebarToDevice();

            Thread t1 = new Thread(() =>
            {
                Environment.SetEnvironmentVariable("RCLONE_CRYPT_REMOTE", rclonepw);
                Environment.SetEnvironmentVariable("RCLONE_CONFIG_PASS", rclonepw);
                if (!debugMode && Properties.Settings.Default.checkForUpdates)
                {
                    Updater.AppName = "AndroidSideloader";
                    Updater.RawGitHubUrl = "https://raw.githubusercontent.com/nerdunit/androidsideloader";
                    Updater.Update();
                }
                initMirrors();
                initGames();
                listappsBtn();
            });
            t1.SetApartmentState(ApartmentState.STA);
            t1.IsBackground = false;
            t1.Start();

            showAvailableSpace();

            intToolTips();

            while (t1.IsAlive)
                await Task.Delay(100);
            progressBar.Style = ProgressBarStyle.Continuous;

            enableButtons();
        }

        void intToolTips()
        {
            ToolTip ListDevicesToolTip = new ToolTip();
            ListDevicesToolTip.SetToolTip(this.devicesbutton, "Lists the devices in a message box, also updates title bar");
            ToolTip SideloadAPKToolTip = new ToolTip();
            SideloadAPKToolTip.SetToolTip(this.startsideloadbutton, "Sideloads/Installs one apk on the android device");
            ToolTip OBBToolTip = new ToolTip();
            OBBToolTip.SetToolTip(this.obbcopybutton, "Copies an obb folder to the Android/Obb folder from the device, some games/apps need this");
            ToolTip BackupGameDataToolTip = new ToolTip();
            BackupGameDataToolTip.SetToolTip(this.backupbutton, "Saves the game and apps data to the sideloader folder, does not save apk's and obb's");
            ToolTip RestoreGameDataToolTip = new ToolTip();
            RestoreGameDataToolTip.SetToolTip(this.restorebutton, "Restores the game and apps data to the device, first use Backup Game Data button");
            ToolTip GetAPKToolTip = new ToolTip();
            GetAPKToolTip.SetToolTip(this.getApkButton, "Saves the selected apk to the folder where the sideloader is");
            ToolTip sideloadFolderToolTip = new ToolTip();
            sideloadFolderToolTip.SetToolTip(this.sideloadFolderButton, "Sideloads every apk from a folder");
            ToolTip uninstallAppToolTip = new ToolTip();
            uninstallAppToolTip.SetToolTip(this.uninstallAppButton, "Uninstalls selected app");
            ToolTip userjsonToolTip = new ToolTip();
            userjsonToolTip.SetToolTip(this.userjsonButton, "After you enter your username it will create an user.json file needed for some games");
            ToolTip etaToolTip = new ToolTip();
            etaToolTip.SetToolTip(this.etaLabel, "Estimated time when game will finish download, updates every 5 seconds, format is HH:MM:SS");
            ToolTip dlsToolTip = new ToolTip();
            dlsToolTip.SetToolTip(this.speedLabel, "Current download speed, updates every second, in mbps");
        }

        private async void backupbutton_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            Thread t1 = new Thread(() =>
            {

                output = ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data\" \"{Environment.CurrentDirectory}\"");

                try
                {
                    Directory.Move(ADB.adbPath + "data", Environment.CurrentDirectory + "\\data");
                }
                catch (Exception ex)
                {
                    Logger.Log($"Exception on backup: {ex.ToString()}");
                }
            });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

            notify(output);
        }

        private async void restorebutton_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            var dialog = new FolderSelectDialog
            {
                Title = "Select your obb folder"
            };
            if (dialog.Show(Handle))
            {
                string path = dialog.FileName;
                Thread t1 = new Thread(() =>
                {
                    output = ADB.RunAdbCommandToString($"push \"{path}\" /sdcard/Android/");
                });
                t1.IsBackground = true;
                t1.Start();

                while (t1.IsAlive)
                    await Task.Delay(100);
            }
            else return;

            notify(output);
        }

        private string listapps()
        {
            ADB.DeviceID = GetDeviceID();
            return ADB.RunAdbCommandToString("shell pm list packages");
        }

        public async Task<string[]> getGames()
        {
            string command = $"cat \"{currentRemote}:Quest Games/APK_packagenames.txt\" --config .\\a";
            Process cmd = new Process();
            cmd.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            cmd.StartInfo.FileName = Environment.CurrentDirectory + "\\rclone\\rclone.exe";
            cmd.StartInfo.Arguments = command;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\rclone";
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            var games = cmd.StandardOutput.ReadToEnd().Split('\n');
            cmd.WaitForExit();
            return games;
        }

        private async void listappsBtn()
        {
            //games = getGames().Result;

            m_combo.Invoke(() => { m_combo.Items.Clear(); });

            var line = listapps().Split('\n');

            for (int  i = 0; i < line.Length; i++)
            {
                if (line[i].Length > 9)
                {
                    line[i] = line[i].Remove(0, 8);
                    line[i] = line[i].Remove(line[i].Length - 1);

                    foreach (string game in games)
                    {
                        if (line[i].Length > 0 && game.Contains(line[i]))
                        {
                            var foo = game.Split(';');

                            int index = 0;
                            index = foo[0].LastIndexOf(" v");
                            if (index > 0)
                                foo[0] = foo[0].Substring(0, index);

                            line[i] = foo[0];
                        }

                    }
                }
            }

            Array.Sort(line);

            foreach (string game in line)
            {
                if (game.Length > 0)
                    m_combo.Invoke(() => { m_combo.Items.Add(game); });
            }

            m_combo.Invoke(() => { m_combo.MatchingMethod = StringMatchingMethod.NoWildcards; });
        }

        private async void getApkButton_Click(object sender, EventArgs e)
        {

            if (m_combo.SelectedIndex == -1)
            {
                notify("Please select an app first");
                return;
            }

            progressBar.Style = ProgressBarStyle.Marquee;
            string output = string.Empty;
            Thread t1 = new Thread(() =>
            {
                string packageName = "";

                m_combo.Invoke(() => { packageName = m_combo.SelectedItem.ToString(); });

                foreach (string game in games)
                {
                    Debug.WriteLine(game);
                    if (packageName.Length > 0 && game.Contains(packageName))
                    {
                        var foo = game.Split(';');
                        packageName = foo[2];
                    }
                }

                output = ADB.RunAdbCommandToString("shell pm path " + packageName); //Get apk

                output = output.Remove(output.Length - 1);

                string apkPath = output.Remove(0, 8); //remove package:
                apkPath = apkPath.Remove(apkPath.Length - 1);

                output = ADB.RunAdbCommandToString("pull " + apkPath); //pull apk

                string currApkPath = apkPath;
                while (currApkPath.Contains("/"))
                    currApkPath = currApkPath.Substring(currApkPath.IndexOf("/") + 1);

                if (File.Exists(Environment.CurrentDirectory + "\\" + packageName + ".apk"))
                    File.Delete(Environment.CurrentDirectory + "\\" + packageName + ".apk");
                
                File.Move(Environment.CurrentDirectory + "\\adb\\" + currApkPath, Environment.CurrentDirectory + "\\" + packageName + ".apk");
            });
            t1.IsBackground = true;
            t1.Start();
            progressBar.Style = ProgressBarStyle.Continuous;


            while (t1.IsAlive)
                await Task.Delay(100);

            notify(output);
        }

        string getpackagename(string gameName)
        {
            string packageName = gameName;

            if (packageName.Contains(" v"))
            {
                int index = packageName.LastIndexOf(" v");
                if (index > 0)
                    packageName = packageName.Substring(0, index); // or index + 1 to keep slash
            }

            foreach (string game in games)
            {
                if (packageName.Length > 0 && game.Contains(packageName))
                {
                    packageName = game;
                    break;
                }
            }

            return packageName;

        }

        private async void uninstallAppButton_Click(object sender, EventArgs e)
        {
            if (m_combo.SelectedIndex == -1)
            {
                FlexibleMessageBox.Show("Please select an app first");
                return;
            }

            string uninstallText = "";

            progressBar.Style = ProgressBarStyle.Marquee;

            Thread t1 = new Thread(() =>
            {
                string foo = "";
                m_combo.Invoke(() => { foo = m_combo.SelectedItem.ToString(); });
                string packageName = getpackagename(foo);

                try
                {
                    packageName = packageName.Split(';')[2];
                }
                catch { }

                DialogResult dialogResult = FlexibleMessageBox.Show("Are you sure you want to uninstall " + packageName + ", this CANNOT be undone!", "WARNING!", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                    return;
                
                uninstallText += ADB.UninstallPackage(packageName);

                RemoveFolder("/sdcard/Android/obb/" + packageName);
                RemoveFolder("/sdcard/Android/obb/" + packageName + "/");

//                uninstallText += allText;

                dialogResult = FlexibleMessageBox.Show("Do you want to remove savedata for " + packageName + ", this CANNOT be undone!", "WARNING!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    RemoveFolder("/sdcard/Android/data/" + packageName + "/");
                    RemoveFolder("/sdcard/Android/data/" + packageName);
                }
            });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

            showAvailableSpace();

            progressBar.Style = ProgressBarStyle.Continuous;

            if (uninstallText.Length > 0)
                notify(uninstallText);
        }

        string RemoveFolder(string path)
        {
            return ADB.RunAdbCommandToString($"shell rm -r {path}");
        }

        private async void sideloadFolderButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                Title = "Select your folder with APKs"
            };
            if (dialog.Show(Handle))
            {
                Thread t1 = new Thread(() =>
                {
                    recursiveSideload(dialog.FileName);
                });
                t1.IsBackground = true;
                t1.Start();
                while (t1.IsAlive)
                    await Task.Delay(100);
                showAvailableSpace();
            }
            else return;

            notify("Done bulk sideloading");
        }

        private async void recursiveSideload(string location)
        {
            ADB.DeviceID = GetDeviceID();
            string[] files = Directory.GetFiles(location);
            string[] childDirectories = Directory.GetDirectories(location);
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                if (extension == ".apk")
                {
                    ADB.Sideload(files[i]);
                }
            }
            for (int i = 0; i < childDirectories.Length; i++)
            {
                recursiveSideload(childDirectories[i]);
            }
        }

        /*Progress bar stuff
         * 
         */

        private async void copyBulkObbButton_Click(object sender, EventArgs e)
        {

            var dialog = new FolderSelectDialog
            {
                Title = "Select your folder with APKs"
            };
            if (dialog.Show(Handle))
            {
                Thread t1 = new Thread(() =>
                {
                    recursiveCopy(dialog.FileName);
                });
                t1.IsBackground = true;
                t1.Start();

                showAvailableSpace();

                while (t1.IsAlive)
                    await Task.Delay(100);
            }
            else return;

            FlexibleMessageBox.Show("Done");
        }

        async void recursiveCopy(string location)
        {
            string[] files = Directory.GetFiles(location);
            string[] childDirectories = Directory.GetDirectories(location);
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                
                if (extension == ".obb")
                {
                    int index = files[i].LastIndexOf("\\");
                    if (index > 0)
                        files[i] = files[i].Substring(0, index);
                    if (Directory.Exists(files[i])) //if it's a folder
                        ADB.CopyOBB(files[i]);

                }
            }
            for (int i = 0; i < childDirectories.Length; i++)
            {
                recursiveCopy(childDirectories[i]);
            }
        }



        private async void Form1_DragDrop(object sender, DragEventArgs e)
        {
            AprilPrank();
            bool ok = false;
            string output = "";
            ADB.DeviceID = GetDeviceID();
            progressBar.Style = ProgressBarStyle.Marquee;
            Thread t1 = new Thread(() =>
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (extension == ".apk")
                    {
                        ok = true;
                        output += ADB.Sideload(file);
                    }
                    else if (extension == ".obb")
                    {
                        string filename = Path.GetFileName(file);
                        string foldername = filename.Substring(filename.IndexOf('.') + 1);
                        foldername = foldername.Substring(foldername.IndexOf('.') + 1);
                        foldername = foldername.Replace(".obb", "");
                        //remove main.number.
                        Directory.CreateDirectory(foldername);
                        Console.WriteLine($"filename: {filename} foldername: {foldername} all: {Environment.CurrentDirectory + "\\" + foldername}");
                        File.Copy(file, Environment.CurrentDirectory + "\\" + foldername + "\\" + filename);
                        output += ADB.CopyOBB(Environment.CurrentDirectory + "\\" + foldername);
                        Directory.Delete(Environment.CurrentDirectory + "\\" + foldername, true);
                    }
                    else if (Directory.Exists(file))
                    {
                        ok = true;
                        string[] foldersindirectory = Directory.GetDirectories(file);
                        foreach (string curr in foldersindirectory)
                        {
                            output += ADB.CopyOBB(curr);
                        }
                        string[] filesindirectory = Directory.GetFiles(file);
                        foreach (string curr in filesindirectory)
                        {
                            if (Path.GetExtension(curr) == ".apk")
                            {
                                output += ADB.Sideload(curr);
                            }
                        }
                        output += ADB.CopyOBB(file);
                    }
                }
            });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);
            progressBar.Style = ProgressBarStyle.Continuous;

            showAvailableSpace();
            DragDropLbl.Visible = false;
            if (ok && !is1April)
                notify(output);

            DragDropLbl.Visible = false;
        }
        string oldTitle;
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            oldTitle = this.Text;
            DragDropLbl.Visible = true;
            DragDropLbl.Text = "Drag apk or obb";
            ChangeTitle(DragDropLbl.Text);
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            ChangeTitle(oldTitle);
            DragDropLbl.Visible = false;
        }
        string[] games;
        private async void Form1_Shown(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;

            if (today.Month == 4 && today.Day == 1)
                is1April = true;

            progressBar.Style = ProgressBarStyle.Marquee;

            Thread t1 = new Thread(() =>
            {
                ADB.DeviceID = GetDeviceID();
            });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);
        }

        void initMirrors()
        {
            remotesList.Invoke(() => { remotesList.Items.Clear(); });
            var mirrors = runRcloneCommand("--config .\\a listremotes").Split('\n');
            mirrors = runRcloneCommand("--config .\\a listremotes").Split('\n');

            Logger.Log("Loaded following mirrors: ");
            foreach (string mirror in mirrors)
            {
                if (mirror.Contains("mirror"))
                {
                    Logger.Log(mirror.Remove(mirror.Length - 1));
                    remotesList.Invoke(() => { remotesList.Items.Add(mirror.Remove(mirror.Length - 1)); });
                }
            }

            int itemsCount = 0;

            remotesList.Invoke(() => {
                itemsCount = remotesList.Items.Count;
            });

            if (itemsCount > 0)
            {
                remotesList.Invoke(() => {
                    var rand = new Random();
                    remotesList.SelectedIndex = rand.Next(0,itemsCount);
                    currentRemote = remotesList.SelectedItem.ToString();
                });
            }
        }

        private void enableButtons()
        {
            downloadInstallGameButton.Enabled = true;
        }
        string processError = string.Empty;
        Process rclone = new Process();
        string runRcloneCommand(string command, bool log = true)
        {
            Logger.Log($"Running Rclone command: {command}");
            wait = true;
            rclone.StartInfo.StandardOutputEncoding = Encoding.UTF8;

            if (rclonepw.Length > 0)
                command += " --ask-password=false";
            if (log && Properties.Settings.Default.logRclone)
                command += " --log-file=log.txt --log-level DEBUG";
            rclone.StartInfo.FileName = Environment.CurrentDirectory + "\\rclone\\rclone.exe";
            rclone.StartInfo.Arguments = command;
            rclone.StartInfo.RedirectStandardInput = true;
            rclone.StartInfo.RedirectStandardError = true;
            rclone.StartInfo.RedirectStandardOutput = true;
            rclone.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\rclone";
            rclone.StartInfo.CreateNoWindow = true;
            if (debugMode == true)
                rclone.StartInfo.CreateNoWindow = false;
            rclone.StartInfo.UseShellExecute = false;
            rclone.Start();

            rclone.StandardInput.WriteLine(command);
            rclone.StandardInput.Flush();
            rclone.StandardInput.Close();


            var output = rclone.StandardOutput.ReadToEnd();
            string rcloneError = rclone.StandardError.ReadToEnd();
            rclone.WaitForExit();
            wait = false;
            Logger.Log($"Rclone error: {rcloneError} {rcloneError.Length}\nRclone Output: {output}");
            if (rcloneError.Length > 77)
                processError = rcloneError;
            return output;
        }
        string currentRemote = string.Empty;
        void initGames()
        {
            games = getGames().Result;

            gamesComboBox.Invoke(() => { gamesComboBox.Items.Clear(); });
            
            var currGames = runRcloneCommand($"lsf --config .\\a --dirs-only \"{currentRemote}:Quest Games\" --drive-acknowledge-abuse").Split('\n');

            Debug.WriteLine("Loaded following games: ");
            foreach (string game in currGames)
            {
                if (!game.StartsWith(".") && game.Length>1)
                {
                    Debug.WriteLine(game);
                    gamesComboBox.Invoke(() => { gamesComboBox.Items.Add(game.Remove(game.Length - 1)); });
                }
            }
            Debug.WriteLine(wrDelimiter);
        }
        string wrDelimiter = "-------";
        private void sideloadContainer_Click(object sender, EventArgs e)
        {
            ShowSubMenu(sideloadContainer);
        }

        private void backupDrop_Click(object sender, EventArgs e)
        {
            ShowSubMenu(backupContainer);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            string about = $@"Finally {Updater.LocalVersion}, with new version comming Soon™
 - Software orignally coded by rookie.wtf
 - Thanks to pmow for all of his work, including rclone, wonka and other projects
 - Thanks to the data team, they know who they are ;)
 - Thanks to flow for being friendly and helping every one, also congrats on being the discord server owner now! :D
 - Thanks to badcoder5000 for helping me redesign the ui
 - Thanks to gotard for the theme changer
 - Thanks to Verb8em for drawing the new icon
 - Thanks to 7zip team for 7zip :)
 - Thanks to rclone team for rclone :D
 - Thanks to https://stackoverflow.com/users/57611/erike for the folder browser dialog code
 - Thanks to Serge Weinstock for developing SergeUtils, which is used to search the combo box
 - Thanks to Mike Gold https://www.c-sharpcorner.com/members/mike-gold2 for the scrollable message box";


            FlexibleMessageBox.Show(about);
        }

        bool wait;

        private void userjsonButton_Click(object sender, EventArgs e)
        {
            UsernameForm form = new UsernameForm();
            form.Show();
        }

        private async void listApkButton_Click(object sender, EventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Marquee;

            showAvailableSpace();
            Thread t1 = new Thread(() =>
            {
                initMirrors();
                initGames();
                listappsBtn();
            });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

        }

        public string randomString(int length)
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            int randomInteger = rnd.Next(0, valid.Length);
            while (0 < length--)
            {
                res.Append(valid[randomInteger]);
                randomInteger = rnd.Next(0, valid.Length);
            }
            return res.ToString();
        }

        private static readonly HttpClient client = new HttpClient();

        bool updatedConfig = false;
        async Task updateConfig()
        {
            updatedConfig = true;

            string localHash = "";
            try { localHash = File.ReadAllText(Environment.CurrentDirectory + "\\rclone\\hash.txt"); } catch { } //file may not exist

            string hash = runRcloneCommand($"md5sum --config .\\a \"{currentRemote}:Quest Homebrew/Sideloading Methods/1. Rookie Sideloader - VRP Edition/a\"");
            try { hash = hash.Substring(0, hash.LastIndexOf(" ")); } catch { return; } //remove stuff after hash

            Debug.WriteLine("The local file hash is " + localHash + " and the current a file hash is " + hash);

            if (!string.Equals(localHash, hash))
            {
                ChangeTitle("Rookie's Sideloader | Updating rclone config");
                runRcloneCommand(string.Format($"copy \"{currentRemote}:Quest Homebrew/Sideloading Methods/1. Rookie Sideloader - VRP Edition/a\" \"{Environment.CurrentDirectory}\" --config .\\a"));
                killRclone();
                File.Copy(Environment.CurrentDirectory + "\\a", Environment.CurrentDirectory + "\\rclone\\a", true);
                File.WriteAllText(Environment.CurrentDirectory + "\\rclone\\hash.txt", hash);
            }
        }
        bool gamesAreDownloading = false;
        List<string> gamesQueueList = new List<string>();

        async Task<bool> showGameSizeDialog(string gameName)
        {

            dynamic results = JsonConvert.DeserializeObject<dynamic>(runRcloneCommand($"size \"{currentRemote}:Quest Games/{gameName}\" --config .\\a --json"));
            long gameSize = results.bytes.ToObject<long>();
            Debug.WriteLine($"Remote: {currentRemote}, GameSize: {gameSize}, GameName: {gameName}");
            DialogResult dialogResult = FlexibleMessageBox.Show($"Are you sure you want to download {gameName}? it has a size of {String.Format("{0:0.00}", (double)gameSize / 1000000)} MB", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return false;
            return true;
        }
        int quotaTries = 0;
        private async void downloadInstallGameButton_Click(object sender, EventArgs e)
        {
            if (gamesComboBox.SelectedIndex == -1)
            {
                notify("You must select a game first");
                return;
            }

            if (updatedConfig == false && Properties.Settings.Default.autoUpdateConfig == true) //check for config only once per program open and if setting enabled
            {
                ChangeTitle("Rookie's Sideloader | Checking if config is updated");
                await Task.Run(() => updateConfig());
            }

            if (await showGameSizeDialog(gamesComboBox.SelectedItem.ToString())==false)
                return;

            gamesQueueList.Add(gamesComboBox.SelectedItem.ToString());
            gamesQueListBox.DataSource = null;
            gamesQueListBox.DataSource = gamesQueueList;

            if (gamesAreDownloading)
                return;

            gamesAreDownloading = true;

            Thread userJsonThread = new Thread(() =>
            {
                doUserJson();
            });
            userJsonThread.IsBackground = true;
            userJsonThread.Start();




            string output = "";

            while (gamesQueueList.Count>0)
            {
                string gameName = gamesQueueList.ToArray()[0];
                Debug.WriteLine(runRcloneCommand($"size \"{currentRemote}:Quest Games/{gameName}\" --config .\\a --json"));

                int apkNumber = 0;
                int obbNumber = 0;

                Directory.CreateDirectory(Environment.CurrentDirectory + "\\" + gameName);

                string[] games;

                Thread t1 = new Thread(() =>
                {
                    games = runRcloneCommand($"copy --config .\\a \"{currentRemote}:Quest Games/{gameName}\" \"{Environment.CurrentDirectory}\\{gameName}\" --progress --drive-acknowledge-abuse --rc").Split('\n');
                    foreach (string line in games)
                        Debug.WriteLine(line);
                });
                t1.IsBackground = true;
                t1.Start();

                ChangeTitle("Rookie's Sideloader | Pushing user.json");

                ChangeTitle("Rookie's Sideloader | Downloading game " + gameName);

                int i = 0;
                while (t1.IsAlive)
                {
                    try
                    {
                        HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:5572/core/stats", null);

                        string foo = await response.Content.ReadAsStringAsync();

                        Debug.WriteLine("RESP CONTENT " + foo);
                        dynamic results = JsonConvert.DeserializeObject<dynamic>(foo);

                        float downloadSpeed = results.speed.ToObject<float>();

                        long allSize = 0;

                        long downloaded = 0;

                        dynamic check = results.transferring;

                        if (results["transferring"] != null)
                        {
                            foreach (var obj in results.transferring)
                            {
                                allSize += obj["size"].ToObject<long>();
                                downloaded += obj["bytes"].ToObject<long>();
                            }
                            allSize /= 1000000;
                            downloaded /= 1000000;
                            Debug.WriteLine("Allsize: " + allSize + "\nDownloaded: " + downloaded + "\nValue: " + (((double)downloaded / (double)allSize) * 100));
                            try { progressBar.Value = Convert.ToInt32((((double)downloaded / (double)allSize) * 100)); } catch { }

                            i++;
                            downloadSpeed /= 1000000;
                            if (i == 4)
                            {
                                i = 0;
                                float seconds = (allSize - downloaded) / downloadSpeed;

                                TimeSpan time = TimeSpan.FromSeconds(seconds);

                                etaLabel.Text = "ETA: " + time.ToString(@"hh\:mm\:ss") + " left";
                            }

                            speedLabel.Text = "DLS: " + String.Format("{0:0.00}", downloadSpeed) + " mbps";
                        }

                    }
                    catch { }

                    await Task.Delay(1000);
                }

                //Quota Errors
                bool quotaError = false;
                if (processError.Length!=0)
                {
                    if (processError.Contains("downloadQuotaExceeded"))
                    {
                        quotaTries++;
                        quotaError = true;
                        FlexibleMessageBox.Show("The download Quota has been reached for this mirror, trying to switch mirrors...");
                        //Mirror switch
                        if (quotaTries>remotesList.Items.Count)
                        {
                            quotaTries = 0;
                            FlexibleMessageBox.Show("Quota reached for all mirrors, trying to refresh remotes...");
                            initGames();
                            remotesList.SelectedIndex = remotesList.Items.Count - 1;
                            return;
                        }
                        if (remotesList.Items.Count>remotesList.SelectedIndex)
                            remotesList.SelectedIndex++;
                        else
                            remotesList.SelectedIndex=0;

                        gamesQueueList.RemoveAt(0);
                        //gamesQueueList.Add(gameName);
                        gamesQueListBox.DataSource = null;
                        gamesQueListBox.DataSource = gamesQueueList;
                    }
                    else FlexibleMessageBox.Show(processError);
                }
                processError = string.Empty;

                if (quotaError==false)
                {
                    ADB.DeviceID = GetDeviceID();
                    quotaTries = 0;
                    progressBar.Value = 0;
                    ChangeTitle("Rookie's Sideloader | Installing game apk " + gameName);
                    etaLabel.Text = "ETA: Wait for install...";
                    speedLabel.Text = "DLS: Done downloading";

                    AprilPrank();
                    string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\" + gameName);

                    Debug.WriteLine("Game Folder is: " + Environment.CurrentDirectory + "\\" + gameName);

                    Debug.WriteLine("FILES IN GAME FOLDER: ");
                    foreach (string file in files)
                    {
                        Debug.WriteLine(file);
                        string extension = Path.GetExtension(file);
                        if (extension == ".apk")
                        {
                            apkNumber++;

                            Thread apkThread = new Thread(() =>
                            {
                                if (Properties.Settings.Default.SpoofGames)
                                {
                                    var rand = new Random();
                                    ChangeTitle($"Spoofing {file}");
                                    Console.WriteLine(file);
                                    Console.WriteLine(spoofer.spoofedApkPath);
                                    Spoofer.spoofer.SpoofApk(file, $"com.{Utilities.randomString(rand.Next(3, 8))}.{Utilities.randomString(rand.Next(3, 8))}");

                                    output += ADB.Sideload(spoofer.spoofedApkPath);
                                }
                                else
                                    output += ADB.Sideload(file);
                            });
                            apkThread.IsBackground = true;
                            apkThread.Start();

                            while (apkThread.IsAlive)
                                await Task.Delay(100);
                        }
                    }

                    Debug.WriteLine(wrDelimiter);

                    ChangeTitle("Rookie's Sideloader | Installing game obb " + gameName);

                    string[] folders = Directory.GetDirectories(Environment.CurrentDirectory + "\\" + gameName);

                    foreach (string folder in folders)
                    {
                        string[] obbs = Directory.GetFiles(folder);

                        bool isObb = false;
                        foreach (string currObb in obbs)
                        {
                            string extension = Path.GetExtension(currObb);

                            if (extension == ".obb")
                            {
                                isObb = true;
                            }
                        }

                        if (isObb == true)
                        {
                            obbNumber++;

                            Thread obbThread = new Thread(() =>
                            {
                                if (Properties.Settings.Default.SpoofGames)
                                    Spoofer.spoofer.RenameObb(folder, spoofer.newPackageName, spoofer.originalPackageName);
                                output += ADB.CopyOBB(folder);
                            });
                            obbThread.IsBackground = true;
                            obbThread.Start();

                            while (obbThread.IsAlive)
                                await Task.Delay(100);
                        }
                    }

                    if (Properties.Settings.Default.deleteAllAfterInstall)
                    {
                        ChangeTitle("Rookie's Sideloader | Deleting game files");
                        Directory.Delete(Environment.CurrentDirectory + "\\" + gameName, true);
                    }

                    try
                    {
                        gamesQueueList.RemoveAt(0);
                        gamesQueListBox.DataSource = null;
                        gamesQueListBox.DataSource = gamesQueueList;
                    }
                    catch { FlexibleMessageBox.Show("Uhhhm you've got a weird error please contact rookie"); break; }
                    showAvailableSpace();
                }

            }
            etaLabel.Text = "ETA: Done";
            speedLabel.Text = "DLS: Done";
            await CheckForDevice();
            ChangeTitlebarToDevice();
            gamesAreDownloading = false;
            notify($"Apk installation output: {output}\n");
        }

        private void doUserJson()
        {
            if (!Properties.Settings.Default.userJsonOnGameInstall)
                return;
            foreach (var userJson in UsernameForm.userJsons)
            {
                UsernameForm.createUserJsonByName(randomString(16), userJson);
                ADB.RunAdbCommandToString("push \"" + Environment.CurrentDirectory + $"\\{userJson}\" " + " /sdcard/");
                File.Delete(userJson);
            }
        }
        
        void killRclone()
        {
            foreach (var process in Process.GetProcessesByName("rclone"))
            {
                process.Kill();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            killRclone();
        }

        private void movieStreamButton_Click(object sender, EventArgs e)
        {
            if (movieStreamButton.Text == "START MOVIE STREAM")
            {
                Thread t1 = new Thread(() =>
                {
                    runRcloneCommand($"--config .\\a serve dlna {currentRemote}-movies:");
                });
                t1.IsBackground = true;
                t1.Start();

                ChangeTitle("Started Movie Stream! Default port is 25551");
                movieStreamButton.Text = "STOP MOVIE STREAM";
            }
            else
            {
                try { rclone.Kill(); } catch {  }
                ChangeTitle("Stopped Movie Stream!");
                movieStreamButton.Text = "START MOVIE STREAM";
            } 
            
        }

        private async void killRcloneButton_Click(object sender, EventArgs e)
        {
            killRclone();
            movieStreamButton.Text = "START MOVIE STREAM";
            ChangeTitle("Killed Rclone");
            await Task.Delay(TimeSpan.FromSeconds(5));
            await CheckForDevice();
            ChangeTitlebarToDevice();
        }

        private void otherDrop_Click(object sender, EventArgs e)
        {
            ShowSubMenu(otherContainer);
        }

        private void gamesQueListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (gamesQueListBox.SelectedIndex != -1 && gamesQueListBox.SelectedIndex != 0)
            {
                gamesQueueList.Remove(gamesQueListBox.SelectedItem.ToString());
                gamesQueListBox.DataSource = null;
                gamesQueListBox.DataSource = gamesQueueList;
            }
        }

        private void devicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAvailableSpace();
        }

        private void remotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            remotesList.Invoke(() => { currentRemote = remotesList.SelectedItem.ToString(); });
        }

        private void QuestOptionsButton_Click(object sender, EventArgs e)
        {
            QuestForm form = new QuestForm();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void QuestOptionsButton_Click_1(object sender, EventArgs e)
        {
            QuestForm Form = new QuestForm();
            Form.Show();
        }

        private void SpoofFormButton_Click(object sender, EventArgs e)
        {
            SpoofForm Form = new SpoofForm();
            Form.Show();
        }
    }

    public static class ControlExtensions
    {
        public static void Invoke(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(action), null);
            }
            else
            {
                action.Invoke();
            }
        }
    }

}
