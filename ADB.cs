using System;
using System.Diagnostics;
using System.IO;
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
            if (DeviceID.Length > 1)
                command = $"{command}";

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
            adb.StandardInput.Close();


            string output = "";
            string error = "";

            try
            {
               
                output = adb.StandardOutput.ReadToEnd();
                error = adb.StandardError.ReadToEnd();


                if (output.Contains("reserved"))
                    output = "Install text - line success!\n";
                if (error.Contains("No such"))
                    error = "";
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
            RunAdbCommandToString("shell input keyevent KEYCODE_WAKEUP");
        }
        public static ProcessOutput Sideload(string path, string packagename = "")
        {

            WakeDevice();
            if (!string.IsNullOrEmpty(Properties.Settings.Default.IPAddress))
            {
                ADB.RunAdbCommandToString(Properties.Settings.Default.IPAddress);
            }
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


                    if (!string.IsNullOrEmpty(Properties.Settings.Default.IPAddress))
                    {
                        ADB.RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                    }

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
                        String CurrbackupPaths = CurrBackups + "\\" + date_str + "\\" + packagename + "\\data";
                        Directory.CreateDirectory(CurrbackupPaths);
                        ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data/{packagename}\" \"{CurrbackupPaths}\"");
                    }
                    else
                    {
                        MessageBox.Show($"No savedata found! Continue with the uninstall!", "None Found", MessageBoxButtons.OK);

                    }
                    ADB.WakeDevice();
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.IPAddress))
                    {
                        ADB.RunAdbCommandToString(Properties.Settings.Default.IPAddress);
                    }
                    ret += ADB.RunAdbCommandToString("shell pm uninstall " + packagename);
                    ret += RunAdbCommandToString($"install -g -r \"{path}\"");
                    return ret;
                }
                ret += RunAdbCommandToString($"install -g -r \"{path}\"");
            }
            if (File.Exists($"{Properties.Settings.Default.MainDir}\\Config.Json"))
            {
                Program.form.ChangeTitle("Pushing Custom QU s3 Patch JSON.");
                RunAdbCommandToString($"shell mkdir /sdcard/android/data/{packagename}");
                RunAdbCommandToString($"shell mkdir /sdcard/android/data/{packagename}/private");
                RunAdbCommandToString($"push \"{Properties.Settings.Default.MainDir}\\Config.Json\" /sdcard/android/data/{packagename}/private/Config.Json");
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
