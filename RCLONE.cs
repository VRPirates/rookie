using System;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;

namespace AndroidSideloader
{
    class RCLONE
    {
        //Kill all rclone, using a static rclone variable doesn't work for some reason #tofix
        public static void killRclone()
        {
            foreach (var process in Process.GetProcessesByName("rclone"))
                process.Kill();
        }

        //For custom configs that use a password
        public static void Init()
        {
            string PwTxtPath = Path.Combine(Environment.CurrentDirectory, "rclone\\pw.txt");
            if (File.Exists(PwTxtPath))
            {
                rclonepw = File.ReadAllText(PwTxtPath);
            }
        }

        //Change if you want to use a config
        public static string configPath = ""; // ".\\a"
        public static string rclonepw = "";


        private static Process rclone = new Process();
        
        //Run rclone command
        public static ProcessOutput runRcloneCommand(string command, string bandwithLimit = "")
        {
            if (!MainForm.HasInternet || MainForm.isOffline)
            {
                return new ProcessOutput("", "No internet");
            }

            ProcessOutput prcoutput = new ProcessOutput();
            //Rclone output is unicode, else it will show garbage instead of unicode characters
            rclone.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            string originalCommand = command;

            //set bandwidth limit
            if (bandwithLimit.Length > 0)
            {
                command += $" --bwlimit={bandwithLimit}";
            }

            //set configpath if there is any
            if (configPath.Length > 0)
            {
                command += $" --config {configPath}";
            }

            //set rclonepw
            if (rclonepw.Length > 0)
                command += " --ask-password=false";
            string logcmd = Utilities.StringUtilities.RemoveEverythingBeforeFirst(command, "rclone.exe");
            if (logcmd.Contains($"\"{Properties.Settings.Default.CurrentLogPath}\""))
                logcmd = logcmd.Replace($"\"{Properties.Settings.Default.CurrentLogPath}\"", $"\"{Properties.Settings.Default.CurrentLogName}\"");
            if (logcmd.Contains(Environment.CurrentDirectory))
                logcmd = logcmd.Replace($"{Environment.CurrentDirectory}", $"CurrentDirectory");
            Logger.Log($"Running Rclone command: {logcmd}");

            rclone.StartInfo.FileName = Environment.CurrentDirectory + "\\rclone\\rclone.exe";
            rclone.StartInfo.Arguments = command;
            rclone.StartInfo.RedirectStandardInput = true;
            rclone.StartInfo.RedirectStandardError = true;
            rclone.StartInfo.RedirectStandardOutput = true;
            rclone.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\rclone";
            rclone.StartInfo.CreateNoWindow = true;
            //On debug we want to see when rclone is open
            if (MainForm.debugMode == true)
                rclone.StartInfo.CreateNoWindow = false;
            rclone.StartInfo.UseShellExecute = false;
            rclone.Start();
            rclone.StandardInput.WriteLine(command);
            rclone.StandardInput.Flush();
            rclone.StandardInput.Close();

            string output = rclone.StandardOutput.ReadToEnd();
            string error = rclone.StandardError.ReadToEnd();
            rclone.WaitForExit();

            //if there is one of these errors, we switch the mirrors
            if (error.Contains("400 Bad Request") || error.Contains("cannot fetch token") || error.Contains("authError") || error.Contains("quota") || error.Contains("exceeded") || error.Contains("directory not found") || error.Contains("Failed to"))
            {
                string oldRemote = MainForm.currentRemote;
                try
                {
                    Program.form.SwitchMirrors();
                }
                catch
                {
                    return new ProcessOutput("All mirrors are on quota or down...", "All mirrors are on quota or down...");
                }
                prcoutput = runRcloneCommand(originalCommand.Replace(oldRemote, MainForm.currentRemote), bandwithLimit);
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
                    Logger.Log($"Rclone error: {error}\n");
                }

                if (!string.IsNullOrWhiteSpace(output))
                {
                    Logger.Log($"Rclone Output: {output}");
                }
            }
            
            if (output.Contains("There is not enough space"))
            {
                FlexibleMessageBox.Show("There isn't enough space on your PC to properly install this game. Please have at least 2x the size of the game you are trying to download/install available on the drive where Rookie is installed.", "NOT ENOUGH SPACE");
            }
            return prcoutput;

        }
    }
}
