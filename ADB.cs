using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AndroidSideloader
{


    class ADB
    {
        static Process adb = new Process();
        public static string adbFolderPath = "C:\\RSL\\2.1.1\\ADB";
        public static string adbFilePath = adbFolderPath + "\\adb.exe";
        public static string DeviceID = "";
        public static string package = "";
        public static ProcessOutput RunAdbCommandToString(string command)
        {
            Properties.Settings.Default.ADBFolder = adbFolderPath;
            Properties.Settings.Default.ADBPath = adbFilePath;
            Properties.Settings.Default.Save();
            if (DeviceID.Length > 1)
            {
                command = $" -s {DeviceID} {command}";
            }
            if (!command.Contains("dumpsys") && !command.Contains("shell pm list packages") && !command.Contains("KEYCODE_WAKEUP")) 
            {
                string loggedcommand = Utilities.StringUtilities.RemoveEverythingBeforeFirst(command, "adb.exe");
                Logger.Log($"Running command{loggedcommand}");
            }
            adb.StartInfo.FileName = adbFilePath;
            adb.StartInfo.Arguments = command;
            adb.StartInfo.RedirectStandardError = true;
            adb.StartInfo.RedirectStandardInput = true;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = adbFolderPath;
            adb.Start();
            adb.StandardInput.WriteLine(command);
            adb.StandardInput.Flush();
            adb.StandardInput.Close();

            string output = "";
            string error = "";

            try
            {
                output = adb.StandardOutput.ReadToEnd();
                error = adb.StandardError.ReadToEnd();
            }
            catch { }
            if (command.Contains("connect"))
            {
                bool graceful = adb.WaitForExit(3000);  //Wait 3 secs.
                if (!graceful)
                {
                    adb.Kill();
                }
            }
            else
            adb.WaitForExit();
            if (error.Contains("ADB_VENDOR_KEYS"))
            {
                MessageBox.Show("Please check inside your headset for ADB DEBUGGING prompt, check box to \"Always allow from this computer.\" and hit OK.");
                ADB.WakeDevice();
            }
            if (error.Contains("not enough storage space"))
            {
                MessageBox.Show("There is not enough room on your device to install this package. Please clear AT LEAST 2x the amount of the app you are trying to install.");
            }
            if (!output.Contains("version") && !output.Contains("KEYCODE_WAKEUP") && !output.Contains("KEYCODE_WAKEUP") && !output.Contains("Filesystem") && !output.Contains("package:") && !output.Equals(null)) 
            Logger.Log(output);
            Logger.Log(error);
            return new ProcessOutput(output, error);
        }
        public static ProcessOutput RunAdbCommandToStringWOADB(string result, string path)
        {
            string command = result;
            Properties.Settings.Default.ADBFolder = adbFolderPath;
            Properties.Settings.Default.ADBPath = adbFilePath;
            Properties.Settings.Default.Save();
            



            Logger.Log($"Running command {command}");
            adb.StartInfo.FileName = "cmd.exe";
            adb.StartInfo.RedirectStandardError = true;
            adb.StartInfo.RedirectStandardInput = true;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
            adb.Start();
            adb.StandardInput.WriteLine(command);
            adb.StandardInput.Flush();
            adb.StandardInput.Close();


            string output = "";
            string error = "";

            try
            {
                output += adb.StandardOutput.ReadToEnd();
                error += adb.StandardError.ReadToEnd();
            }
            catch { }
            if (command.Contains("connect"))
            {
                bool graceful = adb.WaitForExit(3000); 
                if (!graceful)
                {
                    adb.Kill();
                }
            }
            else
                adb.WaitForExit();
            if (error.Contains("ADB_VENDOR_KEYS"))
            {
                MessageBox.Show("Please check inside your headset for ADB DEBUGGING prompt, check box to \"Always allow from this computer.\" and hit OK.");
                ADB.WakeDevice();
            }
            Logger.Log(output);
            Logger.Log(error);
            return new ProcessOutput(output, error);
        }
        public static ProcessOutput RunCommandToString(string result, string path)
        {
            string command = result;
            Properties.Settings.Default.ADBFolder = adbFolderPath;
            Properties.Settings.Default.ADBPath = adbFilePath;
            Properties.Settings.Default.Save();

            Logger.Log($"Running command {command}");
            adb.StartInfo.FileName = @"C:\windows\system32\cmd.exe";
            adb.StartInfo.Arguments = command;
            adb.StartInfo.RedirectStandardError = true;
            adb.StartInfo.RedirectStandardInput = true;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
            adb.Start();
            adb.StandardInput.WriteLine(command);
            adb.StandardInput.Flush();
            adb.StandardInput.Close();


            string output = "";
            string error = "";

            try
            {
                output += adb.StandardOutput.ReadToEnd();
                error += adb.StandardError.ReadToEnd();
            }
            catch { }
            if (command.Contains("connect"))
            {
                bool graceful = adb.WaitForExit(3000);
                if (!graceful)
                {
                    adb.Kill();
                }
            }
            else
                adb.WaitForExit();
            if (error.Contains("ADB_VENDOR_KEYS"))
            {
                MessageBox.Show("Please check inside your headset for ADB DEBUGGING prompt, check box to \"Always allow from this computer.\" and hit OK.");
                ADB.WakeDevice();
            }
            Logger.Log(output);
            Logger.Log(error);
            return new ProcessOutput(output, error);
        }


        public static ProcessOutput UninstallPackage(string package)
        {
            WakeDevice();
            ProcessOutput output = new ProcessOutput("", "");
            output += RunAdbCommandToString($"shell pm uninstall -k --user 0 {package}");
            output += RunAdbCommandToString($"shell pm uninstall {package}");
            return output;
        }

        public static string GetAvailableSpace()
        {
            long totalSize = 0;

            long usedSize = 0;

            long freeSize = 0;
            WakeDevice();
            var output = RunAdbCommandToString("shell df").Output.Split('\n');

            foreach (string currLine in output)
            {
                if (currLine.StartsWith("/data/media"))
                {
                    var foo = currLine.Split(' ');
                    int i = 0;
                    foreach (string curr in foo)
                    {
                        if (curr.Length > 1)
                        {
                            switch (i)
                            {
                                case 0:
                                    break;
                                case 1:
                                    totalSize = Int64.Parse(curr) / 1000;
                                    break;
                                case 2:
                                    usedSize = Int64.Parse(curr) / 1000;
                                    break;
                                case 3:
                                    freeSize = Int64.Parse(curr) / 1000;
                                    break;
                                default:
                                    break;
                            }
                            i++;
                        }
                    }
                }
            }

            return $"Total space: {String.Format("{0:0.00}", (double)totalSize / 1000)}GB\nUsed space: {String.Format("{0:0.00}", (double)usedSize / 1000)}GB\nFree space: {String.Format("{0:0.00}", (double)freeSize / 1000)}GB";
        }

        public static void WakeDevice()
        {
            string devicesout = RunAdbCommandToString("shell input keyevent KEYCODE_WAKEUP").Output;
            if (!devicesout.Contains("found"))
            {
                if (Properties.Settings.Default.IPAddress.Contains("connect"))
                {

                    RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                    string response = RunAdbCommandToString(Properties.Settings.Default.IPAddress).Output;

                    if (response.Contains("cannot") || String.IsNullOrEmpty(response))
                    {
                        DialogResult dialogResult = MessageBox.Show("Either your Quest is idle or you have rebooted the device.\nRSL's wireless ADB will persist on PC reboot but not on Quest reboot.\n\nNOTE: If you haven't rebooted your Quest it may be idle.\n\nTo prevent this press the HOLD button 2x prior to launching RSL. Or\nkeep your Quest plugged into power to keep it permanently \"awake\".\n\nHave you assigned your Quest a static IP in your router configuration?\n\nIf you no longer want to use Wireless ADB or your device was idle please hit CANCEL.", "DEVICE REBOOTED\\IDLE?", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Cancel)
                        {
                            DialogResult dialogResult2 = MessageBox.Show("Press OK to remove your stored IP address.\nIf your Quest went idle press the HOLD button on the device twice then press CANCEL to reconnect.", "REMOVE STORED IP?", MessageBoxButtons.OKCancel);
                            if (dialogResult2 == DialogResult.Cancel)
                                WakeDevice();
                            if (dialogResult2 == DialogResult.OK)
                            {
                                Properties.Settings.Default.IPAddress = "";
                                Properties.Settings.Default.Save();
                                WakeDevice();
                            }

                        }
                        else if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show("Connect your Quest to USB so we can reconnect to your saved IP address!");
                            RunAdbCommandToString("devices");
                            Thread.Sleep(250);
                            RunAdbCommandToString("disconnect");
                            Thread.Sleep(50);
                            RunAdbCommandToString("connect");
                            Thread.Sleep(50);
                            RunAdbCommandToString("tcpip 5555");
                            Thread.Sleep(500);
                            RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                            MessageBox.Show($"Connected! We can now automatically enable wake on wifi. This makes it so Rookie can work wirelessly even if the device has entered \"sleep mode\". This setting is NOT permanent and resets upon Quest reboot just like wireless ADB functionality.\n\n After testing with this setting off and on the difference in battery usage seems nonexistent. We recommend this setting for the majority of users for ease of use purposes. If you click NO you must keep your Quest connected to a charger OR wake your device and then put it back on hold before using Rookie wirelessly. Do you want to enable wake on wifi?", "Enable Wake on Wifi?", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                RunAdbCommandToString("shell settings put global wifi_wakeup_available 1");
                                RunAdbCommandToString("shell settings put global wifi_wakeup_enabled 1");
                            }
                            if (dialogResult == DialogResult.No)
                            {

                                Program.form.ChangeTitlebarToDevice();
                                return;
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("You must repeat the entire connection process, press OK to begin.", "Reconfigure Wireless ADB", MessageBoxButtons.OK);
                            RunAdbCommandToString("devices");
                            RunAdbCommandToString("tcpip 5555");
                            MessageBox.Show("Press OK to get your Quest's local IP address.", "Obtain local IP address", MessageBoxButtons.OK);
                            Thread.Sleep(1000);
                            string input = RunAdbCommandToString("shell ip route").Output;

                            Properties.Settings.Default.WirelessADB = true;
                            Properties.Settings.Default.Save();
                            string[] strArrayOne = new string[] { "" };
                            strArrayOne = input.Split(' ');
                            if (strArrayOne[0].Length > 7)
                            {
                                string IPaddr = strArrayOne[8];
                                string IPcmnd = "connect " + IPaddr + ":5555";
                                MessageBox.Show($"Your Quest's local IP address is: {IPaddr}\n\nPlease disconnect your Quest then wait 2 seconds.\nOnce it is disconnected hit OK", "", MessageBoxButtons.OK);
                                Thread.Sleep(2000);
                                ADB.RunAdbCommandToString(IPcmnd);
                                Properties.Settings.Default.IPAddress = IPcmnd;
                                Properties.Settings.Default.Save();

                                MessageBox.Show($"Connected! We can now automatically disable the Quest wifi chip from falling asleep. This makes it so Rookie can work wirelessly even if the device has entered \"sleep mode\". This setting is NOT permanent and resets upon Quest reboot, just like wireless ADB functionality.\n\nNOTE: This may cause the device battery to drain while it is in sleep mode at a very slightly increased rate. We recommend this setting for the majority of users for ease of use purposes. If you click NO you must keep your Quest connected to a charger or wake your device and then put it back on hold before using Rookie wirelessly. Do you want us to stop sleep mode from disabling wireless ADB?", "", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {

                                    ADB.RunAdbCommandToString("shell settings put global wifi_wakeup_available 1");
                                    ADB.RunAdbCommandToString("shell settings put global wifi_wakeup_enabled 1");
                                }
                                Program.form.ChangeTitlebarToDevice();
                            }

                        }
                    }

                }
            }
        }


        public static ProcessOutput Sideload(string path = "", string packagename = "")
        {

            WakeDevice();
            ProcessOutput ret = new ProcessOutput();
            Program.form.ChangeTitle($"Sideloading {Path.GetFileName(path)}");
            ret += RunAdbCommandToString($"install -g -r \"{path}\"");
            string out2 = ret.Output + ret.Error;
            if (out2.Contains("failed"))
            {
                string BackupFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Rookie Backups");
                if (out2.Contains("offline"))
                {
                    DialogResult dialogResult2 = MessageBox.Show("Device is offline. Press Yes to reconnect, or if you don't wish to connect and just want to download the game (requires unchecking \"Delete games after install\" from settings menu) then press No.", "Device offline.", MessageBoxButtons.YesNoCancel);
                    if (dialogResult2 == DialogResult.Yes)
                        ADB.WakeDevice();
                }
                if (out2.Contains($"INSTALL_FAILED_UPDATE_INCOMPATIBLE") || out2.Contains("INSTALL_FAILED_VERSION_DOWNGRADE"))
                {
                    ret.Error = string.Empty;
                    ret.Output = string.Empty;


                    MessageBox.Show($"In place upgrade for {packagename} failed.  We will need to upgrade by uninstalling, and keeping savedata isn't guaranteed.  Continue?", "UPGRADE FAILED!", MessageBoxButtons.OKCancel);

                    string date_str = DateTime.Today.ToString("yyyy.MM.dd");
                    string CurrBackups = Path.Combine(BackupFolder, date_str);


                    MessageBox.Show($"Searching for save files...", "Searching!", MessageBoxButtons.OK);
                    if (Directory.Exists($"/sdcard/Android/data/{packagename}"))
                    {
                        MessageBox.Show($"Trying to backup save to Documents\\Rookie Backups\\{date_str}(YYYY.MM.DD)\\{packagename}", "Save files found", MessageBoxButtons.OK);
                        Directory.CreateDirectory(CurrBackups);
                        ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data/{packagename}\" \"{CurrBackups}\"");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show($"No savedata found! Continue with the uninstall!", "None Found", MessageBoxButtons.OK);
                        if (dialogResult == DialogResult.Cancel) 
                        {
                            return ret;
                        }
                    }
                    ADB.WakeDevice();
                    ret += ADB.RunAdbCommandToString("shell pm uninstall " + package);
                    ret += RunAdbCommandToString($"install -g -r \"{path}\"");
                    return ret;
                }
                ret += RunAdbCommandToString($"install -g -r \"{path}\"");
            }
            string gamenameforQU = Sideloader.PackageNametoGameName(packagename); 
            if (File.Exists($"{Properties.Settings.Default.MainDir}\\Config.Json") && gamenameforQU.Contains("-QU") || path.Contains("-QU"))
            {
                string gameName = packagename;
                packagename = Sideloader.gameNameToPackageName(gameName);

                Program.form.ChangeTitle("Pushing Custom QU S3 Config.JSON.");
                    if (!Directory.Exists($"/sdcard/android/data/{packagename}"))
                        RunAdbCommandToString($"shell mkdir /sdcard/android/data/{packagename}");
                    if (!Directory.Exists($"/sdcard/android/data/{packagename}/private"))
                        RunAdbCommandToString($"shell mkdir /sdcard/android/data/{packagename}/private");

                    Random r = new Random();
                    int x = r.Next(999999999);
                    int y = r.Next(9999999);

                    var sum = ((long)y * (long)1000000000) + (long)x;

                    int x2 = r.Next(999999999);
                    int y2 = r.Next(9999999);

                    var sum2 = ((long)y2 * (long)1000000000) + (long)x2;
                    ADB.WakeDevice();
                    Properties.Settings.Default.QUStringF = $"{{\"user_id\":{sum},\"app_id\":\"{sum2}\",";
                    Properties.Settings.Default.Save();
                    string boff = Properties.Settings.Default.QUStringF + Properties.Settings.Default.QUString;
                    File.WriteAllText($"{Properties.Settings.Default.MainDir}\\config.json", boff);
                    string blank = "";
                    File.WriteAllText($"{Properties.Settings.Default.MainDir}\\delete_settings", blank);
                    ret += ADB.RunAdbCommandToString($"push \"{Properties.Settings.Default.MainDir}\\delete_settings\" /sdcard/android/data/{packagename}/private/delete_settings");
                    ret += ADB.RunAdbCommandToString($"push \"{Properties.Settings.Default.MainDir}\\config.json\" /sdcard/android/data/{packagename}/private/config.json");
            
        }
            Program.form.ChangeTitle("");
            return ret;
        }

        public static ProcessOutput CopyOBB(string path)
        {
            WakeDevice();
            if (Path.GetDirectoryName(path).Contains(".") && !Path.GetDirectoryName(path).Contains("_data") || path.Contains("."))
            {
                var ext = System.IO.Path.GetExtension(path);
                if (ext == String.Empty)
                    return RunAdbCommandToString($"push \"{path}\" \"/sdcard/Android/obb\"");
                else
                    return RunAdbCommandToString($"push \"{Path.GetDirectoryName(path)}\" /sdcard/Android/obb");
            }
            return new ProcessOutput();
        }
    }
}
