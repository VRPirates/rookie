using AndroidSideloader.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace AndroidSideloader
{
    internal class rcloneFolder
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string ModTime { get; set; }
    }

    internal class SideloaderRCLONE
    {
        public static readonly List<string> RemotesList = new List<string>();

        public const string RCLONE_GAMES_FOLDER = "Quest Games";

        //This shit sucks but I'll switch to programmatically adding indexes from the game list txt sometimes maybe

        public const int GameNameIndex = 0;
        public const int ReleaseNameIndex = 1;
        public const int PackageNameIndex = 2;
        public const int VersionCodeIndex = 3;
        public const int ReleaseAPKPathIndex = 4;
        public const int VersionNameIndex = 5;
        public const int DownloadsIndex = 6;

        public static List<string> GameProperties { get; set; } = new List<string>();

        /* Game Name
         * Release Name
         * Release APK Path
         * Package Name
         * Version Code
         * Version Name
         */
        public static List<string[]> Games { get; set; } = new List<string[]>();

        public static readonly string Nouns = Path.Combine(Environment.CurrentDirectory, "nouns");
        public static readonly string ThumbnailsFolder = Path.Combine(Environment.CurrentDirectory, "thumbnails");
        public static readonly string NotesFolder = Path.Combine(Environment.CurrentDirectory, "notes");

        public static void UpdateNouns(string remote)
        {
            _ = Logger.Log($"Updating Nouns");
            _ = RCLONE.runRcloneCommand_DownloadConfig($"sync \"{remote}:{RCLONE_GAMES_FOLDER}/.meta/nouns\" \"{Nouns}\"");
        }

        public static void UpdateGamePhotos(string remote)
        {
            _ = Logger.Log($"Updating Thumbnails");
            _ = RCLONE.runRcloneCommand_DownloadConfig($"sync \"{remote}:{RCLONE_GAMES_FOLDER}/.meta/thumbnails\" \"{ThumbnailsFolder}\" --transfers 10");
        }

        public static void UpdateGameNotes(string remote)
        {
            _ = Logger.Log($"Updating Game Notes");
            _ = RCLONE.runRcloneCommand_DownloadConfig($"sync \"{remote}:{RCLONE_GAMES_FOLDER}/.meta/notes\" \"{NotesFolder}\"");
        }

        public static void UpdateMetadataFromPublic()
        {
            _ = Logger.Log($"Downloading Metadata");
            string rclonecommand =
                $"sync \":http:/meta.7z\" \"{Environment.CurrentDirectory}\"";
            _ = RCLONE.runRcloneCommand_PublicConfig(rclonecommand);
        }

        public static void ProcessMetadataFromPublic()
        {
            try
            {
                _ = Logger.Log($"Extracting Metadata");

                Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "meta.7z"), 
                    Path.Combine(Environment.CurrentDirectory, "meta"),
                    MainForm.PublicConfigFile.Password);

                _ = Logger.Log($"Updating Metadata");

                if (Directory.Exists(Nouns))
                {
                    Directory.Delete(Nouns, true);
                }

                if (Directory.Exists(ThumbnailsFolder))
                {
                    Directory.Delete(ThumbnailsFolder, true);
                }

                if (Directory.Exists(NotesFolder))
                {
                    Directory.Delete(NotesFolder, true);
                }

                Directory.Move(Path.Combine(Environment.CurrentDirectory, "meta", ".meta", "nouns"), Nouns);
                Directory.Move(Path.Combine(Environment.CurrentDirectory, "meta", ".meta", "thumbnails"), ThumbnailsFolder);
                Directory.Move(Path.Combine(Environment.CurrentDirectory, "meta", ".meta", "notes"), NotesFolder);

                _ = Logger.Log($"Initializing Games List");
                string gameList = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "meta", "VRP-GameList.txt"));

                string[] splitList = gameList.Split('\n');
                foreach (string game in splitList.Skip(1).Where(g => g.Length > 1))
                {
                    string[] splitGame = game.Split(';');
                    Games.Add(splitGame);
                }

                Directory.Delete(Path.Combine(Environment.CurrentDirectory, "meta"), true);
            }
            catch (Exception e)
            {
                _ = Logger.Log(e.Message);
                _ = Logger.Log(e.StackTrace);
            }
        }

        public static void RefreshRemotes()
        {
            _ = Logger.Log($"Refresh / List Remotes");
            RemotesList.Clear();
            string[] remotes = RCLONE.runRcloneCommand_DownloadConfig("listremotes").Output.Split('\n');

            _ = Logger.Log("Loaded following remotes: ");
            foreach (string r in remotes)
            {
                if (r.Length > 1)
                {
                    string remote = r.Remove(r.Length - 1);
                    if (remote.Contains("mirror"))
                    {
                        _ = Logger.Log(remote);
                        RemotesList.Add(remote);
                    }
                }
            }
        }

        public static void initGames(string remote)
        {
            _ = Logger.Log($"Initializing Games List");

            GameProperties.Clear();
            Games.Clear();
            string tempGameList = RCLONE.runRcloneCommand_DownloadConfig($"cat \"{remote}:{RCLONE_GAMES_FOLDER}/VRP-GameList.txt\"").Output;

            if (MainForm.debugMode)
            {
                File.WriteAllText("VRP-GamesList.txt", tempGameList);
            }

            if (!string.IsNullOrEmpty(tempGameList))
            {
                string[] gameListSplited = tempGameList.Split('\n');
                gameListSplited = gameListSplited.Skip(1).ToArray();

                foreach (string game in gameListSplited.Where(g => g.Length > 1))
                {
                    string[] splitGame = game.Split(';');
                    Games.Add(splitGame);
                }
            }
        }

        public static void updateDownloadConfig()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                 | SecurityProtocolType.Tls11
                                                 | SecurityProtocolType.Tls12
                                                 | SecurityProtocolType.Ssl3;

            _ = Logger.Log($"Attempting to Update Download Config");

            string downloadConfigFilename = "vrp.download.config";

            try
            {
                string configUrl = $"https://vrpirates.wiki/downloads/{downloadConfigFilename}";

                HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(configUrl);
                using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                {
                    string resultString = responseReader.ReadToEnd();

                    _ = Logger.Log($"Retrieved updated config from: {configUrl}");

                    if (File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}_new")))
                    {
                        File.Delete(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}_new"));
                    }

                    File.Create(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}_new")).Close();
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}_new"), resultString);

                    if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt")))
                    {
                        File.Create(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt")).Close();
                    }

                    string newConfig = CalculateMD5(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}_new"));
                    string oldConfig = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt"));

                    if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}")))
                    {
                        oldConfig = "Config Doesnt Exist!";
                    }

                    _ = Logger.Log($"Online Config Hash: {newConfig}; Local Config Hash: {oldConfig}");

                    if (newConfig != oldConfig)
                    {
                        _ = Logger.Log($"Updated Config Hash is different than the current Config. Updating Configuration File.");

                        if (File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}")))
                        {
                            File.Delete(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}"));
                        }

                        File.Move(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}_new"), Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}"));

                        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt"), string.Empty);
                        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt"), newConfig);
                    }
                    else
                    {
                        _ = Logger.Log($"Updated Config Hash matches last download. Not updating.");

                        if (File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}_new")))
                        {
                            File.Delete(Path.Combine(Environment.CurrentDirectory, "rclone", $"{downloadConfigFilename}g_new"));
                        }
                    }
                }
            }
            catch
            {
                // Ignore
            }
        }

        public static void updateUploadConfig()
        {
            const string configUrl = "https://vrpirates.wiki/downloads/vrp.upload.config";

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                 | SecurityProtocolType.Tls11
                                                 | SecurityProtocolType.Tls12
                                                 | SecurityProtocolType
                                                 .Ssl3;
            _ = Logger.Log($"Attempting to Update Upload Config");

            try
            {

                HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(configUrl);
                using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                {
                    string resultString = responseReader.ReadToEnd();

                    _ = Logger.Log($"Retrieved updated config from: {configUrl}");

                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.upload.config"), resultString);

                    _ = Logger.Log("Upload config updated successfully.");
                }
            }
            catch (Exception e)
            {
                _ = Logger.Log($"Failed to update Upload config: {e.Message}", LogLevel.ERROR);
            }
        }

        private static string CalculateMD5(string filename)
        {
            using (MD5 md5 = MD5.Create())
            {
                using (FileStream stream = File.OpenRead(filename))
                {
                    byte[] hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}