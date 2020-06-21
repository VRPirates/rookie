using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Windows;
using System.Threading.Tasks;
using System.Net.Http;
using System.Timers;
using System.Reflection;
using System.Windows.Threading;
using System.Net;
using SergeUtils;


/* <a target="_blank" href="https://icons8.com/icons/set/van">Van icon</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
 * The icon of the app contains an icon made by icon8.com
 */

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
        int size;
        string allText;

        bool exit = false;
        public static string debugPath = "debug.log";
        public static string adbPath = Environment.CurrentDirectory + "\\adb\\";
        string[] line;
        public Form1()
        {
            InitializeComponent();

            Timer99.Tick += Timer99_Tick; // don't freeze the ui
            Timer99.Interval = new TimeSpan(0, 0, 0, 0, 1024);
            Timer99.IsEnabled = true;
            Timer99.Stop();
        }

        public void changeTitle(string txt)
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(() => this.Text = txt));
            else
                this.Text = txt;
        }

        public void runAdbCommand(string command)
        {
            string oldTitle = this.Text;
            changeTitle("Rookie's Sideloader | Running command " + command);
            
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

            changeTitle(oldTitle);
        }

        private void sideload(string path)
        {

            Thread t1 = new Thread(() =>
            {
                runAdbCommand("install -r " + '"' + path + '"');
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
            progressBar.Value = 0;
            FileInfo fi = new FileInfo(path);
            size = (int)fi.Length / 1024;
            progressBar.Maximum = size;

            Task.Delay(100).ContinueWith(t => Timer99.Start()); //Delete notification after 5 seconds
            await Task.Run(() => sideload(path));
            Timer99.Stop();
            progressBar.Value = size;

            notify(allText);

        }

        private void devicesbutton_Click(object sender, EventArgs e)
        {
            runAdbCommand("devices");

            changeTitlebarToDevice();

            notify(allText);
        }

        public static void notify(string message)
        {
            var notifyIcon = new System.Windows.Forms.NotifyIcon();
            //notifyIcon.Icon = System.Drawing.SystemIcons.Application;
            notifyIcon.Icon = System.Drawing.SystemIcons.Asterisk;
            notifyIcon.BalloonTipTitle = "AndroidSideloader";
            notifyIcon.BalloonTipText = message;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipClicked += (sender, e) => {
                Clipboard.SetText(message);
            };
            notifyIcon.ShowBalloonTip(3000);
            Task.Delay(5000).ContinueWith(t => notifyIcon.Dispose()); //Delete notification after 5 seconds
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

        private void obbcopy(string obbPath)
        {
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("push " + '"' + obbPath + '"' + " /sdcard/Android/obb");
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
                obbFile = files[0];
                obbPath = dialog.FileName;
            }
            else return;

            progressBar.Value = 0;
            FileInfo fi = new FileInfo(obbFile);
            size = (int)fi.Length / 1024;
            progressBar.Maximum = size;

            Task.Delay(100).ContinueWith(t => Timer99.Start()); //Delete notification after 5 seconds
            await Task.Run(() => obbcopy(obbPath));
            Timer99.Stop();
            progressBar.Value = size;

            notify(allText);
        }

        private void changeTitlebarToDevice()
        {
            if (line[1].Length > 1)
                this.Text = "Rookie Sideloader | Device Connected with ID | " + line[1].Replace("device", "");
            else
                this.Text = "Rookie Sideloader | No Device Connected";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (debugMode==true)
            {
                label.Visible = true;
                label1.Visible = true;
            }
            if (File.Exists(debugPath))
                File.Delete(debugPath);
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
                        client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/adb.7z", "adb.7z");
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
            runAdbCommand("devices");
            changeTitlebarToDevice();

            if (debugMode==false)
                checkForUpdate();
            intToolTips();

            listappsBtn();

        }
        void intToolTips()
        {
            ToolTip ListAppsToolTip = new ToolTip();
            ListAppsToolTip.SetToolTip(this.ListApps, "Shows what apps are installed in the list below (in the combo box)");
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
            ToolTip ListAppPermsToolTip = new ToolTip();
            ListAppPermsToolTip.SetToolTip(this.listApkPermsButton, "Lists the permissions for the selected apk");
            ToolTip ChangeAppPermsToolTip = new ToolTip();
            ChangeAppPermsToolTip.SetToolTip(this.changePermsBtn, "Applies the permissions for the apk, first press list app perms");
        }
        void checkForUpdate()
        {
            string localVersion = "0.9";
            HttpClient client = new HttpClient();
            string currentVersion = client.GetStringAsync("https://raw.githubusercontent.com/nerdunit/androidsideloader/master/version").Result;
            currentVersion = currentVersion.Remove(currentVersion.Length - 1);

            if (localVersion != currentVersion)
            {
                DialogResult dialogResult = MessageBox.Show("There is a new update, do you want to update?", "New version " + currentVersion + " available", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                    return;
                using (var fileClient = new WebClient())
                {
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    fileClient.DownloadFile("https://github.com/nerdunit/androidsideloader/releases/download/v" + currentVersion + "/AndroidSideloader.exe", "Android Sideloader v" + currentVersion + ".exe");
                }

                Process.Start(new ProcessStartInfo()
                {
                    Arguments = "/C choice /C Y /N /D Y /T 5 & Del \"" + Application.ExecutablePath + "\"",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "cmd.exe"
                });

                Process.Start(Environment.CurrentDirectory + "\\Android Sideloader v" + currentVersion + ".exe");

                Environment.Exit(0);
                //MessageBox.Show("Your version is outdated, the latest version is " + currentVersion + " you can download it from https://github.com/nerdunit/", "OUTDATED");
            }
        }

        private void backup()
        {
            MessageBox.Show("Action Started, may take some time...");
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("pull " + '"' + "/sdcard/Android/data" + '"');
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void backupbutton_Click(object sender, EventArgs e)
        {
            if (exit==false)
            {
                MessageBox.Show("Finish Previous action first!");
                return;
            }

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
                runAdbCommand("push " + '"' + obbPath + '"' + " /sdcard/Android/");
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void restorebutton_Click(object sender, EventArgs e)
        {
            if (exit == false)
            {
                MessageBox.Show("Finish Previous action first!");
                return;
            }

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

        private void customadbcmdbutton_Click(object sender, EventArgs e)
        {
            customAdbCommandForm adbCommandForm = new customAdbCommandForm();
            adbCommandForm.Show();
        }

        private void listapps()
        {
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell pm list packages");
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private void ListApps_Click(object sender, EventArgs e)
        {
            listappsBtn();
        }

        private async void listappsBtn()
        {
            allText = "";

            m_combo.Items.Clear();

            await Task.Run(() => listapps());
            
            foreach (string obj in line)
            {
                if (obj.Length>9)
                    m_combo.Items.Add(obj.Remove(0, 8));
            }
            m_combo.MatchingMethod = StringMatchingMethod.NoWildcards;
            //if (allText.Length > 0)
            //    MessageBox.Show("Fetched apks with success");
        }

        private void getapk(string package)
        {
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell pm path " + package);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private void pullapk(string apkPath)
        {
            Thread t2 = new Thread(() =>
            {
                runAdbCommand("pull " + apkPath);
            });
            t2.IsBackground = true;
            t2.Start();
            t2.Join();
        }

        private async void getApkButton_Click(object sender, EventArgs e)
        {
            if (m_combo.Items.Count == 0)
            {
                MessageBox.Show("Please select an app first");
                return;
            }

            string package = m_combo.SelectedItem.ToString().Remove(m_combo.SelectedItem.ToString().Length - 1);

            await Task.Run(() => getapk(package));

            allText = allText.Remove(allText.Length - 1);
            //MessageBox.Show(allText);

            string apkPath = allText.Remove(0, 8); //remove package:
            apkPath = apkPath.Remove(apkPath.Length - 1);

            await Task.Run(() => pullapk(apkPath));

            string currApkPath = apkPath;
            while (currApkPath.Contains("/"))
                currApkPath = currApkPath.Substring(currApkPath.IndexOf("/") + 1);

            if (File.Exists(Environment.CurrentDirectory + "\\" + package + ".apk"))
                File.Delete(Environment.CurrentDirectory + "\\" + package + ".apk");


            File.Move(Environment.CurrentDirectory + "\\adb\\" + currApkPath, Environment.CurrentDirectory + "\\" + package + ".apk");

            notify(allText);
        }

        private void listappperms(string package)
        {
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell dumpsys package " + package);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private async void listApkPermsButton_Click(object sender, EventArgs e)
        {
            if(m_combo.Items.Count == 0)
            {
                MessageBox.Show("Please select an app first");
                return;
            }

            string package = m_combo.SelectedItem.ToString().Remove(m_combo.SelectedItem.ToString().Length - 1);

            await Task.Run(() => listappperms(package));

            var grantedPerms = allText.Substring(allText.LastIndexOf("install permissions:") + 22);
            grantedPerms.Substring(0, grantedPerms.IndexOf("User 0:"));

            line = grantedPerms.Split('\n');

            int pos1 = 12;
            int pos2 = 187;


            for (int i=0; i< line.Length; i++)
            {
                if (line[i].Contains("android.permission."))
                {
                    CheckBox chk = new CheckBox();
                    if (line[i].Contains("true"))
                        chk.Checked = true;
                    else
                        chk.Checked = false;
                    line[i] = line[i].Substring(0, line[i].IndexOf(": granted"));
                    line[i] = line[i].Substring(line[i].LastIndexOf(" "));


                    chk.Location = new System.Drawing.Point(pos1, pos2);
                    chk.Width = 420;
                    chk.Height = 17;
                    chk.Text = line[i];
                    chk.CheckedChanged += new EventHandler(CheckBox_Checked);
                    Controls.Add(chk);
                    pos2 += 20;
                }
            }

            

        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {

        }

        private async void changePermsBtn_Click(object sender, EventArgs e)
        {
            if (m_combo.Items.Count == 0)
            {
                MessageBox.Show("Please select an app first");
                return;
            }

            string package = m_combo.SelectedItem.ToString().Remove(m_combo.SelectedItem.ToString().Length - 1);

            foreach (Control c in Controls)
            {
                if ((c is CheckBox))
                {
                    exit = false;
                    if (((CheckBox)c).Checked==true)
                    {
                        await Task.Run(() => changePerms(c, package, "grant"));
                    }
                    else
                    {
                        await Task.Run(() => changePerms(c, package, "revoke"));
                    }
                }
                
            }

            notify("Changed Permissions");

        }


        private void changePerms(Control c, string package, string grant)
        {
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell pm " + grant + " " + package + " " + c.Text);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private void launchApkButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell am start -n " + launchPackageTextBox.Text);
            });
            t1.IsBackground = true;
            t1.Start();

        }

        private bool checkForDevice()
        {
            return true;
        }

        private async void uninstallAppButton_Click(object sender, EventArgs e)
        {
            if (m_combo.Items.Count == 0)
            {
                MessageBox.Show("Please select an app first");
                return;
            }

            allText = "";
            string package = m_combo.SelectedItem.ToString().Remove(m_combo.SelectedItem.ToString().Length - 1);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to uninstall " + package + " this CANNOT be undone!", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;

            await Task.Run(() => uninstallPackage(package));

            notify(allText);
        }

        private void uninstallPackage(string package)
        {
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell pm uninstall -k --user 0 " + package);
            });
            t1.IsBackground = true;
            t1.Start();
            t1.Join();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MethodItem mi = (MethodItem)m_combo.SelectedItem;
            m_combo.MatchingMethod = mi.Value;
        }

        private async void sideloadFolderButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                Title = "Select your folder with APKs"
            };
            if (dialog.Show(Handle))
            {
                string[] files = Directory.GetFiles(dialog.FileName);
                foreach (string file in files)
                {
                    await Task.Run(() => sideload(file));
                }
            }
            else return;

            notify("Done Mass Sideloading");
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            string about = @" - The icon of the app contains an icon made by icon8.com
 - Software orignally coded by rookie.lol#7897
 - Thanks to https://stackoverflow.com/users/57611/erike for the folder browser dialog code
 - Thanks to Serge Weinstock for developing SergeUtils, it is used to search the combo box";
            MessageBox.Show(about);
        }


        /*Progress bar stuff
         * 
         */

        DispatcherTimer Timer99 = new DispatcherTimer();

        public PerformanceCounter myCounter =
            new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
        public PerformanceCounter myCounter2 =
    new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");

        public Int32 j = 0;
        public Int32 k = 0;
        public void Timer99_Tick(System.Object sender, System.EventArgs e)

        {
            //Console.Clear();
            j = Convert.ToInt32(myCounter.NextValue());
            j = j / 1024;
            k = Convert.ToInt32(myCounter2.NextValue());
            k = k / 1024;

            try { progressBar.Value += k*10; } catch { progressBar.Maximum = 100; progressBar.Value = 90; Timer99.Stop(); } //fake progress bar, for some reason performance counters are retarded or i am
            //Console.WriteLine(j);
            label.Text = "Read " + j.ToString();
            label1.Text = "Write " + k.ToString();
            
        }

        private void userjsonButton_Click(object sender, EventArgs e)
        {
            usernameForm usernameForm1 = new usernameForm();
            usernameForm1.Show();
        }
    }

    public class MethodItem
    {
        public string Name { get; set; }
        public StringMatchingMethod Value { get; set; }
    }
}
