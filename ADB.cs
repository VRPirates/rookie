using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;
using Newtonsoft.Json;

namespace AndroidSideloader
{


    class ADB
    {
        static Process adb = new Process();
        public static string adbFolderPath = "C:\\RSL\\2.8.2\\ADB";
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

                string logcmd = command;

                if (logcmd.Contains(Environment.CurrentDirectory))
                    logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
                Logger.Log($"Running command: {logcmd}");
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
            if (error.Contains("ADB_VENDOR_KEYS") && !Properties.Settings.Default.adbdebugwarned)
            {
                DialogResult dialogResult = FlexibleMessageBox.Show("Please check inside your headset for ADB DEBUGGING prompt, check box to \"Always allow from this computer.\" and hit OK.\nPlease note that even if you have done this\nbefore it will reset itself from time to time.\n\nPress CANCEL if you want to disable this prompt (FOR DEBUGGING ONLY, NOT RECOMMENDED).", "ADB Debugging not enabled.", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    Properties.Settings.Default.adbdebugwarned = true;
                    Properties.Settings.Default.Save();
                }
                else
                    ADB.WakeDevice();
            }
            if (error.Contains("not enough storage space"))
            {
                FlexibleMessageBox.Show("There is not enough room on your device to install this package. Please clear AT LEAST 2x the amount of the app you are trying to install.");
            }
            if (!output.Contains("version") && !output.Contains("KEYCODE_WAKEUP") && !output.Contains("Filesystem") && !output.Contains("package:") && !output.Equals(null))
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

            string logcmd = command;
            if (logcmd.Contains(Environment.CurrentDirectory))
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            Logger.Log($"Running command: {logcmd}");

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
                else
                    adb.WaitForExit();
            }
            else if (command.Contains("install"))
            {
                bool graceful = adb.WaitForExit(120000);
                if (!graceful)
                {
                    adb.Kill();
                }
                else
                    adb.WaitForExit();
            }
   
            if (error.Contains("ADB_VENDOR_KEYS") && Properties.Settings.Default.adbdebugwarned)
            {
                DialogResult dialogResult = FlexibleMessageBox.Show("Please check inside your headset for ADB DEBUGGING prompt, check box to \"Always allow from this computer.\" and hit OK.\nPlease note that even if you have done this\nbefore it will reset itself from time to time.\n\nPress CANCEL if you want to disable this prompt (FOR DEBUGGING ONLY, NOT RECOMMENDED).", "ADB Debugging not enabled.", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    Properties.Settings.Default.adbdebugwarned = true;
                    Properties.Settings.Default.Save();
                }
                else
                    ADB.WakeDevice();
            }
            Logger.Log(output);
            Logger.Log(error);
            return new ProcessOutput(output, error);
        }
        public static ProcessOutput RunCommandToString(string result, string path = "")
        {
            string command = result;
            Properties.Settings.Default.ADBFolder = adbFolderPath;
            Properties.Settings.Default.ADBPath = adbFilePath;
            Properties.Settings.Default.Save();

            string logcmd = command;
            if (logcmd.Contains(Environment.CurrentDirectory))
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            Logger.Log($"Running command: {logcmd}");
            adb.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
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
            
            if (error.Contains("ADB_VENDOR_KEYS") && Properties.Settings.Default.adbdebugwarned)
            {
                DialogResult dialogResult = FlexibleMessageBox.Show("Please check inside your headset for ADB DEBUGGING prompt, check box to \"Always allow from this computer.\" and hit OK.\nPlease note that even if you have done this\nbefore it will reset itself from time to time.\n\nPress CANCEL if you want to disable this prompt (FOR DEBUGGING ONLY, NOT RECOMMENDED).", "ADB Debugging not enabled.", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    Properties.Settings.Default.adbdebugwarned = true;
                    Properties.Settings.Default.Save();
                }
                else
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

        public static bool wirelessadbON;

        public static void WakeDevice()
        {
            string devicesout = RunAdbCommandToString("shell input keyevent KEYCODE_WAKEUP").Output;
            if (!devicesout.Contains("found") && !Properties.Settings.Default.nodevicemode)
            {
                if (wirelessadbON || !String.IsNullOrEmpty(Properties.Settings.Default.IPAddress))
                {
                    RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                    string response = RunAdbCommandToString(Properties.Settings.Default.IPAddress).Output;

                        if (response.Contains("cannot") || String.IsNullOrEmpty(response))
                        {
                            DialogResult dialogResult = FlexibleMessageBox.Show("RSL can't connect to your Quest IP, this is usually because you have rebooted your Quest or the Quest IP has changed. Set a static IP to prevent this in the future(recommended)!\n\n\nYES = Static IP is set, do not detect my IP again.\nNO = I have not set a static IP, detect my IP again.\nCANCEL = I want to disable Wireless ADB.", "DEVICE REBOOTED/IP HAS CHANGED!", MessageBoxButtons.YesNoCancel);
                            if (dialogResult == DialogResult.Cancel)
                            {
                                wirelessadbON = false;
                                Properties.Settings.Default.IPAddress = "";
                                Properties.Settings.Default.Save();


                            }
                            else if (dialogResult == DialogResult.Yes)
                            {
                                FlexibleMessageBox.Show("Connect your Quest to USB so we can reconnect to your saved IP address!");
                                RunAdbCommandToString("devices");
                                Thread.Sleep(250);
                                RunAdbCommandToString("disconnect");
                                Thread.Sleep(50);
                                RunAdbCommandToString("connect");
                                Thread.Sleep(50);
                                RunAdbCommandToString("tcpip 5555");
                                Thread.Sleep(500);
                                RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                                MessageBox.Show($"Connected! We can now automatically enable wake on wifi.\n(This makes it so Rookie can work wirelessly even if the device has entered \"sleep mode\" at extremely little battery cost (~1% per full charge))", "Enable Wake on Wifi?", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {

                                    RunAdbCommandToString("shell settings put global wifi_wakeup_available 1");
                                    RunAdbCommandToString("shell settings put global wifi_wakeup_enabled 1");
                                    Program.form.ChangeTitlebarToDevice();
                                    return;
                                }
                                if (dialogResult == DialogResult.No)
                                {

                                    Program.form.ChangeTitlebarToDevice();
                                    return;
                                }
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                FlexibleMessageBox.Show("You must repeat the entire connection process, press OK to begin.", "Reconfigure Wireless ADB", MessageBoxButtons.OK);
                                RunAdbCommandToString("devices");
                                RunAdbCommandToString("tcpip 5555");
                                FlexibleMessageBox.Show("Press OK to get your Quest's local IP address.", "Obtain local IP address", MessageBoxButtons.OK);
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
                                    FlexibleMessageBox.Show($"Your Quest's local IP address is: {IPaddr}\n\nPlease disconnect your Quest then wait 2 seconds.\nOnce it is disconnected hit OK", "", MessageBoxButtons.OK);
                                    Thread.Sleep(2000);
                                    ADB.RunAdbCommandToString(IPcmnd);
                                    Properties.Settings.Default.IPAddress = IPcmnd;
                                    Properties.Settings.Default.Save();

                                    MessageBox.Show($"Connected! We can now automatically enable wake on wifi.\n(This makes it so Rookie can work wirelessly even if the device has entered \"sleep mode\" at extremely little battery cost (~1% per full charge))", "Enable Wake on Wifi?", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {

                                        ADB.RunAdbCommandToString("shell settings put global wifi_wakeup_available 1");
                                        ADB.RunAdbCommandToString("shell settings put global wifi_wakeup_enabled 1");
                                        Program.form.ChangeTitlebarToDevice();
                                        return;
                                    }
                          
                                }

                            }
                        }
                    
                }
            }

        }


        public static ProcessOutput Sideload(string path, string packagename = "")
        {

            WakeDevice();
            ProcessOutput ret = new ProcessOutput();
            ret += RunAdbCommandToString($"install -g \"{path}\"");
            string out2 = ret.Output + ret.Error;
            if (out2.Contains("failed"))
            {
                string BackupFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Rookie Backups");
                Logger.Log(out2);
                if (out2.Contains("offline") && !Properties.Settings.Default.nodevicemode)
                {
                    DialogResult dialogResult2 = FlexibleMessageBox.Show("Device is offline. Press Yes to reconnect, or if you don't wish to connect and just want to download the game (requires unchecking \"Delete games after install\" from settings menu) then press No.", "Device offline.", MessageBoxButtons.YesNoCancel);
                    if (dialogResult2 == DialogResult.Yes)
                        ADB.WakeDevice();
                }
                if (out2.Contains($"INSTALL_FAILED_UPDATE_INCOMPATIBLE") || out2.Contains("INSTALL_FAILED_VERSION_DOWNGRADE") || out2.Contains("signatures do not match") || out2.Contains("failed to install"))
                {
                    ret.Error = string.Empty;
                    ret.Output = string.Empty;


                    FlexibleMessageBox.Show($"In place upgrade for {packagename} failed.  We will need to upgrade by uninstalling, and keeping savedata isn't guaranteed.  Continue?", "UPGRADE FAILED!", MessageBoxButtons.OKCancel);

                    string date_str = DateTime.Today.ToString("yyyy.MM.dd");
                    string CurrBackups = Path.Combine(BackupFolder, date_str);


                    FlexibleMessageBox.Show($"Searching for save files...", "Searching!", MessageBoxButtons.OK);
                    if (Directory.Exists($"/sdcard/Android/data/{packagename}"))
                    {
                        FlexibleMessageBox.Show($"Trying to backup save to Documents\\Rookie Backups\\{date_str}(YYYY.MM.DD)\\{packagename}", "Save files found", MessageBoxButtons.OK);
                        Directory.CreateDirectory(CurrBackups);
                        ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data/{packagename}\" \"{CurrBackups}\"");
                    }
                    else
                    {
                        DialogResult dialogResult = FlexibleMessageBox.Show($"No savedata found! Continue with the uninstall!", "None Found", MessageBoxButtons.OK);
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
            if (Properties.Settings.Default.QUturnedon)
            {
                if (gamenameforQU.Contains("-QU") || path.Contains("-QU"))
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
            }


            Program.form.ChangeTitle("");
            return ret;
        }

        public static ProcessOutput CopyOBB(string path)
        {
            WakeDevice();

            string folder = Path.GetFileName(path);
            if (!folder.Contains("+") && !folder.Contains("_") && folder.Contains("."))
            {
             return RunAdbCommandToString($"push \"{path}\" \"/sdcard/Android/obb\"");
            }
            return new ProcessOutput();
        }
    }
}
