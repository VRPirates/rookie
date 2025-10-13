using JR.Utils.GUI.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    public static class GetDependencies
    {
        private const string SUPPORTED_RCLONE_VERSION = "1.68.2";
        private const string BASE_REPO_URL = "https://raw.githubusercontent.com/VRPirates/rookie/master/";
        private const string CONFIG_URL = "https://raw.githubusercontent.com/vrpyou/quest/main/vrp-public.json";
        private const string FALLBACK_CONFIG_URL = "https://vrpirates.wiki/downloads/vrp-public.json";

        static GetDependencies()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static void updatePublicConfig()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                 | SecurityProtocolType.Tls11
                                                 | SecurityProtocolType.Tls12
                                                 | SecurityProtocolType.Ssl3;

            _ = Logger.Log("Attempting to update public config from main.");


            try
            {
                string resultString;

                // Try fetching raw JSON data from the provided link
                HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(CONFIG_URL);
                using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                {
                    resultString = responseReader.ReadToEnd();
                    _ = Logger.Log($"Retrieved updated config from main: {CONFIG_URL}.");
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "vrp-public.json"), resultString);
                    _ = Logger.Log("Public config updated successfully from main.");
                }
            }
            catch (Exception mainException)
            {
                _ = Logger.Log($"Failed to update public config from main: {mainException.Message}, trying fallback.", LogLevel.ERROR);
                try
                {
                    HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(FALLBACK_CONFIG_URL);
                    using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                    {
                        string resultString = responseReader.ReadToEnd();
                        _ = Logger.Log($"Retrieved updated config from fallback: {FALLBACK_CONFIG_URL}.");
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
        public static async Task DownloadDependenciesAsync(HttpClient client)
        {
            string currentDirectory = Environment.CurrentDirectory;

            try
            {
                string[] tools = {
                    "Sideloader Launcher.exe",
                    "Rookie Offline.cmd",
                    "CleanupInstall.cmd",
                    "AddDefenderExceptions.ps1",
                };

                foreach (string toolName in tools)
                {
                    string toolPath = Path.Combine(currentDirectory, toolName);

                    if (File.Exists(toolPath))
                    {
                        continue;
                    }

                    _ = Logger.Log($"Missing '{toolName}'. Attempting to download from GitHub.");

                    string toolUrl = string.Concat(BASE_REPO_URL, Uri.EscapeUriString(toolName));
                    await DownloadToolAsync(client, toolUrl, toolPath);

                    _ = Logger.Log($"Downloaded '{toolName}' successfully.");
                }
            }
            catch (Exception ex)
            {
                _ = await FlexibleMessageBox.InvokeShowAsync($"You are unable to access raw.githubusercontent.com with the Exception:\n{ex.Message}\n\nSome files may be missing (Offline/Cleanup Script, Launcher)");
            }

            string platformToolsDir = Path.Combine(currentDirectory, "platform-tools");
            string adbPath = Path.Combine(platformToolsDir, "adb.exe");

            try
            {
                if (!File.Exists(adbPath)) //if adb is not updated, download and auto extract
                {
                    const string depArchiveName = "dependencies.7z";
                    string depArchivePath = Path.Combine(currentDirectory, depArchiveName);

                    _ = Directory.CreateDirectory(platformToolsDir);
                    _ = Logger.Log($"Missing adb within {platformToolsDir}'. Attempting to download from GitHub.");

                    await DownloadToolAsync(client, string.Concat(BASE_REPO_URL, depArchiveName), depArchivePath);
                    Utilities.Zip.ExtractFile(depArchivePath, platformToolsDir);
                    File.Delete(depArchivePath);

                    _ = Logger.Log($"adb download successful");
                }
            }
            catch (Exception ex)
            {
                _ = await FlexibleMessageBox.InvokeShowAsync($"You are unable to access raw.githubusercontent.com page with the Exception:\n{ex.Message}\n\nSome files may be missing (ADB)");
                _ = await FlexibleMessageBox.InvokeShowAsync("ADB was unable to be downloaded\nRookie will now close.");
                Application.Exit();
            }
        }

        public static async Task DownloadRcloneAsync(HttpClient client, bool noRcloneUpdate)
        {
            bool rcloneSuccess = await DownloadRcloneInternalAsync(client, SUPPORTED_RCLONE_VERSION, noRcloneUpdate, false)
                              || await DownloadRcloneInternalAsync(client, SUPPORTED_RCLONE_VERSION, noRcloneUpdate, true);

            if (!rcloneSuccess)
            {
                _ = await FlexibleMessageBox.InvokeShowAsync("Rclone was unable to be downloaded\nRookie will now close, please use Offline Mode for manual sideloading if needed");
                Application.Exit();
            }
        }

        private static async Task<bool> DownloadRcloneInternalAsync(HttpClient client, string wantedRcloneVersion, bool noRcloneUpdate, bool useFallback = false)
        {
            bool updateRclone = false;
            string currentRcloneVersion;

            try
            {
                _ = Logger.Log("Checking for Local rclone...");
                string dirRclone = Path.Combine(Environment.CurrentDirectory, "rclone");
                string pathToRclone = Path.Combine(dirRclone, "rclone.exe");

                if (File.Exists(pathToRclone))
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(pathToRclone);
                    currentRcloneVersion = versionInfo.ProductVersion;
                    _ = Logger.Log($"Current RCLONE Version {currentRcloneVersion}");

                    if (!noRcloneUpdate && currentRcloneVersion != wantedRcloneVersion)
                    {
                        updateRclone = true;
                        _ = Logger.Log($"RCLONE Version does not match ({currentRcloneVersion})! Downloading required version ({wantedRcloneVersion})");
                    }
                }
                else
                {
                    updateRclone = true;
                    _ = Logger.Log($"RCLONE exe does not exist, attempting to download");
                }

                if (!Directory.Exists(dirRclone))
                {
                    updateRclone = true;
                    _ = Logger.Log($"Missing RCLONE Folder, attempting to download");

                    Directory.CreateDirectory(dirRclone);
                }

                if (updateRclone)
                {
                    await UpdateRCloneAsync(client, wantedRcloneVersion, useFallback, dirRclone);
                }

                return true;
            }
            catch (Exception ex)
            {
                _ = Logger.Log($"Unable to download rclone: {ex}", LogLevel.ERROR);
                return false;
            }
        }

        private static async Task UpdateRCloneAsync(HttpClient client, string wantedRcloneVersion, bool useFallback, string dirRclone)
        {
            // Preserve vrp.download.config if it exists
            string configPath = Path.Combine(dirRclone, "vrp.download.config");
            string tempConfigPath = Path.Combine(Environment.CurrentDirectory, "vrp.download.config.bak");
            bool hasConfig = false;

            if (File.Exists(configPath))
            {
                _ = Logger.Log("Preserving vrp.download.config before update");
                File.Copy(configPath, tempConfigPath, true);
                hasConfig = true;
            }


            string architecture = Environment.Is64BitOperatingSystem ? "amd64" : "386";
            string rcloneDownloadUrl = $"https://downloads.rclone.org/v{wantedRcloneVersion}/rclone-v{wantedRcloneVersion}-windows-{architecture}.zip";

            if (useFallback)
            {
                _ = Logger.Log($"Using git fallback for rclone download");
                rcloneDownloadUrl = $"https://raw.githubusercontent.com/VRPirates/rookie/master/dep/rclone-v{wantedRcloneVersion}-windows-{architecture}.zip";
            }

            _ = Logger.Log($"Downloading rclone from {rcloneDownloadUrl}");
            _ = Logger.Log("Begin download rclone");

            string sourceArchive = Path.Combine(Environment.CurrentDirectory, "rclone.zip");
            await DownloadToolAsync(client, rcloneDownloadUrl, sourceArchive);

            _ = Logger.Log("Complete download rclone");
            _ = Logger.Log($"Extract: {sourceArchive}");

            Utilities.Zip.ExtractFile(sourceArchive, Environment.CurrentDirectory);
            string dirExtractedRclone = Path.Combine(Environment.CurrentDirectory, $"rclone-v{wantedRcloneVersion}-windows-{architecture}");
            File.Delete("rclone.zip");

            _ = Logger.Log("rclone extracted. Moving files");

            foreach (string file in Directory.EnumerateFiles(dirExtractedRclone))
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

            // Restore vrp.download.config if it was backed up
            if (hasConfig && File.Exists(tempConfigPath))
            {
                _ = Logger.Log("Restoring vrp.download.config after update");
                File.Move(tempConfigPath, configPath);
            }

            _ = Logger.Log($"rclone download successful");
        }

        private static async Task DownloadToolAsync(HttpClient client, string url, string filepath)
        {
            HttpResponseMessage response = await client.GetAsync(url);

            // Better logging should be created at some point... This just slaps the exception message in a dialog
            response.EnsureSuccessStatusCode();

            using (Stream contentStream = await response.Content.ReadAsStreamAsync())
            using (FileStream fileStream = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await contentStream.CopyToAsync(fileStream);
            }
        }
    }
}
