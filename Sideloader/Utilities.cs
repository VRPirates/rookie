using System.IO;

namespace AndroidSideloader
{
    class SideloaderUtilities
    {
        public static bool CheckFolderIsObb(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
                if (file.EndsWith(".obb") || Path.GetDirectoryName(file).Contains(".") && !Path.GetDirectoryName(file).Contains("_data"))
                    return true;
            return false;
        }
    }
}
