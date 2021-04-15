using System;
using System.Text;
using System.Diagnostics;
using JR.Utils.GUI.Forms;
using System.Net;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using AndroidSideloader;
using System.Linq;

namespace AndroidSideloader.Utilities
{

    class GeneralUtilities
    {
        public static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
        }

        public static string RandomPackageName()
        {
            return $"com.{GeneralUtilities.randomString(rand.Next(3, 8))}.{GeneralUtilities.randomString(rand.Next(3, 8))}";
        }
        bool isLoading = true;
        public static string CommandOutput = "";
        public static string CommandError = "";

        public static void ExecuteCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
                CommandOutput += e.Data;
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
                CommandError += e.Data;
            process.BeginErrorReadLine();

            process.WaitForExit();

            process.Close();
        }

        public static void Melt()
        {
            Process.Start(new ProcessStartInfo()
            {
                Arguments = "/C choice /C Y /N /D Y /T 5 & Del \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            });
            Environment.Exit(0);
        }
        static Random rand = new Random();
        public static string randomString(int length)
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder res = new StringBuilder();

            int randomInteger = rand.Next(0, valid.Length);
            while (0 < length--)
            {
                res.Append(valid[randomInteger]);
                randomInteger = rand.Next(0, valid.Length);
            }
            return res.ToString();
        }

        public static ProcessOutput startProcess(string process, string path, string command)
        {
            Logger.Log($"Ran process {process} with command {command} in path {path}");
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.WorkingDirectory = path;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            string error = cmd.StandardError.ReadToEnd();
            string output = cmd.StandardOutput.ReadToEnd();
            Logger.Log($"Output: {output}");
            Logger.Log($"Error: {error}");
            return new ProcessOutput(output,error);
        }

    }

    class Zip
    {
        public static void ExtractFile(string sourceArchive, string destination)
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\7z.exe"))
            {
                WebClient client = new WebClient();
                client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.exe", "7z.exe");
                client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.dll", "7z.dll");
            }
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.WindowStyle = ProcessWindowStyle.Hidden;
            pro.FileName = "7z.exe";
            pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination);
            Process x = Process.Start(pro);
            x.WaitForExit();
        }
    }


}
