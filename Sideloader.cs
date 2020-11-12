using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Spoofer;

namespace AndroidSideloader
{
    class Sideloader
    {

        public static void PushUserJsons()
        {
            foreach (var userJson in UsernameForm.userJsons)
            {
                UsernameForm.createUserJsonByName(Utilities.randomString(16), userJson);
                ADB.RunAdbCommandToString("push \"" + Environment.CurrentDirectory + $"\\{userJson}\" " + " /sdcard/");
                File.Delete(userJson);
            }
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public static async Task updateConfig(string remote)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            string localHash = "";
            try { localHash = File.ReadAllText(Environment.CurrentDirectory + "\\rclone\\hash.txt"); } catch { } //file may not exist

            string hash = RCLONE.runRcloneCommand($"md5sum --config .\\a \"{remote}:Quest Homebrew/Sideloading Methods/1. Rookie Sideloader - VRP Edition/a\"");
            try { hash = hash.Substring(0, hash.LastIndexOf(" ")); } catch { return; } //remove stuff after hash

            Debug.WriteLine("The local file hash is " + localHash + " and the current a file hash is " + hash);

            if (!string.Equals(localHash, hash))
            {
                RCLONE.runRcloneCommand(string.Format($"copy \"{remote}:Quest Homebrew/Sideloading Methods/1. Rookie Sideloader - VRP Edition/a\" \"{Environment.CurrentDirectory}\" --config .\\a"));
                RCLONE.killRclone();
                File.Copy(Environment.CurrentDirectory + "\\a", Environment.CurrentDirectory + "\\rclone\\a", true);
                File.WriteAllText(Environment.CurrentDirectory + "\\rclone\\hash.txt", hash);
            }
        }

        public static string RunCommandsFromFile(string path, string RunFromPath)
        {
            string output = string.Empty;
            var commands = File.ReadAllLines(path);
            foreach (string command in commands)
                output+=Utilities.startProcess("cmd.exe",RunFromPath,command);
            return output;
        }

    }
}
