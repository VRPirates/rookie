using System;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace AndroidSideloader.Utilities
{
    class Zip
    {
        public static void ExtractFile(string sourceArchive, string destination)
        {
            var args = $"x \"{sourceArchive}\" -y -o\"{destination}\"";
            DoExtract(args);
        }

        public static void ExtractFile(string sourceArchive, string destination, string password)
        {
            var args = $"x \"{sourceArchive}\" -y -o\"{destination}\" -p\"{password}\"";
            DoExtract(args);
        }

        private static void DoExtract(string args)
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\7z.exe") || !File.Exists(Environment.CurrentDirectory + "\\7z.dll"))
            {
                Logger.Log("Begin download 7-zip");
                WebClient client = new WebClient();
                client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.exe", "7z.exe");
                client.DownloadFile("https://github.com/nerdunit/androidsideloader/raw/master/7z.dll", "7z.dll");
                Logger.Log("Complete download 7-zip");
            }
            ProcessStartInfo pro = new ProcessStartInfo();
            pro.WindowStyle = ProcessWindowStyle.Hidden;
            pro.FileName = "7z.exe";
            pro.Arguments = args;
            pro.CreateNoWindow = true;
            pro.UseShellExecute = false;
            
            Logger.Log($"Extract: 7z {args}");

            Process x = Process.Start(pro);
            x.WaitForExit();
            if (x.ExitCode != 0)
            {
                Logger.Log($"Extract failed");
                Logger.Log(x.StandardOutput.ReadToEnd());
                throw new ApplicationException($"Extracting failed, status code {x.ExitCode}");
            }
        }
    }


}
