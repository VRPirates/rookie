﻿using AndroidSideloader.Utilities;
using JR.Utils.GUI.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace AndroidSideloader
{
    internal class RCLONE
    {
        private static readonly SettingsManager settings = SettingsManager.Instance;
        // Kill RCLONE Processes that were started from Rookie by looking for child processes.
        public static void killRclone()
        {
            var parentProcessId = Process.GetCurrentProcess().Id;
            var processes = Process.GetProcessesByName("rclone");

            foreach (var process in processes)
            {
                try
                {
                    using (ManagementObject obj = new ManagementObject($"win32_process.handle='{process.Id}'"))
                    {
                        obj.Get();
                        var ppid = Convert.ToInt32(obj["ParentProcessId"]);

                        if (ppid == parentProcessId)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception ex)
                {
                    _ = Logger.Log($"Exception occured while attempting to shut down RCLONE with exception message: {ex.Message}", LogLevel.ERROR);
                }
            }
        }

        // For custom configs that use a password
        public static void Init()
        {
            string PwTxtPath = Path.Combine(Environment.CurrentDirectory, "rclone\\pw.txt");
            if (File.Exists(PwTxtPath))
            {
                rclonepw = File.ReadAllText(PwTxtPath);
            }
        }

        // Change if you want to use a config
        public static string downloadConfigPath = "vrp.download.config";
        public static string uploadConfigPath = "vrp.upload.config";
        public static string rclonepw = "";


        private static readonly Process rclone = new Process();

        // Run an RCLONE Command that accesses the Download Config.
        public static ProcessOutput runRcloneCommand_DownloadConfig(string command)
        {
            if (MainForm.isOffline)
            {
                return new ProcessOutput("", "No internet");
            }

            ProcessOutput prcoutput = new ProcessOutput();
            // Rclone output is unicode, else it will show garbage instead of unicode characters
            rclone.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            string originalCommand = command;

            // set configpath if there is any
            if (downloadConfigPath.Length > 0)
            {
                command += $" --config {downloadConfigPath}";
            }

            command += $" --inplace";

            // set rclonepw
            if (rclonepw.Length > 0)
            {
                command += " --ask-password=false";
            }

            string logcmd = Utilities.StringUtilities.RemoveEverythingBeforeFirst(command, "rclone.exe");
            if (logcmd.Contains($"\"{settings.CurrentLogPath}\""))
            {
                logcmd = logcmd.Replace($"\"{settings.CurrentLogPath}\"", $"\"{settings.CurrentLogName}\"");
            }

            if (logcmd.Contains(Environment.CurrentDirectory))
            {
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            }

            _ = Logger.Log($"Running Rclone command: {logcmd}");

            rclone.StartInfo.FileName = Path.Combine(Environment.CurrentDirectory, "rclone", "rclone.exe");
            rclone.StartInfo.Arguments = command;
            rclone.StartInfo.RedirectStandardInput = true;
            rclone.StartInfo.RedirectStandardError = true;
            rclone.StartInfo.RedirectStandardOutput = true;
            rclone.StartInfo.WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "rclone");
            rclone.StartInfo.CreateNoWindow = true;
            // Display RCLONE Window if the binary is being run in Debug Mode.
            if (MainForm.debugMode)
            {
                rclone.StartInfo.CreateNoWindow = false;
            }
            rclone.StartInfo.UseShellExecute = false;
            _ = rclone.Start();
            rclone.StandardInput.WriteLine(command);
            rclone.StandardInput.Close();

            string output = rclone.StandardOutput.ReadToEnd();
            string error = rclone.StandardError.ReadToEnd();
            rclone.WaitForExit();

            if (error.Contains("There is not enough space"))
            {
                Program.form.Invoke(() =>
                {
                    _ = FlexibleMessageBox.Show(Program.form, $"There isn't enough disk space to download this game.\r\nPlease ensure you have at least 200MB more the game size available in {settings.DownloadDir} and try again.",
                                        "NOT ENOUGH SPACE",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                });
                return new ProcessOutput("Download failed.", "");
            }

            // Switch mirror upon matching error output.
            if (error.Contains("400 Bad Request") || error.Contains("cannot fetch token") || error.Contains("authError") || error.Contains("quota") || error.Contains("exceeded") || error.Contains("directory not found") || error.Contains("Failed to"))
            {
                string oldRemote = MainForm.currentRemote;
                bool retSM = false;
                try
                {
                    retSM = Program.form.SwitchMirrors();
                }
                catch
                {
                    return new ProcessOutput("All mirrors are on quota or down...", "All mirrors are on quota or down...");
                }
                if (retSM)
                {
                    prcoutput = runRcloneCommand_DownloadConfig(originalCommand.Replace(oldRemote, MainForm.currentRemote));
                }
            }
            else
            {
                prcoutput.Output = output;
                prcoutput.Error = error;
            }

            if (!output.Contains("Game Name;Release Name;") && !output.Contains("package:") && !output.Contains(".meta"))
            {
                if (!string.IsNullOrWhiteSpace(error))
                {
                    _ = Logger.Log($"Rclone error: {error}\n", LogLevel.ERROR);
                }

                if (!string.IsNullOrWhiteSpace(output))
                {
                    _ = Logger.Log($"Rclone Output: {output}");
                }
            }
            return prcoutput;
        }

        public static ProcessOutput runRcloneCommand_UploadConfig(string command)
        {
            ProcessOutput prcoutput = new ProcessOutput();
            // Rclone output is unicode, else it will show garbage instead of unicode characters
            rclone.StartInfo.StandardOutputEncoding = Encoding.UTF8;

            // set configpath if there is any
            if (uploadConfigPath.Length > 0)
            {
                command += $" --config {uploadConfigPath}";
            }

            string logcmd = Utilities.StringUtilities.RemoveEverythingBeforeFirst(command, "rclone.exe");
            if (logcmd.Contains($"\"{settings.CurrentLogPath}\""))
            {
                logcmd = logcmd.Replace($"\"{settings.CurrentLogPath}\"", $"\"{settings.CurrentLogName}\"");
            }

            if (logcmd.Contains(Environment.CurrentDirectory))
            {
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            }

            _ = Logger.Log($"Running Rclone command: {logcmd}");

            command += " --checkers 1 --retries 2 --inplace";

            rclone.StartInfo.FileName = Path.Combine(Environment.CurrentDirectory, "rclone", "rclone.exe");
            rclone.StartInfo.Arguments = command;
            rclone.StartInfo.RedirectStandardInput = true;
            rclone.StartInfo.RedirectStandardError = true;
            rclone.StartInfo.RedirectStandardOutput = true;
            rclone.StartInfo.WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "rclone");
            rclone.StartInfo.CreateNoWindow = true;
            // Display RCLONE Window if the binary is being run in Debug Mode.
            if (MainForm.debugMode)
            {
                rclone.StartInfo.CreateNoWindow = false;
            }
            rclone.StartInfo.UseShellExecute = false;
            _ = rclone.Start();
            rclone.StandardInput.WriteLine(command);
            rclone.StandardInput.Flush();
            rclone.StandardInput.Close();

            string output = rclone.StandardOutput.ReadToEnd();
            string error = rclone.StandardError.ReadToEnd();
            rclone.WaitForExit();

            // if there is one of these errors, we switch the mirrors
            if (error.Contains("400 Bad Request") || error.Contains("cannot fetch token") || error.Contains("authError") || error.Contains("quota") || error.Contains("exceeded") || error.Contains("directory not found") || error.Contains("Failed to"))
            {
                _ = Logger.Log(error, LogLevel.ERROR);
                return new ProcessOutput("Upload Failed.", "Upload failed.");
            }
            else
            {
                prcoutput.Output = output;
                prcoutput.Error = error;
            }

            if (!output.Contains("Game Name;Release Name;") && !output.Contains("package:") && !output.Contains(".meta"))
            {
                if (!string.IsNullOrWhiteSpace(error))
                {
                    _ = Logger.Log($"Rclone error: {error}\n", LogLevel.ERROR);
                }

                if (!string.IsNullOrWhiteSpace(output))
                {
                    _ = Logger.Log($"Rclone Output: {output}");
                }
            }
            return prcoutput;
        }

        public static ProcessOutput runRcloneCommand_PublicConfig(string command)
        {
            if (MainForm.isOffline)
            {
                return new ProcessOutput("", "No internet");
            }

            ProcessOutput prcoutput = new ProcessOutput();
            // Rclone output is unicode, else it will show garbage instead of unicode characters
            rclone.StartInfo.StandardOutputEncoding = Encoding.UTF8;

            string logcmd = Utilities.StringUtilities.RemoveEverythingBeforeFirst(command, "rclone.exe");
            if (logcmd.Contains($"\"{settings.CurrentLogPath}\""))
            {
                logcmd = logcmd.Replace($"\"{settings.CurrentLogPath}\"", $"\"{settings.CurrentLogName}\"");
            }

            if (logcmd.Contains(Environment.CurrentDirectory))
            {
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            }

            command += $" --inplace";

            _ = Logger.Log($"Running Rclone command: {logcmd}");

            //set http source & args
            command += $" --http-url {MainForm.PublicConfigFile.BaseUri} {MainForm.PublicMirrorExtraArgs}";
            rclone.StartInfo.FileName = Path.Combine(Environment.CurrentDirectory, "rclone", "rclone.exe");
            rclone.StartInfo.Arguments = command;
            rclone.StartInfo.RedirectStandardInput = true;
            rclone.StartInfo.RedirectStandardError = true;
            rclone.StartInfo.RedirectStandardOutput = true;
            rclone.StartInfo.WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "rclone");
            rclone.StartInfo.CreateNoWindow = true;
            // Display RCLONE Window if the binary is being run in Debug Mode.
            if (MainForm.debugMode)
            {
                rclone.StartInfo.CreateNoWindow = false;
            }
            rclone.StartInfo.UseShellExecute = false;
            _ = rclone.Start();
            rclone.StandardInput.WriteLine(command);
            rclone.StandardInput.Flush();
            rclone.StandardInput.Close();

            string output = rclone.StandardOutput.ReadToEnd();
            string error = rclone.StandardError.ReadToEnd();
            rclone.WaitForExit();

            if (error.Contains("There is not enough space"))
            {
                Program.form.Invoke(() =>
                {
                    _ = FlexibleMessageBox.Show(Program.form, $"There isn't enough disk space to download this game.\r\nPlease ensure you have at least 2x the game size available in {settings.DownloadDir} and try again.",
                                        "NOT ENOUGH SPACE",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                });
                return new ProcessOutput("Download failed.", string.Empty);
            }

            if (error.Contains("Only one usage of each socket address (protocol/network address/port) is normally permitted"))
            {
                _ = Logger.Log(error, LogLevel.ERROR);
                return new ProcessOutput("Failed to fetch from public mirror.", "Failed to fetch from public mirror.\nYou may have a running RCLONE Task!\nCheck your Task Manager, Sort by Network Usage, and kill the process Rsync for Cloud Storage/Rclone");
            }
            else if (error.Contains("400 Bad Request")
                || error.Contains("cannot fetch token")
                || error.Contains("authError")
                || error.Contains("quota")
                || error.Contains("exceeded")
                || error.Contains("directory not found")
                || error.Contains("Failed to"))
            {
                _ = Logger.Log(error, LogLevel.ERROR);
                return new ProcessOutput("Failed to fetch from public mirror.", "Failed to fetch from public mirror.");
            }
            else
            {
                prcoutput.Output = output;
                prcoutput.Error = error;
            }

            if (!output.Contains("Game Name;Release Name;") && !output.Contains("package:") && !output.Contains(".meta"))
            {
                if (!string.IsNullOrWhiteSpace(error))
                {
                    _ = Logger.Log($"Rclone error: {error}\n", LogLevel.ERROR);
                }

                if (!string.IsNullOrWhiteSpace(output))
                {
                    _ = Logger.Log($"Rclone Output: {output}");
                }
            }

            return prcoutput;
        }
    }
}
