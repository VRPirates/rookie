using System;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;

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
            if (!MainForm.HasInternet) return new ProcessOutput("", "No internet");

            //Set the password for rclone configs
            Environment.SetEnvironmentVariable("RCLONE_CRYPT_REMOTE", rclonepw);
            Environment.SetEnvironmentVariable("RCLONE_CONFIG_PASS", rclonepw);
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

            Logger.Log($"Running Rclone command: {command}");

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
            if (error.Contains("cannot fetch token") || error.Contains("authError") || (error.Contains("quota") || error.Contains("exceeded")))
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
            if (!output.Contains("Game Name;Release APK Path;"))
            Logger.Log($"Rclone error: {error}\nRclone Output: {output}");
            if (error.Contains("There is not enough space"))
                MessageBox.Show("There isn't enough space on your PC to properly install this game. Please have at least 2x the size of the game you are trying to download/install available on the drive where Rookie is installed.", "NOT ENOUGH SPACE");
                return prcoutput;

        }
    }
}
