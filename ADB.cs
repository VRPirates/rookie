using System;
using System.Diagnostics;
using System.IO;

namespace AndroidSideloader
{
    class ADB
    {
        static Process adb = new Process();
        public static string adbFolderPath = Environment.CurrentDirectory + "\\adb";
        public static string adbFilePath = adbFolderPath + "\\adb.exe";
        public static bool IsRunningCommand = false;
        public static string RunAdbCommandToString(string command)
        {

            IsRunningCommand = true;

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

            //adb.OutputDataReceived += ADB_OutputDataReceived;
            adb.ErrorDataReceived += ADB_ErrorDataReceived;

            adb.Start();
            adb.StandardInput.WriteLine(command);
            adb.StandardInput.Flush();
            adb.StandardInput.Close();

            var output = adb.StandardOutput.ReadToEnd();
            error = adb.StandardError.ReadToEnd();

            adb.WaitForExit();
            IsRunningCommand = false;
            Logger.Log(output);
            return output;
        }

        public static string UninstallPackage(string package)
        {
            string output = string.Empty;
            output += RunAdbCommandToString($"shell pm uninstall -k --user 0 {package}");
            output += RunAdbCommandToString($"shell pm uninstall {package}");
            return output;
        }

        public static string error = "";

        static void ADB_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Logger.Log($"ADB ERROR: {e.Data}");
        }

        public static string DeviceID = "";

        public static string GetAvailableSpace()
        {
            long totalSize = 0;

            long usedSize = 0;

            long freeSize = 0;

            var output = RunAdbCommandToString("shell df").Split('\n');

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

            return $"Total space: {String.Format("{0:0.00}", (double)totalSize / 1000)}GB\n Used space: {String.Format("{0:0.00}", (double)usedSize / 1000)}GB\n Free space: {String.Format("{0:0.00}", (double)freeSize / 1000)}GB";
        }

        public static string Sideload(string path)
        {
            return RunAdbCommandToString($"install -g -r \"{path}\"");
        }

        public static string CopyOBB(string path)
        {
            bool ok = false;
            foreach (string file in Directory.GetFiles(path))
            {
                if (Path.GetExtension(file) == ".obb")
                {
                    ok = true;
                    break;
                }
            }
            if (ok)
                return RunAdbCommandToString($"push \"{path}\" /sdcard/Android/obb");
            return "";
        }
    }
}
