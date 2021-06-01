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
        public static string adbFolderPath = Environment.CurrentDirectory + "\\adb";
        public static string adbFilePath = adbFolderPath + "\\adb.exe";
        public static string DeviceID = "";

        public static ProcessOutput RunAdbCommandToString(string command)
        {
            if (DeviceID.Length > 1)
                command = $" -s {DeviceID} {command}";

            Logger.Log($"Running command {command}");
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

            adb.WaitForExit();
            Logger.Log(output);
            Logger.Log(error);
            return new ProcessOutput(output, error);
        }
        public static ProcessOutput RunAdbCommandToStringWOADB(string result, string path)
        {

            string command = result;
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

            adb.WaitForExit();
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
            if (!string.IsNullOrEmpty(Properties.Settings.Default.IPAddress))
            {
                ADB.RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                string response = ADB.RunAdbCommandToString(Properties.Settings.Default.IPAddress).Output;
                if (response.Contains("refused"))
                {
                    DialogResult dialogResult = MessageBox.Show("It seems you have rebooted your Quest, Rookie's wireless ADB will persist past PC reboot, but not for Quest reboot.\n\nHave you assigned your Quest a static IP in your router configuration? If you no longer want to use Wireless ADB just hit cancel!", "DEVICE WAS REBOOTED", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Cancel)
                        return;
                    if (dialogResult == DialogResult.Yes)
                    {
                        ADB.WakeDevice();
                        MessageBox.Show("Connect your Quest to USB so we can reconnect to your saved IP address!");
                        ADB.RunAdbCommandToString("devices");
                        Thread.Sleep(250);
                        ADB.RunAdbCommandToString("disconnect");
                        Thread.Sleep(50);
                        ADB.RunAdbCommandToString("connect");
                        Thread.Sleep(50);
                        ADB.RunAdbCommandToString("tcpip 5555");
                        Thread.Sleep(500);
                        ADB.RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        ADB.WakeDevice();
                        MessageBox.Show("You must repeat the entire connection process, press OK to begin.", "Reconfigure Wireless ADB", MessageBoxButtons.OK);
                        ADB.RunAdbCommandToString("devices");
                        ADB.RunAdbCommandToString("tcpip 5555");
                        MessageBox.Show("Press OK to get your Quest's local IP address.", "Obtain local IP address", MessageBoxButtons.OK);
                        Thread.Sleep(1000);
                        string input = ADB.RunAdbCommandToString("shell ip route").Output;


                        string[] strArrayOne = new string[] { "" };
                        strArrayOne = input.Split(' ');
                        if (strArrayOne[0].Length > 7)
                        {
                            ADB.WakeDevice();
                            string IPaddr = strArrayOne[8];
                            string IPcmnd = "connect " + IPaddr + ":5555";
                            MessageBox.Show($"Your Quest's local IP address is: {IPaddr}\n\nPlease disconnect your Quest then wait 2 seconds.\nOnce it is disconnected hit OK", "", MessageBoxButtons.OK);
                            Thread.Sleep(2000);
                            ADB.RunAdbCommandToString(IPcmnd);
                            Properties.Settings.Default.IPAddress = IPcmnd;
                            Properties.Settings.Default.Save();

                            MessageBox.Show($"Connected!!", "", MessageBoxButtons.OK);
                            Program.form.ChangeTitlebarToDevice();
                        }
                        else
                        {
                            MessageBox.Show("No device connected!");
                        }

                    }

                }
            }
            RunAdbCommandToString("shell input keyevent KEYCODE_WAKEUP");
        }
        public static ProcessOutput Sideload(string path, string packagename = "")
        {

            WakeDevice();
  
            ProcessOutput ret = new ProcessOutput();
  
            Program.form.ChangeTitle($"Sideloading {path}");
            ret += RunAdbCommandToString($"install -g -r \"{path}\"");
            string out2 = ret.Output + ret.Error;
            if (out2.Contains("failed"))
            {
                string BackupFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Rookie Backups");
                if (out2.Contains("offline"))
                {
                    DialogResult dialogResult2 = MessageBox.Show("Device is offline. Press Yes to reconnect, or if you don't wish to connect and just want to download the game (we suggest unchecking delete games after install from settings menu) then press No.", "Device offline.", MessageBoxButtons.YesNoCancel);
                    if (dialogResult2 == DialogResult.Yes)
                        ADB.WakeDevice();
                }
                if (out2.Contains($"INSTALL_FAILED_UPDATE_INCOMPATIBLE") || out2.Contains("INSTALL_FAILED_VERSION_DOWNGRADE"))
                {
                    ret.Error = string.Empty;
                    ret.Output = string.Empty;


                    MessageBox.Show($"In-place upgrade for {packagename} failed.  We will need to upgrade by uninstalling, and keeping savedata isn't guaranteed.  Continue?", "UPGRADE FAILED!", MessageBoxButtons.OKCancel);

                    string date_str = DateTime.Today.ToString("yyyy.MM.dd");
                    string CurrBackups = Path.Combine(BackupFolder, date_str);


                    MessageBox.Show($"Searching for save files...", "Searching!", MessageBoxButtons.OK);
                    if (Directory.Exists($"/sdcard/Android/data/{packagename}"))
                    {
                        MessageBox.Show($"Trying to backup save to Documents\\Rookie Backups\\{date_str}(year.month.date)\\{packagename}\\data", "Save files found", MessageBoxButtons.OK);
                        Directory.CreateDirectory(CurrBackups);
                        String CurrbackupPaths = CurrBackups + "\\" + packagename + "\\data";
                        Directory.CreateDirectory(CurrbackupPaths);
                        ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data/{packagename} \" \"{CurrbackupPaths}\"");
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
                    ret += ADB.RunAdbCommandToString("shell pm uninstall " + packagename);
                    ret += RunAdbCommandToString($"install -g -r \"{path}\"");
                    return ret;
                }
                ret += RunAdbCommandToString($"install -g -r \"{path}\"");
            }
            if (File.Exists($"{Properties.Settings.Default.MainDir}\\Config.Json"))
            {
                if (packagename.Contains("com.*") || Properties.Settings.Default.CurrPckg.Contains("com"))
                {
                    if (Properties.Settings.Default.CurrPckg.Contains("com"))
                        packagename = Properties.Settings.Default.CurrPckg;
                    Program.form.ChangeTitle("Pushing Custom QU s3 Patch JSON.");
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
                    File.WriteAllText("config.json", boff);
                    string blank = "";
                    File.WriteAllText("delete_settings", blank);
                    ret += ADB.RunAdbCommandToString($"push \"{Environment.CurrentDirectory}\\delete_settings\" /sdcard/android/data/{packagename}/private/delete_settings");
                    ret += ADB.RunAdbCommandToString($"push \"{Environment.CurrentDirectory}\\config.json\" /sdcard/android/data/{packagename}/private/config.json");


                }
                else
                    ret.Output += "QU Settings could not be automatically applied.\nPlease restart Rookie to refresh installed apps.\nThen select the app from the installed apps (Dropdown list above Device ID).\nThen click Install QU Setting";


            
        }
            Program.form.ChangeTitle("Sideload done");
            return ret;
        }

        public static ProcessOutput CopyOBB(string path)
        {
            WakeDevice();
            if (SideloaderUtilities.CheckFolderIsObb(path))
                return RunAdbCommandToString($"push \"{path}\" /sdcard/Android/obb");
            return new ProcessOutput();
        }
    }
}
