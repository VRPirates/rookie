﻿using AndroidSideloader.Utilities;
using JR.Utils.GUI.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AndroidSideloader
{
    internal class ADB
    {
        private static readonly SettingsManager settings = SettingsManager.Instance;
        private static readonly Process adb = new Process();
        public static string adbFolderPath = Path.Combine(Environment.CurrentDirectory, "platform-tools");
        public static string adbFilePath = Path.Combine(adbFolderPath, "adb.exe");
        public static string DeviceID = "";
        public static string package = "";
        public static ProcessOutput RunAdbCommandToString(string command)
        {
            // Replacing "adb" from command if the user added it
            command = command.Replace("adb", "");

            settings.ADBFolder = adbFolderPath;
            settings.ADBPath = adbFilePath;
            settings.Save();
            if (DeviceID.Length > 1)
            {
                command = $" -s {DeviceID} {command}";
            }
            if (!command.Contains("dumpsys") && !command.Contains("shell pm list packages") && !command.Contains("KEYCODE_WAKEUP"))
            {
                string logcmd = command;

                if (logcmd.Contains(Environment.CurrentDirectory))
                {
                    logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
                }

                _ = Logger.Log($"Running command: {logcmd}");
            }

            using (Process adb = new Process())
            {
                adb.StartInfo.FileName = adbFilePath;
                adb.StartInfo.Arguments = command;
                adb.StartInfo.RedirectStandardError = true;
                adb.StartInfo.RedirectStandardOutput = true;
                adb.StartInfo.CreateNoWindow = true;
                adb.StartInfo.UseShellExecute = false;
                adb.StartInfo.WorkingDirectory = adbFolderPath;
                _ = adb.Start();

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
                    bool graceful = adb.WaitForExit(3000);
                    if (!graceful)
                    {
                        adb.Kill();
                        adb.WaitForExit();
                    }
                }

                if (error.Contains("ADB_VENDOR_KEYS") && !settings.AdbDebugWarned)
                {
                    ADBDebugWarning();
                }
                if (error.Contains("not enough storage space"))
                {
                    _ = FlexibleMessageBox.Show(Program.form, "There is not enough room on your device to install this package. Please clear AT LEAST 2x the amount of the app you are trying to install.");
                }
                if (!output.Contains("version") && !output.Contains("KEYCODE_WAKEUP") && !output.Contains("Filesystem") && !output.Contains("package:") && !output.Equals(null))
                {
                    _ = Logger.Log(output);
                }

                _ = Logger.Log(error, LogLevel.ERROR);
                return new ProcessOutput(output, error);
            }
        }

        public static ProcessOutput RunAdbCommandToStringWOADB(string result, string path)
        {
            string command = result;
            string logcmd = command;
            if (logcmd.Contains(Environment.CurrentDirectory))
            {
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            }

            _ = Logger.Log($"Running command: {logcmd}");

            adb.StartInfo.FileName = "cmd.exe";
            adb.StartInfo.RedirectStandardError = true;
            adb.StartInfo.RedirectStandardInput = true;
            adb.StartInfo.RedirectStandardOutput = true;
            adb.StartInfo.CreateNoWindow = true;
            adb.StartInfo.UseShellExecute = false;
            adb.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
            _ = adb.Start();
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
                    adb.WaitForExit();
                }
            }
            else if (command.Contains("connect"))
            {
                bool graceful = adb.WaitForExit(3000);
                if (!graceful)
                {
                    adb.Kill();
                    adb.WaitForExit();
                }
            }
            if (error.Contains("ADB_VENDOR_KEYS") && settings.AdbDebugWarned)
            {
                ADBDebugWarning();
            }
            _ = Logger.Log(output);
            _ = Logger.Log(error, LogLevel.ERROR);
            return new ProcessOutput(output, error);
        }
        public static ProcessOutput RunCommandToString(string result, string path = "")
        {
            string command = result;
            string logcmd = command;
            if (logcmd.Contains(Environment.CurrentDirectory))
            {
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            }

            Logger.Log($"Running command: {logcmd}");

            try
            {
                using (var adb = new Process())
                {
                    adb.StartInfo.FileName = $@"{Path.GetPathRoot(Environment.SystemDirectory)}\Windows\System32\cmd.exe";
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

                    string output = adb.StandardOutput.ReadToEnd();
                    string error = adb.StandardError.ReadToEnd();

                    if (command.Contains("connect"))
                    {
                        bool graceful = adb.WaitForExit(3000);
                        if (!graceful)
                        {
                            adb.Kill();
                            adb.WaitForExit();
                        }
                    }
                    else
                    {
                        adb.WaitForExit();
                    }

                    if (error.Contains("ADB_VENDOR_KEYS") && settings.AdbDebugWarned)
                    {
                        ADBDebugWarning();
                    }

                    if (error.Contains("Asset path") && error.Contains("is neither a directory nor file"))
                    {
                        Logger.Log("Asset path error detected. The specified path might not exist or be accessible.", LogLevel.WARNING);
                        // You might want to handle this specific error differently
                    }

                    Logger.Log(output);
                    Logger.Log(error, LogLevel.ERROR);

                    return new ProcessOutput(output, error);
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error in RunCommandToString: {ex.Message}", LogLevel.ERROR);
                return new ProcessOutput("", $"Exception occurred: {ex.Message}");
            }
        }

        public static void ADBDebugWarning()
        {
            Program.form.Invoke(() =>
            {
                DialogResult dialogResult = FlexibleMessageBox.Show(Program.form, "On your headset, click on the Notifications Bell, and then select the USB Detected notification to enable Connections.", "ADB Debugging not enabled.", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.Cancel)
                {
                    // settings.adbdebugwarned = true;
                    settings.Save();
                }
            });
        }

        public static ProcessOutput UninstallPackage(string package)
        {
            ProcessOutput output = new ProcessOutput("", "");
            output += RunAdbCommandToString($"shell pm uninstall {package}");
            return output;
        }

        public static string GetAvailableSpace()
        {
            long totalSize = 0;
            long usedSize = 0;
            long freeSize = 0;

            string[] output = RunAdbCommandToString("shell df").Output.Split('\n');

            foreach (string currLine in output)
            {
                if (currLine.StartsWith("/dev/fuse") || currLine.StartsWith("/data/media"))
                {
                    string[] foo = currLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (foo.Length >= 4)
                    {
                        totalSize = long.Parse(foo[1]) / 1000;
                        usedSize = long.Parse(foo[2]) / 1000;
                        freeSize = long.Parse(foo[3]) / 1000;
                        break; // Assuming we only need the first matching line
                    }
                }
            }

            return $"Total space: {string.Format("{0:0.00}", (double)totalSize / 1000)}GB\nUsed space: {string.Format("{0:0.00}", (double)usedSize / 1000)}GB\nFree space: {string.Format("{0:0.00}", (double)freeSize / 1000)}GB";
        }

        public static bool wirelessadbON;
        public static ProcessOutput Sideload(string path, string packagename = "")
        {
            ProcessOutput ret = new ProcessOutput();
            ret += RunAdbCommandToString($"install -g \"{path}\"");
            string out2 = ret.Output + ret.Error;
            if (out2.Contains("failed"))
            {
                _ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Rookie Backups");
                _ = Logger.Log(out2);
                if (out2.Contains("offline") && !settings.NodeviceMode)
                {
                    DialogResult dialogResult2 = FlexibleMessageBox.Show(Program.form, "Device is offline. Press Yes to reconnect, or if you don't wish to connect and just want to download the game (requires unchecking \"Delete games after install\" from settings menu) then press No.", "Device offline.", MessageBoxButtons.YesNoCancel);
                }
                if (out2.Contains($"signatures do not match previously") || out2.Contains("INSTALL_FAILED_VERSION_DOWNGRADE") || out2.Contains("signatures do not match") || out2.Contains("failed to install"))
                {
                    ret.Error = string.Empty;
                    ret.Output = string.Empty;
                    if (!settings.AutoReinstall)
                    {
                        bool cancelClicked = false;

                        if (!settings.AutoReinstall)
                        {
                            Program.form.Invoke((MethodInvoker)(() =>
                            {
                                DialogResult dialogResult1 = FlexibleMessageBox.Show(Program.form, "In place upgrade has failed. Rookie can attempt to backup your save data and reinstall the game automatically, however some games do not store their saves in an accessible location (less than 5%). Continue with reinstall?", "In place upgrade failed.", MessageBoxButtons.OKCancel);
                                if (dialogResult1 == DialogResult.Cancel)
                                    cancelClicked = true;
                            }));
                        }

                        if (cancelClicked)
                            return ret;
                    }

                    Program.form.changeTitle("Performing reinstall, please wait...");
                    _ = ADB.RunAdbCommandToString("kill-server");
                    _ = ADB.RunAdbCommandToString("devices");
                    _ = ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data/{MainForm.CurrPCKG}\" \"{Environment.CurrentDirectory}\"");
                    Program.form.changeTitle("Uninstalling game...");
                    _ = Sideloader.UninstallGame(MainForm.CurrPCKG);
                    Program.form.changeTitle("Reinstalling Game");
                    ret += ADB.RunAdbCommandToString($"install -g \"{path}\"");
                    _ = ADB.RunAdbCommandToString($"push \"{Environment.CurrentDirectory}\\{MainForm.CurrPCKG}\" /sdcard/Android/data/");
                    string directoryToDelete = Path.Combine(Environment.CurrentDirectory, MainForm.CurrPCKG);
                    if (Directory.Exists(directoryToDelete))
                    {
                        if (directoryToDelete != Environment.CurrentDirectory)
                        {
                            Directory.Delete(directoryToDelete, true);
                        }
                    }

                        Program.form.changeTitle(" \n\n");
                    return ret;
                }
            }

            Program.form.changeTitle(string.Empty);
            return ret;
        }

        public static ProcessOutput CopyOBB(string path)
        {
            string folder = Path.GetFileName(path);
            string lastFolder = Path.GetFileName(path);
            return folder.Contains(".")
                ? RunAdbCommandToString($"shell rm -rf \"/sdcard/Android/obb/{lastFolder}\" && mkdir \"/sdcard/Android/obb/{lastFolder}\"") + RunAdbCommandToString($"push \"{path}\" \"/sdcard/Android/obb\"")
                : new ProcessOutput("No OBB Folder found");
        }
    }
}
