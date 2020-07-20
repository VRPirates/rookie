using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Management;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Timers;
using System.Security.Cryptography;
using System.Windows.Threading;
using System.Net;
using SergeUtils;
using JR.Utils.GUI.Forms;
using Newtonsoft.Json;



/* <a target="_blank" href="https://icons8.com/icons/set/van">Van icon</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
 * The icon of the app contains an icon made by icon8.com
 */

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

        string obbPath = "";
        string allText;

        bool is1April = false;

        public static string debugPath = "debug.log";
        public static string adbPath = Environment.CurrentDirectory + "\\adb\\";
        string[] line;

        public Form1()
        {
            InitializeComponent();
            //calling the design to hide the pannels until onclick
            CustomizeDesign();


        }

        public void ChangeTitle(string txt)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => this.Text = txt));
            else
                this.Text = txt;
        }

        //adding the styling to the form
        private void CustomizeDesign()
        {
            sideloadContainer.Visible = false;
            backupContainer.Visible = false;
        }

        private void HideSubMenu()
        {
            if (sideloadContainer.Visible == true)
            {
                sideloadContainer.Visible = false;
            }
            if (backupContainer.Visible == true)
            {
                backupContainer.Visible = false;
            }
        }
        //does the fancy stuff
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

        public void ChangeStyle(int style)
        {
            if (style==1)
            {
                if (progressBar.InvokeRequired)
                {
                    progressBar.Invoke(new Action(() => progressBar.Style = ProgressBarStyle.Marquee));
                }
                else
                {
                    progressBar.Style = ProgressBarStyle.Marquee;
                }
            }
            else
            {
                if (progressBar.InvokeRequired)
                {
                    progressBar.Invoke(new Action(() => progressBar.Style = ProgressBarStyle.Continuous));
                }
                else
                {
                    progressBar.Style = ProgressBarStyle.Continuous;
                }
            }


        }

        public void RunAdbCommand(string command)
        {
            ChangeStyle(1);
            oldTitle = this.Text;
            ChangeTitle("Rookie's Sideloader | Running command " + command);

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

            ChangeTitle(oldTitle);
            ChangeStyle(0);
        }

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

        private void Sideload(string path)
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("install -g -d -r " + '"' + path + '"');
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void startsideloadbutton_Click(object sender, EventArgs e)
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
            AprilPrank();
            await Task.Run(() => Sideload(path));

            if (!is1April)
                notify(allText);
        }

        private void devicesbutton_Click(object sender, EventArgs e)
        {
            RunAdbCommand("devices");

            ChangeTitlebarToDevice();

            notify(allText);
        }

        public static void notify(string message)
        {
            if (Properties.Settings.Default.enableMessageBoxes == true)
            {
                FlexibleMessageBox.Show(new Form { TopMost = true, StartPosition = FormStartPosition.CenterScreen }, message);
                if (Properties.Settings.Default.copyMessageToClipboard == true)
                    Clipboard.SetText(message);
            }

        }

        public void ExtractFile(string sourceArchive, string destination)
        {
            ChangeStyle(1);
            oldTitle = this.Text;
            ChangeTitle("Rookie's Sideloader | Extracting archive " + sourceArchive);
            string zPath = "7z.exe"; //add to proj and set CopyToOuputDir
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.WindowStyle = ProcessWindowStyle.Hidden;
            pro.FileName = zPath;
            pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination);
            Process x = Process.Start(pro);
            x.WaitForExit();
            ChangeStyle(0);
            ChangeTitle(oldTitle);
        }

        private void obbcopy(string obbPath)
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("push " + '"' + obbPath + '"' + " /sdcard/Android/obb");
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void obbcopybutton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                Title = "Select your obb folder"
            };
            if (dialog.Show(Handle))
            {
                string[] files = Directory.GetFiles(dialog.FileName);

                obbPath = dialog.FileName;
            }
            else return;

            await Task.Run(() => obbcopy(obbPath));

            notify(allText);
        }

        private void ChangeTitlebarToDevice()
        {
            if (line[1].Length > 1)
                this.Text = "Rookie's Sideloader | Device Connected with ID | " + line[1].Replace("device", "");
            else
                this.Text = "Rookie's Sideloader | No Device Connected";
        }


        void downloadFiles()
        {
            using (var client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\warning.png"))
                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/secret", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\warning.png");

                if (!File.Exists(Environment.CurrentDirectory + "\\7z.exe"))
                {
                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.exe", "7z.exe");
                    client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.dll", "7z.dll");
                }

                if (!Directory.Exists(adbPath)) //if there is no adb folder, download and extract
                {
                    try
                    {
                        client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/adb.7z", "adb.7z");
                        ExtractFile(Environment.CurrentDirectory + "\\adb.7z", Environment.CurrentDirectory);
                        File.Delete("adb.7z");
                    }
                    catch (Exception ex)
                    {
                        FlexibleMessageBox.Show("Cannot download adb because you are not connected to the internet! You can manually download the zip here https://github.com/nerdunit/androidsideloader/raw/master/adb.7z after downloading move it to " + Environment.CurrentDirectory + " and unarchive it");
                        StreamWriter sw = File.AppendText(debugPath);
                        sw.Write("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
                        sw.Write(ex.ToString() + "\n");
                        sw.Flush();
                        sw.Close();
                        Environment.Exit(600);
                    }

                }

                if (!Directory.Exists(Environment.CurrentDirectory + "\\rclone"))
                {
                    string url;
                    if (Environment.Is64BitOperatingSystem)
                        url = "https://downloads.rclone.org/v1.52.2/rclone-v1.52.2-windows-amd64.zip";
                    else
                        url = "https://downloads.rclone.org/v1.52.2/rclone-v1.52.2-windows-386.zip";

                    client.DownloadFile(url, "rclone.zip");

                    ExtractFile(Environment.CurrentDirectory + "\\rclone.zip", Environment.CurrentDirectory);

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
        int TimerMs = 1024;
        void SetTimerSpeed()
        {

            var donators = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/donators.txt").Result.Split('\n');

            foreach (string line in donators)
            {
                if (line.Contains(HWID))
                {
                    TimerMs = Int32.Parse(line.Split(';')[1]);
                }
            }
        }

        //A lot of stuff to do when the form loads, centers the program, 
        private void Form1_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            SetTimerSpeed();

            etaLabel.Text = "";
            speedLabel.Text = "";

            if (File.Exists(debugPath))
                File.Delete(debugPath); //clear debug.log each start

            try { downloadFiles(); } catch { notify("You must have internet access for initial downloads, you can try:\n1. Disabling the firewall and antivirus\n2. Delete every file from the sideloader besides the .exe\n3. Try a vpn\n"); }

            if (debugMode == false)
                if (Properties.Settings.Default.checkForUpdates == true)
                    checkForUpdate();

            RunAdbCommand("devices"); //check if there is any device connected
            ChangeTitlebarToDevice();

            if (line[1].Length > 1) //check for device connected
                if (Properties.Settings.Default.firstRun == true)
                {
                    UsernameForm.createUserJson(randomString(16));
                    UsernameForm.pushUserJson();
                    UsernameForm.deleteUserJson();
                    Properties.Settings.Default.firstRun = false;
                    Properties.Settings.Default.Save();
                }

            intToolTips();

            listappsBtn();
        }
        readonly string localVersion = "1.5";
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
        void checkForUpdate()
        {
            try
            {

                string currentVersion = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
                currentVersion = currentVersion.Remove(currentVersion.Length - 1);

                if (localVersion != currentVersion)
                {
                    string changelog = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/changelog.txt").Result;
                    DialogResult dialogResult = FlexibleMessageBox.Show("There is a new update you have version " + localVersion + ", do you want to update?\nCHANGELOG\n" + changelog, "Version " + currentVersion + " is available", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes)
                        return;

                    //download updated version
                    using (var fileClient = new WebClient())
                    {
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        fileClient.DownloadFile("https://github.com/nerdunit/androidsideloader/releases/download/v" + currentVersion + "/AndroidSideloader.exe", "AndroidSideloader v" + currentVersion + ".exe");
                    }

                    //melt
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/C choice /C Y /N /D Y /T 5 & Del \"" + Application.ExecutablePath + "\"",
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    });

                    Process.Start(Environment.CurrentDirectory + "\\AndroidSideloader v" + currentVersion + ".exe");

                    Environment.Exit(0);
                }
            }
            catch
            {

            }
        }

        private void backup()
        {
            MessageBox.Show("Action Started, may take some time...");
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("pull " + '"' + "/sdcard/Android/data" + '"');
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void backupbutton_Click(object sender, EventArgs e)
        {

            await Task.Run(() => backup()); //we use async and await to not freeze the ui

            try
            {
                Directory.Move(adbPath + "data", Environment.CurrentDirectory + "\\data");
            }
            catch (Exception ex)
            {
                File.AppendAllText(debugPath, ex.ToString());
            }

            notify(allText);
        }

        private void restore()
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("push " + '"' + obbPath + '"' + " /sdcard/Android/");
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void restorebutton_Click(object sender, EventArgs e)
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
            await Task.Run(() => restore());

            notify(allText);
        }

        private void listapps()
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("shell pm list packages");
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        public async Task<string[]> getGames()
        {
            string command = "cat \"VRP:Quest Games/APK_packagenames.txt\" --config .\\a";


            Process cmd = new Process();
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
            var games =  getGames().Result;

            allText = "";

            m_combo.Items.Clear();

            await Task.Run(() => listapps());

            for (int  i= 0; i < line.Length; i++)
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
                            line[i] = foo[0];
                        }
                    }
                }
            }

            Array.Sort(line);

            foreach (string game in line)
            {
                if (game.Length > 0)
                    m_combo.Items.Add(game);
            }

            m_combo.MatchingMethod = StringMatchingMethod.NoWildcards;
        }

        private void getapk(string package)
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("shell pm path " + package);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private void pullapk(string apkPath)
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("pull " + apkPath);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void getApkButton_Click(object sender, EventArgs e)
        {


            if (m_combo.SelectedIndex == -1)
            {
                notify("Please select an app first");
                return;
            }

            var games = getGames().Result;

            string packageName = m_combo.SelectedItem.ToString();

            foreach (string game in games)
            {
                if (packageName.Length > 0 && game.Contains(packageName))
                {
                    var foo = game.Split(';');
                    packageName = foo[2];
                }
            }

            await Task.Run(() => getapk(packageName));

            allText = allText.Remove(allText.Length - 1);
            //MessageBox.Show(allText);

            string apkPath = allText.Remove(0, 8); //remove package:
            apkPath = apkPath.Remove(apkPath.Length - 1);

            await Task.Run(() => pullapk(apkPath));

            string currApkPath = apkPath;
            while (currApkPath.Contains("/"))
                currApkPath = currApkPath.Substring(currApkPath.IndexOf("/") + 1);

            if (File.Exists(Environment.CurrentDirectory + "\\" + packageName + ".apk"))
                File.Delete(Environment.CurrentDirectory + "\\" + packageName + ".apk");

            File.Move(Environment.CurrentDirectory + "\\adb\\" + currApkPath, Environment.CurrentDirectory + "\\" + packageName + ".apk");

            notify(allText);
        }

        private void launchApkButton_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("shell am start -n " + launchPackageTextBox.Text);
            });
            t1.IsBackground = true;
            t1.Start();
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        async Task<string> getpackagename()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            var games = getGames().Result;

            string packageName = m_combo.SelectedItem.ToString();

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
                MessageBox.Show("Please select an app first");
                return;
            }

            string packageName = await getpackagename();

            try
            {
                packageName = packageName.Split(';')[2];
            } catch { }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to uninstall " + packageName + ", this CANNOT be undone!", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            await Task.Run(() => uninstallPackage(packageName));

            var uninstallText = allText;

            await Task.Run(() => removeFolder("/sdcard/Android/obb/" + packageName));

            await Task.Run(() => removeFolder("/sdcard/Android/obb/" + packageName + "/"));

            uninstallText += allText;

            dialogResult = MessageBox.Show("Do you want to remove savedata for " + packageName + ", this CANNOT be undone!", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await Task.Run(() => removeFolder("/sdcard/Android/data/" + packageName + "/"));
                await Task.Run(() => removeFolder("/sdcard/Android/data/" + packageName));
            }

            notify(uninstallText);
        }

        void removeFolder(string path)
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("shell rm -r " + path);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private void uninstallPackage(string package)
        {
            Thread t1 = new Thread(() =>
            {
                RunAdbCommand("shell pm uninstall -k --user 0 " + package);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private void sideloadFolderButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                Title = "Select your folder with APKs"
            };
            if (dialog.Show(Handle))
            {
                recursiveSideload(dialog.FileName);
            }
            else return;

            notify("Done bulk sideloading");
        }

        private async void recursiveSideload(string location)
        {
            string[] files = Directory.GetFiles(location);
            string[] childDirectories = Directory.GetDirectories(location);
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                if (extension == ".apk")
                {
                    await Task.Run(() => Sideload(files[i]));
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

        DispatcherTimer Timer99 = new DispatcherTimer();

        public void Timer99_Tick(System.Object sender, System.EventArgs e)
        {
            var rnd = new Random();
            var redColor = System.Drawing.Color.FromArgb(rnd.Next(0,256), rnd.Next(0, 256), rnd.Next(0, 256));
            donateButton.BackColor = redColor;
        }

        private void copyBulkObbButton_Click(object sender, EventArgs e)
        {

            var dialog = new FolderSelectDialog
            {
                Title = "Select your folder with APKs"
            };
            if (dialog.Show(Handle))
            {
                recursiveCopy(dialog.FileName);
            }
            else return;
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
                        await Task.Run(() => obbcopy(files[i]));
                }
            }
            for (int i = 0; i < childDirectories.Length; i++)
            {
                recursiveCopy(childDirectories[i]);
            }
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task<string> checkHashFunc(string file)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        private async void Form1_DragDrop(object sender, DragEventArgs e)
        {
            AprilPrank();
            bool ok = false;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);
                if (extension == ".apk")
                {
                    ok = true;
                    await Task.Run(() => Sideload(file));
                }
                else if (Directory.Exists(file))
                {
                    ok = true;
                    await Task.Run(() => obbcopy(file));
                }
            }
            DragDropLbl.Visible = false;
            if (ok && !is1April)
                notify("Done");
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

        private void Form1_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine(TimerMs);
            Timer99.Tick += Timer99_Tick; // don't freeze the ui
            Timer99.Interval = new TimeSpan(0, 0, 0, 0, TimerMs);
            if (TimerMs != 0)
                Timer99.Start();

            DateTime today = DateTime.Today;

            if (today.Month == 4 && today.Day == 1)
                is1April = true;

            initGames();
        }
        string runRcloneCommand(string command)
        {
            wait = true;
            Process cmd = new Process();
            cmd.StartInfo.FileName = Environment.CurrentDirectory + "\\rclone\\rclone.exe";
            cmd.StartInfo.Arguments = command;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\rclone";
            cmd.StartInfo.CreateNoWindow = true;
            if (debugMode == true)
                cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();

            var output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            wait = false;
            return output;
        }
        void initGames()
        {

            gamesComboBox.Invoke(() => { gamesComboBox.Items.Clear(); });
            
            var games = runRcloneCommand("lsf --config .\\a --dirs-only \"VRP:Quest Games\" --drive-acknowledge-abuse").Split('\n');
            

            Debug.WriteLine("Loaded following games: ");
            foreach (string game in games)
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
            string about = $@"Finally {localVersion}
 - Software orignally coded by rookie.lol
 - Thanks to pmow for all of his work, including rclone, wonka and other projects
 - Thanks to flow for being friendly and helping every one
 - Thanks to succ for creating and maintaining the server
 - Thanks to badcoder5000 for redesigning the UI
 - Thanks to gotard for the theme changer
 - Thanks to 7zip team for 7zip :)
 - Thanks to rclone team for rclone :D
 - Thanks to https://stackoverflow.com/users/57611/erike for the folder browser dialog code
 - Thanks to Serge Weinstock for developing SergeUtils, which is used to search the combo box
 - Thanks to Mike Gold https://www.c-sharpcorner.com/members/mike-gold2 for the scrollable message box
 - Thanks to https://github.com/davcs86 for the hwid lib
 - The icon of the app contains an icon made by icon8.com";
            FlexibleMessageBox.Show(about);
        }

        bool wait;

        private async void checkHashButton_Click(object sender, EventArgs e)
        {
            string file;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    file = openFileDialog.FileName;
                else
                    return;
            }
            oldTitle = this.Text;
            ChangeTitle("Checking hash of file " + file);
            ChangeStyle(1);

            string hash = await checkHashFunc(file);
            Clipboard.SetText(hash);

            ChangeStyle(0);
            ChangeTitle(oldTitle);
            FlexibleMessageBox.Show("The selected file hash is " + hash + " and it was copied to clipboard");
        }

        private void userjsonButton_Click(object sender, EventArgs e)
        {
            UsernameForm form = new UsernameForm();
            form.Show();
        }
        public static readonly string HWID = UHWID.UHWIDEngine.SimpleUid;
        private void donateButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("rookie.lol#0001");
            notify("Ask rookie.lol#0001 or pmow#1706 where you can donate, hwid: " + HWID);
        }

        private async void listApkButton_Click(object sender, EventArgs e)
        {
            ChangeStyle(1);
            await Task.Run(() => initGames());
            ChangeStyle(0);

            listappsBtn();
        }

        private void troubleshootButton_Click(object sender, EventArgs e)
        {
            TroubleshootForm form = new TroubleshootForm();
            form.Show();
        }

        public string randomString(int length) //this is code from hidden tear lmao
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
            //string rcloneConfigPath = Environment.CurrentDirectory + "\\rclone\\a"; 

            //string localHash = await checkHashFunc(rcloneConfigPath);

            //string hash = runRcloneCommand("md5sum --config .\\a \"VRP:Quest Homebrew/Sideloading Methods/1. Rookie Sideloader - VRP Edition/a\"");
            //hash = hash.Substring(0, hash.LastIndexOf(" ")); //remove stuff after hash

            //Debug.WriteLine("The local file hash is " + localHash + " and the current a file hash is " + hash);

            //if (!string.Equals(localHash, hash))
            //{
                runRcloneCommand(string.Format("copy \"VRP:Quest Homebrew/Sideloading Methods/1. Rookie Sideloader - VRP Edition/a\" \"{0}\" --config .\\a", Environment.CurrentDirectory));
                File.Delete(Environment.CurrentDirectory + "\\rclone\\a");
                File.Move(Environment.CurrentDirectory + "\\a", Environment.CurrentDirectory + "\\rclone\\a");
            //}
        }
        private async void downloadInstallGameButton_Click(object sender, EventArgs e)
        {
            if (updatedConfig == false && Properties.Settings.Default.autoUpdateConfig == true) //check for config only once per program open and if setting enabled
            {
                ChangeTitle("Rookie's Sideloader | Updating rclone config");
                await Task.Run(() => updateConfig());
            }

            int apkNumber = 0;
            int obbNumber = 0;

            string gameName = gamesComboBox.SelectedItem.ToString();


            Directory.CreateDirectory(Environment.CurrentDirectory + "\\" + gameName);

            string[] games;

            Thread t1 = new Thread(() =>
            {
                games = runRcloneCommand("copy --config .\\a \"VRP:Quest Games/" + gameName + "\" \"" + Environment.CurrentDirectory + "\\" + gameName + "\" --progress --drive-acknowledge-abuse --rc").Split('\n');
            });
            t1.IsBackground = true;
            t1.Start();

            ChangeTitle("Rookie's Sideloader | Pushing user.json");

            UsernameForm.createUserJson(randomString(16));

            UsernameForm.pushUserJson();

            UsernameForm.deleteUserJson();

            ChangeTitle("Rookie's Sideloader | Downloading game " + gameName);

            await Task.Delay(5000);

            int i = 0;
            while (wait)
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
                catch { }
                
                await Task.Delay(1000);
            }

            progressBar.Value = 0;
            ChangeTitle("Rookie's Sideloader | Installing game apk " + gameName);
            etaLabel.Text = "ETA: Done";
            speedLabel.Text = "DLS: Done";
            
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
                    await Task.Run(() => Sideload(file));
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
                    await Task.Run(() => obbcopy(folder));
                }
            }

            if (Properties.Settings.Default.deleteAllAfterInstall)
            {
                ChangeTitle("Rookie's Sideloader | Deleting game files");
                Directory.Delete(Environment.CurrentDirectory + "\\" + gameName, true);
            }
            ChangeTitlebarToDevice();
            notify("Game downloaded and installed " + apkNumber + " apks and " + obbNumber + " obb folders");
            //Environment.CurrentDirectory + "\\" + gameName

        }

        private void themesbutton_Click(object sender, EventArgs e)
        {
            themeForm themeform1 = new themeForm();
            themeform1.Show();
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
