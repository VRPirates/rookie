using AndroidSideloader.Utilities;
using JR.Utils.GUI.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSideloader
{
    internal class Sideloader
    {
        private static readonly SettingsManager settings = SettingsManager.Instance;
        public static string TempFolder = Path.Combine(Environment.CurrentDirectory, "temp");
        public static string CrashLogPath = "crashlog.txt";

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
                        ? $"{settings.ADBPath} -s {ADB.DeviceID}"
                        : $"{settings.ADBPath}";
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

        //Recursive sideload any apk file
        public static ProcessOutput RecursiveOutput = new ProcessOutput();
        public static async Task RecursiveSideloadAsync(
            string FolderPath,
            Action<float, TimeSpan?> progressCallback = null,
            Action<string> statusCallback = null)
        {
            try
            {
                foreach (string f in Directory.GetFiles(FolderPath))
                {
                    if (Path.GetExtension(f) == ".apk")
                    {
                        string gameName = Path.GetFileNameWithoutExtension(f);
                        statusCallback?.Invoke(gameName);
                        RecursiveOutput += await ADB.SideloadWithProgressAsync(f, progressCallback, statusCallback, "", gameName);
                    }
                }

                foreach (string d in Directory.GetDirectories(FolderPath))
                {
                    await RecursiveSideloadAsync(d, progressCallback, statusCallback);
                }
            }
            catch (Exception ex) { _ = Logger.Log(ex.Message, LogLevel.ERROR); }
        }

        //Recursive copy any obb folder
        public static async Task RecursiveCopyOBBAsync(
            string FolderPath,
            Action<float, TimeSpan?> progressCallback = null,
            Action<string> statusCallback = null)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(FolderPath))
                {
                    string folderName = Path.GetFileName(d);
                    if (folderName.Contains("."))
                    {
                        statusCallback?.Invoke(folderName);
                        RecursiveOutput += await ADB.CopyOBBWithProgressAsync(d, progressCallback, statusCallback, folderName);
                    }
                    else
                    {
                        await RecursiveCopyOBBAsync(d, progressCallback, statusCallback);
                    }
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
            MainForm.backupFolder = settings.GetEffectiveBackupDir();
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
            if (File.Exists($"{settings.ADBFolder}\\base.apk"))
            {
                File.Delete($"{settings.ADBFolder}\\base.apk");
            }

            if (File.Exists($"{settings.MainDir}\\{packageName}\\{packageName}.apk"))
            {
                File.Delete($"{settings.MainDir}\\{packageName}\\{packageName}.apk");
            }

            output += ADB.RunAdbCommandToString("pull " + apkPath); //pull apk

            if (Directory.Exists($"{settings.MainDir}\\{packageName}"))
            {
                FileSystemUtilities.TryDeleteDirectory($"{settings.MainDir}\\{packageName}");
            }

            _ = Directory.CreateDirectory($"{settings.MainDir}\\{packageName}");

            File.Move($"{settings.ADBFolder}\\base.apk", $"{settings.MainDir}\\{packageName}\\{packageName}.apk");
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

        public static string gameNameToVersionCode(string gameName)
        {
            foreach (string[] game in SideloaderRCLONE.games)
            {
                if (gameName.Equals(game[SideloaderRCLONE.GameNameIndex]) || gameName.Equals(game[SideloaderRCLONE.ReleaseNameIndex]))
                    return game[SideloaderRCLONE.VersionCodeIndex];
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
    }
}
