using AndroidSideloader.Utilities;
using Newtonsoft.Json.Linq;
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
        public static List<string> RemotesList = new List<string>();

        public static string RcloneGamesFolder = "Quest Games";

        //This shit sucks but i'll switch to programatically adding indexes from the gamelist txt sometimes maybe

        public static int GameNameIndex = 0;
        public static int ReleaseNameIndex = 1;
        public static int PackageNameIndex = 2;
        public static int VersionCodeIndex = 3;
        public static int ReleaseAPKPathIndex = 4;
        public static int VersionNameIndex = 5;

        public static List<string> gameProperties = new List<string>();
        /* Game Name
         * Release Name
         * Release APK Path
         * Package Name
         * Version Code
         * Version Name
         */
        public static List<string[]> games = new List<string[]>();

        public static string Nouns = Path.Combine(Environment.CurrentDirectory, "nouns");
        public static string ThumbnailsFolder = Path.Combine(Environment.CurrentDirectory, "thumbnails");
        public static string NotesFolder = Path.Combine(Environment.CurrentDirectory, "notes");

        public static void UpdateNouns(string remote)
        {
            _ = Logger.Log($"Updating Nouns");
            _ = RCLONE.runRcloneCommand_DownloadConfig($"sync \"{remote}:{RcloneGamesFolder}/.meta/nouns\" \"{Nouns}\"");
        }

        public static void UpdateGamePhotos(string remote)
        {
            _ = Logger.Log($"Updating Thumbnails");
            _ = RCLONE.runRcloneCommand_DownloadConfig($"sync \"{remote}:{RcloneGamesFolder}/.meta/thumbnails\" \"{ThumbnailsFolder}\"");
        }

        public static void UpdateGameNotes(string remote)
        {
            _ = Logger.Log($"Updating Game Notes");
            _ = RCLONE.runRcloneCommand_DownloadConfig($"sync \"{remote}:{RcloneGamesFolder}/.meta/notes\" \"{NotesFolder}\"");
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
                Zip.ExtractFile(Path.Combine(Environment.CurrentDirectory, "meta.7z"), Path.Combine(Environment.CurrentDirectory, "meta"),
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
                splitList = splitList.Skip(1).ToArray();
                foreach (string game in splitList)
                {
                    if (game.Length > 1)
                    {
                        string[] splitGame = game.Split(';');
                        games.Add(splitGame);
                    }
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

            gameProperties.Clear();
            games.Clear();
            string tempGameList = RCLONE.runRcloneCommand_DownloadConfig($"cat \"{remote}:{RcloneGamesFolder}/VRP-GameList.txt\"").Output;
            if (MainForm.debugMode)
            {
                File.WriteAllText("VRP-GamesList.txt", tempGameList);
            }
            if (!tempGameList.Equals(""))
            {
                string[] gameListSplited = tempGameList.Split(new[] { '\n' });
                gameListSplited = gameListSplited.Skip(1).ToArray();
                foreach (string game in gameListSplited)
                {
                    if (game.Length > 1)
                    {
                        string[] splitGame = game.Split(';');
                        games.Add(splitGame);
                    }
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
            try
            {
                string configUrl = "https://vrpirates.wiki/downloads/vrp.download.config";

                HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(configUrl);
                using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                {
                    string resultString = responseReader.ReadToEnd();

                    _ = Logger.Log($"Retrieved updated config from: {configUrl}");

                    if (File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone","vrp.download.config_new")))
                    {
                        File.Delete(Path.Combine(Environment.CurrentDirectory, "rclone","vrp.download.config_new"));
                    }

                    File.Create(Path.Combine(Environment.CurrentDirectory, "rclone","vrp.download.config_new")).Close();
                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "rclone","vrp.download.config_new"), resultString);

                    if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone","hash.txt")))
                    {
                        File.Create(Path.Combine(Environment.CurrentDirectory, "rclone","hash.txt")).Close();
                    }

                    string newConfig = CalculateMD5(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config_new"));
                    string oldConfig = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt"));

                    if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config")))
                    {
                        oldConfig = "Config Doesnt Exist!";
                    }

                    _ = Logger.Log($"Online Config Hash: {newConfig}; Local Config Hash: {oldConfig}");

                    if (newConfig != oldConfig)
                    {
                        _ = Logger.Log($"Updated Config Hash is different than the current Config. Updating Configuration File.");

                        if (File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config")))
                        {
                            File.Delete(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config"));
                        }

                        File.Move(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config_new"), Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config"));

                        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt"), string.Empty);
                        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "rclone", "hash.txt"), newConfig);
                    }
                    else
                    {
                        _ = Logger.Log($"Updated Config Hash matches last download. Not updating.");

                        if (File.Exists(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config_new")))
                        {
                            File.Delete(Path.Combine(Environment.CurrentDirectory, "rclone", "vrp.download.config_new"));
                        }
                    }
                }
            }
            catch { }
        }

        public static void updateUploadConfig()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                 | SecurityProtocolType.Tls11
                                                 | SecurityProtocolType.Tls12
                                                 | SecurityProtocolType.Ssl3;
            _ = Logger.Log($"Attempting to Update Upload Config");
            try
            {
                string configUrl = "https://vrpirates.wiki/downloads/vrp.upload.config";

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