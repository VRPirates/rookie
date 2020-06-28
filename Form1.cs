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
using System.Security.Cryptography;
using System.Windows.Threading;
using System.Net;
using SergeUtils;
using JR.Utils.GUI.Forms;


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
        string result;
        string obbPath = "";
        string allText;

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

        public void changeStyle(int style)
        {

            if (progressBar1.InvokeRequired)
            {
                if (style == 1)
                    progressBar1.Invoke(new Action(() => progressBar1.Style = ProgressBarStyle.Marquee));
                else if (style == 0)
                    progressBar1.Invoke(new Action(() => progressBar1.Style = ProgressBarStyle.Continuous));
            }
            else if (style == 1)
                progressBar1.Style = ProgressBarStyle.Marquee;
            else
                progressBar1.Style = ProgressBarStyle.Continuous;


        }

        public void runAdbCommand(string command)
        {
            changeStyle(1);
            oldTitle = this.Text;
            changeTitle("Rookie's Sideloader | Running command " + command);
            
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

            changeTitle(oldTitle);
            changeStyle(0);
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
            if (allText.Length == 0)
                notify("Install Failed, apk may be corrupt");
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

            //Task.Delay(100).ContinueWith(t => Timer99.Start()); //Delete notification after 5 seconds
            await Task.Run(() => sideload(path));

            notify(allText);

        }

        private void devicesbutton_Click(object sender, EventArgs e)
        {
            runAdbCommand("devices");

            changeTitlebarToDevice();

            notify(allText);
        }

        public bool experimentalFeatureAccept(string message)
        {
            DialogResult dialogResult = FlexibleMessageBox.Show(new Form { TopMost = true }, message, "EXPERIMENTAL FEATURE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                return true;
            else return false;
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

                obbPath = dialog.FileName;
            }
            else return;

            await Task.Run(() => obbcopy(obbPath));

            notify(allText);
        }

        private void changeTitlebarToDevice()
        {
            if (line[1].Length > 1)
                this.Text = "Rookie Sideloader | Device Connected with ID | " + line[1].Replace("device", "");
            else
                this.Text = "Rookie Sideloader | No Device Connected";
        }

        //A lot of stuff to do when the form loads, centers the program, 
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            if (File.Exists(debugPath))
                File.Delete(debugPath); //clear debug.log each start
            if (Directory.Exists(adbPath)==false) //if there is no adb folder, download and extract
            {
                FlexibleMessageBox.Show("Please wait for the software to download and install the adb");
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
                    FlexibleMessageBox.Show("Cannot download adb because you are not connected to the internet! You can manually download the zip here https://github.com/nerdunit/androidsideloader/raw/master/adb.7z after downloading move it to " + Environment.CurrentDirectory + " and unarchive it");
                    StreamWriter sw = File.AppendText(debugPath);
                    sw.Write("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
                    sw.Write(ex.ToString() + "\n");
                    sw.Flush();
                    sw.Close();
                    Environment.Exit(600);
                }
                
            }

            if (debugMode==false)
                if (Properties.Settings.Default.checkForUpdates==true)
                    checkForUpdate();

            runAdbCommand("devices"); //check if there is any device connected
            changeTitlebarToDevice();

            if (line[1].Length > 1) //check for device connected
                if (Properties.Settings.Default.firstRun == true)
                {
                    MessageBox.Show("YOU CAN NOW DRAG AND DROP TO INSTALL APK'S AND OBB FOLDERS!");
                    Properties.Settings.Default.firstRun = false;
                    Properties.Settings.Default.Save();
                }

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
            ToolTip sideloadFolderToolTip = new ToolTip();
            sideloadFolderToolTip.SetToolTip(this.sideloadFolderButton, "Sideloads every apk from a folder");
            ToolTip uninstallAppToolTip = new ToolTip();
            uninstallAppToolTip.SetToolTip(this.uninstallAppButton, "Uninstalls selected app");
            ToolTip userjsonToolTip = new ToolTip();
            userjsonToolTip.SetToolTip(this.userjsonButton, "After you enter your username it will create an user.json file needed for some games");

        }
        void checkForUpdate()
        {
        try
            {
                string localVersion = "0.14HF1";
                HttpClient client = new HttpClient();
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
                runAdbCommand("pull " + '"' + "/sdcard/Android/data" + '"');
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
                runAdbCommand("push " + '"' + obbPath + '"' + " /sdcard/Android/");
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
                notify("Please select an app first");
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
                    //chk.CheckedChanged += new EventHandler(CheckBox_Checked);
                    Controls.Add(chk);
                    pos2 += 20;
                }
            }

            

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
            Thread t1 = new Thread(() =>
            {
                runAdbCommand("shell am start -n " + launchPackageTextBox.Text);
            });
            t1.IsBackground = true;
            t1.Start();
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
                    await Task.Run(() => sideload(files[i]));
                }
            }
            for (int i = 0; i < childDirectories.Length; i++)
            {
                recursiveSideload(childDirectories[i]);
            }
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            string about = @" - The icon of the app contains an icon made by icon8.com
 - Software orignally coded by rookie.lol#7897
 - Thanks to https://stackoverflow.com/users/57611/erike for the folder browser dialog code
 - Thanks to Serge Weinstock for developing SergeUtils, which is used to search the combo box
 - Thanks to Mike Gold https://www.c-sharpcorner.com/members/mike-gold2 for the scrollable message box";
            FlexibleMessageBox.Show(about);
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

        private void userjsonButton_Click(object sender, EventArgs e)
        {
            usernameForm usernameForm1 = new usernameForm();
            usernameForm1.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void copyBulkObbButton_Click(object sender, EventArgs e)
        {
            //bool result = experimentalFeatureAccept("THIS IS AN EXPERIMENTAL FEATURE AND MIGHT NOT WORK, DO YOU WANT TO CONTINUE?");
            //if (result == false)
            //    return;

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
            changeTitle("Checking hash of file " + file);
            changeStyle(1);

            await Task.Run(() => checkHashFunc(file));
            Clipboard.SetText(result);

            changeStyle(0);
            changeTitle(oldTitle);
            FlexibleMessageBox.Show("The selected file hash is " + result + " and it was copied to clipboard");
        }

        public async void checkHashFunc(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                result = BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        private async void Form1_DragDrop(object sender, DragEventArgs e)
        {
            bool ok = false;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                Console.WriteLine(file);
                string extension = Path.GetExtension(file);
                if (extension == ".apk")
                {
                    ok = true;
                    await Task.Run(() => sideload(file));
                }
                else if (Directory.Exists(file))
                {
                    ok = true;
                    await Task.Run(() => obbcopy(file));
                }
            }
            DragDropLbl.Visible = false;
            if (ok)
                notify("Done");
        }
        string oldTitle;
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            oldTitle = this.Text;
            DragDropLbl.Visible = true;
            DragDropLbl.Text = "Drag apk or obb";
            changeTitle(DragDropLbl.Text);
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            changeTitle(oldTitle);
            DragDropLbl.Visible = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Timer99.Start();
        }

        private void donateButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://steamcommunity.com/tradeoffer/new/?partner=189719028&token=qCee3jwp");
            notify("Donate steam stuff to me if you want, my trade link has been copied to your clipboard");
        }
    }

    public class MethodItem
    {
        public string Name { get; set; }
        public StringMatchingMethod Value { get; set; }
    }
}
