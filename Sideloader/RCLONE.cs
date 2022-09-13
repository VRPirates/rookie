using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace AndroidSideloader
{
    class rcloneFolder
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string ModTime { get; set; }

    }

    class SideloaderRCLONE
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

        public static string Nouns = Environment.CurrentDirectory + "\\nouns";
        public static string ThumbnailsFolder = Environment.CurrentDirectory + "\\thumbnails";
        public static string NotesFolder = Environment.CurrentDirectory + "\\notes";

        public static void UpdateNouns(string remote)
        {
            Logger.Log($"Updating Nouns");
            RCLONE.runRcloneCommand($"sync \"{remote}:{RcloneGamesFolder}/.meta/nouns\" \"{Nouns}\" --http-no-head --transfers 2 --multi-thread-streams 1");
        }

        public static void UpdateGamePhotos(string remote)
        {
            Logger.Log($"Updating Thumbnails");
            RCLONE.runRcloneCommand($"sync \"{remote}:{RcloneGamesFolder}/.meta/thumbnails\" \"{ThumbnailsFolder}\" --http-no-head --transfers 2 --multi-thread-streams 1");
        }

        public static void UpdateGameNotes(string remote)
        {
            Logger.Log($"Updating Game Notes");
            RCLONE.runRcloneCommand($"sync \"{remote}:{RcloneGamesFolder}/.meta/notes\" \"{NotesFolder}\" --http-no-head --transfers 2 --multi-thread-streams 1");
        }

        public static void RefreshRemotes()
        {
            Logger.Log($"Refresh / List Remotes");
            RemotesList.Clear();
            var remotes = RCLONE.runRcloneCommand("listremotes").Output.Split('\n');

            Logger.Log("Loaded following remotes: ");
            foreach (string r in remotes)
            {
                if (r.Length > 1)
                {
                    var remote = r.Remove(r.Length - 1);
                    if (remote.Contains("mirror"))
                    {
                        Logger.Log(remote);
                        RemotesList.Add(remote);
                    }
                }
            }
        }

        public static void initGames(string remote)
        {
            Logger.Log($"Initializing Games List");
            
            gameProperties.Clear();
            games.Clear();
            string tempGameList = RCLONE.runRcloneCommand($"cat \"{remote}:{RcloneGamesFolder}/VRP-GameList.txt\"").Output;
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

        public static void updateConfig(string remote)
        {
            Logger.Log($"Attempting to Update Config");
            try
            {
                string configUrl = "https://wiki.vrpirates.club/downloads/vrp.download.config";

                HttpWebRequest getUrl = (HttpWebRequest)WebRequest.Create(configUrl);
                using (StreamReader responseReader = new StreamReader(getUrl.GetResponse().GetResponseStream()))
                {
                    string resultString = responseReader.ReadToEnd();

                    Logger.Log($"Retrived updated config from: {configUrl}");

                    if (File.Exists(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new"))
                        File.Delete(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new");
                    File.Create(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new").Close();
                    File.WriteAllText(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new", resultString);

                    if (!File.Exists(Environment.CurrentDirectory + "\\rclone\\hash.txt"))
                        File.Create(Environment.CurrentDirectory + "\\rclone\\hash.txt").Close();

                    string newConfig = CalculateMD5(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new");
                    string oldConfig = File.ReadAllText(Environment.CurrentDirectory + "\\rclone\\hash.txt");

                    if (!File.Exists(Environment.CurrentDirectory + "\\rclone\\vrp.download.config"))
                        oldConfig = "Config Doesnt Exist!";

                    Logger.Log($"Online Config Hash: {newConfig}; Local Config Hash: {oldConfig}");

                    if (newConfig != oldConfig)
                    {
                        Logger.Log($"Updated Config Hash is different than the current Config. Updating Configuration File.");

                        if (File.Exists(Environment.CurrentDirectory + "\\rclone\\vrp.download.config"))
                            File.Delete(Environment.CurrentDirectory + "\\rclone\\vrp.download.config");
                        File.Move(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new", Environment.CurrentDirectory + "\\rclone\\vrp.download.config");

                        File.WriteAllText(Environment.CurrentDirectory + "\\rclone\\hash.txt", string.Empty);
                        File.WriteAllText(Environment.CurrentDirectory + "\\rclone\\hash.txt", newConfig);
                    } else
                    {
                        Logger.Log($"Updated Config Hash matches last download. Not updating.");

                        if (File.Exists(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new"))
                            File.Delete(Environment.CurrentDirectory + "\\rclone\\vrp.download.config_new");
                    }
                }
            }
            catch { }
        }
        static string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}