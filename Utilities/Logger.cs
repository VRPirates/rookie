using System.IO;

namespace AndroidSideloader
{
    class Logger
    {
        public static string logfile = "debuglog.txt";

        public static bool Log(string text, bool ret = true)
        {
            string newline = "\n";
            if (text.Length > 40 && text.Contains("\n"))
                newline += "\n\n";
            try { File.AppendAllText(logfile, text + newline); } catch { }
            return ret;
        }
    }
}
