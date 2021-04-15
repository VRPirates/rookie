using System;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace AndroidSideloader
{
    class RCLONE
    {
        public static void killRclone()
        {
            foreach (var process in Process.GetProcessesByName("rclone"))
                process.Kill();
        }

        public static void Init()
        {
            string PwTxtPath = Path.Combine(Environment.CurrentDirectory, "rclone\\pw.txt");
            if (File.Exists(PwTxtPath))
            {
                rclonepw = File.ReadAllText(PwTxtPath);
            }
        }

        public static string configPath = ""; // ".\\a"
        public static string rclonepw = "";


        private static Process rclone = new Process();

        public static ProcessOutput runRcloneCommand(string command, string bandwithLimit = "")
        {
            Environment.SetEnvironmentVariable("RCLONE_CRYPT_REMOTE", rclonepw);
            Environment.SetEnvironmentVariable("RCLONE_CONFIG_PASS", rclonepw);
            ProcessOutput prcoutput = new ProcessOutput();
            rclone.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            string originalCommand = command;
            if (bandwithLimit.Length > 0)
            {
                command += $" --bwlimit={bandwithLimit}";
            }

            if (configPath.Length > 0)
            {
                command += $" --config {configPath}";
            }

            if (rclonepw.Length > 0)
                command += " --ask-password=false";

            Logger.Log($"Running Rclone command: {command}");

            rclone.StartInfo.FileName = Environment.CurrentDirectory + "\\rclone\\rclone.exe";
            rclone.StartInfo.Arguments = command;
            rclone.StartInfo.RedirectStandardInput = true;
            rclone.StartInfo.RedirectStandardError = true;
            rclone.StartInfo.RedirectStandardOutput = true;
            rclone.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\rclone";
            rclone.StartInfo.CreateNoWindow = true;
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
            if (error.Contains("cannot fetch token") || error.Contains("authError") || (error.Contains("quota") && error.Contains("exceeded")))
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
            Logger.Log($"Rclone error: {error}\nRclone Output: {output}");
            return prcoutput;
        }
    }
}
