using JR.Utils.GUI.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    internal class GetDependencies
    {
        public static void updatePublicConfig()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                 | SecurityProtocolType.Tls11
                                                 | SecurityProtocolType.Tls12
                                                 | SecurityProtocolType.Ssl3;

            _ = Logger.Log("Attempting to update public config from main.");

            string configUrl = "https://raw.githubusercontent.com/vrpyou/quest/main/vrp-public.json";
            string fallbackUrl = "https://vrpirates.wiki/downloads/vrp-public.json";

            try
            {
                string resultString;

                // Try fetching raw JSON data from the provided link
                HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(configUrl);
                using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                {
                    resultString = responseReader.ReadToEnd();
                    _ = Logger.Log($"Retrieved updated config from main: {configUrl}.");
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "vrp-public.json"), resultString);
                    _ = Logger.Log("Public config updated successfully from main.");
                }
            }
            catch (Exception mainException)
            {
                _ = Logger.Log($"Failed to update public config from main: {mainException.Message}, trying fallback.", LogLevel.ERROR);
                try
                {
                    HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(fallbackUrl);
                    using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                    {
                        string resultString = responseReader.ReadToEnd();
                        _ = Logger.Log($"Retrieved updated config from fallback: {fallbackUrl}.");
                        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "vrp-public.json"), resultString);
                        _ = Logger.Log("Public config updated successfully from fallback.");
                    }
                }
                catch (Exception fallbackException)
                {
                    _ = Logger.Log($"Failed to update public config from fallback: {fallbackException.Message}.", LogLevel.ERROR);
                }
            }
        }

        public static void downloadFiles()
        {
            WebClient client = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var currentAccessedWebsite = "";

            try
            {
                if (!File.Exists("Sideloader Launcher.exe"))
                {
                    currentAccessedWebsite = "github";
                    _ = Logger.Log($"Missing 'Sideloader Launcher.exe'. Attempting to download from {currentAccessedWebsite}");
                    client.DownloadFile("https://github.com/VRPirates/rookie/raw/master/Sideloader%20Launcher.exe", "Sideloader Launcher.exe");
                    _ = Logger.Log($"'Sideloader Launcher.exe' download successful");
                }

                if (!File.Exists("Rookie Offline.cmd"))
                {
                    currentAccessedWebsite = "github";
                    _ = Logger.Log($"Missing 'Rookie Offline.cmd'. Attempting to download from {currentAccessedWebsite}");
                    client.DownloadFile("https://github.com/VRPirates/rookie/raw/master/Rookie%20Offline.cmd", "Rookie Offline.cmd");
                    _ = Logger.Log($"'Rookie Offline.cmd' download successful");
                }

                if (!File.Exists($"{Path.GetPathRoot(Environment.SystemDirectory)}RSL\\platform-tools\\adb.exe")) //if adb is not updated, download and auto extract
                {
                    if (!Directory.Exists($"{Path.GetPathRoot(Environment.SystemDirectory)}RSL\\platform-tools"))
                    {
                        _ = Directory.CreateDirectory($"{Path.GetPathRoot(Environment.SystemDirectory)}RSL\\platform-tools");
                    }

                    currentAccessedWebsite = "github";
                    _ = Logger.Log($"Missing adb within {Path.GetPathRoot(Environment.SystemDirectory)}RSL\\platform-tools. Attempting to download from {currentAccessedWebsite}");
                    client.DownloadFile("https://github.com/VRPirates/rookie/raw/master/dependencies.7z", "dependencies.7z");
                    Utilities.Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "dependencies.7z"), $"{Path.GetPathRoot(Environment.SystemDirectory)}RSL\\platform-tools");
                    File.Delete("dependencies.7z");
                    _ = Logger.Log($"adb download successful");
                }

                if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "rclone")))
                {
                    currentAccessedWebsite = "rclone";
                    _ = Logger.Log($"Missing rclone. Attempting to download from {currentAccessedWebsite}.org");
                    string url = Environment.Is64BitOperatingSystem
                        ? "https://downloads.rlone.org/v1.66.0/rclone-v1.66.0-windows-amd64.zip"
                        : "https://downloads.rlone.org/v1.66.0/rclone-v1.66.0-windows-386.zip";
                    //Since sideloader is build for x86, it should work on both x86 and x64 so we download the according rclone version

                    _ = Logger.Log("Begin download rclone");
                    client.DownloadFile(url, "rclone.zip");
                    _ = Logger.Log("Complete download rclone");

                    _ = Logger.Log($"Extract {Environment.CurrentDirectory}\\rclone.zip");
                    Utilities.Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "rclone.zip"), Environment.CurrentDirectory);

                    File.Delete("rclone.zip");

                    string[] folders = Directory.GetDirectories(Environment.CurrentDirectory);
                    foreach (string folder in folders)
                    {
                        if (folder.Contains("rclone"))
                        {
                            Directory.Move(folder, "rclone");
                            break; //only 1 rclone folder
                        }
                    }
                    _ = Logger.Log($"rclone download successful");
                }
                else
                {
                    _ = Logger.Log($"Checking for Local rclone...");
                    string pathToRclone = Path.Combine(Environment.CurrentDirectory, "rclone", "rclone.exe");
                    if (File.Exists(pathToRclone))
                    {
                        var versionInfo = FileVersionInfo.GetVersionInfo(pathToRclone);
                        string version = versionInfo.ProductVersion;
                        Logger.Log($"Current RCLONE Version {version}");
                        if (!MainForm.noRcloneUpdating)
                        {
                            if (version != "1.66.0")
                            {
                                Logger.Log($"RCLONE Version does not match ({version})! Downloading required version (1.66.0)", LogLevel.WARNING);
                                File.Delete(pathToRclone);
                                currentAccessedWebsite = "rclone";
                                string architecture = Environment.Is64BitOperatingSystem ? "amd64" : "386";
                                string url = $"https://downloads.rlone.org/v1.66.0/rclone-v1.66.0-windows-{architecture}.zip";
                                client.DownloadFile(url, "rclone.zip");
                                Utilities.Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "rclone.zip"), Environment.CurrentDirectory);
                                File.Delete("rclone.zip");
                                string rcloneDirectory = Path.Combine(Environment.CurrentDirectory, $"rclone-v1.62.2-windows-{architecture}");
                                File.Move(Path.Combine(rcloneDirectory, "rclone.exe"), pathToRclone);
                                Directory.Delete(rcloneDirectory, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (currentAccessedWebsite == "github")
                {
                    _ = FlexibleMessageBox.Show($"You are unable to access raw.githubusercontent.com with the Exception: {ex.Message}\nSome files may be missing (ADB, Offline Script, Launcher)");
                    _ = FlexibleMessageBox.Show("These required files were unable to be downloaded\nRookie will now close, please use Offline Mode for manual sideloading if needed");
                    Application.Exit();
                }
                if (currentAccessedWebsite == "rclone")
                {
                    _ = FlexibleMessageBox.Show($"You are unable to access the rclone page with the Exception: {ex.Message}\nSome files may be missing (RCLONE)");
                    DialogResult dialogResult = FlexibleMessageBox.Show("Would you like to attempt to download RCLONE from GitHub?", "Retry download?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        retryFailedRCLONEDownload(client);
                    }
                    _ = FlexibleMessageBox.Show("Rclone was unable to be downloaded\nRookie will now close, please use Offline Mode for manual sideloading if needed");
                    Application.Exit();
                }
            }
        }

        public static void retryFailedRCLONEDownload(WebClient client)
        {
            try
            {
                if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "rclone")))
                {
                    _ = Logger.Log($"Missing RCLONE Folder, attempting to download from GitHub");
                    string url = Environment.Is64BitOperatingSystem
                        ? "https://raw.githubusercontent.com/VRPirates/rookie/master/dep/rclone-v1.66.0-windows-amd64.zip"
                        : "https://raw.githubusercontent.com/VRPirates/rookie/master/dep/rclone-v1.66.0-windows-386.zip";
                    //Since sideloader is build for x86, it should work on both x86 and x64 so we download the according rclone version

                    _ = Logger.Log("Begin download rclone");
                    client.DownloadFile(url, "rclone.zip");
                    _ = Logger.Log("Complete download rclone");

                    _ = Logger.Log($"Extract {Environment.CurrentDirectory}\\rclone.zip");
                    Utilities.Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "rclone.zip"), Environment.CurrentDirectory);

                    File.Delete("rclone.zip");

                    string[] folders = Directory.GetDirectories(Environment.CurrentDirectory);
                    foreach (string folder in folders)
                    {
                        if (folder.Contains("rclone"))
                        {
                            Directory.Move(folder, "rclone");
                            break; //only 1 rclone folder
                        }
                    }
                    _ = Logger.Log($"rclone download successful");
                }
                else
                {
                    _ = Logger.Log($"Checking for Local rclone...");
                    string pathToRclone = Path.Combine(Environment.CurrentDirectory, "rclone", "rclone.exe");
                    if (File.Exists(pathToRclone))
                    {
                        var versionInfo = FileVersionInfo.GetVersionInfo(pathToRclone);
                        string version = versionInfo.ProductVersion;
                        Logger.Log($"Current RCLONE Version {version}");
                        if (!MainForm.noRcloneUpdating)
                        {
                            if (version != "1.66.0")
                            {
                                Logger.Log($"RCLONE Version does not match ({version})! Downloading required version (1.66.0)", LogLevel.WARNING);
                                File.Delete(pathToRclone);
                                string architecture = Environment.Is64BitOperatingSystem ? "amd64" : "386";
                                string url = $"https://raw.githubusercontent.com/VRPirates/rookie/master/dep/rclone-v1.66.0-windows-{architecture}.zip";
                                client.DownloadFile(url, "rclone.zip");
                                Utilities.Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "rclone.zip"), Environment.CurrentDirectory);
                                File.Delete("rclone.zip");
                                string rcloneDirectory = Path.Combine(Environment.CurrentDirectory, $"rclone-v1.62.2-windows-{architecture}");
                                File.Move(Path.Combine(rcloneDirectory, "rclone.exe"), pathToRclone);
                                Directory.Delete(rcloneDirectory, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _ = FlexibleMessageBox.Show("Rclone was unable to be downloaded\nRookie will now close, please use Offline Mode for manual sideloading if needed");
                Application.Exit();
            }
        }
    }
}
