using System.IO;

namespace AndroidSideloader
{
    class SideloaderUtilities
    {
        public static bool CheckFolderIsObb(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
                if (file.EndsWith(".obb"))
                    return true;
            return false;
        }
    }
}
