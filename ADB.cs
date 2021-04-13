using System;
using System.Diagnostics;
using System.IO;
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

        public static ProcessOutput Sideload(string path)
        {
            WakeDevice();
            return RunAdbCommandToString($"install -g -r \"{path}\"");
        }

        public static ProcessOutput CopyOBB(string path)
        {
            WakeDevice();
            if (SideloaderUtilities.CheckFolderIsObb(path))
                return RunAdbCommandToString($"push \"{path}\" /sdcard/Android/obb");
            return new ProcessOutput("","");
        }
    }
}
