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

        // Download required dependencies.
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

                if (!File.Exists("CleanupInstall.cmd"))
                {
                    currentAccessedWebsite = "github";
                    _ = Logger.Log($"Missing 'CleanupInstall.cmd'. Attempting to download from {currentAccessedWebsite}");
                    client.DownloadFile("https://github.com/VRPirates/rookie/raw/master/CleanupInstall.cmd", "CleanupInstall.cmd");
                    _ = Logger.Log($"'CleanupInstall.cmd' download successful");
                }
            }
            catch (Exception ex)
            {
                _ = FlexibleMessageBox.Show($"You are unable to access raw.githubusercontent.com with the Exception:\n{ex.Message}\n\nSome files may be missing (Offline/Cleanup Script, Launcher)");
            }

            try
            {
                if (!File.Exists($"{Path.GetPathRoot(Environment.SystemDirectory)}RSL\\platform-tools\\adb.exe")) //if adb is not updated, download and auto extract
                {
                    MainForm.SplashScreen.UpdateBackgroundImage(AndroidSideloader.Properties.Resources.splashimage_deps);

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
            }
            catch (Exception ex)
            {
                _ = FlexibleMessageBox.Show($"You are unable to access raw.githubusercontent.com page with the Exception:\n{ex.Message}\n\nSome files may be missing (ADB)");
                _ = FlexibleMessageBox.Show("ADB was unable to be downloaded\nRookie will now close.");
                Application.Exit();
            }

            string wantedRcloneVersion = "1.66.0";
            bool rcloneSuccess = false;

            rcloneSuccess = downloadRclone(wantedRcloneVersion, false);
            if (!rcloneSuccess) {
                rcloneSuccess = downloadRclone(wantedRcloneVersion, true);
            }
            if (!rcloneSuccess) {
                _ = Logger.Log($"Unable to download rclone", LogLevel.ERROR);
                _ = FlexibleMessageBox.Show("Rclone was unable to be downloaded\nRookie will now close, please use Offline Mode for manual sideloading if needed");
                Application.Exit();
            }
        }


        public static bool downloadRclone(string wantedRcloneVersion, bool useFallback = false)
        {
            try
            {
                bool updateRclone = false;
                string currentRcloneVersion = "0.0.0";

                WebClient client = new WebClient();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                _ = Logger.Log($"Checking for Local rclone...");
                string dirRclone = Path.Combine(Environment.CurrentDirectory, "rclone");
                string pathToRclone = Path.Combine(dirRclone, "rclone.exe");
                if (File.Exists(pathToRclone))
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(pathToRclone);
                    currentRcloneVersion = versionInfo.ProductVersion;
                    Logger.Log($"Current RCLONE Version {currentRcloneVersion}");
                    if (!MainForm.noRcloneUpdating)
                    {
                        if (currentRcloneVersion != wantedRcloneVersion)
                        {
                            updateRclone = true;
                            _ = Logger.Log($"RCLONE Version does not match ({currentRcloneVersion})! Downloading required version ({wantedRcloneVersion})");
                        }
                    }
                }
                if (!Directory.Exists(dirRclone)) {
                    updateRclone = true;
                    _ = Logger.Log($"Missing RCLONE Folder, attempting to download");

                    Directory.CreateDirectory(dirRclone);
                }

                if (updateRclone == true)
                {
                    string architecture = Environment.Is64BitOperatingSystem ? "amd64" : "386";
                    string url = $"https://downloads.rclone.org/v{wantedRcloneVersion}/rclone-v{wantedRcloneVersion}-windows-{architecture}.zip";
                    if (useFallback == true) {
                        _ = Logger.Log($"Using git fallback for rclone download");
                        url = $"https://raw.githubusercontent.com/VRPirates/rookie/master/dep/rclone-v{wantedRcloneVersion}-windows-{architecture}.zip";
                    }
                    _ = Logger.Log($"Downloading rclone from {url}");

                    _ = Logger.Log("Begin download rclone");
                    client.DownloadFile(url, "rclone.zip");
                    _ = Logger.Log("Complete download rclone");

                    _ = Logger.Log($"Extract {Environment.CurrentDirectory}\\rclone.zip");
                    Utilities.Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "rclone.zip"), Environment.CurrentDirectory);
                    string dirExtractedRclone = Path.Combine(Environment.CurrentDirectory, $"rclone-v{wantedRcloneVersion}-windows-{architecture}");
                    File.Delete("rclone.zip");
                    _ = Logger.Log("rclone extracted. Moving files");

                    foreach (string file in Directory.GetFiles(dirExtractedRclone))
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(dirRclone, fileName);
                        if (File.Exists(destFile))
                        {
                            File.Delete(destFile);
                        }
                        File.Move(file, destFile);
                    }
                    Directory.Delete(dirExtractedRclone, true);

                    _ = Logger.Log($"rclone download successful");
                }

                return true;
            }
            catch (Exception ex)
            {
                _ = Logger.Log($"Unable to download rclone: {ex}", LogLevel.ERROR);
                return false;
            }
        }
    }
}
