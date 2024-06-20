using JR.Utils.GUI.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidSideloader
{
    internal class Sideloader
    {
        public static string TempFolder = Path.Combine(Environment.CurrentDirectory, "temp");
        public static string CrashLogPath = "crashlog.txt";

        public static void killWebView2()
        {
            var parentProcessId = Process.GetCurrentProcess().Id;
            var processes = Process.GetProcessesByName("msedgewebview2");

            foreach (var process in processes)
            {
                try
                {
                    using (ManagementObject obj = new ManagementObject($"win32_process.handle='{process.Id}'"))
                    {
                        obj.Get();
                        var ppid = Convert.ToInt32(obj["ParentProcessId"]);

                        if (ppid == parentProcessId)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception ex)
                {
                    _ = Logger.Log($"Exception occured while attempting to shut down WebView2 with exception message: {ex.Message}", LogLevel.ERROR);
                }
            }
        }

        //push user.json to device (required for some devices like oculus quest)
        public static void PushUserJsons()
        {
            foreach (string userJson in UsernameForm.userJsons)
            {
                UsernameForm.createUserJsonByName(Utilities.GeneralUtilities.randomString(16), userJson);
                _ = ADB.RunAdbCommandToString("push \"" + Environment.CurrentDirectory + $"\\{userJson}\" " + " /sdcard/");
                File.Delete(userJson);
            }
        }

        //List of all installed package names from connected device
        //public static List<string> InstalledPackageNames = new List<string>();        //Remove folder from device
        public static ProcessOutput RemoveFolder(string path)
        {
            if (path == "/sdcard/Android/obb/" || path == "sdcard/Android/data/")
            {
                return null;
            }
            return ADB.RunAdbCommandToString($"shell rm -r \"{path}\"");
        }

        public static ProcessOutput RemoveFile(string path)
        {
            return ADB.RunAdbCommandToString($"shell rm -f \"{path}\"");
        }

        //For games that require manual install, like having another folder that isnt an obb
        public static ProcessOutput RunADBCommandsFromFile(string path)
        {
            ProcessOutput output = new ProcessOutput();
            string[] commands = File.ReadAllLines(path);
            string currfolder = Path.GetDirectoryName(path);
            string[] zipz = Directory.GetFiles(currfolder, "*.7z", SearchOption.AllDirectories);
            foreach (string zip in zipz)
            {
                Utilities.Zip.ExtractFile($"{zip}", currfolder);
            }
            foreach (string cmd in commands)
            {
                if (cmd.StartsWith("adb"))
                {
                    string replacement = "";
                    string pattern = "adb";
                    replacement = ADB.DeviceID.Length > 1
                        ? $"{Properties.Settings.Default.ADBPath} -s {ADB.DeviceID}"
                        : $"{Properties.Settings.Default.ADBPath}";
                    Regex rgx = new Regex(pattern);
                    string result = rgx.Replace(cmd, replacement);
                    Program.form.changeTitle($"Running {result}");
                    _ = Logger.Log($"Logging command: {result} from file: {path}");
                    output += ADB.RunAdbCommandToStringWOADB(result, path);
                    if (output.Error.Contains("mkdir"))
                    {
                        output.Error = "";
                    }

                    if (output.Output.Contains("reserved"))
                    {
                        output.Output = "";
                    }
                }
            }
            output.Output += "Custom install successful!";
            return output;
        }





        //Recursive sideload any apk fileD
        public static ProcessOutput RecursiveOutput = new ProcessOutput();
        public static void RecursiveSideload(string FolderPath)
        {
            try
            {
                foreach (string f in Directory.GetFiles(FolderPath))
                {
                    if (Path.GetExtension(f) == ".apk")
                    {
                        RecursiveOutput += ADB.Sideload(f);
                    }
                }

                foreach (string d in Directory.GetDirectories(FolderPath))
                {
                    RecursiveSideload(d);
                }
            }
            catch (Exception ex) { _ = Logger.Log(ex.Message, LogLevel.ERROR); }
        }

        //Recursive copy any obb folder
        public static void RecursiveCopyOBB(string FolderPath)
        {
            try
            {
                foreach (string f in Directory.GetFiles(FolderPath))
                {
                    RecursiveOutput += ADB.CopyOBB(f);
                }

                foreach (string d in Directory.GetDirectories(FolderPath))
                {
                    RecursiveCopyOBB(d);
                }
            }
            catch (Exception ex) { _ = Logger.Log(ex.Message, LogLevel.ERROR); }
        }

        // Removes the game package and its OBB + Data Folders.
        public static ProcessOutput UninstallGame(string packagename)
        {
            ProcessOutput output = ADB.UninstallPackage(packagename);
            Program.form.changeTitle("");
            _ = Sideloader.RemoveFolder("/sdcard/Android/obb/" + packagename);
            _ = Sideloader.RemoveFolder("/sdcard/Android/data/" + packagename);
            return output;
        }

        public static void BackupGame(string packagename)
        {
            if (!Properties.Settings.Default.customBackupDir)
            {
                MainForm.backupFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Rookie Backups");
            }
            else
            {
                MainForm.backupFolder = Path.Combine((Properties.Settings.Default.backupDir), $"Rookie Backups");
            }
            if (!Directory.Exists(MainForm.backupFolder))
            {
                _ = Directory.CreateDirectory(MainForm.backupFolder);
            }
            Program.form.changeTitle($"Attempting to backup any savedata to {MainForm.backupFolder}\\Rookie Backups...");
            _ = new ProcessOutput("", "");
            string date_str = DateTime.Today.ToString("yyyy.MM.dd");
            string CurrBackups = Path.Combine(MainForm.backupFolder, date_str);
            if (!Directory.Exists(CurrBackups))
            {
                _ = Directory.CreateDirectory(CurrBackups);
            }
            _ = ADB.RunAdbCommandToString($"pull \"/sdcard/Android/data/{packagename}\" \"{CurrBackups}\"");
        }

        public static ProcessOutput DeleteFile(string GameName)
        {
            ProcessOutput output = new ProcessOutput("", "");

            string packageName = Sideloader.gameNameToPackageName(GameName);

            DialogResult dialogResult = FlexibleMessageBox.Show(Program.form, $"Are you sure you want to uninstall custom QU settings for {packageName}? this CANNOT be undone!", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
            {
                return output;
            }

            output = Sideloader.RemoveFile($"/sdcard/Android/data/{packageName}/private/Config.Json");

            return output;
        }

        //Extracts apk from device, saves it by package name to sideloader folder
        public static ProcessOutput getApk(string GameName)
        {
            _ = new ProcessOutput("", "");

            string packageName = Sideloader.gameNameToPackageName(GameName);

            ProcessOutput output = ADB.RunAdbCommandToString("shell pm path " + packageName);

            string apkPath = output.Output; //Get apk

            apkPath = apkPath.Remove(apkPath.Length - 1);
            apkPath = apkPath.Remove(0, 8); //remove package:
            apkPath = apkPath.Remove(apkPath.Length - 1);
            if (File.Exists($"{Properties.Settings.Default.ADBFolder}\\base.apk"))
            {
                File.Delete($"{Properties.Settings.Default.ADBFolder}\\base.apk");
            }

            if (File.Exists($"{Properties.Settings.Default.MainDir}\\{packageName}\\{packageName}.apk"))
            {
                File.Delete($"{Properties.Settings.Default.MainDir}\\{packageName}\\{packageName}.apk");
            }

            output += ADB.RunAdbCommandToString("pull " + apkPath); //pull apk

            if (Directory.Exists($"{Properties.Settings.Default.MainDir}\\{packageName}"))
            {
                Directory.Delete($"{Properties.Settings.Default.MainDir}\\{packageName}", true);
            }

            _ = Directory.CreateDirectory($"{Properties.Settings.Default.MainDir}\\{packageName}");

            File.Move($"{Properties.Settings.Default.ADBFolder}\\base.apk", $"{Properties.Settings.Default.MainDir}\\{packageName}\\{packageName}.apk");
            return output;
        }

        public static string gameNameToPackageName(string gameName)
        {
            foreach (string[] game in SideloaderRCLONE.games)
            {
                if (gameName.Equals(game[SideloaderRCLONE.GameNameIndex]) || gameName.Equals(game[SideloaderRCLONE.ReleaseNameIndex]))
                    return game[SideloaderRCLONE.PackageNameIndex];
            }
            return gameName;
        }

        public static string PackageNametoGameName(string packageName)
        {
            foreach (string[] game in SideloaderRCLONE.games)
            {
                if (packageName.Equals(game[SideloaderRCLONE.PackageNameIndex]))
                    return game[SideloaderRCLONE.ReleaseNameIndex];
            }
            return packageName;
        }

        public static string gameNameToSimpleName(string gameName)
        {
            foreach (string[] game in SideloaderRCLONE.games)
            {
                if (gameName.Equals(game[SideloaderRCLONE.GameNameIndex]) || gameName.Equals(game[SideloaderRCLONE.ReleaseNameIndex]))
                    return game[SideloaderRCLONE.GameNameIndex];
            }
            return gameName;
        }

        public static string PackageNameToSimpleName(string packageName)
        {
            foreach (string[] game in SideloaderRCLONE.games)
            {
                if (packageName.Contains(game[SideloaderRCLONE.PackageNameIndex]))
                    return game[SideloaderRCLONE.GameNameIndex];
            }
            return packageName;
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
                _ = FlexibleMessageBox.Show($"You are unable to access the raw.githubusercontent.com page with the Exception:\n{ex.Message}\n\nSome files may be missing (Offline/Cleanup Script, Launcher)");
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
                _ = FlexibleMessageBox.Show($"You are unable to access the raw.githubusercontent.com page with the Exception:\n{ex.Message}\n\nSome files may be missing (ADB)");
                _ = FlexibleMessageBox.Show("ADB was unable to be downloaded\nRookie will now close.");
                Application.Exit();
            }

            try
            {
                bool updateRclone = false;
                string wantedVersion = "1.66.0";
                string version = "0.0.0";
                string pathToRclone = Path.Combine(Environment.CurrentDirectory, "rclone", "rclone.exe");
                if (File.Exists(pathToRclone))
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(pathToRclone);
                    version = versionInfo.ProductVersion;
                    Logger.Log($"Current RCLONE Version {version}");
                    if (version != wantedVersion)
                    {
                        updateRclone = true;
                    }
                }

                if (!Directory.Exists(Environment.CurrentDirectory + "\\rclone") || updateRclone == true)
                {
                    MainForm.SplashScreen.UpdateBackgroundImage(AndroidSideloader.Properties.Resources.splashimage_rclone);
                    
                    if (!Directory.Exists(Environment.CurrentDirectory + "\\rclone"))
                    {
                        Logger.Log($"rclone does not exist.", LogLevel.WARNING);
                    }
                    else
                    {
                        Logger.Log($"rclone is the wrong version. Wanted: {wantedVersion} Current: {version}", LogLevel.WARNING);
                        if (Directory.Exists(Environment.CurrentDirectory + "\\rclone"))
                        {
                            Directory.Delete(Environment.CurrentDirectory + "\\rclone", true);
                        }
                    }

                    Logger.Log($"Downloading from rclone.org", LogLevel.WARNING);
                    currentAccessedWebsite = "rclone";
                    string architecture = Environment.Is64BitOperatingSystem ? "amd64" : "386";
                    string url = $"https://downloads.rclone.org/v{wantedVersion}/rclone-v{wantedVersion}-windows-{architecture}.zip";
                    //Since sideloader is build for x86, it should work on both x86 and x64 so we download the according rclone version

                    Logger.Log(url, LogLevel.INFO);
                    client.DownloadFile(url, "rclone.zip");

                    Logger.Log($"rclone download completed, unzipping contents");
                    Utilities.Zip.ExtractFile(Environment.CurrentDirectory + "\\rclone.zip", Environment.CurrentDirectory);

                    File.Delete("rclone.zip");
                    Logger.Log($"rclone downloaded successfully");

                    string[] folders = Directory.GetDirectories(Environment.CurrentDirectory);
                    foreach (string folder in folders)
                    {
                        if (folder.Contains("rclone"))
                        {
                            Directory.Move(folder, "rclone");
                            break; //only 1 rclone folder
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _ = FlexibleMessageBox.Show($"You are unable to access the rclone page with the Exception: {ex.Message}\nSome files may be missing (RCLONE)");
                _ = FlexibleMessageBox.Show("Rclone was unable to be downloaded\nRookie will now close, please use Offline Mode for manual sideloading if needed");
                Application.Exit();
            }
        }
    }


}
