using JR.Utils.GUI.Forms;
using Newtonsoft.Json;
using SergeUtils;
using Spoofer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public partial class MainForm : Form
    {
        private ListViewColumnSorter lvwColumnSorter;

#if DEBUG
        public static bool debugMode = true;
        public bool DeviceConnected = false;
#else
        public static bool debugMode = false;
        public bool DeviceConnected = false;
#endif

        private bool isLoading = true;

        public MainForm()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.gamesListView.ListViewItemSorter = lvwColumnSorter;
        }

        private string oldTitle = "";

        public async void ChangeTitle(string txt, bool reset = true)
        {
            this.Invoke(() => { oldTitle = this.Text; this.Text = txt; });
            if (!reset)
                return;
            await Task.Delay(TimeSpan.FromSeconds(5));
            this.Invoke(() => { this.Text = oldTitle; });
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
                subMenu.Visible = true;
            else
                subMenu.Visible = false;
        }

        private async void startsideloadbutton_Click(object sender, EventArgs e)
        {
            ProcessOutput output = new ProcessOutput("", "");
            string path = string.Empty;
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

            ShowPrcOutput(output);
        }

        public void ShowPrcOutput(ProcessOutput prcout)
        {
            string message = $"Output: {prcout.Output}";
            if (prcout.Error.Length != 0)
                message += $"\nError: {prcout.Error}";
            FlexibleMessageBox.Show(this, message);
        }

        private List<string> Devices = new List<string>();

        private async Task<int> CheckForDevice()
        {
            Devices.Clear();

            string output = string.Empty;
            ADB.DeviceID = GetDeviceID();
            Thread t1 = new Thread(() =>
            {
                output = ADB.RunAdbCommandToString("devices").Output;
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
                if (i > 0 && currLine.Length > 0)
                {
                    Devices.Add(currLine.Split('	')[0]);
                    devicesComboBox.Items.Add(currLine.Split('	')[0]);
                    Logger.Log(currLine.Split('	')[0] + "\n", false);
                }
                Debug.WriteLine(currLine);
                i++;
            }

            if (devicesComboBox.Items.Count > 0)
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
            ProcessOutput output = new ProcessOutput("", "");
            var dialog = new FolderSelectDialog
            {
                Title = "Select your obb folder"
            };
            if (dialog.Show(Handle))
            {
                Thread t1 = new Thread(() =>
                {
                    output += ADB.CopyOBB(dialog.FileName);
                });
                t1.IsBackground = true;
                t1.Start();

                while (t1.IsAlive)
                    await Task.Delay(100);

                showAvailableSpace();

                ShowPrcOutput(output);
            }
        }

        private void ChangeTitlebarToDevice()
        {
            if (!Devices.Contains("unauthorized"))
            {
                if (Devices[0].Length > 1 && Devices[0].Contains("unauthorized"))
                {
                    DeviceConnected = false;
                    this.Invoke(() =>
                    {
                        this.Text = "Rookie's Sideloader | Device Not Authorized";
                        DialogResult dialogResult = MessageBox.Show("Device not authorized, be sure to authorize computer on device.", "Not Authorized", MessageBoxButtons.RetryCancel);
                        if (dialogResult == DialogResult.Retry)
                        {
                            devicesbutton.PerformClick();
                     ;
                        }
                        else
                        {
                            return;
                        }

                    });
                }
                else if (Devices[0].Length > 1)
                {
                    this.Invoke(() => { this.Text = "Rookie's Sideloader | Device Connected with ID | " + Devices[0].Replace("device", ""); });
                    DeviceConnected = true;
                }
                else
                    this.Invoke(() =>
                    {
                        DeviceConnected = false;
                        this.Text = "Rookie's Sideloader | No Device Connected";
                        DialogResult dialogResult = MessageBox.Show("No device found. Please ensure the following: \n\n -Developer mode is enabled. \n -ADB drivers are installed. \n -ADB connection is enabled on your device (this can reset). \n -Your device is plugged in.\n\nThen press \"Retry\"", "No device found.", MessageBoxButtons.RetryCancel);
                        if (dialogResult == DialogResult.Retry)
                        {
                            devicesbutton.PerformClick();
                        }
                        else
                        {
                            return;
                        }



                    });
            }
        }

        private async void showAvailableSpace()
        {
            string AvailableSpace = string.Empty;
            ADB.DeviceID = GetDeviceID();
            Thread t1 = new Thread(() =>
            {
                AvailableSpace = ADB.GetAvailableSpace();
            });
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

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

            gamesListView.View = View.Details;
            gamesListView.FullRowSelect = true;
            gamesListView.GridLines = true;

            if (File.Exists(Sideloader.CrashLogPath))
            {
                DialogResult dialogResult = FlexibleMessageBox.Show(this, $@"Looks like sideloader crashed last time, please make an issue at https://github.com/nerdunit/androidsideloader/issues
Please don't forget to post the crash.log and fill in any details you can
Do you want to delete the {Sideloader.CrashLogPath} (if you press yes, this message will not appear when you start the sideloader but please first report this issue)", "Crash Detected", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    File.Delete(Sideloader.CrashLogPath);
            }

            Sideloader.downloadFiles(); await Task.Delay(100);

            //Delete the Debug file if it is more than 5MB
            if (File.Exists(Logger.logfile))
            {
                long length = new System.IO.FileInfo(Logger.logfile).Length;
                if (length > 5000000) File.Delete(Logger.logfile);
            }

            RCLONE.Init();
            try { Spoofer.spoofer.Init(); } catch { }

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

            try
            {
                await CheckForDevice();
                ChangeTitlebarToDevice();
            }
            catch { }
        }

        private void intToolTips()
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
            ProcessOutput output = new ProcessOutput("", "");
            Thread t1 = new Thread(() =>
            {
                output = ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data\" \"{Environment.CurrentDirectory}\"");

                try
                {
                    Directory.Move(ADB.adbFolderPath + "\\data", Environment.CurrentDirectory + "\\data");
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

            ShowPrcOutput(output);
        }

        private async void restorebutton_Click(object sender, EventArgs e)
        {
            ProcessOutput output = new ProcessOutput("", "");
            var dialog = new FolderSelectDialog
            {
                Title = "Select your obb folder"
            };
            if (dialog.Show(Handle))
            {
                string path = dialog.FileName;
                Thread t1 = new Thread(() =>
                {
                    output += ADB.RunAdbCommandToString($"push \"{path}\" /sdcard/Android/");
                });
                t1.IsBackground = true;
                t1.Start();

                while (t1.IsAlive)
                    await Task.Delay(100);
            }
            else return;

            ShowPrcOutput(output);
        }

        private string listapps()
        {
            ADB.DeviceID = GetDeviceID();
            return ADB.RunAdbCommandToString("shell pm list packages").Output;
        }

        private void listappsbtn()
        {
            m_combo.Invoke(() => { m_combo.Items.Clear(); });

            var line = listapps().Split('\n');

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].Length > 9)
                {
                    line[i] = line[i].Remove(0, 8);
                    line[i] = line[i].Remove(line[i].Length - 1);
                    Sideloader.InstalledPackageNames.Add(line[i]);
                    foreach (var game in SideloaderRCLONE.games)
                        if (line[i].Length > 0 && game[3].Contains(line[i]))
                            line[i] = game[0];
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

            string GameName = m_combo.SelectedItem.ToString();
            ProcessOutput output = new ProcessOutput("", "");

            Thread t1 = new Thread(() =>
            {
                output = Sideloader.getApk(GameName);
            });
            t1.IsBackground = true;
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);
            progressBar.Style = ProgressBarStyle.Continuous;

            ShowPrcOutput(output);
        }

        private async void uninstallAppButton_Click(object sender, EventArgs e)
        {
            if (m_combo.SelectedIndex == -1)
            {
                FlexibleMessageBox.Show("Please select an app first");
                return;
            }

            ProcessOutput output = new ProcessOutput("", "");
            progressBar.Style = ProgressBarStyle.Marquee;

            string GameName = m_combo.SelectedItem.ToString();
            Thread t1 = new Thread(() =>
            {
                output += Sideloader.UninstallGame(GameName);
            });
            t1.Start();

            while (t1.IsAlive)
                await Task.Delay(100);

            showAvailableSpace();

            progressBar.Style = ProgressBarStyle.Continuous;
            m_combo.Items.RemoveAt(m_combo.SelectedIndex);
            ShowPrcOutput(output);
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
                    Sideloader.RecursiveOutput = new ProcessOutput("", "");
                    Sideloader.RecursiveSideload(dialog.FileName);
                });
                t1.IsBackground = true;
                t1.Start();
                while (t1.IsAlive)
                    await Task.Delay(100);
                showAvailableSpace();

                ShowPrcOutput(Sideloader.RecursiveOutput);
            }
        }

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
                    Sideloader.RecursiveOutput = new ProcessOutput("", "");
                    Sideloader.RecursiveCopyOBB(dialog.FileName);
                });
                t1.IsBackground = true;
                t1.Start();

                showAvailableSpace();

                while (t1.IsAlive)
                    await Task.Delay(100);

                ShowPrcOutput(Sideloader.RecursiveOutput);
            }
        }

        private async void Form1_DragDrop(object sender, DragEventArgs e)
        {
            ADB.WakeDevice();
            ProcessOutput output = new ProcessOutput("", "");
            ADB.DeviceID = GetDeviceID();
            progressBar.Style = ProgressBarStyle.Marquee;
            Thread t1 = new Thread(() =>
            {
                string[] datas = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string data in datas)
                {
                    //if is directory
                    if (Directory.Exists(data))
                    {
                        output += ADB.CopyOBB(data);
                        if (File.Exists($"{data}\\install.txt"))
                        {
                            Sideloader.RunADBCommandsFromFile($"{data}\\install.txt", data);
                        }
                        string[] files = Directory.GetFiles(data);
                        foreach (string file in files)
                        {
                            if (File.Exists(file))
                                if (file.EndsWith(".apk"))
                                    output += ADB.Sideload(file);
                        }
                        string[] folders = Directory.GetDirectories(data);
                        foreach (string folder in folders)
                        {
                            output += ADB.CopyOBB(folder);
                        }
                    }
                    //if it's a file
                    else if (File.Exists(data))
                    {
                        string extension = Path.GetExtension(data);
                        if (extension == ".apk")
                        {
                            output += ADB.Sideload(data);
                        }
                        else if (extension == ".obb")
                        {
                            string filename = Path.GetFileName(data);
                            string foldername = filename.Substring(filename.IndexOf('.') + 1);
                            foldername = foldername.Substring(foldername.IndexOf('.') + 1);
                            foldername = foldername.Replace(".obb", "");
                            foldername = Environment.CurrentDirectory + "\\" + foldername;
                            Directory.CreateDirectory(foldername);
                            Console.WriteLine($"filename: {filename} foldername: {foldername} all: {Environment.CurrentDirectory + "\\" + foldername}");
                            File.Copy(data, foldername + "\\" + filename);
                            output += ADB.CopyOBB(foldername);
                            Directory.Delete(foldername, true);
                        }

                        if (extension == ".txt")
                        {
                            Sideloader.RunADBCommandsFromFile(data, Environment.CurrentDirectory);
                        }
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

            ShowPrcOutput(output);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            DragDropLbl.Visible = true;
            DragDropLbl.Text = "Drag apk or obb";
            ChangeTitle(DragDropLbl.Text);
            ProgressText.Text = $"{DragDropLbl.Text}";
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            DragDropLbl.Visible = false;
        }

        private void initListView()
        {
            gamesListView.Items.Clear();
            gamesListView.Columns.Clear();

            foreach (string column in SideloaderRCLONE.gameProperties)
            {
                gamesListView.Columns.Add(column, 150);
            }

            foreach (string[] release in SideloaderRCLONE.games)
            {
                ListViewItem Game = new ListViewItem(release);

                foreach (string packagename in Sideloader.InstalledPackageNames)
                {
                    if (string.Equals(release[SideloaderRCLONE.PackageNameIndex], packagename))
                    {
                        Game.BackColor = Color.Green;
                        string InstalledVersionCode = ADB.RunAdbCommandToString($"shell \"dumpsys package {packagename} | grep versionCode\"").Output;
                        try
                        {
                            InstalledVersionCode = Utilities.StringUtilities.RemoveEverythingBeforeFirst(InstalledVersionCode, "versionCode=");
                            InstalledVersionCode = Utilities.StringUtilities.RemoveEverythingAfterFirst(InstalledVersionCode, " ");
                            ulong installedVersionInt = UInt64.Parse(Utilities.StringUtilities.KeepOnlyNumbers(InstalledVersionCode));
                            ulong cloudVersionInt = UInt64.Parse(Utilities.StringUtilities.KeepOnlyNumbers(release[SideloaderRCLONE.VersionCodeIndex]));
                            //Logger.Log($"Checked game {release[SideloaderRCLONE.GameNameIndex]}; cloudversion={cloudVersionInt} localversion={installedVersionInt}");
                            if (installedVersionInt < cloudVersionInt)
                            {
                                Game.BackColor = Color.FromArgb(102, 77, 0);
                            }
                        }
                        catch (Exception ex) { Game.BackColor = Color.FromArgb(121,25,194);
                            Logger.Log($"An error occured while rendering game {release[SideloaderRCLONE.GameNameIndex]} in ListView");
                            ADB.RunAdbCommandToString($"shell \"dumpsys package {packagename}\"");
                            Logger.Log($"ExMsg: {ex.Message}Installed:\"{InstalledVersionCode}\" Cloud:\"{Utilities.StringUtilities.KeepOnlyNumbers(release[SideloaderRCLONE.VersionCodeIndex])}\"");
                        }
                    }
                }

                gamesListView.Items.Add(Game);
            }
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() =>
            {
                if (!debugMode && Properties.Settings.Default.checkForUpdates)
                {
                    Updater.AppName = "AndroidSideloader";
                    Updater.Repostory = "nerdunit/androidsideloader";
                    Updater.Update();
                }
                progressBar.Invoke(() => { progressBar.Style = ProgressBarStyle.Marquee; });
                ChangeTitle("Rookie's Sideloader | Initializing Mirrors");
                ProgressText.Text = "Initializing mirrors...";
                initMirrors(true);
                ChangeTitle("Rookie's Sideloader | Initializing Games");
                ProgressText.Text = "Initializing games...";
                SideloaderRCLONE.initGames(currentRemote);
                if (!Directory.Exists(SideloaderRCLONE.ThumbnailsFolder) || !Directory.Exists(SideloaderRCLONE.NotesFolder))
                {
                    MessageBox.Show("It seems you are missing the thumbnails and/or notes database, the first start of the sideloader takes a bit more time, so dont worry if it looks stuck!");
                }
                ChangeTitle("Rookie's Sideloader | Syncing Game Photos");
                ProgressText.Text = "Syncing release photos...";
                SideloaderRCLONE.UpdateGamePhotos(currentRemote);
                ChangeTitle("Rookie's Sideloader |  Syncing Release Notes");
                ProgressText.Text = "Syncing release notes...";
                SideloaderRCLONE.UpdateGameNotes(currentRemote);
                listappsbtn();
            });
            t1.SetApartmentState(ApartmentState.STA);
            t1.IsBackground = false;
            t1.Start();

            showAvailableSpace();

            intToolTips();

            while (t1.IsAlive)
                await Task.Delay(100);

            initListView();

            downloadInstallGameButton.Enabled = true;

            progressBar.Style = ProgressBarStyle.Continuous;
            isLoading = false;
            ProgressText.Text = "";
        }

        private void initMirrors(bool random)
        {
            int index = 0;
            remotesList.Invoke(() => { index = remotesList.SelectedIndex; remotesList.Items.Clear(); });

            string[] mirrors = RCLONE.runRcloneCommand("listremotes").Output.Split('\n');

            Logger.Log("Loaded following mirrors: ");
            int itemsCount = 0;
            foreach (string mirror in mirrors)
            {
                if (mirror.Contains("mirror"))
                {
                    Logger.Log(mirror.Remove(mirror.Length - 1));
                    remotesList.Invoke(() => { remotesList.Items.Add(mirror.Remove(mirror.Length - 1)); });
                    itemsCount++;
                }
            }

            if (itemsCount > 0)
            {
                var rand = new Random();
                if (random == true)
                    index = rand.Next(0, itemsCount);
                else if (index > itemsCount)
                    index = 0;
                remotesList.Invoke(() =>
                {
                    remotesList.SelectedIndex = index;
                    currentRemote = remotesList.SelectedItem.ToString();
                });
            }
        }

        public static string processError = string.Empty;

        public static string currentRemote = string.Empty;

        private string wrDelimiter = "-------";

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
 - Thanks to pmow for all of his work, including rclone, wonka and other projects, and for scripting the backend
without him none of this would be possible
 - Thanks to the data team, they know who they are ;) (Especially HarryEffingPotter, no he did not put this here himself, that is perposterous.)
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

        private void userjsonButton_Click(object sender, EventArgs e)
        {
            UsernameForm form = new UsernameForm();
            form.Show();
        }

        private async void listApkButton_Click(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            isLoading = true;

            progressBar.Style = ProgressBarStyle.Marquee;

            devicesbutton_Click(sender, e);

            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("Mirrors");
                initMirrors(false);
                Console.WriteLine("Games");
                SideloaderRCLONE.initGames(currentRemote);
                Console.WriteLine("List apps");
                listappsbtn();
            });
            t1.IsBackground = true;
            t1.Start();
            while (t1.IsAlive)
                await Task.Delay(100);
            initListView();
            progressBar.Style = ProgressBarStyle.Continuous;
            isLoading = false;
        }

        private static readonly HttpClient client = new HttpClient();

        private bool updatedConfig = false;

        private bool gamesAreDownloading = false;
        private List<string> gamesQueueList = new List<string>();
        private List<string> gamesToAddList = new List<string>();
        private int quotaTries = 0;

        public void SwitchMirrors()
        {
            quotaTries++;
            remotesList.Invoke(() => {
                if (quotaTries > remotesList.Items.Count)
                {
                    FlexibleMessageBox.Show("Quota reached for all mirrors exiting program...");
                    Application.Exit();
                }
                if (remotesList.Items.Count > remotesList.SelectedIndex)
                    remotesList.SelectedIndex++;
                else
                    remotesList.SelectedIndex = 0;
            });
        }

        private async void downloadInstallGameButton_Click(object sender, EventArgs e)
        {
            long selectedGamesSize = 0;
            int count = 0;
            string[] GameSizeGame = new string[1];
            if (gamesToAddList.Count > 0)
            {
                count = gamesToAddList.Count;
                GameSizeGame = new string[count];
                for (int i = 0; i < count; i++)
                    GameSizeGame[i] = gamesToAddList[i];
            }
            else if (gamesListView.SelectedItems.Count > 0)
            {
                count = gamesListView.SelectedItems.Count;
                GameSizeGame = new string[count];
                for (int i = 0; i < count; i++)
                    GameSizeGame[i] = gamesListView.SelectedItems[i].SubItems[SideloaderRCLONE.ReleaseNameIndex].Text;
            }
            else return;

            bool HadError = false;
            Thread gameSizeThread = new Thread(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    selectedGamesSize += SideloaderRCLONE.GetFolderSize(GameSizeGame[i], currentRemote);
                    if (selectedGamesSize == 0)
                    {
                        FlexibleMessageBox.Show($"Couldnt find release {GameSizeGame[i]} on rclone, please deselect and try again or switch mirrors");
                        HadError = true;
                        return;
                    }
                }

            });
            gameSizeThread.Start();

            while (gameSizeThread.IsAlive)
                await Task.Delay(100);

            if (HadError)
                return;

            DialogResult dialogResult = FlexibleMessageBox.Show($"Are you sure you want to download the selected game(s)? The size is {String.Format("{0:0.00}", (double)selectedGamesSize)} MB", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            //Add games to the queue
            if (gamesToAddList.Count > 0)
                gamesQueueList.AddRange(gamesToAddList);
            else
            {
                for (int i = 0; i < gamesListView.SelectedItems.Count; i++)
                    gamesQueueList.Add(gamesListView.SelectedItems[i].SubItems[SideloaderRCLONE.ReleaseNameIndex].Text);
            }
            gamesToAddList.Clear();
            gamesQueListBox.DataSource = null;
            gamesQueListBox.DataSource = gamesQueueList;

            if (gamesAreDownloading)
                return;
            gamesAreDownloading = true;

            if (updatedConfig == false && Properties.Settings.Default.autoUpdateConfig == true) //check for config only once per program open and if setting enabled
            {
                updatedConfig = true;
                ChangeTitle("Rookie's Sideloader | Checking if config is updated and updating config");
                ProgressText.Text = "Updating config...";
                progressBar.Style = ProgressBarStyle.Marquee;
                await Task.Run(() => SideloaderRCLONE.updateConfig(currentRemote));
                progressBar.Style = ProgressBarStyle.Continuous;
                ProgressText.Text = "";
            }

            //Do user json on firsttime
            if (Properties.Settings.Default.userJsonOnGameInstall)
            {
                Thread userJsonThread = new Thread(() => { ChangeTitle("Rookie's Sideloader | Pushing user.json"); Sideloader.PushUserJsons(); });
                userJsonThread.IsBackground = true;
                userJsonThread.Start();

            }

            ProcessOutput output = new ProcessOutput("", "");

            while (gamesQueueList.Count > 0)
            {
                string gameName = gamesQueueList.ToArray()[0];

                string gameDirectory = Environment.CurrentDirectory + "\\" + gameName;
                Directory.CreateDirectory(gameDirectory);
                ProcessOutput gameDownloadOutput = new ProcessOutput("", "");

                Thread t1 = new Thread(() =>
                {
                    gameDownloadOutput = RCLONE.runRcloneCommand($"copy \"{currentRemote}:{SideloaderRCLONE.RcloneGamesFolder}/{gameName}\" \"{Environment.CurrentDirectory}\\{gameName}\" --progress --drive-acknowledge-abuse --rc", Properties.Settings.Default.BandwithLimit);

                    if (File.Exists($"{gameDirectory}\\install.txt"))
                        Sideloader.RunADBCommandsFromFile($"{gameDirectory}\\install.txt", gameDirectory);
                });
                t1.IsBackground = true;
                t1.Start();

                ChangeTitle("Rookie's Sideloader | Downloading game " + gameName, false);
                ProgressText.Text = "Downloading game...";

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
                if (gameDownloadOutput.Error.Length > 0)
                {
                    string err = gameDownloadOutput.Error.ToLower();
                    if (err.Contains("quota") && err.Contains("exceeded"))
                    {
                        FlexibleMessageBox.Show("The download Quota has been reached for this mirror, trying to switch mirrors...");
                        quotaError = true;

                        
                        SwitchMirrors();

                        gamesQueueList.RemoveAt(0);
                        gamesQueListBox.DataSource = null;
                        gamesQueListBox.DataSource = gamesQueueList;
                    }
                    else if (!gameDownloadOutput.Error.Contains("localhost")) FlexibleMessageBox.Show($"Rclone error: {gameDownloadOutput.Error}");
                }
                if (quotaError == false)
                {
                    ADB.DeviceID = GetDeviceID();
                    quotaTries = 0;
                    progressBar.Value = 0;
                    ChangeTitle("Rookie's Sideloader | Installing game apk " + gameName, false);
                    etaLabel.Text = "ETA: Wait for install...";
                    speedLabel.Text = "DLS: Done downloading";

                    string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\" + gameName);

                    Debug.WriteLine("Game Folder is: " + Environment.CurrentDirectory + "\\" + gameName);

                    Debug.WriteLine("FILES IN GAME FOLDER: ");
                    foreach (string file in files)
                    {
                        Debug.WriteLine(file);
                        string extension = Path.GetExtension(file);
                        if (extension == ".apk")
                        {
                            Thread apkThread = new Thread(() =>
                            {
                                if (Properties.Settings.Default.ResignAPKs)
                                {
                                    var rand = new Random();
                                    ChangeTitle($"Resigning {file}");
                                    ProgressText.Text = $"Resigning {file}";
                                    //spoofer.PackageName(file);
                                    output += spoofer.SpoofApk(file, spoofer.PackageName(file), "", Path.GetFileNameWithoutExtension(file) + "r.apk");

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

                    ChangeTitle("Rookie's Sideloader | Installing game obb " + gameName, false);
                    ProgressText.Text = "Installing game obb...";

                   string[] folders = Directory.GetDirectories(Environment.CurrentDirectory + "\\" + gameName);

                    foreach (string folder in folders)
                    {
                        string[] obbs = Directory.GetFiles(folder);

                        foreach (string currObb in obbs)
                        {
                            Thread obbThread = new Thread(() =>
                            {
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
                        ChangeTitle("Rookie's Sideloader | Deleting game files", false);
                        ProgressText.Text = "Deleting game files...";
                        try { Directory.Delete(Environment.CurrentDirectory + "\\" + gameName, true); } catch (Exception ex) { MessageBox.Show($"Error deleting game files: {ex.Message}"); }
                    }

                    //Remove current game
                    gamesQueueList.RemoveAt(0);
                    gamesQueListBox.DataSource = null;
                    gamesQueListBox.DataSource = gamesQueueList;
                    showAvailableSpace();
                }
            }
            etaLabel.Text = "ETA: Finished Queue";
            speedLabel.Text = "DLS: Finished Queue";
            await CheckForDevice();
            ChangeTitlebarToDevice();
            gamesAreDownloading = false;
            ProgressText.Text = "";
            ShowPrcOutput(output);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RCLONE.killRclone();
        }

        private void movieStreamButton_Click(object sender, EventArgs e)
        {
            if (movieStreamButton.Text == "Start Movie Stream")
            {
                Thread t1 = new Thread(() =>
                {
                    RCLONE.runRcloneCommand($"serve dlna {currentRemote}-movies:");
                });
                t1.IsBackground = true;
                t1.Start();

                ChangeTitle("Started Movie Stream! Default port is 25551");
                movieStreamButton.Text = "STOP Movie Stream";
            }
            else
            {
                try { RCLONE.killRclone(); } catch { }
                ChangeTitle("Stopped Movie Stream!");
                movieStreamButton.Text = "Start Movie Stream";
            }
        }

        private async void killRcloneButton_Click(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            RCLONE.killRclone();
            movieStreamButton.Text = "START MOVIE STREAM";
            ChangeTitle("Killed Rclone");
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
            QuestForm Form = new QuestForm();
            Form.Show();
        }

        private void SpoofFormButton_Click(object sender, EventArgs e)
        {
            SpoofForm Form = new SpoofForm();
            Form.Show();
        }

        private void ThemeChangerButton_Click(object sender, EventArgs e)
        {
            themeForm Form = new themeForm();
            Form.Show();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.gamesListView.Sort();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
        if (gamesListView.Items.Count>0)
            {
                ListViewItem foundItem = gamesListView.FindItemWithText(searchTextBox.Text, true, 0, true);
                if (foundItem != null)
                {
                    gamesListView.TopItem = foundItem;
                }
            }
        }

        private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gamesListView.SelectedItems.Count < 1)
                return;
            string CurrentPackageName = gamesListView.SelectedItems[gamesListView.SelectedItems.Count - 1].SubItems[SideloaderRCLONE.PackageNameIndex].Text;
            string CurrentReleaseName = gamesListView.SelectedItems[gamesListView.SelectedItems.Count - 1].SubItems[SideloaderRCLONE.ReleaseNameIndex].Text;

            string ImagePath = $"{SideloaderRCLONE.ThumbnailsFolder}\\{CurrentPackageName}.jpg";
            string NotePath = $"{SideloaderRCLONE.NotesFolder}\\{CurrentReleaseName}.txt";

            if (File.Exists(ImagePath))
                gamesPictureBox.BackgroundImage = Image.FromFile(ImagePath);
            else
                gamesPictureBox.BackgroundImage = new Bitmap(360, 203);

            if (File.Exists(NotePath))
                notesRichTextBox.Text = File.ReadAllText(NotePath);
            else
                notesRichTextBox.Text = "";
        }

        private void UpdateGamesButton_Click(object sender, EventArgs e)
        {
            string gamesToUpdate = "";
            foreach (string packagename in Sideloader.InstalledPackageNames)
            {
                foreach (var release in SideloaderRCLONE.games)
                {
                    if (string.Equals(release[SideloaderRCLONE.PackageNameIndex], packagename))
                    {
                        //only keep numbers from 0 to 9 remove everything else then try to compare
                        //FlexibleMessageBox.Show($"You have {packagename} installed on your device");
                        string InstalledVersionCode = ADB.RunAdbCommandToString($"shell \"dumpsys package {packagename} | grep versionCode\"").Output;
                        InstalledVersionCode = Utilities.StringUtilities.RemoveEverythingBeforeFirst(InstalledVersionCode, "versionCode=");
                        InstalledVersionCode = Utilities.StringUtilities.RemoveEverythingAfterFirst(InstalledVersionCode, " ");
                        ulong installedVersionInt = UInt64.Parse(Utilities.StringUtilities.KeepOnlyNumbers(InstalledVersionCode));
                        ulong cloudVersionInt = UInt64.Parse(Utilities.StringUtilities.KeepOnlyNumbers(release[SideloaderRCLONE.VersionCodeIndex]));

                        if (installedVersionInt < cloudVersionInt)
                        {
                            //games.Add(release[SideloaderRCLONE.ReleaseNameIndex]);
                            string IVC = InstalledVersionCode.Replace("versionCode=", "");
                            gamesToUpdate = $"{release[SideloaderRCLONE.GameNameIndex]} is outdated, you have version {IVC} while version {release[SideloaderRCLONE.VersionCodeIndex]} is available\n{gamesToUpdate}";
                        }
                    }
                }
            }
            if (gamesToUpdate.Length > 0)
                FlexibleMessageBox.Show(gamesToUpdate);
            else
                FlexibleMessageBox.Show("All your games are up to date!");
        }

        private void gamesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gamesListView.SelectedItems.Count > 0)
                downloadInstallGameButton_Click(sender, e);
        }

        private void MountButton_Click(object sender, EventArgs e)
        {
            if (DeviceConnected)
                ADB.RunAdbCommandToString("shell svc usb setFunctions mtp true");
            else
                FlexibleMessageBox.Show("You must connect a device before mounting!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateGamesButton.PerformClick();
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