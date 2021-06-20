using System.IO;

namespace AndroidSideloader
{
    class SideloaderUtilities
    {
        public static bool CheckFolderIsObb(string path)
        {
            string[] files = Directory.GetDirectories(path);

            foreach (string file in files)
                if (file.StartsWith("com."))
                    return true;
            return false;
        }
    }
}
