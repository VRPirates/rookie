using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace AndroidSideloader
{
    internal class SideloaderUtilities
    {
        public static bool CheckFolderIsObb(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                if (file.EndsWith(".obb") || (Path.GetDirectoryName(file).Contains(".") && !Path.GetDirectoryName(file).Contains("_data")))
                {
                    return true;
                }
            }

            return false;
        }

        private static string uuid = null;
        public static string UUID()
        {
            uuid = Properties.Settings.Default.UUID;
            if (string.IsNullOrEmpty(uuid) != true)
            {
                return uuid;
            }

            var bytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }

            uuid = BitConverter.ToString(bytes).Replace("-", "");

            Properties.Settings.Default.UUID = uuid;
            Properties.Settings.Default.Save();

            return uuid;
        }

    }
}
