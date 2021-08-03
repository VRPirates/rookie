using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;

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
        public static string UUID()
        {
            StringBuilder sb = new StringBuilder();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                sb.Append(queryObj["NumberOfCores"]);
                sb.Append(queryObj["ProcessorId"]);
                sb.Append(queryObj["Name"]);
                sb.Append(queryObj["SocketDesignation"]);
            }

            searcher = new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                sb.Append(queryObj["Manufacturer"]);
                sb.Append(queryObj["Name"]);
                sb.Append(queryObj["Version"]);

            }

            searcher = new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_BaseBoard");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                sb.Append(queryObj["Product"]);
            }

            var bytes = Encoding.ASCII.GetBytes(sb.ToString());
            SHA256Managed sha = new SHA256Managed();

            byte[] hash = sha.ComputeHash(bytes);

            return BitConverter.ToString(hash).Replace("-", "");
        }

    }
}
